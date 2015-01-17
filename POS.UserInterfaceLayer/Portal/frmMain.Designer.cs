﻿namespace POS.UserInterfaceLayer.Portal
{
    partial class frmMain
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
            this.mnu_MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuItem_Administration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_UserGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_BasicData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.mnuItem_Products = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_ProductGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.بياناتالموزعينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_MainMenu
            // 
            this.mnu_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_Administration,
            this.mnuItem_BasicData});
            this.mnu_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnu_MainMenu.Name = "mnu_MainMenu";
            this.mnu_MainMenu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.mnu_MainMenu.Size = new System.Drawing.Size(776, 24);
            this.mnu_MainMenu.TabIndex = 0;
            this.mnu_MainMenu.Text = "menuStrip1";
            this.mnu_MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnu_MainMenu_ItemClicked);
            // 
            // mnuItem_Administration
            // 
            this.mnuItem_Administration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_UserGroups});
            this.mnuItem_Administration.Name = "mnuItem_Administration";
            this.mnuItem_Administration.Size = new System.Drawing.Size(71, 19);
            this.mnuItem_Administration.Text = "المستخدمين";
            this.mnuItem_Administration.Visible = false;
            // 
            // mnuItem_UserGroups
            // 
            this.mnuItem_UserGroups.Name = "mnuItem_UserGroups";
            this.mnuItem_UserGroups.Size = new System.Drawing.Size(170, 22);
            this.mnuItem_UserGroups.Text = "مجموعات المستخدمين";
            this.mnuItem_UserGroups.Click += new System.EventHandler(this.mnuItem_UserGroups_Click);
            // 
            // mnuItem_BasicData
            // 
            this.mnuItem_BasicData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_Customers,
            this.mnuItem_Products,
            this.mnuItem_ProductGroup,
            this.بياناتالموزعينToolStripMenuItem});
            this.mnuItem_BasicData.Name = "mnuItem_BasicData";
            this.mnuItem_BasicData.Size = new System.Drawing.Size(95, 19);
            this.mnuItem_BasicData.Text = "البيانات الرئيسية";
            this.mnuItem_BasicData.Visible = false;
            // 
            // mnuItem_Customers
            // 
            this.mnuItem_Customers.Name = "mnuItem_Customers";
            this.mnuItem_Customers.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_Customers.Text = "بيانات العملاء";
            this.mnuItem_Customers.Click += new System.EventHandler(this.mnuItem_Customers_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(715, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "مرحبا ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Welcome.Location = new System.Drawing.Point(643, 35);
            this.lbl_Welcome.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(48, 20);
            this.lbl_Welcome.TabIndex = 3;
            this.lbl_Welcome.Text = "مرحبا ";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuItem_Products
            // 
            this.mnuItem_Products.Name = "mnuItem_Products";
            this.mnuItem_Products.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_Products.Text = "الاصناف";
            // 
            // mnuItem_ProductGroup
            // 
            this.mnuItem_ProductGroup.Name = "mnuItem_ProductGroup";
            this.mnuItem_ProductGroup.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_ProductGroup.Text = "مجموعة الاصناف";
            // 
            // بياناتالموزعينToolStripMenuItem
            // 
            this.بياناتالموزعينToolStripMenuItem.Name = "بياناتالموزعينToolStripMenuItem";
            this.بياناتالموزعينToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.بياناتالموزعينToolStripMenuItem.Text = "بيانات الموردين";
            this.بياناتالموزعينToolStripMenuItem.Click += new System.EventHandler(this.بياناتالموزعينToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(776, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.mnu_MainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnu_MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج المخازن";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnu_MainMenu.ResumeLayout(false);
            this.mnu_MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_BasicData;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Customers;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Administration;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_UserGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Products;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_ProductGroup;
        private System.Windows.Forms.ToolStripMenuItem بياناتالموزعينToolStripMenuItem;
    }
}