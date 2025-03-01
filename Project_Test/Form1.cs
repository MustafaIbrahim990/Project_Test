using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Test
{
    public partial class Form1 : Form
    {
        private string _Name { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            _Name = txtName.Text;
            lblName.Text = (string.IsNullOrWhiteSpace(_Name)) ? "[????]" : _Name;
        }
    }
}