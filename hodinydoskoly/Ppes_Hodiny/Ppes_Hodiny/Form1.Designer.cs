namespace Ppes_Hodiny
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkAnaDig = new System.Windows.Forms.CheckBox();
            this.chkVter = new System.Windows.Forms.CheckBox();
            this.digitalHod1 = new Ppes_Hodiny.digitalHod();
            this.analogHod1 = new Ppes_Hodiny.AnalogHod();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkAnaDig);
            this.splitContainer1.Panel1.Controls.Add(this.chkVter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.digitalHod1);
            this.splitContainer1.Panel2.Controls.Add(this.analogHod1);
            this.splitContainer1.Size = new System.Drawing.Size(471, 430);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkAnaDig
            // 
            this.chkAnaDig.AutoSize = true;
            this.chkAnaDig.Location = new System.Drawing.Point(36, 30);
            this.chkAnaDig.Name = "chkAnaDig";
            this.chkAnaDig.Size = new System.Drawing.Size(93, 17);
            this.chkAnaDig.TabIndex = 1;
            this.chkAnaDig.Text = "Analog/Digital";
            this.chkAnaDig.UseVisualStyleBackColor = true;
            this.chkAnaDig.CheckedChanged += new System.EventHandler(this.chkAnaDig_CheckedChanged);
            // 
            // chkVter
            // 
            this.chkVter.AutoSize = true;
            this.chkVter.Location = new System.Drawing.Point(370, 30);
            this.chkVter.Name = "chkVter";
            this.chkVter.Size = new System.Drawing.Size(78, 17);
            this.chkVter.TabIndex = 0;
            this.chkVter.Text = "Vteřinovka";
            this.chkVter.UseVisualStyleBackColor = true;
            this.chkVter.CheckedChanged += new System.EventHandler(this.chkVter_CheckedChanged);
            // 
            // digitalHod1
            // 
            this.digitalHod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitalHod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.digitalHod1.Location = new System.Drawing.Point(0, 0);
            this.digitalHod1.Name = "digitalHod1";
            this.digitalHod1.Size = new System.Drawing.Size(471, 361);
            this.digitalHod1.TabIndex = 1;
            this.digitalHod1.Text = "digitalHod1";
            // 
            // analogHod1
            // 
            this.analogHod1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analogHod1.Location = new System.Drawing.Point(0, 0);
            this.analogHod1.Name = "analogHod1";
            this.analogHod1.Size = new System.Drawing.Size(471, 361);
            this.analogHod1.TabIndex = 0;
            this.analogHod1.Text = "analogHod1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 430);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Hodiny";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox chkAnaDig;
        private System.Windows.Forms.CheckBox chkVter;
        private AnalogHod analogHod1;
        private digitalHod digitalHod1;
    }
}

