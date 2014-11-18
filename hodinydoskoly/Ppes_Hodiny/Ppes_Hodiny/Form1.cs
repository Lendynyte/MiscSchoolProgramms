using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ppes_Hodiny
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void chkVter_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAnaDig.Checked) {
                if (chkVter.Checked)
                {
                    analogHod1.displaySec = true;
                    Invalidate();
                }
                else {
                    analogHod1.displaySec = false;
                    Invalidate();
                }
            }
        }

        private void chkAnaDig_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnaDig.Checked)
            {
                analogHod1.Visible = false;
                digitalHod1.Visible = true;
                Invalidate();
            }
            else {
                analogHod1.Visible = true;
                digitalHod1.Visible = false;
                Invalidate();
            }
        }


        

    }

}
