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
    public partial class รายละเอียดหอพัก : Form
    {
        public รายละเอียดหอพัก()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();//ปิดโปรแกรมหน้านี้
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();//กลับไปที่หน้าแรก
        }
    }
}
