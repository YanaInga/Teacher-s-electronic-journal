namespace WindowsFormsApplication3
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
            this.журналГруппToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингпланToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.журналГруппToolStripMenuItem,
            this.расписаниеToolStripMenuItem,
            this.рейтингпланToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1378, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // журналГруппToolStripMenuItem
            // 
            this.журналГруппToolStripMenuItem.Name = "журналГруппToolStripMenuItem";
            this.журналГруппToolStripMenuItem.Size = new System.Drawing.Size(140, 29);
            this.журналГруппToolStripMenuItem.Text = "Журнал групп";
            this.журналГруппToolStripMenuItem.Click += new System.EventHandler(this.журналГруппToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // рейтингпланToolStripMenuItem
            // 
            this.рейтингпланToolStripMenuItem.Name = "рейтингпланToolStripMenuItem";
            this.рейтингпланToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.рейтингпланToolStripMenuItem.Text = "Рейтинг-план";
            this.рейтингпланToolStripMenuItem.Click += new System.EventHandler(this.рейтингпланToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1378, 622);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 678);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1400, 678);
            this.Name = "Form1";
            this.Text = "Электронный журнал преподавателя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem журналГруппToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингпланToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

