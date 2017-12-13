using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_603410063_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void regularity_Click(object sender, EventArgs e)
        {
            รายละเอียดหอพัก sasikorn = new รายละเอียดหอพัก();//สร้างsasikorn ขึ้นมาเก็บ form
            sasikorn.Show();//แสดง form sasikorn
        }

        private void room_Click(object sender, EventArgs e)
        {
            คำนวณค่าห้อง calculate  = new คำนวณค่าห้อง();//สร้างcalculate ขึ้นมาเก็บ form
            calculate.Show();//แสดง form calculate

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);       }
    }
}
