using AppNet.Infrastructer.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNet.WinFormUI
{
    public partial class Settings : Form
    {
        public Settings()
        {
            MessageBox.Show("ÖNcesi");
            InitializeComponent();
            MessageBox.Show("Sonrasi");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  
           var context = new ErpDbContext();
          
           context.Database.EnsureCreated();
            MessageBox.Show("sss");

        }
    }
}
