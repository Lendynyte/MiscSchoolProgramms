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
  public partial class AnalogHod : Control
  {
    private Timer tmr = null;

    public bool displaySec = true;


    public AnalogHod()
    {
      InitializeComponent();
      this.DoubleBuffered = true;

      tmr = new Timer();
      tmr.Interval = 100;
      tmr.Tick += tmr_Tick;
      tmr.Start();

      
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
      // base.OnPaint(pe);
      Graphics gr = pe.Graphics;
      Rectangle rect = this.ClientRectangle;
      gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      int clockWidth;
      int clockHeight;

      if (rect.Height < rect.Width)
      {
        clockWidth = rect.Height ;
        clockHeight = rect.Height;
      }
      else {
        clockWidth = rect.Width ;
        clockHeight = rect.Width ;
      }
     

      int centerX = (rect.Width / 2) - 1;
      int centerY = (rect.Height / 2) - 1;

      using (Pen p = new Pen(Color.Black, 1))
      {
        gr.DrawEllipse(p, centerX - (clockWidth / 2), centerY - (clockWidth / 2), clockWidth - 1, clockWidth - 1);
      }

       using (SolidBrush br = new SolidBrush(this.ForeColor))
      {
        gr.FillEllipse(br, centerX - (clockWidth / 2), centerY - (clockWidth / 2), clockWidth - 1, clockWidth - 1);
      }

      DateTime datim = DateTime.Now;

      float fRadHr = (float)(((datim.Hour % 12) + (float)datim.Minute / 60) * 30 * Math.PI / 180);
      float fRadMin = (float)((datim.Minute) * 6 * Math.PI / 180);
      float fRadSec = (float)((datim.Second) * 6 * Math.PI / 180);

      float hx = centerX + (float)((clockHeight / 2) * System.Math.Sin(fRadHr));
      float hy = centerY - (float)((clockHeight / 2) * System.Math.Cos(fRadHr));

      float mx = centerX + (float)((clockHeight / 2) * System.Math.Sin(fRadMin));
      float my = centerY - (float)((clockHeight / 2) * System.Math.Cos(fRadMin));

      float sx = centerX + (float)((clockHeight / 2) * System.Math.Sin(fRadSec));
      float sy = centerY - (float)((clockHeight / 2) * System.Math.Cos(fRadSec));

      using (Pen p = new Pen(Color.Black, 4))
      {

        gr.DrawLine(p, centerX, centerY, hx, hy);
      }
      using (Pen p = new Pen(Color.Black, 2))
      {

        gr.DrawLine(p, centerX, centerY, mx, my);
      }

      for (int i = 0; i < 60; i++)
      {

        using (Pen p = new Pen(Color.DarkCyan, 2))
        {
          gr.DrawLine(p,
                centerX + (float)(((clockWidth * 0.75)) / 1.50 * System.Math.Sin(i * 6 * Math.PI / 180)),
                centerY - (float)(((clockWidth * 0.75)) / 1.50 * System.Math.Cos(i * 6 * Math.PI / 180)),
                centerX + (float)(((clockWidth * 0.75)) / 1.65 * System.Math.Sin(i * 6 * Math.PI / 180)),
                centerY - (float)(((clockWidth * 0.75)) / 1.65 * System.Math.Cos(i * 6 * Math.PI / 180)));
        }

        if (i % 5 == 0)
        {
          using (Pen p = new Pen(Color.Red, 5))
          {

            gr.DrawLine(p,
                  centerX + (float)(((clockWidth * 0.75)) / 1.50 * System.Math.Sin(i * 6 * Math.PI / 180)),
                  centerY - (float)(((clockWidth * 0.75)) / 1.50 * System.Math.Cos(i * 6 * Math.PI / 180)),
                  centerX + (float)(((clockWidth * 0.75)) / 1.65 * System.Math.Sin(i * 6 * Math.PI / 180)),
                  centerY - (float)(((clockWidth * 0.75)) / 1.65 * System.Math.Cos(i * 6 * Math.PI / 180)));
          }

        }

      }


      if (displaySec)
      {
        using (Pen p = new Pen(Color.Black, 1))
        {
          gr.DrawLine(p, centerX, centerY, sx, sy);

        }
      }

    }

    protected override void OnAutoSizeChanged(EventArgs e)
    {
      base.OnAutoSizeChanged(e);
      Invalidate();
    }


    void tmr_Tick(object sender, EventArgs e)
    {
      Invalidate();
    }



  }
}
