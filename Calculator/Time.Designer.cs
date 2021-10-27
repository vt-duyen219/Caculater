
namespace Calculator
{
    partial class Time
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbInput = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt7 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bt4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt8 = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.btClr = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mauform = new System.Windows.Forms.ColorDialog();
            this.btColorChange = new System.Windows.Forms.Button();
            this.lbNameMSSV = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lbUsername);
            this.groupBox1.Controls.Add(this.lbInput);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.bt7);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.bt4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.bt8);
            this.groupBox1.Controls.Add(this.lbOutput);
            this.groupBox1.Controls.Add(this.bt1);
            this.groupBox1.Controls.Add(this.bt9);
            this.groupBox1.Controls.Add(this.btDel);
            this.groupBox1.Controls.Add(this.bt5);
            this.groupBox1.Controls.Add(this.btClr);
            this.groupBox1.Controls.Add(this.bt2);
            this.groupBox1.Controls.Add(this.btDot);
            this.groupBox1.Controls.Add(this.bt6);
            this.groupBox1.Controls.Add(this.bt0);
            this.groupBox1.Controls.Add(this.bt3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 332);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // lbUsername
            // 
            this.lbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Black;
            this.lbUsername.Location = new System.Drawing.Point(237, 34);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(220, 30);
            this.lbUsername.TabIndex = 48;
            this.lbUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // lbInput
            // 
            this.lbInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput.Location = new System.Drawing.Point(6, 80);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(196, 39);
            this.lbInput.TabIndex = 43;
            this.lbInput.Text = "0";
            this.lbInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(18, 34);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(98, 28);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.loginToolStripMenuItem.Text = "Calculator";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click_1);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(221, 138);
            this.bt7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(75, 41);
            this.bt7.TabIndex = 30;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "hours",
            "minutes",
            "seconds"});
            this.comboBox2.Location = new System.Drawing.Point(6, 238);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 28);
            this.comboBox2.TabIndex = 44;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(221, 185);
            this.bt4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 41);
            this.bt4.TabIndex = 33;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "hours",
            "minutes",
            "seconds"});
            this.comboBox1.Location = new System.Drawing.Point(6, 127);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 28);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(302, 138);
            this.bt8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(75, 41);
            this.bt8.TabIndex = 31;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt);
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.Location = new System.Drawing.Point(6, 192);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(196, 41);
            this.lbOutput.TabIndex = 43;
            this.lbOutput.Text = "0";
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(221, 232);
            this.bt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 41);
            this.bt1.TabIndex = 36;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(382, 138);
            this.bt9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(75, 41);
            this.bt9.TabIndex = 32;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDel.Location = new System.Drawing.Point(382, 91);
            this.btDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 41);
            this.btDel.TabIndex = 42;
            this.btDel.Text = "<-";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(302, 185);
            this.bt5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 41);
            this.bt5.TabIndex = 34;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt);
            // 
            // btClr
            // 
            this.btClr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClr.Location = new System.Drawing.Point(302, 91);
            this.btClr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btClr.Name = "btClr";
            this.btClr.Size = new System.Drawing.Size(75, 41);
            this.btClr.TabIndex = 41;
            this.btClr.Text = "CLR";
            this.btClr.UseVisualStyleBackColor = false;
            this.btClr.Click += new System.EventHandler(this.btClr_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(302, 232);
            this.bt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 41);
            this.bt2.TabIndex = 37;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt);
            // 
            // btDot
            // 
            this.btDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDot.Location = new System.Drawing.Point(382, 279);
            this.btDot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(75, 41);
            this.btDot.TabIndex = 40;
            this.btDot.Text = ".";
            this.btDot.UseVisualStyleBackColor = false;
            this.btDot.Click += new System.EventHandler(this.btDot_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(382, 185);
            this.bt6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(75, 41);
            this.bt6.TabIndex = 35;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(302, 279);
            this.bt0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(75, 41);
            this.bt0.TabIndex = 39;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(382, 232);
            this.bt3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 41);
            this.bt3.TabIndex = 38;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btColorChange
            // 
            this.btColorChange.Location = new System.Drawing.Point(381, 416);
            this.btColorChange.Name = "btColorChange";
            this.btColorChange.Size = new System.Drawing.Size(115, 31);
            this.btColorChange.TabIndex = 47;
            this.btColorChange.Text = "Color Change";
            this.btColorChange.UseVisualStyleBackColor = true;
            this.btColorChange.Click += new System.EventHandler(this.btColorChange_Click);
            // 
            // lbNameMSSV
            // 
            this.lbNameMSSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbNameMSSV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNameMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameMSSV.ForeColor = System.Drawing.Color.Blue;
            this.lbNameMSSV.Location = new System.Drawing.Point(12, 9);
            this.lbNameMSSV.Name = "lbNameMSSV";
            this.lbNameMSSV.Size = new System.Drawing.Size(499, 46);
            this.lbNameMSSV.TabIndex = 48;
            this.lbNameMSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNameMSSV.Click += new System.EventHandler(this.lbNameMSSV_Click);
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 452);
            this.Controls.Add(this.lbNameMSSV);
            this.Controls.Add(this.btColorChange);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Time";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time";
            this.Load += new System.EventHandler(this.Time_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button btClr;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button btDot;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.ColorDialog mauform;
        private System.Windows.Forms.Button btColorChange;
        private System.Windows.Forms.Label lbNameMSSV;
    }
}