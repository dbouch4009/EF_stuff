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
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(67, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Person";
            // 
            // btnTargetSales
            // 
            this.btnTargetSales.Location = new System.Drawing.Point(35, 161);
            this.btnTargetSales.Name = "btnTargetSales";
            this.btnTargetSales.Size = new System.Drawing.Size(75, 46);
            this.btnTargetSales.TabIndex = 12;
            this.btnTargetSales.Text = "Target";
            this.btnTargetSales.UseVisualStyleBackColor = true;
            this.btnTargetSales.Click += new System.EventHandler(this.btnTargetSales_Click);
            // 
            // btnTBRefresh
            // 
            this.btnTBRefresh.Location = new System.Drawing.Point(70, 229);
            this.btnTBRefresh.Name = "btnTBRefresh";
            this.btnTBRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnTBRefresh.TabIndex = 13;
            this.btnTBRefresh.Text = "TB Refresh";
            this.btnTBRefresh.UseVisualStyleBackColor = true;
            this.btnTBRefresh.Click += new System.EventHandler(this.btnTBRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 616);
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
    }
}

