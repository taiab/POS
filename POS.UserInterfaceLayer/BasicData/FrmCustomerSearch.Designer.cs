﻿namespace POS.UserInterfaceLayer.BasicData
{
    partial class FrmCustomerSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tbx_cusomerName = new System.Windows.Forms.TextBox();
            this.tbx_customerCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panl_Header.SuspendLayout();
            this.panl_Footer.SuspendLayout();
            this.grb_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panl_Header
            // 
            this.panl_Header.Size = new System.Drawing.Size(635, 53);
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Location = new System.Drawing.Point(277, 20);
            this.lbl_FormHeader.Size = new System.Drawing.Size(73, 19);
            this.lbl_FormHeader.Text = "بحث العملاء";
            // 
            // panl_Footer
            // 
            this.panl_Footer.Location = new System.Drawing.Point(0, 390);
            this.panl_Footer.Size = new System.Drawing.Size(635, 62);
            // 
            // groupBox2
            // 
            this.grb_search.Controls.Add(this.button1);
            this.grb_search.Controls.Add(this.btn_Search);
            this.grb_search.Controls.Add(this.label1);
            this.grb_search.Controls.Add(this.tbx_cusomerName);
            this.grb_search.Controls.Add(this.label2);
            this.grb_search.Controls.Add(this.tbx_customerCode);
            this.grb_search.Location = new System.Drawing.Point(0, 53);
            this.grb_search.Size = new System.Drawing.Size(635, 82);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(430, 2);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(115, 2);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(325, 2);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(220, 2);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "كود العميل";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(6, 15);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 29);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "بحث";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tbx_cusomerName
            // 
            this.tbx_cusomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_cusomerName.Location = new System.Drawing.Point(353, 47);
            this.tbx_cusomerName.Name = "tbx_cusomerName";
            this.tbx_cusomerName.Size = new System.Drawing.Size(184, 22);
            this.tbx_cusomerName.TabIndex = 9;
            // 
            // tbx_customerCode
            // 
            this.tbx_customerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_customerCode.Location = new System.Drawing.Point(353, 18);
            this.tbx_customerCode.Name = "tbx_customerCode";
            this.tbx_customerCode.Size = new System.Drawing.Size(184, 22);
            this.tbx_customerCode.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "إسم العميل";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "تعديل حساب";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(635, 452);
            this.Name = "FrmCustomerSearch";
            this.Text = "العملاء";
            this.Load += new System.EventHandler(this.FrmCustomerSearch_Load);
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.panl_Footer.ResumeLayout(false);
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tbx_cusomerName;
        private System.Windows.Forms.TextBox tbx_customerCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

    }
}
