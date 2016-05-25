namespace EnhancedPainter
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
            this.txtColors = new System.Windows.Forms.GroupBox();
            this.rdbtnEraser = new System.Windows.Forms.RadioButton();
            this.rdbtnYellow = new System.Windows.Forms.RadioButton();
            this.rdbtnRed = new System.Windows.Forms.RadioButton();
            this.rdbtnBlue = new System.Windows.Forms.RadioButton();
            this.txtSize = new System.Windows.Forms.GroupBox();
            this.rdbtnMegaLarge = new System.Windows.Forms.RadioButton();
            this.rdbtnLarge = new System.Windows.Forms.RadioButton();
            this.rdbtnMedium = new System.Windows.Forms.RadioButton();
            this.rdbtnSmall = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtColors.SuspendLayout();
            this.txtSize.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtColors
            // 
            this.txtColors.Controls.Add(this.rdbtnEraser);
            this.txtColors.Controls.Add(this.rdbtnYellow);
            this.txtColors.Controls.Add(this.rdbtnRed);
            this.txtColors.Controls.Add(this.rdbtnBlue);
            this.txtColors.Location = new System.Drawing.Point(12, 36);
            this.txtColors.Name = "txtColors";
            this.txtColors.Size = new System.Drawing.Size(102, 150);
            this.txtColors.TabIndex = 0;
            this.txtColors.TabStop = false;
            this.txtColors.Text = "Colors";
            // 
            // rdbtnEraser
            // 
            this.rdbtnEraser.AutoSize = true;
            this.rdbtnEraser.Location = new System.Drawing.Point(22, 116);
            this.rdbtnEraser.Name = "rdbtnEraser";
            this.rdbtnEraser.Size = new System.Drawing.Size(55, 17);
            this.rdbtnEraser.TabIndex = 3;
            this.rdbtnEraser.TabStop = true;
            this.rdbtnEraser.Text = "Eraser";
            this.rdbtnEraser.UseVisualStyleBackColor = true;
            // 
            // rdbtnYellow
            // 
            this.rdbtnYellow.AutoSize = true;
            this.rdbtnYellow.Location = new System.Drawing.Point(23, 83);
            this.rdbtnYellow.Name = "rdbtnYellow";
            this.rdbtnYellow.Size = new System.Drawing.Size(56, 17);
            this.rdbtnYellow.TabIndex = 2;
            this.rdbtnYellow.TabStop = true;
            this.rdbtnYellow.Text = "Yellow";
            this.rdbtnYellow.UseVisualStyleBackColor = true;
            // 
            // rdbtnRed
            // 
            this.rdbtnRed.AutoSize = true;
            this.rdbtnRed.Location = new System.Drawing.Point(23, 51);
            this.rdbtnRed.Name = "rdbtnRed";
            this.rdbtnRed.Size = new System.Drawing.Size(45, 17);
            this.rdbtnRed.TabIndex = 1;
            this.rdbtnRed.TabStop = true;
            this.rdbtnRed.Text = "Red";
            this.rdbtnRed.UseVisualStyleBackColor = true;
            this.rdbtnRed.UseWaitCursor = true;
            // 
            // rdbtnBlue
            // 
            this.rdbtnBlue.AutoSize = true;
            this.rdbtnBlue.Location = new System.Drawing.Point(22, 19);
            this.rdbtnBlue.Name = "rdbtnBlue";
            this.rdbtnBlue.Size = new System.Drawing.Size(46, 17);
            this.rdbtnBlue.TabIndex = 0;
            this.rdbtnBlue.TabStop = true;
            this.rdbtnBlue.Text = "Blue";
            this.rdbtnBlue.UseVisualStyleBackColor = true;
            // 
            // txtSize
            // 
            this.txtSize.Controls.Add(this.rdbtnMegaLarge);
            this.txtSize.Controls.Add(this.rdbtnLarge);
            this.txtSize.Controls.Add(this.rdbtnMedium);
            this.txtSize.Controls.Add(this.rdbtnSmall);
            this.txtSize.Location = new System.Drawing.Point(12, 230);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(102, 167);
            this.txtSize.TabIndex = 1;
            this.txtSize.TabStop = false;
            this.txtSize.Text = "Size";
            // 
            // rdbtnMegaLarge
            // 
            this.rdbtnMegaLarge.AutoSize = true;
            this.rdbtnMegaLarge.Location = new System.Drawing.Point(18, 128);
            this.rdbtnMegaLarge.Name = "rdbtnMegaLarge";
            this.rdbtnMegaLarge.Size = new System.Drawing.Size(82, 17);
            this.rdbtnMegaLarge.TabIndex = 3;
            this.rdbtnMegaLarge.TabStop = true;
            this.rdbtnMegaLarge.Text = "Mega Large";
            this.rdbtnMegaLarge.UseVisualStyleBackColor = true;
            // 
            // rdbtnLarge
            // 
            this.rdbtnLarge.AutoSize = true;
            this.rdbtnLarge.Location = new System.Drawing.Point(18, 93);
            this.rdbtnLarge.Name = "rdbtnLarge";
            this.rdbtnLarge.Size = new System.Drawing.Size(52, 17);
            this.rdbtnLarge.TabIndex = 2;
            this.rdbtnLarge.TabStop = true;
            this.rdbtnLarge.Text = "Large";
            this.rdbtnLarge.UseVisualStyleBackColor = true;
            // 
            // rdbtnMedium
            // 
            this.rdbtnMedium.AutoSize = true;
            this.rdbtnMedium.Location = new System.Drawing.Point(18, 60);
            this.rdbtnMedium.Name = "rdbtnMedium";
            this.rdbtnMedium.Size = new System.Drawing.Size(62, 17);
            this.rdbtnMedium.TabIndex = 1;
            this.rdbtnMedium.TabStop = true;
            this.rdbtnMedium.Text = "Medium";
            this.rdbtnMedium.UseVisualStyleBackColor = true;
            // 
            // rdbtnSmall
            // 
            this.rdbtnSmall.AutoSize = true;
            this.rdbtnSmall.Location = new System.Drawing.Point(18, 28);
            this.rdbtnSmall.Name = "rdbtnSmall";
            this.rdbtnSmall.Size = new System.Drawing.Size(50, 17);
            this.rdbtnSmall.TabIndex = 0;
            this.rdbtnSmall.TabStop = true;
            this.rdbtnSmall.Text = "Small";
            this.rdbtnSmall.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(137, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 529);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtColors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.txtColors.ResumeLayout(false);
            this.txtColors.PerformLayout();
            this.txtSize.ResumeLayout(false);
            this.txtSize.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox txtColors;
        private System.Windows.Forms.RadioButton rdbtnYellow;
        private System.Windows.Forms.RadioButton rdbtnRed;
        private System.Windows.Forms.RadioButton rdbtnBlue;
        private System.Windows.Forms.GroupBox txtSize;
        private System.Windows.Forms.RadioButton rdbtnLarge;
        private System.Windows.Forms.RadioButton rdbtnMedium;
        private System.Windows.Forms.RadioButton rdbtnSmall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbtnEraser;
        private System.Windows.Forms.RadioButton rdbtnMegaLarge;
    }
}

