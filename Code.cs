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
    public partial class Code : Form
    {
        public Code()
        {
            InitializeComponent();
        }

        private void Code_Load(object sender, EventArgs e)
        {
            this.Text = "Code-[" + Calseare.Properties.Resources.Title_Text + "](Partial)";
            richTextBox.Text = Calseare.Properties.Resources.Code;
        }
    }
}
