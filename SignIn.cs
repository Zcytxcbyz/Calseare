using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calseare
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void buttonsign_Click(object sender, EventArgs e)
        {
            if (textsign.Text == DateTime.Now.ToString("yyyyMMddHHmm"))
            {
                MessageBox.Show("Verification passed!", "Sign in", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Code().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Verification failed!", "Sign in", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textsign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonsign_Click(sender, e);
            }
        }
    }
}
