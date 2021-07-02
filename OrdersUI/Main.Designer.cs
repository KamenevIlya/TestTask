
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
            this.productsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersLogЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productsChoosingButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.logInLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.productsListBox = new System.Windows.Forms.ListBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(615, 30);
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
            // productsToolStripMenuItem1
            // 
            this.productsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem});
            this.productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            this.productsToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.productsToolStripMenuItem1.Text = "Товары";
            this.productsToolStripMenuItem1.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.addProductToolStripMenuItem.Text = "Добавить";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // sellersToolStripMenuItem
            // 
            this.sellersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSellerToolStripMenuItem});
            this.sellersToolStripMenuItem.Name = "sellersToolStripMenuItem";
            this.sellersToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.sellersToolStripMenuItem.Text = "Продавцы";
            this.sellersToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // addSellerToolStripMenuItem
            // 
            this.addSellerToolStripMenuItem.Name = "addSellerToolStripMenuItem";
            this.addSellerToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.addSellerToolStripMenuItem.Text = "Добавить";
            this.addSellerToolStripMenuItem.Click += new System.EventHandler(this.addSellerToolStripMenuItem_Click);
            // 
            // ordersLogЗаказовToolStripMenuItem
            // 
            this.ordersLogЗаказовToolStripMenuItem.Name = "ordersLogЗаказовToolStripMenuItem";
            this.ordersLogЗаказовToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.ordersLogЗаказовToolStripMenuItem.Text = "История заказов";
            this.ordersLogЗаказовToolStripMenuItem.Click += new System.EventHandler(this.OrdersLogToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 84);
            this.comboBox1.MaxDropDownItems = 100;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Выберите продавца";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // productsChoosingButton
            // 
            this.productsChoosingButton.Location = new System.Drawing.Point(12, 156);
            this.productsChoosingButton.Name = "productsChoosingButton";
            this.productsChoosingButton.Size = new System.Drawing.Size(302, 65);
            this.productsChoosingButton.TabIndex = 14;
            this.productsChoosingButton.Text = "Выбрать товары";
            this.productsChoosingButton.UseVisualStyleBackColor = true;
            this.productsChoosingButton.Click += new System.EventHandler(this.productsChoosingButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(338, 493);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(265, 40);
            this.payButton.TabIndex = 15;
            this.payButton.Text = "Оформить заказ";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // logInLinkLabel1
            // 
            this.logInLinkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logInLinkLabel1.AutoSize = true;
            this.logInLinkLabel1.Location = new System.Drawing.Point(499, 44);
            this.logInLinkLabel1.Name = "logInLinkLabel1";
            this.logInLinkLabel1.Size = new System.Drawing.Size(94, 17);
            this.logInLinkLabel1.TabIndex = 17;
            this.logInLinkLabel1.TabStop = true;
            this.logInLinkLabel1.Text = "Авторизация";
            this.logInLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logInLinkLabel1_LinkClicked);
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 16;
            this.productsListBox.Location = new System.Drawing.Point(12, 241);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(302, 292);
            this.productsListBox.TabIndex = 18;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 550);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.logInLinkLabel1);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.productsChoosingButton);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSellerToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button productsChoosingButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.LinkLabel logInLinkLabel1;
        private System.Windows.Forms.ListBox productsListBox;
    }
}

