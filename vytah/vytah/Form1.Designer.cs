namespace vytah
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
      this.components = new System.ComponentModel.Container();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.lblStatus = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btn2DOWN = new System.Windows.Forms.Button();
      this.btn3DOWN = new System.Windows.Forms.Button();
      this.btn4DOWN = new System.Windows.Forms.Button();
      this.btn2UP = new System.Windows.Forms.Button();
      this.btn3UP = new System.Windows.Forms.Button();
      this.btn4UP = new System.Windows.Forms.Button();
      this.btn1UP = new System.Windows.Forms.Button();
      this.btn1DOWN = new System.Windows.Forms.Button();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.lbl4fl = new System.Windows.Forms.Label();
      this.lbl3fl = new System.Windows.Forms.Label();
      this.lbl2fl = new System.Windows.Forms.Label();
      this.lbl1fl = new System.Windows.Forms.Label();
      this.tmr1 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
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
      this.splitContainer1.Panel1.Controls.Add(this.lblStatus);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
      this.splitContainer1.Size = new System.Drawing.Size(492, 459);
      this.splitContainer1.SplitterDistance = 113;
      this.splitContainer1.TabIndex = 0;
      // 
      // lblStatus
      // 
      this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lblStatus.Location = new System.Drawing.Point(0, 0);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(492, 113);
      this.lblStatus.TabIndex = 0;
      this.lblStatus.Text = "STATUS";
      this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.7561F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.2439F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 342);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.btn2DOWN, 1, 2);
      this.tableLayoutPanel2.Controls.Add(this.btn3DOWN, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.btn4DOWN, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.btn2UP, 0, 2);
      this.tableLayoutPanel2.Controls.Add(this.btn3UP, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.btn4UP, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.btn1UP, 0, 3);
      this.tableLayoutPanel2.Controls.Add(this.btn1DOWN, 1, 3);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 4;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 336);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // btn2DOWN
      // 
      this.btn2DOWN.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btn2DOWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btn2DOWN.Location = new System.Drawing.Point(147, 171);
      this.btn2DOWN.Name = "btn2DOWN";
      this.btn2DOWN.Size = new System.Drawing.Size(138, 78);
      this.btn2DOWN.TabIndex = 9;
      this.btn2DOWN.Tag = "2";
      this.btn2DOWN.Text = "↓";
      this.btn2DOWN.UseVisualStyleBackColor = true;
      this.btn2DOWN.Click += new System.EventHandler(this.btnDOWN_Click);
      // 
      // btn3DOWN
      // 
      this.btn3DOWN.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btn3DOWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btn3DOWN.Location = new System.Drawing.Point(147, 87);
      this.btn3DOWN.Name = "btn3DOWN";
      this.btn3DOWN.Size = new System.Drawing.Size(138, 78);
      this.btn3DOWN.TabIndex = 8;
      this.btn3DOWN.Tag = "3";
      this.btn3DOWN.Text = "↓";
      this.btn3DOWN.UseVisualStyleBackColor = true;
      this.btn3DOWN.Click += new System.EventHandler(this.btnDOWN_Click);
      // 
      // btn4DOWN
      // 
      this.btn4DOWN.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btn4DOWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btn4DOWN.Location = new System.Drawing.Point(147, 3);
      this.btn4DOWN.Name = "btn4DOWN";
      this.btn4DOWN.Size = new System.Drawing.Size(138, 78);
      this.btn4DOWN.TabIndex = 7;
      this.btn4DOWN.Tag = "4";
      this.btn4DOWN.Text = "↓";
      this.btn4DOWN.UseVisualStyleBackColor = true;
      this.btn4DOWN.Click += new System.EventHandler(this.btnDOWN_Click);
      // 
      // btn2UP
      // 
      this.btn2UP.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btn2UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btn2UP.Location = new System.Drawing.Point(3, 171);
      this.btn2UP.Name = "btn2UP";
      this.btn2UP.Size = new System.Drawing.Size(138, 78);
      this.btn2UP.TabIndex = 6;
      this.btn2UP.Tag = "2";
      this.btn2UP.Text = "↑";
      this.btn2UP.UseVisualStyleBackColor = true;
      this.btn2UP.Click += new System.EventHandler(this.btnUP_Click);
      // 
      // btn3UP
      // 
      this.btn3UP.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btn3UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btn3UP.Location = new System.Drawing.Point(3, 87);
      this.btn3UP.Name = "btn3UP";
      this.btn3UP.Size = new System.Drawing.Size(138, 78);
      this.btn3UP.TabIndex = 4;
      this.btn3UP.Tag = "3";
      this.btn3UP.Text = "↑";
      this.btn3UP.UseVisualStyleBackColor = true;
      this.btn3UP.Click += new System.EventHandler(this.btnUP_Click);
      // 
      // btn4UP
      // 
      this.btn4UP.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btn4UP.Enabled = false;
      this.btn4UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btn4UP.Location = new System.Drawing.Point(3, 3);
      this.btn4UP.Name = "btn4UP";
      this.btn4UP.Size = new System.Drawing.Size(138, 78);
      this.btn4UP.TabIndex = 2;
      this.btn4UP.Tag = "4";
      this.btn4UP.Text = "↑";
      this.btn4UP.UseVisualStyleBackColor = true;
      this.btn4UP.Click += new System.EventHandler(this.btnUP_Click);
      // 
      // btn1UP
      // 
      this.btn1UP.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btn1UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btn1UP.Location = new System.Drawing.Point(3, 255);
      this.btn1UP.Name = "btn1UP";
      this.btn1UP.Size = new System.Drawing.Size(138, 78);
      this.btn1UP.TabIndex = 0;
      this.btn1UP.Tag = "1";
      this.btn1UP.Text = "↑";
      this.btn1UP.UseVisualStyleBackColor = true;
      this.btn1UP.Click += new System.EventHandler(this.btnUP_Click);
      // 
      // btn1DOWN
      // 
      this.btn1DOWN.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btn1DOWN.Enabled = false;
      this.btn1DOWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btn1DOWN.Location = new System.Drawing.Point(147, 255);
      this.btn1DOWN.Name = "btn1DOWN";
      this.btn1DOWN.Size = new System.Drawing.Size(138, 78);
      this.btn1DOWN.TabIndex = 1;
      this.btn1DOWN.Tag = "1";
      this.btn1DOWN.Text = "↓";
      this.btn1DOWN.UseVisualStyleBackColor = true;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.lbl4fl, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.lbl3fl, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.lbl2fl, 0, 2);
      this.tableLayoutPanel3.Controls.Add(this.lbl1fl, 0, 3);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(297, 3);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 4;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(192, 336);
      this.tableLayoutPanel3.TabIndex = 1;
      // 
      // lbl4fl
      // 
      this.lbl4fl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbl4fl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lbl4fl.Location = new System.Drawing.Point(3, 0);
      this.lbl4fl.Name = "lbl4fl";
      this.lbl4fl.Size = new System.Drawing.Size(186, 84);
      this.lbl4fl.TabIndex = 0;
      this.lbl4fl.Text = "4";
      this.lbl4fl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbl3fl
      // 
      this.lbl3fl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbl3fl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lbl3fl.Location = new System.Drawing.Point(3, 84);
      this.lbl3fl.Name = "lbl3fl";
      this.lbl3fl.Size = new System.Drawing.Size(186, 84);
      this.lbl3fl.TabIndex = 1;
      this.lbl3fl.Text = "3";
      this.lbl3fl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbl2fl
      // 
      this.lbl2fl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbl2fl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lbl2fl.Location = new System.Drawing.Point(3, 168);
      this.lbl2fl.Name = "lbl2fl";
      this.lbl2fl.Size = new System.Drawing.Size(186, 84);
      this.lbl2fl.TabIndex = 2;
      this.lbl2fl.Text = "2";
      this.lbl2fl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbl1fl
      // 
      this.lbl1fl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbl1fl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.lbl1fl.Location = new System.Drawing.Point(3, 252);
      this.lbl1fl.Name = "lbl1fl";
      this.lbl1fl.Size = new System.Drawing.Size(186, 84);
      this.lbl1fl.TabIndex = 3;
      this.lbl1fl.Text = "1";
      this.lbl1fl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tmr1
      // 
      this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(492, 459);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "Vytah";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btn2DOWN;
    private System.Windows.Forms.Button btn3DOWN;
    private System.Windows.Forms.Button btn4DOWN;
    private System.Windows.Forms.Button btn2UP;
    private System.Windows.Forms.Button btn3UP;
    private System.Windows.Forms.Button btn4UP;
    private System.Windows.Forms.Button btn1UP;
    private System.Windows.Forms.Button btn1DOWN;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Label lbl4fl;
    private System.Windows.Forms.Label lbl3fl;
    private System.Windows.Forms.Label lbl2fl;
    private System.Windows.Forms.Label lbl1fl;
    private System.Windows.Forms.Timer tmr1;
  }
}

