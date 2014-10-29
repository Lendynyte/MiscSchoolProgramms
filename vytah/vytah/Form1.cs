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
      lbl1fl.BackColor = Color.Red;
    }

    private int position = 1;
    private int prevPosition;
    private bool movingUp = false;
    private bool movingDown = false;
    private int topFloor = 4;
    private int transitionTime = 5000;
    private int now = 1;

    private void nastavCerny() {
        foreach (Control ctrl in tableLayoutPanel3.Controls)
        {
            Label lbl = ctrl as Label;
            if (lbl == null)
                continue;
            lbl.BackColor = Color.SlateGray;
        }
    }

      //nastavCerny();
    private async void positionChange(int position) {
        
        foreach (Control ctrl in tableLayoutPanel3.Controls)
        {
        Label lbl = ctrl as Label;
        if (lbl == null)
          continue;

        //zjistit jestli jedu nahoru popripade doliu + timer
        if (lbl.Text == prevPosition.ToString()) {
            nastavCerny();
            /*tmr1.Interval = 500;
            tmr1.Start();*/

            lbl.BackColor = Color.Red;
            lblStatus.Text = "STATUS: " + prevPosition.ToString();
            Console.WriteLine(prevPosition.ToString());
        }




       /* while (prevPosition <= position)
        {*/
         /*   if (lbl.Text == prevPosition.ToString())
            {
                //System.Threading.Thread.Sleep(500);
                lbl.BackColor = Color.Red;
                lblStatus.Text = "STATUS: " + position.ToString();
            }*/
           // prevPosition++;
      //  }

       // DateTime ted = DateTime.Now;
        //DateTime plusPet = DateTime.Now.AddSeconds(5);

/*
        if (movingUp == true) {
            for (int i = prevPosition; i <= position; i++) {
                await Task.Delay(3000);
                now = prevPosition;
                now++;
            }
        }
        else if (movingDown == true) {
            for (int i = prevPosition; i <= position; i--)
            {
                await Task.Delay(3000);
                now = prevPosition;
                now--;
            }
        }
          */
       
            //for (int i = prevPosition; i <= position; i++)
       /*   int i = prevPosition;
          do
            {
                
                //lbl.BackColor = Color.SlateGray;
                await Task.Delay(300);
                if (lbl.Text == i.ToString())
                {
                    
                    lbl.BackColor = Color.Red;
                    lblStatus.Text = "STATUS: " + position.ToString();
                }
                i++;
            }while(i <= position);*/
           // prevPosition = position;
      
        //prevPosition = position;

       
       // {//&& ted == plusPet
            //System.Threading.Thread.Sleep(500);
           /* tmr1.Start();
            tmr1.Interval = 500;
            tmr1.Stop();*/
          //  tmr1.Interval = 500;
            //tmr1.Start(); 
           // Delayed(2000, () =>  lbl.BackColor = Color.Red, () => lblStatus.Text = "STATUS: " + position.ToString());
       //    await Task.Delay(3000);
            
          /*  switch (now) { 
                case 1:
                    patroJedna();
                    break;
                case 2:
                    patroDva();
                        break;
                case 3:
                        patroTri();
                        break;
                case 4:
                    patroCtyri();
                    break;*/

          //  }
           // movingUp = false;
            //movingDown = false;

        
      }
    }
/*
    private void patroJedna() {
        lbl1fl.BackColor = Color.Red;
        lblStatus.Text = "STATUS: " + position.ToString();
    }
    private void patroDva()
    {
        lbl2fl.BackColor = Color.Red;
        lblStatus.Text = "STATUS: " + position.ToString();
    }
    private void patroTri()
    {
        lbl3fl.BackColor = Color.Red;
        lblStatus.Text = "STATUS: " + position.ToString();
    }
    private void patroCtyri()
    {
        lbl4fl.BackColor = Color.Red;
        lblStatus.Text = "STATUS: " + position.ToString();
    }
          */
    private void btnUP_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      if (btn == null)
        return;

      //prevPosition = position;
      position =  int.Parse(btn.Tag.ToString());
      if (btn.Text == "↑" && position <= topFloor)
      {
          /*while (prevPosition <= position) {
              positionChange(position);
              prevPosition++;
          }
        */
          if (prevPosition <= position)
          {
              while (prevPosition <= position)
              {
                  positionChange(prevPosition);
                  System.Threading.Thread.Sleep(500);
                  prevPosition++;
              }
          }
          else if (prevPosition >= position) {
              while (prevPosition >= position)
              {
                  positionChange(prevPosition);
                  System.Threading.Thread.Sleep(500);
                  prevPosition--;
              }
          }


       // position++;
      }
      movingUp = true;
    }

    private void btnDOWN_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      if (btn == null)
        return;

     // prevPosition = position;
      position = int.Parse(btn.Tag.ToString());
      if (btn.Text == "↓" && position >= 1)
      {
         /* while (prevPosition >= position)
          {/**/
            /*  if (prevPosition < position) {
                  positionChange(position);
                  prevPosition--;
              }
              else if (prevPosition < position) {
                  positionChange(position);
                  prevPosition++;
              }*/

          if (prevPosition <= position)
          {
              while (prevPosition <= position)
              {
                  positionChange(prevPosition);
                  System.Threading.Thread.Sleep(500);
                  prevPosition++;
              }
          }
          else if (prevPosition >= position)
          {
              while (prevPosition >= position)
              {
                  positionChange(prevPosition);
                  System.Threading.Thread.Sleep(500);
                  prevPosition--;
              }
          }
              
         // }
        //position--;
      }
      movingDown = true;
    }

     
    private void tmr1_Tick(object sender, EventArgs e)
    {
        tmr1.Stop();

    }

    /*private void tmr1_Tick(object sender, EventArgs e)
    {
        foreach (Control ctrl in tableLayoutPanel3.Controls)
        {
            Label lbl = ctrl as Label;
            if (lbl == null)
                continue;
            //&& ted == plusPet
                //System.Threading.Thread.Sleep(500);
                /* tmr1.Start();
                 tmr1.Interval = 500;
                 tmr1.Stop();*/
           /* if (lbl.Text == position.ToString())
            {
                tmr1.Stop();
                // Delayed(2000, () =>  lbl.BackColor = Color.Red, () => lblStatus.Text = "STATUS: " + position.ToString());
                lbl.BackColor = Color.Red;
                lblStatus.Text = "STATUS: " + position.ToString();
            }
        }*/
    }

    /*public void Delayed(int delay, Action action, Action action2)
    {
        Timer timer = new Timer();
        timer.Interval = delay;
        timer.Tick += (s, e) =>
        {
            action();
            action2();
            timer.Stop();
        };
        timer.Start();
    }
  }*/
}
