namespace EBay
{
    partial class Buyers
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
            System.Windows.Forms.Label buyerIDLabel;
            System.Windows.Forms.Label buyerNameLabel;
            System.Windows.Forms.Label buyerAddressLabel;
            System.Windows.Forms.Label buyerPhoneLabel;
            System.Windows.Forms.Label buyerMailLabel;
            this.eBuyDataSet = new EBay.EBuyDataSet();
            this.buyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyersTableAdapter = new EBay.EBuyDataSetTableAdapters.BuyersTableAdapter();
            this.tableAdapterManager = new EBay.EBuyDataSetTableAdapters.TableAdapterManager();
            this.buyersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerIDTextBox = new System.Windows.Forms.TextBox();
            this.buyerNameTextBox = new System.Windows.Forms.TextBox();
            this.buyerAddressTextBox = new System.Windows.Forms.TextBox();
            this.buyerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.buyerMailTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            buyerIDLabel = new System.Windows.Forms.Label();
            buyerNameLabel = new System.Windows.Forms.Label();
            buyerAddressLabel = new System.Windows.Forms.Label();
            buyerPhoneLabel = new System.Windows.Forms.Label();
            buyerMailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eBuyDataSet
            // 
            this.eBuyDataSet.DataSetName = "EBuyDataSet";
            this.eBuyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchesTableAdapter = null;
            this.tableAdapterManager.BuyersTableAdapter = this.buyersTableAdapter;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CountriesTableAdapter = null;
            this.tableAdapterManager.CreatorsTableAdapter = null;
            this.tableAdapterManager.DealItemsTableAdapter = null;
            this.tableAdapterManager.DealTableAdapter = null;
            this.tableAdapterManager.ImportersTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EBay.EBuyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buyersDataGridView
            // 
            this.buyersDataGridView.AutoGenerateColumns = false;
            this.buyersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.buyersDataGridView.DataSource = this.buyersBindingSource;
            this.buyersDataGridView.Location = new System.Drawing.Point(12, 165);
            this.buyersDataGridView.Name = "buyersDataGridView";
            this.buyersDataGridView.Size = new System.Drawing.Size(591, 211);
            this.buyersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BuyerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BuyerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BuyerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "BuyerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BuyerAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "BuyerAddress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BuyerPhone";
            this.dataGridViewTextBoxColumn4.HeaderText = "BuyerPhone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BuyerMail";
            this.dataGridViewTextBoxColumn5.HeaderText = "BuyerMail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // buyerIDLabel
            // 
            buyerIDLabel.AutoSize = true;
            buyerIDLabel.Location = new System.Drawing.Point(66, 19);
            buyerIDLabel.Name = "buyerIDLabel";
            buyerIDLabel.Size = new System.Drawing.Size(51, 13);
            buyerIDLabel.TabIndex = 1;
            buyerIDLabel.Text = "Buyer ID:";
            // 
            // buyerIDTextBox
            // 
            this.buyerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerID", true));
            this.buyerIDTextBox.Enabled = false;
            this.buyerIDTextBox.Location = new System.Drawing.Point(150, 16);
            this.buyerIDTextBox.Name = "buyerIDTextBox";
            this.buyerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyerIDTextBox.TabIndex = 2;
            // 
            // buyerNameLabel
            // 
            buyerNameLabel.AutoSize = true;
            buyerNameLabel.Location = new System.Drawing.Point(66, 45);
            buyerNameLabel.Name = "buyerNameLabel";
            buyerNameLabel.Size = new System.Drawing.Size(68, 13);
            buyerNameLabel.TabIndex = 3;
            buyerNameLabel.Text = "Buyer Name:";
            // 
            // buyerNameTextBox
            // 
            this.buyerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerName", true));
            this.buyerNameTextBox.Location = new System.Drawing.Point(150, 42);
            this.buyerNameTextBox.Name = "buyerNameTextBox";
            this.buyerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyerNameTextBox.TabIndex = 4;
            // 
            // buyerAddressLabel
            // 
            buyerAddressLabel.AutoSize = true;
            buyerAddressLabel.Location = new System.Drawing.Point(66, 71);
            buyerAddressLabel.Name = "buyerAddressLabel";
            buyerAddressLabel.Size = new System.Drawing.Size(78, 13);
            buyerAddressLabel.TabIndex = 5;
            buyerAddressLabel.Text = "Buyer Address:";
            // 
            // buyerAddressTextBox
            // 
            this.buyerAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerAddress", true));
            this.buyerAddressTextBox.Location = new System.Drawing.Point(150, 68);
            this.buyerAddressTextBox.Name = "buyerAddressTextBox";
            this.buyerAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyerAddressTextBox.TabIndex = 6;
            // 
            // buyerPhoneLabel
            // 
            buyerPhoneLabel.AutoSize = true;
            buyerPhoneLabel.Location = new System.Drawing.Point(66, 97);
            buyerPhoneLabel.Name = "buyerPhoneLabel";
            buyerPhoneLabel.Size = new System.Drawing.Size(71, 13);
            buyerPhoneLabel.TabIndex = 7;
            buyerPhoneLabel.Text = "Buyer Phone:";
            // 
            // buyerPhoneTextBox
            // 
            this.buyerPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerPhone", true));
            this.buyerPhoneTextBox.Location = new System.Drawing.Point(150, 94);
            this.buyerPhoneTextBox.Name = "buyerPhoneTextBox";
            this.buyerPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyerPhoneTextBox.TabIndex = 8;
            // 
            // buyerMailLabel
            // 
            buyerMailLabel.AutoSize = true;
            buyerMailLabel.Location = new System.Drawing.Point(66, 123);
            buyerMailLabel.Name = "buyerMailLabel";
            buyerMailLabel.Size = new System.Drawing.Size(59, 13);
            buyerMailLabel.TabIndex = 9;
            buyerMailLabel.Text = "Buyer Mail:";
            // 
            // buyerMailTextBox
            // 
            this.buyerMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyersBindingSource, "BuyerMail", true));
            this.buyerMailTextBox.Location = new System.Drawing.Point(150, 120);
            this.buyerMailTextBox.Name = "buyerMailTextBox";
            this.buyerMailTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyerMailTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "First";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(559, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(315, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(396, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(478, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(560, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Clear);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(367, 91);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Search";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(448, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(554, 92);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 21;
            this.button10.Text = "Cancel";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Buyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 466);
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
            this.Controls.Add(buyerIDLabel);
            this.Controls.Add(this.buyerIDTextBox);
            this.Controls.Add(buyerNameLabel);
            this.Controls.Add(this.buyerNameTextBox);
            this.Controls.Add(buyerAddressLabel);
            this.Controls.Add(this.buyerAddressTextBox);
            this.Controls.Add(buyerPhoneLabel);
            this.Controls.Add(this.buyerPhoneTextBox);
            this.Controls.Add(buyerMailLabel);
            this.Controls.Add(this.buyerMailTextBox);
            this.Controls.Add(this.buyersDataGridView);
            this.Name = "Buyers";
            this.Text = "Buyers";
            this.Load += new System.EventHandler(this.Buyers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EBuyDataSet eBuyDataSet;
        private System.Windows.Forms.BindingSource buyersBindingSource;
        private EBuyDataSetTableAdapters.BuyersTableAdapter buyersTableAdapter;
        private EBuyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView buyersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox buyerIDTextBox;
        private System.Windows.Forms.TextBox buyerNameTextBox;
        private System.Windows.Forms.TextBox buyerAddressTextBox;
        private System.Windows.Forms.TextBox buyerPhoneTextBox;
        private System.Windows.Forms.TextBox buyerMailTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button10;
    }
}