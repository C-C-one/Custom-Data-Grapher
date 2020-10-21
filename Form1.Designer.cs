namespace Adress_book
{
    partial class sdasdawd
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLine1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbltest = new System.Windows.Forms.Label();
            this.horriaxis = new System.Windows.Forms.PictureBox();
            this.vertiaxis = new System.Windows.Forms.PictureBox();
            this.tmrCon = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horriaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertiaxis)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBar1.Location = new System.Drawing.Point(46, 387);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(334, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.trackBar3.LargeChange = 1;
            this.trackBar3.Location = new System.Drawing.Point(5, 84);
            this.trackBar3.Maximum = 3;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(56, 229);
            this.trackBar3.TabIndex = 0;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(62, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trail 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(116, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trail 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Chartreuse;
            this.label4.Location = new System.Drawing.Point(170, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trail 1";
            // 
            // btnLine1
            // 
            this.btnLine1.Location = new System.Drawing.Point(419, 378);
            this.btnLine1.Name = "btnLine1";
            this.btnLine1.Size = new System.Drawing.Size(81, 25);
            this.btnLine1.TabIndex = 9;
            this.btnLine1.Text = "UPDATE";
            this.btnLine1.UseVisualStyleBackColor = true;
            this.btnLine1.Click += new System.EventHandler(this.btnLine1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(399, 383);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.ForeColor = System.Drawing.Color.Blue;
            this.lbltest.Location = new System.Drawing.Point(396, 9);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(48, 17);
            this.lbltest.TabIndex = 12;
            this.lbltest.Text = "Trail 1";
            // 
            // horriaxis
            // 
            this.horriaxis.BackColor = System.Drawing.SystemColors.ControlDark;
            this.horriaxis.Location = new System.Drawing.Point(67, 139);
            this.horriaxis.Name = "horriaxis";
            this.horriaxis.Size = new System.Drawing.Size(440, 2);
            this.horriaxis.TabIndex = 13;
            this.horriaxis.TabStop = false;
            // 
            // vertiaxis
            // 
            this.vertiaxis.BackColor = System.Drawing.SystemColors.ControlDark;
            this.vertiaxis.Location = new System.Drawing.Point(191, 14);
            this.vertiaxis.Name = "vertiaxis";
            this.vertiaxis.Size = new System.Drawing.Size(2, 360);
            this.vertiaxis.TabIndex = 14;
            this.vertiaxis.TabStop = false;
            // 
            // tmrCon
            // 
            this.tmrCon.Enabled = true;
            this.tmrCon.Interval = 35;
            this.tmrCon.Tick += new System.EventHandler(this.tmrCon_Tick);
            // 
            // sdasdawd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(528, 427);
            this.Controls.Add(this.vertiaxis);
            this.Controls.Add(this.horriaxis);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLine1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sdasdawd";
            this.Text = "dasdawas";
            this.Load += new System.EventHandler(this.sdasdawd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horriaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertiaxis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLine1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.PictureBox horriaxis;
        private System.Windows.Forms.PictureBox vertiaxis;
        private System.Windows.Forms.Timer tmrCon;
    }
}

