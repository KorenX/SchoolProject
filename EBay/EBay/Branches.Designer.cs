namespace EBay
{
    partial class Branches
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
            System.Windows.Forms.Label branchIDLabel;
            System.Windows.Forms.Label branchNameLabel;
            System.Windows.Forms.Label branchAddressLabel;
            System.Windows.Forms.Label branchPhoneLabel;
            System.Windows.Forms.Label branchManagerLabel;
            this.eBuyDataSet = new EBay.EBuyDataSet();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchesTableAdapter = new EBay.EBuyDataSetTableAdapters.BranchesTableAdapter();
            this.tableAdapterManager = new EBay.EBuyDataSetTableAdapters.TableAdapterManager();
            this.branchesDataGridView = new System.Windows.Forms.DataGridView();
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
            this.branchIDTextBox = new System.Windows.Forms.TextBox();
            this.branchNameTextBox = new System.Windows.Forms.TextBox();
            this.branchAddressTextBox = new System.Windows.Forms.TextBox();
            this.branchPhoneTextBox = new System.Windows.Forms.TextBox();
            this.branchManagerTextBox = new System.Windows.Forms.TextBox();
            branchIDLabel = new System.Windows.Forms.Label();
            branchNameLabel = new System.Windows.Forms.Label();
            branchAddressLabel = new System.Windows.Forms.Label();
            branchPhoneLabel = new System.Windows.Forms.Label();
            branchManagerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // branchIDLabel
            // 
            branchIDLabel.AutoSize = true;
            branchIDLabel.Location = new System.Drawing.Point(54, 9);
            branchIDLabel.Name = "branchIDLabel";
            branchIDLabel.Size = new System.Drawing.Size(58, 13);
            branchIDLabel.TabIndex = 45;
            branchIDLabel.Text = "Branch ID:";
            // 
            // branchNameLabel
            // 
            branchNameLabel.AutoSize = true;
            branchNameLabel.Location = new System.Drawing.Point(54, 35);
            branchNameLabel.Name = "branchNameLabel";
            branchNameLabel.Size = new System.Drawing.Size(75, 13);
            branchNameLabel.TabIndex = 47;
            branchNameLabel.Text = "Branch Name:";
            // 
            // branchAddressLabel
            // 
            branchAddressLabel.AutoSize = true;
            branchAddressLabel.Location = new System.Drawing.Point(54, 61);
            branchAddressLabel.Name = "branchAddressLabel";
            branchAddressLabel.Size = new System.Drawing.Size(85, 13);
            branchAddressLabel.TabIndex = 49;
            branchAddressLabel.Text = "Branch Address:";
            // 
            // branchPhoneLabel
            // 
            branchPhoneLabel.AutoSize = true;
            branchPhoneLabel.Location = new System.Drawing.Point(54, 87);
            branchPhoneLabel.Name = "branchPhoneLabel";
            branchPhoneLabel.Size = new System.Drawing.Size(78, 13);
            branchPhoneLabel.TabIndex = 51;
            branchPhoneLabel.Text = "Branch Phone:";
            // 
            // branchManagerLabel
            // 
            branchManagerLabel.AutoSize = true;
            branchManagerLabel.Location = new System.Drawing.Point(54, 113);
            branchManagerLabel.Name = "branchManagerLabel";
            branchManagerLabel.Size = new System.Drawing.Size(89, 13);
            branchManagerLabel.TabIndex = 53;
            branchManagerLabel.Text = "Branch Manager:";
            // 
            // eBuyDataSet
            // 
            this.eBuyDataSet.DataSetName = "EBuyDataSet";
            this.eBuyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchesTableAdapter = this.branchesTableAdapter;
            this.tableAdapterManager.BuyersTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CountriesTableAdapter = null;
            this.tableAdapterManager.CreatorsTableAdapter = null;
            this.tableAdapterManager.DealItemsTableAdapter = null;
            this.tableAdapterManager.DealTableAdapter = null;
            this.tableAdapterManager.ImportersTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EBay.EBuyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // branchesDataGridView
            // 
            this.branchesDataGridView.AutoGenerateColumns = false;
            this.branchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.branchesDataGridView.DataSource = this.branchesBindingSource;
            this.branchesDataGridView.Location = new System.Drawing.Point(57, 146);
            this.branchesDataGridView.Name = "branchesDataGridView";
            this.branchesDataGridView.Size = new System.Drawing.Size(598, 213);
            this.branchesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BranchID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BranchID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BranchName";
            this.dataGridViewTextBoxColumn2.HeaderText = "BranchName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BranchAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "BranchAddress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BranchPhone";
            this.dataGridViewTextBoxColumn4.HeaderText = "BranchPhone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BranchManager";
            this.dataGridViewTextBoxColumn5.HeaderText = "BranchManager";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(597, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 45;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(516, 42);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 44;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(434, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 43;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(353, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 42;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(597, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(516, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "First";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // branchIDTextBox
            // 
            this.branchIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchesBindingSource, "BranchID", true));
            this.branchIDTextBox.Enabled = false;
            this.branchIDTextBox.Location = new System.Drawing.Point(149, 6);
            this.branchIDTextBox.Name = "branchIDTextBox";
            this.branchIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.branchIDTextBox.TabIndex = 46;
            // 
            // branchNameTextBox
            // 
            this.branchNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchesBindingSource, "BranchName", true));
            this.branchNameTextBox.Location = new System.Drawing.Point(149, 32);
            this.branchNameTextBox.Name = "branchNameTextBox";
            this.branchNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.branchNameTextBox.TabIndex = 48;
            // 
            // branchAddressTextBox
            // 
            this.branchAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchesBindingSource, "BranchAddress", true));
            this.branchAddressTextBox.Location = new System.Drawing.Point(149, 58);
            this.branchAddressTextBox.Name = "branchAddressTextBox";
            this.branchAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.branchAddressTextBox.TabIndex = 50;
            // 
            // branchPhoneTextBox
            // 
            this.branchPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchesBindingSource, "BranchPhone", true));
            this.branchPhoneTextBox.Location = new System.Drawing.Point(149, 84);
            this.branchPhoneTextBox.Name = "branchPhoneTextBox";
            this.branchPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.branchPhoneTextBox.TabIndex = 52;
            // 
            // branchManagerTextBox
            // 
            this.branchManagerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.branchesBindingSource, "BranchManager", true));
            this.branchManagerTextBox.Location = new System.Drawing.Point(149, 110);
            this.branchManagerTextBox.Name = "branchManagerTextBox";
            this.branchManagerTextBox.Size = new System.Drawing.Size(100, 20);
            this.branchManagerTextBox.TabIndex = 54;
            // 
            // Branches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 379);
            this.Controls.Add(branchIDLabel);
            this.Controls.Add(this.branchIDTextBox);
            this.Controls.Add(branchNameLabel);
            this.Controls.Add(this.branchNameTextBox);
            this.Controls.Add(branchAddressLabel);
            this.Controls.Add(this.branchAddressTextBox);
            this.Controls.Add(branchPhoneLabel);
            this.Controls.Add(this.branchPhoneTextBox);
            this.Controls.Add(branchManagerLabel);
            this.Controls.Add(this.branchManagerTextBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.branchesDataGridView);
            this.Name = "Branches";
            this.Text = "Branches";
            this.Load += new System.EventHandler(this.Branches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EBuyDataSet eBuyDataSet;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private EBuyDataSetTableAdapters.BranchesTableAdapter branchesTableAdapter;
        private EBuyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView branchesDataGridView;
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
        private System.Windows.Forms.TextBox branchIDTextBox;
        private System.Windows.Forms.TextBox branchNameTextBox;
        private System.Windows.Forms.TextBox branchAddressTextBox;
        private System.Windows.Forms.TextBox branchPhoneTextBox;
        private System.Windows.Forms.TextBox branchManagerTextBox;
    }
}