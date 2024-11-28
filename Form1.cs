using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roomms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        main main;
        room room;
        customer customer;
        adjustment adjustment;
        machine machine;
        private void Form1_Load(object sender, EventArgs e)
        {
            main = new main(); //Form2
            main.MdiParent = this;
            main.Show();  //Mdi폼의 자식은 Show()모달리스만 사용 가능  
        }

        private void 고객관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customer == null || customer.IsDisposed)  //Form4
            {
                customer = new customer();
                customer.MdiParent = this;
                customer.Show();
            }
        }

        private void 방관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (room == null || room.IsDisposed)  //Form4
            {
                room = new room();
                room.MdiParent = this;
                room.Show();
            }
        }

        private void 기계관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (machine == null || machine.IsDisposed)  //Form4
            {
                machine = new machine();
                machine.MdiParent = this;
                machine.Show();
            }
        }

        private void 정산ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (adjustment == null || adjustment.IsDisposed)  //Form4
            {
                adjustment = new adjustment();
                adjustment.MdiParent = this;
                adjustment.Show();
            }
        }
    }
}
