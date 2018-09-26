using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Chairside f2;
        public void button1_Click(object sender, EventArgs e)
        {
            if (sender == null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            if (f2 == null)
            {
                f2 = new Chairside();
                f2.MdiParent = this;
                f2.FormClosed += new FormClosedEventHandler(f2_FormClosed);
                f2.Show();
            }
            else
                f2.Activate();
            {
                chairsideButton.BackColor = Color.Orange;
            }
        }

        private void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void chairsideButton_Leave(object sender, EventArgs e)
        {
            chairsideButton.BackColor = Color.Maroon;
        }
    }
}