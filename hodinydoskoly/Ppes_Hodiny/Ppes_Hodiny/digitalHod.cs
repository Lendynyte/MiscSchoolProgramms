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
