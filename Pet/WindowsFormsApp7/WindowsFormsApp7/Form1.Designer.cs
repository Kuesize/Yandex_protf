namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.самостоятельнаяРабота2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пройтиТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.самостоятельнаяРабота2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // самостоятельнаяРабота2ToolStripMenuItem
            // 
            this.самостоятельнаяРабота2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пройтиТестToolStripMenuItem,
            this.результатToolStripMenuItem});
            this.самостоятельнаяРабота2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.самостоятельнаяРабота2ToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.самостоятельнаяРабота2ToolStripMenuItem.Name = "самостоятельнаяРабота2ToolStripMenuItem";
            this.самостоятельнаяРабота2ToolStripMenuItem.Size = new System.Drawing.Size(94, 32);
            this.самостоятельнаяРабота2ToolStripMenuItem.Text = "G.O.A.T.";
            // 
            // пройтиТестToolStripMenuItem
            // 
            this.пройтиТестToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.пройтиТестToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.пройтиТестToolStripMenuItem.Name = "пройтиТестToolStripMenuItem";
            this.пройтиТестToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.пройтиТестToolStripMenuItem.Text = "Пройти \"К.О.З.А.\"";
            this.пройтиТестToolStripMenuItem.Click += new System.EventHandler(this.пройтиТестToolStripMenuItem_Click);
            // 
            // результатToolStripMenuItem
            // 
            this.результатToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen;
            this.результатToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.результатToolStripMenuItem.Name = "результатToolStripMenuItem";
            this.результатToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.результатToolStripMenuItem.Text = "Просмотреть результат";
            this.результатToolStripMenuItem.Click += new System.EventHandler(this.результатToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp7.Properties.Resources.goat;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "G.O.A.T.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem самостоятельнаяРабота2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пройтиТестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

