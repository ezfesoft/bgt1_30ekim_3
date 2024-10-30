using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_30ekim_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            int dogumYili, yas;
            dogumYili = Convert.ToInt32(textBox1.Text);
            yas = 2024 - dogumYili;
            label3.Text = Convert.ToString(yas);
        }





    }
}
