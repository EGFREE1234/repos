using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
            {
                if (sender == null)
                {
                    throw new ArgumentNullException(nameof(sender));
                }

                if (button1 == null)
                {
                    Form2.MdiParent = this;
                    Form2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
                    Form2.Show();
                }
                else
                    Form2.Activate();

            }

            private void Form2_FormClosed(object sender, FormClosedEventArgs e)
            {
                throw new NotImplementedException();
            }

        private void button1_LocationChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Maroon;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Maroon;
        }
        
    }
}
