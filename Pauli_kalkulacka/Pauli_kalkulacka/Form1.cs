using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pauli_kalkulacka
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
/*
    private void tlacitko_1_Click(object sender, EventArgs e)
    {
      tBoxDisplay.Text = tBoxDisplay.Text +"1";
    }*/

    private void tlacitko_clear_Click(object sender, EventArgs e)
    {
      tBoxDisplay.Text = string.Empty;
      //tBoxDisplay.Text = "0";
    }

    private void tlacitko_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      if (btn == null)
        return;
      if (jePrvni == true)
      {
        tBoxDisplay.Text = String.Empty;
        tBoxDisplay.Text = tBoxDisplay.Text + btn.Text;
        jePrvni = false;
      }
      else {
        tBoxDisplay.Text = tBoxDisplay.Text + btn.Text;
      }
    }
/*
    private void tlacitko_2_Click(object sender, EventArgs e)
    {
      tBoxDisplay.Text = tBoxDisplay.Text + "2";
    }

    private void tlacitko_3_Click(object sender, EventArgs e)
    {
      tBoxDisplay.Text = tBoxDisplay.Text + "3";
    }

    private void tlacitko_4_Click(object sender, EventArgs e)
    {
      tBoxDisplay.Text = tBoxDisplay.Text + "4";
    }

    private void tlacitko_5_Click(object sender, EventArgs e)
    {
      tBoxDisplay.Text = tBoxDisplay.Text + "5";
    }

    private void tlacitko_6_Click(object sender, EventArgs e)
    {
      tBoxDisplay.Text = tBoxDisplay.Text + "6";
    }

    private void tlacitko_7_Click(object sender, EventArgs e)
    {
      tBoxDisplay.Text = tBoxDisplay.Text + "7";
    }

    private void tlacitko_8_Click(object sender, EventArgs e)
    {
      tBoxDisplay.Text = tBoxDisplay.Text + "8";
    }

    private void tlacitko_9_Click(object sender, EventArgs e)
    {
      tBoxDisplay.Text = tBoxDisplay.Text + "9";
    }

    private void tlacitko_0_Click(object sender, EventArgs e)
    {
      tBoxDisplay.Text = tBoxDisplay.Text + "0";
    }*/

  /*  private float vysledekPlus = 0;
    private float vysledekMinus = 0;
    private float vysledekKrat = 0;
    private float vysledekDeleno = 0;*/
    private float vysledek = 0;
    private string posledniZmacknuteTlacitko;
    private bool jeCarka = false;
    private bool jePrvni = true;
/*
    private void tlacitko_plus_Click(object sender, EventArgs e)
    {
      //tBoxDisplay.Text = tBoxDisplay.Text + "+";
      vysledekPlus = float.Parse(tBoxDisplay.Text);
      tBoxDisplay.Text = string.Empty;
      posledniZmacknuteTlacitko = "+";
      jeCarka = false;
    }*/
    
    private void tlacitko_rovnase_Click(object sender, EventArgs e)
    {
     /* int vysledek = int.Parse(tBoxDisplay.Text);
      tBoxDisplay.Text = vysledek.ToString();*/
      if (posledniZmacknuteTlacitko == "+")
      {
        tBoxDisplay.Text = (vysledek + float.Parse(tBoxDisplay.Text)).ToString();
        vysledek = 0;

      }
      if (posledniZmacknuteTlacitko == "-")
      {
        tBoxDisplay.Text = (vysledek - float.Parse(tBoxDisplay.Text)).ToString();
        vysledek = 0;
      }
      if (posledniZmacknuteTlacitko == "X")
      {
        tBoxDisplay.Text = (vysledek * float.Parse(tBoxDisplay.Text)).ToString();
        vysledek = 0;
      }
      if (posledniZmacknuteTlacitko == ":")
      {
        float vysledekDelenoDva = float.Parse(tBoxDisplay.Text);
        if (vysledekDelenoDva == 0)
        {
          tBoxDisplay.Text = "Nelze Delit Nulou";
        }
        else
        {
          tBoxDisplay.Text = (vysledek / vysledekDelenoDva).ToString();
          vysledek = 0;
          vysledekDelenoDva = 0;
        }
      }
      posledniZmacknuteTlacitko = string.Empty;
      jePrvni = true;
    }

    
    private void tlacitkoZnamenka_Click(object sender, EventArgs e) {
      if (float.TryParse(tBoxDisplay.Text, out vysledek) == false) {
        vysledek = 0;
      }
      //float.TryParse(tBoxDisplay.Text, vysledek);
      //tBoxDisplay.Text = string.Empty;
      
      Button btn = sender as Button;
      if (btn == null)
        return;
      if (btn.Text == "+") {
        posledniZmacknuteTlacitko = "+";
      }
      else if (btn.Text == "-") {
        posledniZmacknuteTlacitko = "-";
      }
      else if (btn.Text == "X")
      {
        posledniZmacknuteTlacitko = "X";
      }
      else if (btn.Text == ":")
      {
        posledniZmacknuteTlacitko = ":";
      }
      jeCarka = false;
      jePrvni = true;
    }

    /*
    private void tlacitko_minus_Click(object sender, EventArgs e)
    {
      vysledekMinus = float.Parse(tBoxDisplay.Text);
      tBoxDisplay.Text = string.Empty;
      posledniZmacknuteTlacitko = "-";
      jeCarka = false;
    }

    private void tlacitko_krat_Click(object sender, EventArgs e)
    {
      vysledekKrat = float.Parse(tBoxDisplay.Text);
      tBoxDisplay.Text = string.Empty;
      posledniZmacknuteTlacitko = "X";
      jeCarka = false;
    }

    private void tlacitko_deleno_Click(object sender, EventArgs e)
    {
      vysledekDeleno = float.Parse(tBoxDisplay.Text);
      tBoxDisplay.Text = string.Empty;
      posledniZmacknuteTlacitko = ":";
      jeCarka = false;
    }*/

    private void tlacitko_odmocnina_Click(object sender, EventArgs e)
    {
      float vysledekOdmocnina = float.Parse(tBoxDisplay.Text);
      tBoxDisplay.Text = (Math.Sqrt(vysledekOdmocnina)).ToString();
    }

    private void tlacitko_carka_Click(object sender, EventArgs e)
    {
      if (jePrvni == false)
      {
        if (jeCarka == false)
        {
          tBoxDisplay.Text = tBoxDisplay.Text + ",";
          jeCarka = true;
        }
      }
    }

  }
}
