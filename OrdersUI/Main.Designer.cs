
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
            this.sellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersLogЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInLabel2 = new System.Windows.Forms.LinkLabel();
            this.productsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.payButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(615, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem1,
            this.sellersToolStripMenuItem,
            this.ordersLogЗаказовToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.сущностиToolStripMenuItem.Text = "Сущности";
            // 
            // sellersToolStripMenuItem
            // 
            this.sellersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSellerToolStripMenuItem});
            this.sellersToolStripMenuItem.Name = "sellersToolStripMenuItem";
            this.sellersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sellersToolStripMenuItem.Text = "Продавцы";
            this.sellersToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // ordersLogЗаказовToolStripMenuItem
            // 
            this.ordersLogЗаказовToolStripMenuItem.Name = "ordersLogЗаказовToolStripMenuItem";
            this.ordersLogЗаказовToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ordersLogЗаказовToolStripMenuItem.Text = "История заказов";
            this.ordersLogЗаказовToolStripMenuItem.Click += new System.EventHandler(this.OrdersLogToolStripMenuItem_Click);
            // 
            // logInLabel2
            // 
            this.logInLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logInLabel2.AutoSize = true;
            this.logInLabel2.Location = new System.Drawing.Point(499, 37);
            this.logInLabel2.Name = "logInLabel2";
            this.logInLabel2.Size = new System.Drawing.Size(94, 17);
            this.logInLabel2.TabIndex = 6;
            this.logInLabel2.TabStop = true;
            this.logInLabel2.Text = "Авторизация";
            this.logInLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logInLabel2_LinkClicked);
            // 
            // productsToolStripMenuItem1
            // 
            this.productsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem});
            this.productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            this.productsToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.productsToolStripMenuItem1.Text = "Товары";
            this.productsToolStripMenuItem1.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 468);
            this.listBox1.TabIndex = 8;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(328, 70);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(265, 372);
            this.listBox2.TabIndex = 9;
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(328, 498);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(265, 40);
            this.payButton.TabIndex = 11;
            this.payButton.Text = "Оплатить";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(325, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Итого: ";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addProductToolStripMenuItem.Text = "Добавить";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // addSellerToolStripMenuItem
            // 
            this.addSellerToolStripMenuItem.Name = "addSellerToolStripMenuItem";
            this.addSellerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addSellerToolStripMenuItem.Text = "Добавить";
            this.addSellerToolStripMenuItem.Click += new System.EventHandler(this.addSellerToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 550);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.logInLabel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersLogЗаказовToolStripMenuItem;
        private System.Windows.Forms.LinkLabel logInLabel2;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSellerToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

