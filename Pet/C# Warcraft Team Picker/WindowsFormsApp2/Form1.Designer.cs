namespace WindowsFormsApp2
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ордаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.альянсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нежитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ночныеЭльфыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фракцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ордаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альянсToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.нежитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ночныеЭльфыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фракцияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.Jhlf;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(678, 692);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Альянс;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 692);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp2.Properties.Resources.Ночные_эльфы;
            this.pictureBox4.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(680, 686);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.Нежить;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(677, 685);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // ордаToolStripMenuItem1
            // 
            this.ордаToolStripMenuItem1.Name = "ордаToolStripMenuItem1";
            this.ордаToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.ордаToolStripMenuItem1.Text = "Орда";
            // 
            // альянсToolStripMenuItem
            // 
            this.альянсToolStripMenuItem.Name = "альянсToolStripMenuItem";
            this.альянсToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.альянсToolStripMenuItem.Text = "Альянс";
            this.альянсToolStripMenuItem.Click += new System.EventHandler(this.альянсToolStripMenuItem_Click);
            // 
            // нежитьToolStripMenuItem
            // 
            this.нежитьToolStripMenuItem.Name = "нежитьToolStripMenuItem";
            this.нежитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.нежитьToolStripMenuItem.Text = "Нежить";
            this.нежитьToolStripMenuItem.Click += new System.EventHandler(this.нежитьToolStripMenuItem_Click);
            // 
            // ночныеЭльфыToolStripMenuItem
            // 
            this.ночныеЭльфыToolStripMenuItem.Name = "ночныеЭльфыToolStripMenuItem";
            this.ночныеЭльфыToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ночныеЭльфыToolStripMenuItem.Text = "Ночные эльфы";
            this.ночныеЭльфыToolStripMenuItem.Click += new System.EventHandler(this.ночныеЭльфыToolStripMenuItem_Click);
            // 
            // фракцияToolStripMenuItem
            // 
            this.фракцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ордаToolStripMenuItem,
            this.альянсToolStripMenuItem1,
            this.нежитьToolStripMenuItem1,
            this.ночныеЭльфыToolStripMenuItem1});
            this.фракцияToolStripMenuItem.Name = "фракцияToolStripMenuItem";
            this.фракцияToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.фракцияToolStripMenuItem.Text = "Фракция";
            // 
            // ордаToolStripMenuItem
            // 
            this.ордаToolStripMenuItem.Name = "ордаToolStripMenuItem";
            this.ордаToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ордаToolStripMenuItem.Text = "орда";
            this.ордаToolStripMenuItem.Click += new System.EventHandler(this.ордаToolStripMenuItem_Click_1);
            // 
            // альянсToolStripMenuItem1
            // 
            this.альянсToolStripMenuItem1.Name = "альянсToolStripMenuItem1";
            this.альянсToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.альянсToolStripMenuItem1.Text = "альянс";
            this.альянсToolStripMenuItem1.Click += new System.EventHandler(this.альянсToolStripMenuItem1_Click);
            // 
            // нежитьToolStripMenuItem1
            // 
            this.нежитьToolStripMenuItem1.Name = "нежитьToolStripMenuItem1";
            this.нежитьToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.нежитьToolStripMenuItem1.Text = "нежить";
            this.нежитьToolStripMenuItem1.Click += new System.EventHandler(this.нежитьToolStripMenuItem1_Click);
            // 
            // ночныеЭльфыToolStripMenuItem1
            // 
            this.ночныеЭльфыToolStripMenuItem1.Name = "ночныеЭльфыToolStripMenuItem1";
            this.ночныеЭльфыToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.ночныеЭльфыToolStripMenuItem1.Text = "ночные эльфы";
            this.ночныеЭльфыToolStripMenuItem1.Click += new System.EventHandler(this.ночныеЭльфыToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 678);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "За кого ты???";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolStripMenuItem ордаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem альянсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нежитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ночныеЭльфыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фракцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ордаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альянсToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem нежитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ночныеЭльфыToolStripMenuItem1;
    }
}

