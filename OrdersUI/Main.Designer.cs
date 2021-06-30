
namespace OrdersUI
{
    partial class Main
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
            this.сущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продавцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInLabel2 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продавцыToolStripMenuItem,
            this.историяЗаказовToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.сущностиToolStripMenuItem.Text = "Сущности";
            // 
            // продавцыToolStripMenuItem
            // 
            this.продавцыToolStripMenuItem.Name = "продавцыToolStripMenuItem";
            this.продавцыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.продавцыToolStripMenuItem.Text = "Продавцы";
            // 
            // историяЗаказовToolStripMenuItem
            // 
            this.историяЗаказовToolStripMenuItem.Name = "историяЗаказовToolStripMenuItem";
            this.историяЗаказовToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.историяЗаказовToolStripMenuItem.Text = "История заказов";
            // 
            // logInLabel2
            // 
            this.logInLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logInLabel2.AutoSize = true;
            this.logInLabel2.Location = new System.Drawing.Point(684, 37);
            this.logInLabel2.Name = "logInLabel2";
            this.logInLabel2.Size = new System.Drawing.Size(94, 17);
            this.logInLabel2.TabIndex = 6;
            this.logInLabel2.TabStop = true;
            this.logInLabel2.Text = "Авторизация";
            this.logInLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logInLabel2_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logInLabel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продавцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяЗаказовToolStripMenuItem;
        private System.Windows.Forms.LinkLabel logInLabel2;
    }
}

