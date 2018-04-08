namespace _SIC
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
            this.components = new System.ComponentModel.Container();
            this.grbOrdersList = new System.Windows.Forms.GroupBox();
            this.dgvOrdersList = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aisleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCustomerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sICDbDataSet6 = new _SIC.SICDbDataSet6();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sICDbDataSet1 = new _SIC.SICDbDataSet1();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.grbOrderRelease = new System.Windows.Forms.GroupBox();
            this.lblOtherType = new System.Windows.Forms.Label();
            this.rtxtOther = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
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
            this.ordersTableAdapter = new _SIC.SICDbDataSet1TableAdapters.OrdersTableAdapter();
            this.ordersTableAdapter1 = new _SIC.SICDbDataSet6TableAdapters.OrdersTableAdapter();
            this.grbOrdersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet1)).BeginInit();
            this.grbOrderRelease.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOrdersList
            // 
            this.grbOrdersList.Controls.Add(this.dgvOrdersList);
            this.grbOrdersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOrdersList.Location = new System.Drawing.Point(12, 12);
            this.grbOrdersList.Name = "grbOrdersList";
            this.grbOrdersList.Size = new System.Drawing.Size(733, 221);
            this.grbOrdersList.TabIndex = 22;
            this.grbOrdersList.TabStop = false;
            this.grbOrdersList.Text = "Orders List";
            this.grbOrdersList.Enter += new System.EventHandler(this.grbOrdersList_Enter);
            // 
            // dgvOrdersList
            // 
            this.dgvOrdersList.AutoGenerateColumns = false;
            this.dgvOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.specificationDataGridViewTextBoxColumn,
            this.warehouseDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.aisleDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.shelfDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.customerCustomerIdDataGridViewTextBoxColumn});
            this.dgvOrdersList.DataSource = this.ordersBindingSource1;
            this.dgvOrdersList.Location = new System.Drawing.Point(6, 19);
            this.dgvOrdersList.Name = "dgvOrdersList";
            this.dgvOrdersList.Size = new System.Drawing.Size(714, 191);
            this.dgvOrdersList.TabIndex = 20;
            this.dgvOrdersList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdersList_CellContentClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // specificationDataGridViewTextBoxColumn
            // 
            this.specificationDataGridViewTextBoxColumn.DataPropertyName = "Specification";
            this.specificationDataGridViewTextBoxColumn.HeaderText = "Specification";
            this.specificationDataGridViewTextBoxColumn.Name = "specificationDataGridViewTextBoxColumn";
            // 
            // warehouseDataGridViewTextBoxColumn
            // 
            this.warehouseDataGridViewTextBoxColumn.DataPropertyName = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.HeaderText = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.Name = "warehouseDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // aisleDataGridViewTextBoxColumn
            // 
            this.aisleDataGridViewTextBoxColumn.DataPropertyName = "Aisle";
            this.aisleDataGridViewTextBoxColumn.HeaderText = "Aisle";
            this.aisleDataGridViewTextBoxColumn.Name = "aisleDataGridViewTextBoxColumn";
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "Shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "Shelf";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // customerCustomerIdDataGridViewTextBoxColumn
            // 
            this.customerCustomerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerCustomerId";
            this.customerCustomerIdDataGridViewTextBoxColumn.HeaderText = "CustomerCustomerId";
            this.customerCustomerIdDataGridViewTextBoxColumn.Name = "customerCustomerIdDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.sICDbDataSet6;
            // 
            // sICDbDataSet6
            // 
            this.sICDbDataSet6.DataSetName = "SICDbDataSet6";
            this.sICDbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.sICDbDataSet1;
            // 
            // sICDbDataSet1
            // 
            this.sICDbDataSet1.DataSetName = "SICDbDataSet1";
            this.sICDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.cmbShelf.Location = new System.Drawing.Point(330, 179);
            this.cmbShelf.Name = "cmbShelf";
            this.cmbShelf.Size = new System.Drawing.Size(48, 23);
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
            "Electronics",
            "Files",
            "Moving House",
            "High Value",
            "Personal",
            "Other"});
            this.cmbProductType.Location = new System.Drawing.Point(126, 183);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(149, 23);
            this.cmbProductType.TabIndex = 42;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(15, 184);
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
            this.cmbAisle.Location = new System.Drawing.Point(369, 153);
            this.cmbAisle.Name = "cmbAisle";
            this.cmbAisle.Size = new System.Drawing.Size(59, 23);
            this.cmbAisle.TabIndex = 40;
            // 
            // lblAisle
            // 
            this.lblAisle.AutoSize = true;
            this.lblAisle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAisle.Location = new System.Drawing.Point(314, 153);
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
            this.cmbRoom.Location = new System.Drawing.Point(246, 153);
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
            this.cmbWarehouse.Location = new System.Drawing.Point(126, 152);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(59, 23);
            this.cmbWarehouse.TabIndex = 37;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouse.Location = new System.Drawing.Point(15, 153);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(87, 16);
            this.lblWarehouse.TabIndex = 35;
            this.lblWarehouse.Text = "Warehouse";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(454, 179);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(34, 21);
            this.txtQuantity.TabIndex = 34;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(384, 183);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblQuantity.TabIndex = 33;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(401, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 30);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grbOrderRelease
            // 
            this.grbOrderRelease.Controls.Add(this.lblOtherType);
            this.grbOrderRelease.Controls.Add(this.rtxtOther);
            this.grbOrderRelease.Controls.Add(this.btnReset);
            this.grbOrderRelease.Controls.Add(this.btnSearch);
            this.grbOrderRelease.Controls.Add(this.txtSearch);
            this.grbOrderRelease.Controls.Add(this.lblSearch);
            this.grbOrderRelease.Controls.Add(this.cmbCurrency);
            this.grbOrderRelease.Controls.Add(this.txtOrderId);
            this.grbOrderRelease.Controls.Add(this.lblOrderId);
            this.grbOrderRelease.Controls.Add(this.btnDelete);
            this.grbOrderRelease.Controls.Add(this.btnClear);
            this.grbOrderRelease.Controls.Add(this.btnClose);
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
            this.grbOrderRelease.Size = new System.Drawing.Size(733, 387);
            this.grbOrderRelease.TabIndex = 31;
            this.grbOrderRelease.TabStop = false;
            this.grbOrderRelease.Text = "Order Release";
            // 
            // lblOtherType
            // 
            this.lblOtherType.AutoSize = true;
            this.lblOtherType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherType.Location = new System.Drawing.Point(15, 218);
            this.lblOtherType.Name = "lblOtherType";
            this.lblOtherType.Size = new System.Drawing.Size(178, 16);
            this.lblOtherType.TabIndex = 60;
            this.lblOtherType.Text = "Description (Other Type)";
            this.lblOtherType.Visible = false;
            // 
            // rtxtOther
            // 
            this.rtxtOther.Location = new System.Drawing.Point(18, 238);
            this.rtxtOther.Name = "rtxtOther";
            this.rtxtOther.Size = new System.Drawing.Size(332, 70);
            this.rtxtOther.TabIndex = 59;
            this.rtxtOther.Text = "";
            this.rtxtOther.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::_SIC.Properties.Resources.ic_update;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Location = new System.Drawing.Point(451, 29);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(22, 22);
            this.btnReset.TabIndex = 58;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::_SIC.Properties.Resources.ic_search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(423, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(22, 22);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(317, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 21);
            this.txtSearch.TabIndex = 54;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(196, 33);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 16);
            this.lblSearch.TabIndex = 53;
            this.lblSearch.Text = "Search Order";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Items.AddRange(new object[] {
            "CAD$",
            "US$",
            "R$"});
            this.cmbCurrency.Location = new System.Drawing.Point(312, 118);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(66, 23);
            this.cmbCurrency.TabIndex = 52;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(87, 31);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(59, 21);
            this.txtOrderId.TabIndex = 51;
            this.txtOrderId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(15, 33);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(66, 16);
            this.lblOrderId.TabIndex = 50;
            this.lblOrderId.Text = "Order ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(228, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 30);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(316, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 30);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(126, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 30);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(317, 60);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(154, 21);
            this.txtCustomerName.TabIndex = 48;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(196, 63);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(118, 16);
            this.lblCustomerName.TabIndex = 47;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(126, 59);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(59, 21);
            this.txtCustomerId.TabIndex = 46;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(15, 63);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(92, 16);
            this.lblCustomerId.TabIndex = 45;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // lblShelf
            // 
            this.lblShelf.AutoSize = true;
            this.lblShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShelf.Location = new System.Drawing.Point(281, 184);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(43, 16);
            this.lblShelf.TabIndex = 43;
            this.lblShelf.Text = "Shelf";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(191, 153);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(49, 16);
            this.lblRoom.TabIndex = 36;
            this.lblRoom.Text = "Room";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(399, 117);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(72, 21);
            this.txtPrice.TabIndex = 32;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(262, 121);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 16);
            this.lblPrice.TabIndex = 31;
            this.lblPrice.Text = "Price";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(317, 86);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(154, 21);
            this.txtBrand.TabIndex = 30;
            // 
            // txtSpecification
            // 
            this.txtSpecification.Location = new System.Drawing.Point(126, 117);
            this.txtSpecification.Name = "txtSpecification";
            this.txtSpecification.Size = new System.Drawing.Size(130, 21);
            this.txtSpecification.TabIndex = 29;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(15, 90);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(106, 16);
            this.lblProductName.TabIndex = 26;
            this.lblProductName.Text = "Product Name";
            // 
            // lblSpecification
            // 
            this.lblSpecification.AutoSize = true;
            this.lblSpecification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecification.Location = new System.Drawing.Point(15, 121);
            this.lblSpecification.Name = "lblSpecification";
            this.lblSpecification.Size = new System.Drawing.Size(98, 16);
            this.lblSpecification.TabIndex = 28;
            this.lblSpecification.Text = "Specification";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(262, 90);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(49, 16);
            this.lblBrand.TabIndex = 20;
            this.lblBrand.Text = "Brand";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(126, 86);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(130, 21);
            this.txtProductName.TabIndex = 27;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // ManagerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 670);
            this.Controls.Add(this.grbOrderRelease);
            this.Controls.Add(this.grbOrdersList);
            this.MaximizeBox = false;
            this.Name = "ManagerOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerOrders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerOrders_Load);
            this.grbOrdersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet1)).EndInit();
            this.grbOrderRelease.ResumeLayout(false);
            this.grbOrderRelease.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOrdersList;
        private System.Windows.Forms.DataGridView dgvOrdersList;
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
        private System.Windows.Forms.Button btnClose;
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
        private SICDbDataSet1 sICDbDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private SICDbDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private SICDbDataSet6 sICDbDataSet6;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private SICDbDataSet6TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aisleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCustomerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblOtherType;
        private System.Windows.Forms.RichTextBox rtxtOther;
    }
}