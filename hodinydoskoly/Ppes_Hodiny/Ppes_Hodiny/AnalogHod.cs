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

        public bool displaySec = false;
    

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

           
           int clockWidth = rect.Width / 2;
           int clockHeight = rect.Height / 2;

           int centerX = (rect.Width / 2) - 1;
           int centerY = (rect.Height / 2) - 1;

           using (Pen p = new Pen(Color.Black, 1))
           {
               gr.DrawEllipse(p, centerX-(clockWidth/2), centerY-(clockWidth/2), clockWidth -1 , clockWidth - 1);
           }


           DateTime datim = DateTime.Now;

          double hod = datim.Hour % 12 + (double)datim.Minute / 60;
          double min = datim.Minute;
          double sec = datim.Second;

          float fRadHr = (float)((datim.Hour % 12 + datim.Minute / 60) * 30 * Math.PI / 180);
          float fRadMin = (float)((datim.Minute) * 6 * Math.PI / 180);
          float fRadSec = (float)((datim.Second) * 6 * Math.PI / 180);

          float hx =  centerX + (float)(clockWidth*System.Math.Sin(fRadHr));
          float hy = centerY - (float)(clockWidth*System.Math.Cos(fRadHr));

          float mx = centerX + (float)(clockWidth * System.Math.Sin(fRadMin));
          float my = centerY - (float)(clockWidth * System.Math.Cos(fRadMin));

          float sx = centerX + (float)(clockWidth * System.Math.Sin(fRadSec));
          float sy = centerY - (float)(clockWidth * System.Math.Cos(fRadSec));

          using (Pen p = new Pen(Color.Black, 5)) {

              gr.DrawLine(p, centerX, centerY, hx, hy);
          }
          using (Pen p = new Pen(Color.Black, 2))
          {

              gr.DrawLine(p, centerX, centerY, mx, my);
          }

          if (displaySec) {
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
