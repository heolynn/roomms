using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roomms
{
    public partial class adjustment : Form
    {
        string salessql;  //쿼리문 저장 변수
        DBClass dbc = new DBClass();  //*****DBClass 객체 생성
        DataRow currRow;  
        public adjustment()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
            dbc.DB_Access();//
        }
        public void sql_execute(String sqlstr, DataSet dsstr)    //사용자 함수 정의
        {
            if (dsstr.Tables.Contains("transaction"))
            {
                dsstr.Tables["room"].Clear();
            }
            dbc.DCom.CommandText = sqlstr;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(dsstr, "transaction");

            DataGridView1.DataSource = dsstr.Tables["transaction"].DefaultView;
            transaction_header();
            transaction_display();
        }
        public void transaction_display()
        {
            // 총 거래 횟수 계산
            DataTable transactionCountTable = new DataTable();
            salessql = "SELECT COUNT(*) AS total_transactions FROM transaction";
            dbc.DCom.CommandText = salessql;
            dbc.DA.SelectCommand = dbc.DCom;
            dbc.DA.Fill(transactionCountTable);

            if (transactionCountTable.Rows.Count > 0)
            {
                label2.Text = transactionCountTable.Rows[0]["total_transactions"].ToString() + "번";
            }

            // 총 결제 금액 계산
            DataTable paymentSumTable = new DataTable();
            salessql = "SELECT NVL(SUM(payment_amount), 0) AS total_payment_amount FROM transaction";
            dbc.DCom.CommandText = salessql;
            dbc.DA.Fill(paymentSumTable);

            if (paymentSumTable.Rows.Count > 0)
            {
                label4.Text = paymentSumTable.Rows[0]["total_payment_amount"].ToString() + "원";
            }
            else
            {
                label4.Text = "0원";
            }
        }

        public void transaction_header()
        {
            DataGridView1.Columns[0].HeaderText = "거래 번호";
            DataGridView1.Columns[1].HeaderText = "방 번호";
            DataGridView1.Columns[2].HeaderText = "결제 금액";
            DataGridView1.Columns[3].HeaderText = "결제 시간";

            DataGridView1.Columns[0].Width = 80;
            DataGridView1.Columns[1].Width = 80;
            DataGridView1.Columns[2].Width = 80;
            DataGridView1.Columns[3].Width = 80;

        }
        private void adjustment_Load(object sender, EventArgs e)
        {
            transaction_id();
            this.Left = 0;
            this.Top = 0;

        }
        public void transaction_id()
        {
            salessql = "Select * From transaction ORDER BY t_id ASC";
            sql_execute((salessql), dbc.DS);
        }

    }
}
