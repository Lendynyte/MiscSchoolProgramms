using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vytah
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private int position = 1;
    private bool movingUp = false;
    private bool movingDown = false;
    private int topFloor = 4;
    private int transitionTime = 5000;

    private void positionChange(int position) {
      foreach (Control ctrl in tableLayoutPanel3.Controls)
      {
        Label lbl = ctrl as Label;
        if (lbl == null)
          continue;
        lbl.BackColor = Color.SlateGray;
       // DateTime ted = DateTime.Now;
       // DateTime plusPet = DateTime.Now.AddSeconds(5);


        if (lbl.Text == position.ToString())
        {//&& ted == plusPet
          lbl.BackColor = Color.Red;
          lblStatus.Text = "STATUS: " + position.ToString();
        }
      }
    }
    
    private void btnUP_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      if (btn == null)
        return;

      position =  int.Parse(btn.Tag.ToString());
      if (btn.Text == "↑" && position <= topFloor)
      {
        positionChange(position);
        position++;
      }
    }

    private void btnDOWN_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      if (btn == null)
        return;

      position = int.Parse(btn.Tag.ToString());
      if (btn.Text == "↓" && position >= 1)
      {
        positionChange(position);
        position--;
      }
    }


    private void tmr1_Tick(object sender, EventArgs e)
    {
      if (tmr1.Enabled == true)
      {
        tmr1.Stop();
      }
      else {
        tmr1.Start();
      }
    }
  }
}
