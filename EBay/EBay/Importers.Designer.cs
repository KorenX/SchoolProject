namespace EBay
{
    partial class Importers
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
            System.Windows.Forms.Label importIDLabel;
            System.Windows.Forms.Label importNameLabel;
            System.Windows.Forms.Label importAddressLabel;
            System.Windows.Forms.Label importPhoneLabel;
            System.Windows.Forms.Label importMailLabel;
            this.eBuyDataSet = new EBay.EBuyDataSet();
            this.importersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importersTableAdapter = new EBay.EBuyDataSetTableAdapters.ImportersTableAdapter();
            this.tableAdapterManager = new EBay.EBuyDataSetTableAdapters.TableAdapterManager();
            this.importersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.importIDTextBox = new System.Windows.Forms.TextBox();
            this.importNameTextBox = new System.Windows.Forms.TextBox();
            this.importAddressTextBox = new System.Windows.Forms.TextBox();
            this.importPhoneTextBox = new System.Windows.Forms.TextBox();
            this.importMailTextBox = new System.Windows.Forms.TextBox();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchesTableAdapter = new EBay.EBuyDataSetTableAdapters.BranchesTableAdapter();
            this.buyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyersTableAdapter = new EBay.EBuyDataSetTableAdapters.BuyersTableAdapter();
            importIDLabel = new System.Windows.Forms.Label();
            importNameLabel = new System.Windows.Forms.Label();
            importAddressLabel = new System.Windows.Forms.Label();
            importPhoneLabel = new System.Windows.Forms.Label();
            importMailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // importIDLabel
            // 
            importIDLabel.AutoSize = true;
            importIDLabel.Location = new System.Drawing.Point(44, 42);
            importIDLabel.Name = "importIDLabel";
            importIDLabel.Size = new System.Drawing.Size(53, 13);
            importIDLabel.TabIndex = 37;
            importIDLabel.Text = "Import ID:";
            // 
            // importNameLabel
            // 
            importNameLabel.AutoSize = true;
            importNameLabel.Location = new System.Drawing.Point(44, 68);
            importNameLabel.Name = "importNameLabel";
            importNameLabel.Size = new System.Drawing.Size(70, 13);
            importNameLabel.TabIndex = 39;
            importNameLabel.Text = "Import Name:";
            // 
            // importAddressLabel
            // 
            importAddressLabel.AutoSize = true;
            importAddressLabel.Location = new System.Drawing.Point(44, 94);
            importAddressLabel.Name = "importAddressLabel";
            importAddressLabel.Size = new System.Drawing.Size(80, 13);
            importAddressLabel.TabIndex = 41;
            importAddressLabel.Text = "Import Address:";
            // 
            // importPhoneLabel
            // 
            importPhoneLabel.AutoSize = true;
            importPhoneLabel.Location = new System.Drawing.Point(44, 120);
            importPhoneLabel.Name = "importPhoneLabel";
            importPhoneLabel.Size = new System.Drawing.Size(73, 13);
            importPhoneLabel.TabIndex = 43;
            importPhoneLabel.Text = "Import Phone:";
            // 
            // importMailLabel
            // 
            importMailLabel.AutoSize = true;
            importMailLabel.Location = new System.Drawing.Point(44, 146);
            importMailLabel.Name = "importMailLabel";
            importMailLabel.Size = new System.Drawing.Size(61, 13);
            importMailLabel.TabIndex = 45;
            importMailLabel.Text = "Import Mail:";
            // 
            // eBuyDataSet
            // 
            this.eBuyDataSet.DataSetName = "EBuyDataSet";
            this.eBuyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importersBindingSource
            // 
            this.importersBindingSource.DataMember = "Importers";
            this.importersBindingSource.DataSource = this.eBuyDataSet;
            // 
            // importersTableAdapter
            // 
            this.importersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchesTableAdapter = null;
            this.tableAdapterManager.BuyersTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CountriesTableAdapter = null;
            this.tableAdapterManager.CreatorsTableAdapter = null;
            this.tableAdapterManager.DealItemsTableAdapter = null;
            this.tableAdapterManager.DealTableAdapter = null;
            this.tableAdapterManager.ImportersTableAdapter = this.importersTableAdapter;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EBay.EBuyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // importersDataGridView
            // 
            this.importersDataGridView.AutoGenerateColumns = false;
            this.importersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.importersDataGridView.DataSource = this.importersBindingSource;
            this.importersDataGridView.Location = new System.Drawing.Point(12, 205);
            this.importersDataGridView.Name = "importersDataGridView";
            this.importersDataGridView.Size = new System.Drawing.Size(553, 221);
            this.importersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ImportID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ImportID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ImportName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ImportName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ImportAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "ImportAddress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ImportPhone";
            this.dataGridViewTextBoxColumn4.HeaderText = "ImportPhone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ImportMail";
            this.dataGridViewTextBoxColumn5.HeaderText = "ImportMail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(519, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 37;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(438, 42);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 36;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(356, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(275, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(519, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "First";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // importIDTextBox
            // 
            this.importIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importersBindingSource, "ImportID", true));
            this.importIDTextBox.Enabled = false;
            this.importIDTextBox.Location = new System.Drawing.Point(130, 39);
            this.importIDTextBox.Name = "importIDTextBox";
            this.importIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.importIDTextBox.TabIndex = 38;
            // 
            // importNameTextBox
            // 
            this.importNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importersBindingSource, "ImportName", true));
            this.importNameTextBox.Location = new System.Drawing.Point(130, 65);
            this.importNameTextBox.Name = "importNameTextBox";
            this.importNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.importNameTextBox.TabIndex = 40;
            // 
            // importAddressTextBox
            // 
            this.importAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importersBindingSource, "ImportAddress", true));
            this.importAddressTextBox.Location = new System.Drawing.Point(130, 91);
            this.importAddressTextBox.Name = "importAddressTextBox";
            this.importAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.importAddressTextBox.TabIndex = 42;
            // 
            // importPhoneTextBox
            // 
            this.importPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importersBindingSource, "ImportPhone", true));
            this.importPhoneTextBox.Location = new System.Drawing.Point(130, 117);
            this.importPhoneTextBox.Name = "importPhoneTextBox";
            this.importPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.importPhoneTextBox.TabIndex = 44;
            // 
            // importMailTextBox
            // 
            this.importMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importersBindingSource, "ImportMail", true));
            this.importMailTextBox.Location = new System.Drawing.Point(130, 143);
            this.importMailTextBox.Name = "importMailTextBox";
            this.importMailTextBox.Size = new System.Drawing.Size(100, 20);
            this.importMailTextBox.TabIndex = 46;
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "Branches";
            this.branchesBindingSource.DataSource = this.eBuyDataSet;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // buyersBindingSource
            // 
            this.buyersBindingSource.DataMember = "Buyers";
            this.buyersBindingSource.DataSource = this.eBuyDataSet;
            // 
            // buyersTableAdapter
            // 
            this.buyersTableAdapter.ClearBeforeFill = true;
            // 
            // Importers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(766, 694);
            this.Controls.Add(importIDLabel);
            this.Controls.Add(this.importIDTextBox);
            this.Controls.Add(importNameLabel);
            this.Controls.Add(this.importNameTextBox);
            this.Controls.Add(importAddressLabel);
            this.Controls.Add(this.importAddressTextBox);
            this.Controls.Add(importPhoneLabel);
            this.Controls.Add(this.importPhoneTextBox);
            this.Controls.Add(importMailLabel);
            this.Controls.Add(this.importMailTextBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.importersDataGridView);
            this.Name = "Importers";
            this.Text = "Importers";
            this.Load += new System.EventHandler(this.Importers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EBuyDataSet eBuyDataSet;
        private System.Windows.Forms.BindingSource importersBindingSource;
        private EBuyDataSetTableAdapters.ImportersTableAdapter importersTableAdapter;
        private EBuyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView importersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox importIDTextBox;
        private System.Windows.Forms.TextBox importNameTextBox;
        private System.Windows.Forms.TextBox importAddressTextBox;
        private System.Windows.Forms.TextBox importPhoneTextBox;
        private System.Windows.Forms.TextBox importMailTextBox;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private EBuyDataSetTableAdapters.BranchesTableAdapter branchesTableAdapter;
        private System.Windows.Forms.BindingSource buyersBindingSource;
        private EBuyDataSetTableAdapters.BuyersTableAdapter buyersTableAdapter;
    }
}