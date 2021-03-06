﻿namespace POS.UserInterfaceLayer.Purcase
{
    partial class frmPurchaseOrderAddEdit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgrd_OrderLines = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsAcceptBatch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_Inventory = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.num_OtherPayments = new System.Windows.Forms.TextBox();
            this.num_Remaining = new System.Windows.Forms.TextBox();
            this.num_Paied = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_ClosePrint = new System.Windows.Forms.Button();
            this.lbl_paymentType = new System.Windows.Forms.Label();
            this.dtb_LastTimeToPay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_TaxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_FormHeader = new System.Windows.Forms.Label();
            this.grb_lineData = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_AfterDescount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_DiscountAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_AddLine = new System.Windows.Forms.Button();
            this.btn_DeleteLine = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_PaymentType = new System.Windows.Forms.ComboBox();
            this.cbx_Supplier = new System.Windows.Forms.ComboBox();
            this.panl_Header = new System.Windows.Forms.Panel();
            this.dtb_Date = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.btn_Print = new System.Windows.Forms.Button();
            this.pnl_headerData = new System.Windows.Forms.Panel();
            this.txt_chequeNumber = new System.Windows.Forms.TextBox();
            this.txt_invoiceNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_OrderLines)).BeginInit();
            this.grb_lineData.SuspendLayout();
            this.panl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.pnl_headerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrd_OrderLines
            // 
            this.dgrd_OrderLines.AllowUserToAddRows = false;
            this.dgrd_OrderLines.AllowUserToDeleteRows = false;
            this.dgrd_OrderLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgrd_OrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_OrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.IsAcceptBatch,
            this.TotalQty,
            this.PurchasePrice,
            this.BatchNumber,
            this.ExpiryDate});
            this.dgrd_OrderLines.Location = new System.Drawing.Point(6, 54);
            this.dgrd_OrderLines.Name = "dgrd_OrderLines";
            this.dgrd_OrderLines.RowHeadersVisible = false;
            this.dgrd_OrderLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgrd_OrderLines.Size = new System.Drawing.Size(741, 291);
            this.dgrd_OrderLines.TabIndex = 32;
            this.dgrd_OrderLines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrd_OrderLines_CellValueChanged);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "إسم المنتج";
            this.ProductName.Name = "ProductName";
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductName.Width = 250;
            // 
            // IsAcceptBatch
            // 
            this.IsAcceptBatch.HeaderText = "يقبل تشغيله";
            this.IsAcceptBatch.Name = "IsAcceptBatch";
            this.IsAcceptBatch.ReadOnly = true;
            this.IsAcceptBatch.Width = 50;
            // 
            // TotalQty
            // 
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.TotalQty.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalQty.HeaderText = "الكمية";
            this.TotalQty.Name = "TotalQty";
            this.TotalQty.Width = 60;
            // 
            // PurchasePrice
            // 
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.PurchasePrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.PurchasePrice.HeaderText = "سعر الشراء";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Width = 60;
            // 
            // BatchNumber
            // 
            this.BatchNumber.HeaderText = "رقم التشغيله";
            this.BatchNumber.Name = "BatchNumber";
            // 
            // ExpiryDate
            // 
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.ExpiryDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.ExpiryDate.HeaderText = "تاريخ الصلاحيه";
            this.ExpiryDate.Name = "ExpiryDate";
            // 
            // cbx_Inventory
            // 
            this.cbx_Inventory.FormattingEnabled = true;
            this.cbx_Inventory.Location = new System.Drawing.Point(144, 4);
            this.cbx_Inventory.Name = "cbx_Inventory";
            this.cbx_Inventory.Size = new System.Drawing.Size(241, 21);
            this.cbx_Inventory.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "المخزن";
            // 
            // num_OtherPayments
            // 
            this.num_OtherPayments.Location = new System.Drawing.Point(453, 151);
            this.num_OtherPayments.Name = "num_OtherPayments";
            this.num_OtherPayments.Size = new System.Drawing.Size(78, 20);
            this.num_OtherPayments.TabIndex = 46;
            this.num_OtherPayments.Text = "0";
            // 
            // num_Remaining
            // 
            this.num_Remaining.Location = new System.Drawing.Point(259, 122);
            this.num_Remaining.Name = "num_Remaining";
            this.num_Remaining.ReadOnly = true;
            this.num_Remaining.Size = new System.Drawing.Size(82, 20);
            this.num_Remaining.TabIndex = 45;
            this.num_Remaining.Text = "0";
            // 
            // num_Paied
            // 
            this.num_Paied.Location = new System.Drawing.Point(98, 121);
            this.num_Paied.Name = "num_Paied";
            this.num_Paied.Size = new System.Drawing.Size(80, 20);
            this.num_Paied.TabIndex = 44;
            this.num_Paied.Text = "0";
            this.num_Paied.TextChanged += new System.EventHandler(this.num_Paied_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "خدمات أخرى";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(249, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(99, 55);
            this.btn_Cancel.TabIndex = 42;
            this.btn_Cancel.Text = "ألغاء";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(552, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 55);
            this.btn_Save.TabIndex = 41;
            this.btn_Save.Text = "حفظ فقط";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_ClosePrint
            // 
            this.btn_ClosePrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ClosePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClosePrint.Location = new System.Drawing.Point(448, 3);
            this.btn_ClosePrint.Name = "btn_ClosePrint";
            this.btn_ClosePrint.Size = new System.Drawing.Size(99, 55);
            this.btn_ClosePrint.TabIndex = 40;
            this.btn_ClosePrint.Text = "حفظ و إغلاق";
            this.btn_ClosePrint.UseVisualStyleBackColor = true;
            this.btn_ClosePrint.Click += new System.EventHandler(this.btn_ClosePrint_Click);
            // 
            // lbl_paymentType
            // 
            this.lbl_paymentType.AutoSize = true;
            this.lbl_paymentType.Location = new System.Drawing.Point(211, 70);
            this.lbl_paymentType.Name = "lbl_paymentType";
            this.lbl_paymentType.Size = new System.Drawing.Size(78, 13);
            this.lbl_paymentType.TabIndex = 36;
            this.lbl_paymentType.Text = "أخر ميعاد للدفع";
            // 
            // dtb_LastTimeToPay
            // 
            this.dtb_LastTimeToPay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_LastTimeToPay.Location = new System.Drawing.Point(118, 66);
            this.dtb_LastTimeToPay.Name = "dtb_LastTimeToPay";
            this.dtb_LastTimeToPay.RightToLeftLayout = true;
            this.dtb_LastTimeToPay.Size = new System.Drawing.Size(78, 20);
            this.dtb_LastTimeToPay.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "المتبقى";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "المدفوع";
            // 
            // cbx_TaxType
            // 
            this.cbx_TaxType.FormattingEnabled = true;
            this.cbx_TaxType.Location = new System.Drawing.Point(97, 151);
            this.cbx_TaxType.Name = "cbx_TaxType";
            this.cbx_TaxType.Size = new System.Drawing.Size(241, 21);
            this.cbx_TaxType.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(758, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "أسم المورد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "طريقة الدفع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "التاريخ";
            // 
            // lbl_FormHeader
            // 
            this.lbl_FormHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FormHeader.AutoSize = true;
            this.lbl_FormHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormHeader.Location = new System.Drawing.Point(410, 20);
            this.lbl_FormHeader.Name = "lbl_FormHeader";
            this.lbl_FormHeader.Size = new System.Drawing.Size(105, 19);
            this.lbl_FormHeader.TabIndex = 0;
            this.lbl_FormHeader.Text = "فاتورة شراء جديده";
            // 
            // grb_lineData
            // 
            this.grb_lineData.Controls.Add(this.label13);
            this.grb_lineData.Controls.Add(this.txt_AfterDescount);
            this.grb_lineData.Controls.Add(this.label9);
            this.grb_lineData.Controls.Add(this.label10);
            this.grb_lineData.Controls.Add(this.txt_Total);
            this.grb_lineData.Controls.Add(this.txt_DiscountAmount);
            this.grb_lineData.Controls.Add(this.label8);
            this.grb_lineData.Controls.Add(this.btn_AddLine);
            this.grb_lineData.Controls.Add(this.btn_DeleteLine);
            this.grb_lineData.Controls.Add(this.btn_Plus);
            this.grb_lineData.Controls.Add(this.dgrd_OrderLines);
            this.grb_lineData.Location = new System.Drawing.Point(12, 188);
            this.grb_lineData.Name = "grb_lineData";
            this.grb_lineData.Size = new System.Drawing.Size(828, 377);
            this.grb_lineData.TabIndex = 39;
            this.grb_lineData.TabStop = false;
            this.grb_lineData.Text = "بيانات الفاتورة";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(316, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "%";
            // 
            // txt_AfterDescount
            // 
            this.txt_AfterDescount.Location = new System.Drawing.Point(118, 351);
            this.txt_AfterDescount.Name = "txt_AfterDescount";
            this.txt_AfterDescount.ReadOnly = true;
            this.txt_AfterDescount.Size = new System.Drawing.Size(100, 20);
            this.txt_AfterDescount.TabIndex = 44;
            this.txt_AfterDescount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "بعد الخصم";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "الخصم على الفاتورة";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(531, 351);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(100, 20);
            this.txt_Total.TabIndex = 41;
            this.txt_Total.Text = "0";
            this.txt_Total.TextChanged += new System.EventHandler(this.txt_Total_TextChanged);
            // 
            // txt_DiscountAmount
            // 
            this.txt_DiscountAmount.Location = new System.Drawing.Point(337, 351);
            this.txt_DiscountAmount.Name = "txt_DiscountAmount";
            this.txt_DiscountAmount.Size = new System.Drawing.Size(73, 20);
            this.txt_DiscountAmount.TabIndex = 40;
            this.txt_DiscountAmount.Text = "0";
            this.txt_DiscountAmount.TextChanged += new System.EventHandler(this.txt_Total_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(638, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "المبلغ الإجمالي";
            // 
            // btn_AddLine
            // 
            this.btn_AddLine.Location = new System.Drawing.Point(661, 13);
            this.btn_AddLine.Name = "btn_AddLine";
            this.btn_AddLine.Size = new System.Drawing.Size(75, 35);
            this.btn_AddLine.TabIndex = 36;
            this.btn_AddLine.Text = "أضافة";
            this.btn_AddLine.UseVisualStyleBackColor = true;
            this.btn_AddLine.Click += new System.EventHandler(this.btn_AddLine_Click);
            // 
            // btn_DeleteLine
            // 
            this.btn_DeleteLine.Location = new System.Drawing.Point(580, 13);
            this.btn_DeleteLine.Name = "btn_DeleteLine";
            this.btn_DeleteLine.Size = new System.Drawing.Size(75, 35);
            this.btn_DeleteLine.TabIndex = 35;
            this.btn_DeleteLine.Text = "حذف";
            this.btn_DeleteLine.UseVisualStyleBackColor = true;
            this.btn_DeleteLine.Click += new System.EventHandler(this.btn_DeleteLine_Click);
            // 
            // btn_Plus
            // 
            this.btn_Plus.Location = new System.Drawing.Point(758, 77);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(64, 56);
            this.btn_Plus.TabIndex = 33;
            this.btn_Plus.Text = "إضافه تشغيله";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "الضريبة";
            // 
            // cbx_PaymentType
            // 
            this.cbx_PaymentType.FormattingEnabled = true;
            this.cbx_PaymentType.Location = new System.Drawing.Point(295, 67);
            this.cbx_PaymentType.Name = "cbx_PaymentType";
            this.cbx_PaymentType.Size = new System.Drawing.Size(89, 21);
            this.cbx_PaymentType.TabIndex = 33;
            this.cbx_PaymentType.SelectedIndexChanged += new System.EventHandler(this.cbx_PaymentType_SelectedIndexChanged);
            // 
            // cbx_Supplier
            // 
            this.cbx_Supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_Supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Supplier.FormattingEnabled = true;
            this.cbx_Supplier.Location = new System.Drawing.Point(98, 93);
            this.cbx_Supplier.Name = "cbx_Supplier";
            this.cbx_Supplier.Size = new System.Drawing.Size(241, 21);
            this.cbx_Supplier.TabIndex = 32;
            // 
            // panl_Header
            // 
            this.panl_Header.BackColor = System.Drawing.Color.MintCream;
            this.panl_Header.Controls.Add(this.lbl_FormHeader);
            this.panl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl_Header.Location = new System.Drawing.Point(0, 0);
            this.panl_Header.Name = "panl_Header";
            this.panl_Header.Size = new System.Drawing.Size(852, 53);
            this.panl_Header.TabIndex = 31;
            // 
            // dtb_Date
            // 
            this.dtb_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtb_Date.Location = new System.Drawing.Point(98, 64);
            this.dtb_Date.Name = "dtb_Date";
            this.dtb_Date.RightToLeftLayout = true;
            this.dtb_Date.Size = new System.Drawing.Size(243, 20);
            this.dtb_Date.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnl_footer
            // 
            this.pnl_footer.Controls.Add(this.btn_Print);
            this.pnl_footer.Controls.Add(this.btn_Cancel);
            this.pnl_footer.Controls.Add(this.btn_Save);
            this.pnl_footer.Controls.Add(this.btn_ClosePrint);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 573);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(852, 67);
            this.pnl_footer.TabIndex = 49;
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(349, 3);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(99, 55);
            this.btn_Print.TabIndex = 43;
            this.btn_Print.Text = "طباعه";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Visible = false;
            // 
            // pnl_headerData
            // 
            this.pnl_headerData.Controls.Add(this.dtb_LastTimeToPay);
            this.pnl_headerData.Controls.Add(this.txt_chequeNumber);
            this.pnl_headerData.Controls.Add(this.lbl_paymentType);
            this.pnl_headerData.Controls.Add(this.txt_invoiceNumber);
            this.pnl_headerData.Controls.Add(this.label14);
            this.pnl_headerData.Controls.Add(this.cbx_Inventory);
            this.pnl_headerData.Controls.Add(this.label7);
            this.pnl_headerData.Controls.Add(this.label4);
            this.pnl_headerData.Controls.Add(this.label3);
            this.pnl_headerData.Controls.Add(this.label1);
            this.pnl_headerData.Controls.Add(this.cbx_PaymentType);
            this.pnl_headerData.Controls.Add(this.label2);
            this.pnl_headerData.Location = new System.Drawing.Point(13, 56);
            this.pnl_headerData.Name = "pnl_headerData";
            this.pnl_headerData.Size = new System.Drawing.Size(827, 128);
            this.pnl_headerData.TabIndex = 50;
            // 
            // txt_chequeNumber
            // 
            this.txt_chequeNumber.Location = new System.Drawing.Point(96, 70);
            this.txt_chequeNumber.Name = "txt_chequeNumber";
            this.txt_chequeNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_chequeNumber.TabIndex = 38;
            // 
            // txt_invoiceNumber
            // 
            this.txt_invoiceNumber.Location = new System.Drawing.Point(144, 37);
            this.txt_invoiceNumber.Name = "txt_invoiceNumber";
            this.txt_invoiceNumber.Size = new System.Drawing.Size(241, 20);
            this.txt_invoiceNumber.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(411, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "رقم الفاتوره";
            // 
            // frmPurchaseOrderAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(852, 640);
            this.Controls.Add(this.dtb_Date);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.num_OtherPayments);
            this.Controls.Add(this.num_Remaining);
            this.Controls.Add(this.num_Paied);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_TaxType);
            this.Controls.Add(this.grb_lineData);
            this.Controls.Add(this.cbx_Supplier);
            this.Controls.Add(this.panl_Header);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_headerData);
            this.Name = "frmPurchaseOrderAddEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إضافه فاتوره";
            this.Load += new System.EventHandler(this.frmPurchaseOrderAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_OrderLines)).EndInit();
            this.grb_lineData.ResumeLayout(false);
            this.grb_lineData.PerformLayout();
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_headerData.ResumeLayout(false);
            this.pnl_headerData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Inventory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox num_OtherPayments;
        private System.Windows.Forms.TextBox num_Remaining;
        private System.Windows.Forms.TextBox num_Paied;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_ClosePrint;
        private System.Windows.Forms.Label lbl_paymentType;
        private System.Windows.Forms.DateTimePicker dtb_LastTimeToPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_TaxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label lbl_FormHeader;
        private System.Windows.Forms.GroupBox grb_lineData;
        private System.Windows.Forms.Button btn_AddLine;
        private System.Windows.Forms.Button btn_DeleteLine;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_PaymentType;
        private System.Windows.Forms.ComboBox cbx_Supplier;
        protected System.Windows.Forms.Panel panl_Header;
        private System.Windows.Forms.DateTimePicker dtb_Date;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgrd_OrderLines;
        private System.Windows.Forms.TextBox txt_AfterDescount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_DiscountAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAcceptBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Panel pnl_headerData;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_invoiceNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_chequeNumber;
    }
}