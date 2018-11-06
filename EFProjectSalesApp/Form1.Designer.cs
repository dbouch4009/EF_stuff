namespace EFProjectSalesApp
{
    partial class Form1
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
            this.cbSalesPeople = new System.Windows.Forms.ComboBox();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSalesRegion = new System.Windows.Forms.ComboBox();
            this.salesRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedByUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTargetSales = new System.Windows.Forms.Button();
            this.btnTBRefresh = new System.Windows.Forms.Button();
            this.newSaleAmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.newSaleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newRegionComboBox = new System.Windows.Forms.ComboBox();
            this.newPersonComboBox = new System.Windows.Forms.ComboBox();
            this.newSaleButton = new System.Windows.Forms.Button();
            this.btnUpdateSale = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSaleReadID = new System.Windows.Forms.TextBox();
            this.cbIDUpdate = new System.Windows.Forms.ComboBox();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUpdateID = new System.Windows.Forms.TextBox();
            this.btnDeleteSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSaleAmountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSalesPeople
            // 
            this.cbSalesPeople.DataSource = this.salesPersonBindingSource;
            this.cbSalesPeople.DisplayMember = "LastName";
            this.cbSalesPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalesPeople.FormattingEnabled = true;
            this.cbSalesPeople.Location = new System.Drawing.Point(316, 40);
            this.cbSalesPeople.Name = "cbSalesPeople";
            this.cbSalesPeople.Size = new System.Drawing.Size(121, 21);
            this.cbSalesPeople.TabIndex = 0;
            this.cbSalesPeople.ValueMember = "id";
            this.cbSalesPeople.SelectedIndexChanged += new System.EventHandler(this.cbSalesPeople_SelectedIndexChanged);
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataSource = typeof(EFProjectSalesApp.Model_Entity.SalesPerson);
            // 
            // cbSalesRegion
            // 
            this.cbSalesRegion.DataSource = this.salesRegionBindingSource;
            this.cbSalesRegion.DisplayMember = "Name";
            this.cbSalesRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalesRegion.FormattingEnabled = true;
            this.cbSalesRegion.Location = new System.Drawing.Point(316, 109);
            this.cbSalesRegion.Name = "cbSalesRegion";
            this.cbSalesRegion.Size = new System.Drawing.Size(121, 21);
            this.cbSalesRegion.TabIndex = 1;
            this.cbSalesRegion.ValueMember = "id";
            // 
            // salesRegionBindingSource
            // 
            this.salesRegionBindingSource.DataSource = typeof(EFProjectSalesApp.Model_Entity.SalesRegion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sales Region";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(316, 161);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.personDataGridViewTextBoxColumn,
            this.personIdDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.UpdatedByUser});
            this.dataGridView1.DataSource = this.saleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 429);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            this.personIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UpdatedByUser
            // 
            this.UpdatedByUser.DataPropertyName = "UpdatedByUser";
            this.UpdatedByUser.HeaderText = "UpdatedByUser";
            this.UpdatedByUser.Name = "UpdatedByUser";
            this.UpdatedByUser.ReadOnly = true;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(EFProjectSalesApp.Model_Entity.Sale);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(70, 332);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 6;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(210, 332);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 20);
            this.tbDate.TabIndex = 7;
            // 
            // tbPerson
            // 
            this.tbPerson.Location = new System.Drawing.Point(337, 332);
            this.tbPerson.Name = "tbPerson";
            this.tbPerson.Size = new System.Drawing.Size(100, 20);
            this.tbPerson.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Person";
            // 
            // btnTargetSales
            // 
            this.btnTargetSales.Location = new System.Drawing.Point(316, 190);
            this.btnTargetSales.Name = "btnTargetSales";
            this.btnTargetSales.Size = new System.Drawing.Size(75, 46);
            this.btnTargetSales.TabIndex = 12;
            this.btnTargetSales.Text = "Target";
            this.btnTargetSales.UseVisualStyleBackColor = true;
            this.btnTargetSales.Click += new System.EventHandler(this.btnTargetSales_Click);
            // 
            // btnTBRefresh
            // 
            this.btnTBRefresh.Location = new System.Drawing.Point(316, 242);
            this.btnTBRefresh.Name = "btnTBRefresh";
            this.btnTBRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnTBRefresh.TabIndex = 13;
            this.btnTBRefresh.Text = "TB Refresh";
            this.btnTBRefresh.UseVisualStyleBackColor = true;
            this.btnTBRefresh.Click += new System.EventHandler(this.btnTBRefresh_Click);
            // 
            // newSaleAmountUpDown
            // 
            this.newSaleAmountUpDown.Location = new System.Drawing.Point(15, 41);
            this.newSaleAmountUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.newSaleAmountUpDown.Name = "newSaleAmountUpDown";
            this.newSaleAmountUpDown.Size = new System.Drawing.Size(120, 20);
            this.newSaleAmountUpDown.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "New & Update Sale";
            // 
            // newSaleDateTimePicker
            // 
            this.newSaleDateTimePicker.Location = new System.Drawing.Point(15, 83);
            this.newSaleDateTimePicker.Name = "newSaleDateTimePicker";
            this.newSaleDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newSaleDateTimePicker.TabIndex = 16;
            // 
            // newRegionComboBox
            // 
            this.newRegionComboBox.DataSource = this.salesRegionBindingSource;
            this.newRegionComboBox.DisplayMember = "Name";
            this.newRegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newRegionComboBox.FormattingEnabled = true;
            this.newRegionComboBox.Location = new System.Drawing.Point(15, 147);
            this.newRegionComboBox.Name = "newRegionComboBox";
            this.newRegionComboBox.Size = new System.Drawing.Size(182, 21);
            this.newRegionComboBox.TabIndex = 17;
            // 
            // newPersonComboBox
            // 
            this.newPersonComboBox.DataSource = this.salesPersonBindingSource;
            this.newPersonComboBox.DisplayMember = "FullName";
            this.newPersonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newPersonComboBox.FormattingEnabled = true;
            this.newPersonComboBox.Location = new System.Drawing.Point(15, 109);
            this.newPersonComboBox.Name = "newPersonComboBox";
            this.newPersonComboBox.Size = new System.Drawing.Size(182, 21);
            this.newPersonComboBox.TabIndex = 18;
            // 
            // newSaleButton
            // 
            this.newSaleButton.Location = new System.Drawing.Point(15, 174);
            this.newSaleButton.Name = "newSaleButton";
            this.newSaleButton.Size = new System.Drawing.Size(155, 23);
            this.newSaleButton.TabIndex = 19;
            this.newSaleButton.Text = "New Sale";
            this.newSaleButton.UseVisualStyleBackColor = true;
            this.newSaleButton.Click += new System.EventHandler(this.newSaleButton_Click);
            // 
            // btnUpdateSale
            // 
            this.btnUpdateSale.Location = new System.Drawing.Point(15, 204);
            this.btnUpdateSale.Name = "btnUpdateSale";
            this.btnUpdateSale.Size = new System.Drawing.Size(155, 23);
            this.btnUpdateSale.TabIndex = 20;
            this.btnUpdateSale.Text = "Update Sale";
            this.btnUpdateSale.UseVisualStyleBackColor = true;
            this.btnUpdateSale.Click += new System.EventHandler(this.btnUpdateSale_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "ID";
            // 
            // tbSaleReadID
            // 
            this.tbSaleReadID.Location = new System.Drawing.Point(70, 403);
            this.tbSaleReadID.Name = "tbSaleReadID";
            this.tbSaleReadID.Size = new System.Drawing.Size(100, 20);
            this.tbSaleReadID.TabIndex = 24;
            // 
            // cbIDUpdate
            // 
            this.cbIDUpdate.DataSource = this.salesBindingSource;
            this.cbIDUpdate.DisplayMember = "id";
            this.cbIDUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDUpdate.FormattingEnabled = true;
            this.cbIDUpdate.Location = new System.Drawing.Point(491, 41);
            this.cbIDUpdate.Name = "cbIDUpdate";
            this.cbIDUpdate.Size = new System.Drawing.Size(121, 21);
            this.cbIDUpdate.TabIndex = 25;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.salesPersonBindingSource;
            // 
            // tbUpdateID
            // 
            this.tbUpdateID.Location = new System.Drawing.Point(155, 40);
            this.tbUpdateID.Name = "tbUpdateID";
            this.tbUpdateID.Size = new System.Drawing.Size(100, 20);
            this.tbUpdateID.TabIndex = 26;
            // 
            // btnDeleteSale
            // 
            this.btnDeleteSale.Location = new System.Drawing.Point(15, 233);
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.Size = new System.Drawing.Size(155, 23);
            this.btnDeleteSale.TabIndex = 27;
            this.btnDeleteSale.Text = "Delete Sale";
            this.btnDeleteSale.UseVisualStyleBackColor = true;
            this.btnDeleteSale.Click += new System.EventHandler(this.btnDeleteSale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 616);
            this.Controls.Add(this.btnDeleteSale);
            this.Controls.Add(this.tbUpdateID);
            this.Controls.Add(this.cbIDUpdate);
            this.Controls.Add(this.tbSaleReadID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdateSale);
            this.Controls.Add(this.newSaleButton);
            this.Controls.Add(this.newPersonComboBox);
            this.Controls.Add(this.newRegionComboBox);
            this.Controls.Add(this.newSaleDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newSaleAmountUpDown);
            this.Controls.Add(this.btnTBRefresh);
            this.Controls.Add(this.btnTargetSales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPerson);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSalesRegion);
            this.Controls.Add(this.cbSalesPeople);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSaleAmountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSalesPeople;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private System.Windows.Forms.ComboBox cbSalesRegion;
        private System.Windows.Forms.BindingSource salesRegionBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedByUser;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTargetSales;
        private System.Windows.Forms.Button btnTBRefresh;
        private System.Windows.Forms.NumericUpDown newSaleAmountUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker newSaleDateTimePicker;
        private System.Windows.Forms.ComboBox newRegionComboBox;
        private System.Windows.Forms.ComboBox newPersonComboBox;
        private System.Windows.Forms.Button newSaleButton;
        private System.Windows.Forms.Button btnUpdateSale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSaleReadID;
        private System.Windows.Forms.ComboBox cbIDUpdate;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.TextBox tbUpdateID;
        private System.Windows.Forms.Button btnDeleteSale;
    }
}

