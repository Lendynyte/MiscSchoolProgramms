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
    public partial class digitalHod : Control
    {
        private Timer tmr = null;

        public digitalHod()
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

            String txt= DateTime.Now.ToString("HH:mm:ss.fff");


            using (SolidBrush br = new SolidBrush(this.ForeColor))
            {
                SizeF sz = gr.MeasureString(this.Text, this.Font);
                gr.DrawString(txt, this.Font, br, (rect.Width - sz.Width) / 2, (rect.Height - sz.Height) / 2);
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
