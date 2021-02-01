using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_projet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCurrentTemp_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
        }

        private void btnTempHistory_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 1;
        }

        private void btnAddCapt_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 3;
        }
    }
}
