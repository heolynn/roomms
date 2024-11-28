using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace roomms
{
    public partial class machine : Form
    {
        string mid_code; // 유지보수 등록시 사용할 변수
        string machinesql;    //쿼리문 저장 변수
        DBClass dbc = new DBClass();
        DataRow currRow; //DS의 현재 행 저장 변수
        public machine()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//
        }
        public void sql_execute(String sqlstr, DataSet dsstr)    //사용자 함수 정의
        {
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;

            dbc.DA.Fill(dsstr, "room");
            dsstr.Tables["room"].Clear();
            dbc.DA.Fill(dsstr, "room");

            DataGridView1.DataSource = dsstr.Tables["room"].DefaultView;
            machine_header();
        }
        public void machine_header()
        {
            DataGridView1.Columns[0].HeaderText = "기계 번호";
            DataGridView1.Columns[1].HeaderText = "종류";
            DataGridView1.Columns[2].HeaderText = "상태";
            DataGridView1.Columns[3].HeaderText = "설치날짜";

            DataGridView1.Columns[0].Width = 80;
            DataGridView1.Columns[1].Width = 80;
            DataGridView1.Columns[2].Width = 80;
            DataGridView1.Columns[3].Width = 80;

        }
        private void machine_Load(object sender, EventArgs e)
        {
            repair_id();
            this.Left = 0;
            this.Top = 0;
        }

        public void repair_id()
        {
            machinesql = "Select * From machine ORDER BY m_id ASC";
            sql_execute(machinesql, dbc.DS);
        }

        private void MRbtn_Click(object sender, EventArgs e)
        {
            if (mIDtxt.Text.Trim() == "")
            {
                MessageBox.Show("기계코드 미입력");
                mIDtxt.Focus();
            }
            else
            {  //1 if
                if (radioButton1.Checked)  // 유지
                {
                    dbc.DS.Tables["room"].Clear();
                    machinesql = "Select * From machine Where m_id = '" + mIDtxt.Text + "'";
                    dbc.DCom.CommandText = machinesql;
                    dbc.DA.SelectCommand = dbc.DCom;
                    dbc.DA.Fill(dbc.DS, "room");

                    if (dbc.DS.Tables["room"].Rows.Count == 0)
                    {
                        MessageBox.Show("해당되는 기계가 없습니다.");
                        mIDtxt.Text = "";
                        mIDtxt.Focus();
                    }
                    else
                    {
                        currRow = dbc.DS.Tables["room"].Rows[0];  //유지

                        if (currRow[2].ToString() == "")
                        {
                           
                        }
                    }
                }
                else if (radioButton2.Checked)  // 보수
                {
                    DialogResult rtyes = MessageBox.Show("해당 기계를 보수처리하시겠습니까?", "등록 확인", MessageBoxButtons.YesNo);
                    dbc.DS.Tables["room"].Clear();
                    if (rtyes == DialogResult.Yes)
                    {
                        machinesql = "Select * From machine Where m_id='" + mIDtxt.Text + "'";
                        dbc.DCom.CommandText = machinesql;
                        dbc.DA.SelectCommand = dbc.DCom;
                        dbc.DA.Fill(dbc.DS, "room");
                        currRow = dbc.DS.Tables["room"].Rows[0];  //****

                        mid_code = currRow[2].ToString();  

                        machinesql = "Select * From machine Where m_id = '" + mid_code + "'";
                        dbc.DCom.CommandText = machinesql;
                        dbc.DA.SelectCommand = dbc.DCom;
                        dbc.DA.Fill(dbc.DS, "room");
                        DataRow currRow1 = dbc.DS.Tables["room"].Rows[0];  //****

                        if (dbc.DS.Tables["room"].Rows.Count == 0)
                        {
                            MessageBox.Show("해당되는 기계가 없습니다.");
                            mIDtxt.Text = "";
                            mIDtxt.Focus();
                        }
                        else if (currRow[2].ToString() == "")
                        {
                            MessageBox.Show("보수되지 않은 기계입니다.");
                            mIDtxt.Text = "";
                            mIDtxt.Focus();
                        }

                        else
                        {
                            machinesql = "Update machine Set status = 'Active' Where m_id = '" + mIDtxt.Text + "'";
                            dbc.DCom.CommandText = machinesql;
                            dbc.DCom.ExecuteNonQuery();
                            dbc.DS.Tables["room"].Clear();
                            dbc.DA.Fill(dbc.DS, "room");

                            mIDtxt.Text = "";
                            mIDtxt.Focus();
                            repair_id();
                        }
                    } 
                }
            } 
        } 
    }
}
