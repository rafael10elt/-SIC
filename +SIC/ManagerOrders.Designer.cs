﻿namespace _SIC
{
    partial class ManagerOrders
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
            this.grbOrdersList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbShelf = new System.Windows.Forms.ComboBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.cmbAisle = new System.Windows.Forms.ComboBox();
            this.lblAisle = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbOrderRelease = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblShelf = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtSpecification = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSpecification = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grbOrdersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbOrderRelease.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOrdersList
            // 
            this.grbOrdersList.Controls.Add(this.dataGridView1);
            this.grbOrdersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOrdersList.Location = new System.Drawing.Point(12, 12);
            this.grbOrdersList.Name = "grbOrdersList";
            this.grbOrdersList.Size = new System.Drawing.Size(733, 221);
            this.grbOrdersList.TabIndex = 22;
            this.grbOrdersList.TabStop = false;
            this.grbOrdersList.Text = "Orders List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 191);
            this.dataGridView1.TabIndex = 20;
            // 
            // cmbShelf
            // 
            this.cmbShelf.FormattingEnabled = true;
            this.cmbShelf.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbShelf.Location = new System.Drawing.Point(246, 154);
            this.cmbShelf.Name = "cmbShelf";
            this.cmbShelf.Size = new System.Drawing.Size(59, 23);
            this.cmbShelf.TabIndex = 44;
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Items.AddRange(new object[] {
            "Food",
            "Construction",
            "Chemicals",
            "Furniture",
            "Files",
            "Moving House",
            "High Value",
            "Personal",
            "Others  "});
            this.cmbProductType.Location = new System.Drawing.Point(126, 153);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(59, 23);
            this.cmbProductType.TabIndex = 42;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(15, 154);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(101, 16);
            this.lblProductType.TabIndex = 41;
            this.lblProductType.Text = "Product Type";
            // 
            // cmbAisle
            // 
            this.cmbAisle.FormattingEnabled = true;
            this.cmbAisle.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P"});
            this.cmbAisle.Location = new System.Drawing.Point(369, 123);
            this.cmbAisle.Name = "cmbAisle";
            this.cmbAisle.Size = new System.Drawing.Size(59, 23);
            this.cmbAisle.TabIndex = 40;
            // 
            // lblAisle
            // 
            this.lblAisle.AutoSize = true;
            this.lblAisle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAisle.Location = new System.Drawing.Point(314, 123);
            this.lblAisle.Name = "lblAisle";
            this.lblAisle.Size = new System.Drawing.Size(43, 16);
            this.lblAisle.TabIndex = 39;
            this.lblAisle.Text = "Aisle";
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cmbRoom.Location = new System.Drawing.Point(246, 123);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(59, 23);
            this.cmbRoom.TabIndex = 38;
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cmbWarehouse.Location = new System.Drawing.Point(126, 122);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(59, 23);
            this.cmbWarehouse.TabIndex = 37;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouse.Location = new System.Drawing.Point(15, 123);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(87, 16);
            this.lblWarehouse.TabIndex = 35;
            this.lblWarehouse.Text = "Warehouse";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(384, 154);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(64, 21);
            this.txtQuantity.TabIndex = 34;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(314, 158);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblQuantity.TabIndex = 33;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(401, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 30);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grbOrderRelease
            // 
            this.grbOrderRelease.Controls.Add(this.btnDelete);
            this.grbOrderRelease.Controls.Add(this.btnClear);
            this.grbOrderRelease.Controls.Add(this.btnCancel);
            this.grbOrderRelease.Controls.Add(this.btnUpdate);
            this.grbOrderRelease.Controls.Add(this.txtCustomerName);
            this.grbOrderRelease.Controls.Add(this.lblCustomerName);
            this.grbOrderRelease.Controls.Add(this.txtCustomerId);
            this.grbOrderRelease.Controls.Add(this.lblCustomerId);
            this.grbOrderRelease.Controls.Add(this.cmbShelf);
            this.grbOrderRelease.Controls.Add(this.lblShelf);
            this.grbOrderRelease.Controls.Add(this.cmbProductType);
            this.grbOrderRelease.Controls.Add(this.lblProductType);
            this.grbOrderRelease.Controls.Add(this.cmbAisle);
            this.grbOrderRelease.Controls.Add(this.lblAisle);
            this.grbOrderRelease.Controls.Add(this.cmbRoom);
            this.grbOrderRelease.Controls.Add(this.cmbWarehouse);
            this.grbOrderRelease.Controls.Add(this.lblRoom);
            this.grbOrderRelease.Controls.Add(this.lblWarehouse);
            this.grbOrderRelease.Controls.Add(this.txtQuantity);
            this.grbOrderRelease.Controls.Add(this.lblQuantity);
            this.grbOrderRelease.Controls.Add(this.txtPrice);
            this.grbOrderRelease.Controls.Add(this.lblPrice);
            this.grbOrderRelease.Controls.Add(this.txtBrand);
            this.grbOrderRelease.Controls.Add(this.txtSpecification);
            this.grbOrderRelease.Controls.Add(this.lblProductName);
            this.grbOrderRelease.Controls.Add(this.lblSpecification);
            this.grbOrderRelease.Controls.Add(this.lblBrand);
            this.grbOrderRelease.Controls.Add(this.txtProductName);
            this.grbOrderRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOrderRelease.Location = new System.Drawing.Point(12, 255);
            this.grbOrderRelease.Name = "grbOrderRelease";
            this.grbOrderRelease.Size = new System.Drawing.Size(733, 265);
            this.grbOrderRelease.TabIndex = 31;
            this.grbOrderRelease.TabStop = false;
            this.grbOrderRelease.Text = "Order Release";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(317, 30);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(154, 21);
            this.txtCustomerName.TabIndex = 48;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(196, 33);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(118, 16);
            this.lblCustomerName.TabIndex = 47;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(126, 29);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(59, 21);
            this.txtCustomerId.TabIndex = 46;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(15, 33);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(92, 16);
            this.lblCustomerId.TabIndex = 45;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // lblShelf
            // 
            this.lblShelf.AutoSize = true;
            this.lblShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShelf.Location = new System.Drawing.Point(191, 154);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(43, 16);
            this.lblShelf.TabIndex = 43;
            this.lblShelf.Text = "Shelf";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(191, 123);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(49, 16);
            this.lblRoom.TabIndex = 36;
            this.lblRoom.Text = "Room";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(317, 87);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(72, 21);
            this.txtPrice.TabIndex = 32;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(262, 91);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 16);
            this.lblPrice.TabIndex = 31;
            this.lblPrice.Text = "Price";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(317, 56);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(154, 21);
            this.txtBrand.TabIndex = 30;
            // 
            // txtSpecification
            // 
            this.txtSpecification.Location = new System.Drawing.Point(126, 87);
            this.txtSpecification.Name = "txtSpecification";
            this.txtSpecification.Size = new System.Drawing.Size(130, 21);
            this.txtSpecification.TabIndex = 29;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(15, 60);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(106, 16);
            this.lblProductName.TabIndex = 26;
            this.lblProductName.Text = "Product Name";
            // 
            // lblSpecification
            // 
            this.lblSpecification.AutoSize = true;
            this.lblSpecification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecification.Location = new System.Drawing.Point(15, 91);
            this.lblSpecification.Name = "lblSpecification";
            this.lblSpecification.Size = new System.Drawing.Size(98, 16);
            this.lblSpecification.TabIndex = 28;
            this.lblSpecification.Text = "Specification";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(262, 60);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(49, 16);
            this.lblBrand.TabIndex = 20;
            this.lblBrand.Text = "Brand";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(126, 56);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(130, 21);
            this.txtProductName.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(316, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 30);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(228, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 30);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(126, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 30);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // ManagerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 563);
            this.Controls.Add(this.grbOrderRelease);
            this.Controls.Add(this.grbOrdersList);
            this.Name = "ManagerOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerOrders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbOrdersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbOrderRelease.ResumeLayout(false);
            this.grbOrderRelease.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOrdersList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbShelf;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbAisle;
        private System.Windows.Forms.Label lblAisle;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbOrderRelease;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblShelf;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtSpecification;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblSpecification;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}