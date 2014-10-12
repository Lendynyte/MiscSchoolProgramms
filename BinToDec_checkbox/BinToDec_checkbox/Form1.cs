using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinToDec_checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxDec.Text = "0";
        }

        //private int cislo = 0;

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                CheckBox chk = ctrl as CheckBox;
                if (chk == null)
                    continue;

               if (chk.Checked == true && chk.Enabled == true)
                {
                   /*cislo = int.Parse(textBoxDec.Text);
                   textBoxDec.Text = (cislo + int.Parse(chk.Tag.ToString())).ToString();
                   */
                   textBoxDec.Text = (int.Parse(textBoxDec.Text) + int.Parse(chk.Tag.ToString())).ToString();
                   
                    //text z textboxu do intu + tag to stringu a string do intu a pak cely zpet do stringu a do text boxu
                    // vim ze to jsou cisla proto staci parse
                   
                   //textBoxDec.Text = chk.CheckState.ToString();

                    textBoxHex.Text = int.Parse(textBoxDec.Text).ToString("X02");//frmatovany pretizeny tostring

                    textBoxBin.Text = Convert.ToString(int.Parse(textBoxDec.Text), 2);//convert konvertuje cisla

                    chk.Enabled = false;
                    //break; // uz nepotrebuju
                }            
                
            }
            
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            //tohle je rychlejsi na psani ale ukazovali nam na cv tu verzi pod
            /*foreach (CheckBox c in tableLayoutPanel1.Controls) {
                if (c.Checked == true) {
                    c.Checked = false;
                }
            }*/
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                CheckBox chk = ctrl as CheckBox;
                if (chk == null)
                    continue;

                if (chk.Checked == true)
                {
                    chk.Checked = false;
                    chk.Enabled = true;
                }
            }
            textBoxDec.Text = "0";
            textBoxBin.Text = string.Empty;
            textBoxHex.Text = string.Empty;
        }
    }
}
