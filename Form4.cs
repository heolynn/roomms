using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roomms
{
    public partial class customer : Form
    {
        string sqlstr;    //쿼리문 저장 변수
        DBClass dbc = new DBClass();
        public customer()
        {
            InitializeComponent();
        }
        public void customer_header()
        {
            DataGridView1.Columns[0].HeaderText = "고객 ID";
            DataGridView1.Columns[1].HeaderText = "이름";
            DataGridView1.Columns[2].HeaderText = "연락처";
            DataGridView1.Columns[3].HeaderText = "누적 사용시간";

            DataGridView1.Columns[0].Width = 80;
            DataGridView1.Columns[1].Width = 80;
            DataGridView1.Columns[2].Width = 80;
            DataGridView1.Columns[3].Width = 80;
        }

        private void customer_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void customer_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DB_Access();//***

                sqlstr = "Select * From customer ORDER BY c_id ASC";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "customer");
                dbc.DS.Tables["customer"].Clear();
                dbc.DA.Fill(dbc.DS, "customer");
                DataGridView1.DataSource = dbc.DS.Tables["customer"].DefaultView;
                customer_header();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
    }
}
