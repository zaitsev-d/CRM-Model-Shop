namespace CRM.UI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerAddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BuyerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entitiesToolStripMenuItem
            // 
            this.entitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductToolStripMenuItem,
            this.SellerToolStripMenuItem,
            this.BuyerToolStripMenuItem,
            this.CheckToolStripMenuItem});
            this.entitiesToolStripMenuItem.Name = "entitiesToolStripMenuItem";
            this.entitiesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.entitiesToolStripMenuItem.Text = "Entities";
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem});
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ProductToolStripMenuItem.Text = "Product";
            this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // ProductAddToolStripMenuItem1
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem1";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AddToolStripMenuItem.Text = "Add";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.ProductAddToolStripMenuItem1_Click);
            // 
            // SellerToolStripMenuItem
            // 
            this.SellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SellerAddToolStripMenuItem1});
            this.SellerToolStripMenuItem.Name = "SellerToolStripMenuItem";
            this.SellerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SellerToolStripMenuItem.Text = "Seller";
            this.SellerToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // SellerAddToolStripMenuItem1
            // 
            this.SellerAddToolStripMenuItem1.Name = "SellerAddToolStripMenuItem1";
            this.SellerAddToolStripMenuItem1.Size = new System.Drawing.Size(120, 26);
            this.SellerAddToolStripMenuItem1.Text = "Add";
            this.SellerAddToolStripMenuItem1.Click += new System.EventHandler(this.SellerAddToolStripMenuItem1_Click);
            // 
            // BuyerToolStripMenuItem
            // 
            this.BuyerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem2});
            this.BuyerToolStripMenuItem.Name = "BuyerToolStripMenuItem";
            this.BuyerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.BuyerToolStripMenuItem.Text = "Buyer";
            this.BuyerToolStripMenuItem.Click += new System.EventHandler(this.BuyerToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem2
            // 
            this.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2";
            this.AddToolStripMenuItem2.Size = new System.Drawing.Size(120, 26);
            this.AddToolStripMenuItem2.Text = "Add";
            this.AddToolStripMenuItem2.Click += new System.EventHandler(this.BuyerAddToolStripMenuItem2_Click);
            // 
            // CheckToolStripMenuItem
            // 
            this.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem";
            this.CheckToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CheckToolStripMenuItem.Text = "Check";
            this.CheckToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuyerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellerAddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem2;
    }
}

