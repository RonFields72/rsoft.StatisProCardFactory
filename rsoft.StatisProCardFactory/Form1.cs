using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rsoft.StatisProCardFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void tbWins_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbWins.Text, "[^0-9]"))
            {
                MessageBox.Show("Only numeric input is allowed.");
                tbWins.Text.Remove(tbWins.Text.Length - 1);
            }
        }

        private void tbLosses_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbLosses.Text, "[^0-9]"))
            {
                MessageBox.Show("Only numeric input is allowed.");
                tbLosses.Text.Remove(tbLosses.Text.Length - 1);
            }
        }
    }
}
