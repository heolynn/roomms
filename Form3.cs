using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace roomms
{
    public partial class room : Form
    {
        new main Parent;
        string sqlstr;    //쿼리문 저장 변수
        DBClass dbc = new DBClass();

        public room()
        {
            InitializeComponent();
        }
        public void room_header()
        {
            DataGridView1.Columns[0].HeaderText = "방 번호";
            DataGridView1.Columns[1].HeaderText = "기계 번호";
            DataGridView1.Columns[2].HeaderText = "상태";
            DataGridView1.Columns[3].HeaderText = "수용 인원";
            DataGridView1.Columns[4].HeaderText = "청소 상태";

            DataGridView1.Columns[0].Width = 60;
            DataGridView1.Columns[1].Width = 80;
            DataGridView1.Columns[2].Width = 80;
            DataGridView1.Columns[3].Width = 80;
            DataGridView1.Columns[4].Width = 80;
        }

        private void room_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void room_Load(object sender, EventArgs e)
        {
            try
            {
                dbc.DB_ObjCreate(); //*****
                dbc.DB_Open();//*****
                dbc.DB_Access();//***

                sqlstr = "Select * From room ORDER BY room_id ASC";
                dbc.DCom.CommandText = sqlstr;
                dbc.DA.SelectCommand = dbc.DCom;
                dbc.DA.Fill(dbc.DS, "room");
                dbc.DS.Tables["room"].Clear();
                dbc.DA.Fill(dbc.DS, "room");
                DataGridView1.DataSource = dbc.DS.Tables["room"].DefaultView;
                room_header();
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

        

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 폼에서 입력한 데이터를 기반으로 새 행을 생성합니다.
                DataRow newRow = dbc.DS.Tables["room"].NewRow();
                newRow["room_id"] = rNumtxt.Text; // 방 번호 텍스트박스
                newRow["machine_id"] = mNumtxt.Text; // 기계 번호 텍스트박스
               // newRow["status"] = rStatustxt.Text; // 상태 텍스트박스
                newRow["capacity"] = rCapacitytxt.Text; // 수용 인원 텍스트박스
               // newRow["cleaning_status"] = rCleaningtxt.Text; // 청소 상태 텍스트박스
                string cleaning_status = rCleaningtxt.SelectedItem.ToString();
                string selectedStatus = rStatustxt.SelectedItem.ToString();
                MessageBox.Show("선택된 상태: " + selectedStatus);
                // 새 행을 DataTable에 추가
                dbc.DS.Tables["room"].Rows.Add(newRow);

                // OracleDataAdapter를 사용해 DB에 반영
                dbc.DA.Update(dbc.DS, "room");
                dbc.DS.AcceptChanges(); // 변경 사항 적용

                MessageBox.Show("새로운 방 정보가 추가되었습니다.");
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

        private void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 수정할 행을 찾기 위한 PrimaryKey 설정
                DataColumn[] primaryKey = new DataColumn[1];
                primaryKey[0] = dbc.DS.Tables["room"].Columns["room_id"];
                dbc.DS.Tables["room"].PrimaryKey = primaryKey;

                // 선택된 행을 찾고 수정
                DataRow rowToUpdate = dbc.DS.Tables["room"].Rows.Find(rNumtxt.Text); // 방 번호 기준으로 찾기
                if (rowToUpdate != null)
                {
                    rowToUpdate["machine_id"] = mNumtxt.Text; // 기계 번호 텍스트박스
                    rowToUpdate["status"] = rStatustxt.Text; // 상태 텍스트박스
                    rowToUpdate["capacity"] = rCapacitytxt.Text; // 수용 인원 텍스트박스
                    rowToUpdate["cleaning_status"] = rCleaningtxt.Text; // 청소 상태 텍스트박스

                    // DB에 반영
                    dbc.DA.Update(dbc.DS, "room");
                    dbc.DS.AcceptChanges(); // 변경 사항 적용

                    MessageBox.Show("방 정보가 수정되었습니다.");
                }
                else
                {
                    MessageBox.Show("해당 방 번호를 찾을 수 없습니다.");
                }
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

        private void Delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 삭제할 행을 찾기 위한 PrimaryKey 설정
                DataColumn[] primaryKey = new DataColumn[1];
                primaryKey[0] = dbc.DS.Tables["room"].Columns["room_id"];
                dbc.DS.Tables["room"].PrimaryKey = primaryKey;

                // 선택된 행을 찾고 삭제
                DataRow rowToDelete = dbc.DS.Tables["room"].Rows.Find(rNumtxt.Text); // 방 번호 기준으로 찾기
                if (rowToDelete != null)
                {
                    rowToDelete.Delete();

                    // DB에 반영
                    dbc.DA.Update(dbc.DS, "room");
                    dbc.DS.AcceptChanges(); // 변경 사항 적용

                    MessageBox.Show("방 정보가 삭제되었습니다.");
                }
                else
                {
                    MessageBox.Show("해당 방 번호를 찾을 수 없습니다.");
                }
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

        private void rStatustxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 사용자가 입력한 값 가져오기
                string roomNumber = rNumtxt.Text; // 방 번호 텍스트박스
                string status = rStatustxt.SelectedItem.ToString(); // 선택된 상태
                string machine_id = mNumtxt.Text; // 기계 번호 텍스트박스
                string capacity = rCapacitytxt.Text; // 수용 인원 텍스트박스
                string cleaning_status = rCleaningtxt.SelectedItem.ToString(); // 청소 상태 텍스트박스

                // 입력값 검증 (빈 값이 입력되었는지 체크)
                if (string.IsNullOrEmpty(roomNumber) || string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("모든 항목을 입력해주세요.");
                    return;
                }

                // DB에 추가할 쿼리문
                sqlstr = "INSERT INTO room (room_id, status) VALUES (:room_id, :status)";

                // OracleCommand 객체 생성
                OracleCommand cmd = new OracleCommand(sqlstr, dbc.Con);
               
                cmd.Parameters.Add("room_id", OracleDbType.Varchar2).Value = Convert.ToInt32(roomNumber);
                cmd.Parameters.Add("machine_id", OracleDbType.Varchar2).Value = Convert.ToInt32(mNumtxt);
                cmd.Parameters.Add("status", OracleDbType.Varchar2).Value = status;  // 방 상태
                cmd.Parameters.Add("capacity", OracleDbType.Int32).Value = Convert.ToInt32(capacity);
                cmd.Parameters.Add("clean_status", OracleDbType.Varchar2).Value = rCleaningtxt;  // 청소 상태

                // 쿼리 실행 (데이터 삽입)
                cmd.ExecuteNonQuery();

                // 데이터 그리드 새로 고침 (새로 추가된 데이터를 반영)
                dbc.DA.Fill(dbc.DS, "room");
                DataGridView1.DataSource = dbc.DS.Tables["room"].DefaultView;

                // 입력한 값 초기화
                rNumtxt.Clear(); 
                rStatustxt.SelectedItem = 0;
                mNumtxt.Clear();
                rCapacitytxt.Clear();
                rCleaningtxt.SelectedItem = 0;
                
                MessageBox.Show("방이 성공적으로 추가되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("추가 오류: " + ex.Message);
            }
        }
    }
}
