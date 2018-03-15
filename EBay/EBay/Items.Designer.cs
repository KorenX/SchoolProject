namespace EBay
{
    partial class Items
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
            System.Windows.Forms.Label itemIDLabel;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label itemDiscriptionLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label creatorIDLabel;
            System.Windows.Forms.Label importIDLabel;
            System.Windows.Forms.Label itemCostLabel;
            System.Windows.Forms.Label itemQuantityLabel;
            System.Windows.Forms.Label itemPicLabel;
            this.eBuyDataSet = new EBay.EBuyDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new EBay.EBuyDataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new EBay.EBuyDataSetTableAdapters.TableAdapterManager();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemDiscriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.creatorIDTextBox = new System.Windows.Forms.TextBox();
            this.importIDTextBox = new System.Windows.Forms.TextBox();
            this.itemCostTextBox = new System.Windows.Forms.TextBox();
            this.itemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.itemPicTextBox = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            itemIDLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            itemDiscriptionLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            creatorIDLabel = new System.Windows.Forms.Label();
            importIDLabel = new System.Windows.Forms.Label();
            itemCostLabel = new System.Windows.Forms.Label();
            itemQuantityLabel = new System.Windows.Forms.Label();
            itemPicLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eBuyDataSet
            // 
            this.eBuyDataSet.DataSetName = "EBuyDataSet";
            this.eBuyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.eBuyDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ImportersTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = EBay.EBuyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AutoGenerateColumns = false;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.itemsDataGridView.DataSource = this.itemsBindingSource;
            this.itemsDataGridView.Location = new System.Drawing.Point(12, 242);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.Size = new System.Drawing.Size(1051, 158);
            this.itemsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemDiscription";
            this.dataGridViewTextBoxColumn3.HeaderText = "ItemDiscription";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn4.HeaderText = "Category";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreatorID";
            this.dataGridViewTextBoxColumn5.HeaderText = "CreatorID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ImportID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ImportID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ItemCost";
            this.dataGridViewTextBoxColumn7.HeaderText = "ItemCost";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ItemQuantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "ItemQuantity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ItemPic";
            this.dataGridViewTextBoxColumn9.HeaderText = "ItemPic";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Location = new System.Drawing.Point(33, 9);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new System.Drawing.Size(44, 13);
            itemIDLabel.TabIndex = 1;
            itemIDLabel.Text = "Item ID:";
            // 
            // itemIDTextBox
            // 
            this.itemIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ItemID", true));
            this.itemIDTextBox.Enabled = false;
            this.itemIDTextBox.Location = new System.Drawing.Point(121, 6);
            this.itemIDTextBox.Name = "itemIDTextBox";
            this.itemIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemIDTextBox.TabIndex = 2;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(33, 35);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(61, 13);
            itemNameLabel.TabIndex = 3;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ItemName", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(121, 32);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNameTextBox.TabIndex = 4;
            // 
            // itemDiscriptionLabel
            // 
            itemDiscriptionLabel.AutoSize = true;
            itemDiscriptionLabel.Location = new System.Drawing.Point(33, 61);
            itemDiscriptionLabel.Name = "itemDiscriptionLabel";
            itemDiscriptionLabel.Size = new System.Drawing.Size(82, 13);
            itemDiscriptionLabel.TabIndex = 5;
            itemDiscriptionLabel.Text = "Item Discription:";
            // 
            // itemDiscriptionTextBox
            // 
            this.itemDiscriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ItemDiscription", true));
            this.itemDiscriptionTextBox.Location = new System.Drawing.Point(121, 58);
            this.itemDiscriptionTextBox.Name = "itemDiscriptionTextBox";
            this.itemDiscriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemDiscriptionTextBox.TabIndex = 6;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(33, 87);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(121, 84);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 8;
            // 
            // creatorIDLabel
            // 
            creatorIDLabel.AutoSize = true;
            creatorIDLabel.Location = new System.Drawing.Point(33, 113);
            creatorIDLabel.Name = "creatorIDLabel";
            creatorIDLabel.Size = new System.Drawing.Size(58, 13);
            creatorIDLabel.TabIndex = 9;
            creatorIDLabel.Text = "Creator ID:";
            // 
            // creatorIDTextBox
            // 
            this.creatorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "CreatorID", true));
            this.creatorIDTextBox.Location = new System.Drawing.Point(121, 110);
            this.creatorIDTextBox.Name = "creatorIDTextBox";
            this.creatorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatorIDTextBox.TabIndex = 10;
            // 
            // importIDLabel
            // 
            importIDLabel.AutoSize = true;
            importIDLabel.Location = new System.Drawing.Point(33, 139);
            importIDLabel.Name = "importIDLabel";
            importIDLabel.Size = new System.Drawing.Size(53, 13);
            importIDLabel.TabIndex = 11;
            importIDLabel.Text = "Import ID:";
            // 
            // importIDTextBox
            // 
            this.importIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ImportID", true));
            this.importIDTextBox.Location = new System.Drawing.Point(121, 136);
            this.importIDTextBox.Name = "importIDTextBox";
            this.importIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.importIDTextBox.TabIndex = 12;
            // 
            // itemCostLabel
            // 
            itemCostLabel.AutoSize = true;
            itemCostLabel.Location = new System.Drawing.Point(33, 165);
            itemCostLabel.Name = "itemCostLabel";
            itemCostLabel.Size = new System.Drawing.Size(54, 13);
            itemCostLabel.TabIndex = 13;
            itemCostLabel.Text = "Item Cost:";
            // 
            // itemCostTextBox
            // 
            this.itemCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ItemCost", true));
            this.itemCostTextBox.Location = new System.Drawing.Point(121, 162);
            this.itemCostTextBox.Name = "itemCostTextBox";
            this.itemCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemCostTextBox.TabIndex = 14;
            // 
            // itemQuantityLabel
            // 
            itemQuantityLabel.AutoSize = true;
            itemQuantityLabel.Location = new System.Drawing.Point(33, 191);
            itemQuantityLabel.Name = "itemQuantityLabel";
            itemQuantityLabel.Size = new System.Drawing.Size(72, 13);
            itemQuantityLabel.TabIndex = 15;
            itemQuantityLabel.Text = "Item Quantity:";
            // 
            // itemQuantityTextBox
            // 
            this.itemQuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ItemQuantity", true));
            this.itemQuantityTextBox.Location = new System.Drawing.Point(121, 188);
            this.itemQuantityTextBox.Name = "itemQuantityTextBox";
            this.itemQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemQuantityTextBox.TabIndex = 16;
            // 
            // itemPicLabel
            // 
            itemPicLabel.AutoSize = true;
            itemPicLabel.Location = new System.Drawing.Point(33, 217);
            itemPicLabel.Name = "itemPicLabel";
            itemPicLabel.Size = new System.Drawing.Size(48, 13);
            itemPicLabel.TabIndex = 17;
            itemPicLabel.Text = "Item Pic:";
            // 
            // itemPicTextBox
            // 
            this.itemPicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ItemPic", true));
            this.itemPicTextBox.Location = new System.Drawing.Point(121, 214);
            this.itemPicTextBox.Name = "itemPicTextBox";
            this.itemPicTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemPicTextBox.TabIndex = 18;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(569, 110);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 32;
            this.button10.Text = "Cancel";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 31;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(382, 87);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 30;
            this.button9.Text = "Search";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(575, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(493, 41);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 28;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(411, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(330, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(574, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(493, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "First";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Search by ID or Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Search by Category";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(463, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 36;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(382, 131);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 35;
            this.button11.Text = "Search";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 452);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(itemIDLabel);
            this.Controls.Add(this.itemIDTextBox);
            this.Controls.Add(itemNameLabel);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(itemDiscriptionLabel);
            this.Controls.Add(this.itemDiscriptionTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(creatorIDLabel);
            this.Controls.Add(this.creatorIDTextBox);
            this.Controls.Add(importIDLabel);
            this.Controls.Add(this.importIDTextBox);
            this.Controls.Add(itemCostLabel);
            this.Controls.Add(this.itemCostTextBox);
            this.Controls.Add(itemQuantityLabel);
            this.Controls.Add(this.itemQuantityTextBox);
            this.Controls.Add(itemPicLabel);
            this.Controls.Add(this.itemPicTextBox);
            this.Controls.Add(this.itemsDataGridView);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EBuyDataSet eBuyDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private EBuyDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private EBuyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox itemIDTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemDiscriptionTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox creatorIDTextBox;
        private System.Windows.Forms.TextBox importIDTextBox;
        private System.Windows.Forms.TextBox itemCostTextBox;
        private System.Windows.Forms.TextBox itemQuantityTextBox;
        private System.Windows.Forms.TextBox itemPicTextBox;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button11;
    }
}