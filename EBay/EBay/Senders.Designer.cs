namespace EBay
{
    partial class Senders
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
            System.Windows.Forms.Label senderIDLabel;
            System.Windows.Forms.Label senderNameLabel;
            System.Windows.Forms.Label senderCompanyLabel;
            System.Windows.Forms.Label senderPhoneLabel;
            System.Windows.Forms.Label senderMailLabel;
            this.eBuyDataSet = new EBay.EBuyDataSet();
            this.sendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sendersTableAdapter = new EBay.EBuyDataSetTableAdapters.SendersTableAdapter();
            this.tableAdapterManager = new EBay.EBuyDataSetTableAdapters.TableAdapterManager();
            this.sendersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderIDTextBox = new System.Windows.Forms.TextBox();
            this.senderNameTextBox = new System.Windows.Forms.TextBox();
            this.senderCompanyTextBox = new System.Windows.Forms.TextBox();
            this.senderPhoneTextBox = new System.Windows.Forms.TextBox();
            this.senderMailTextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            senderIDLabel = new System.Windows.Forms.Label();
            senderNameLabel = new System.Windows.Forms.Label();
            senderCompanyLabel = new System.Windows.Forms.Label();
            senderPhoneLabel = new System.Windows.Forms.Label();
            senderMailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eBuyDataSet
            // 
            this.eBuyDataSet.DataSetName = "EBuyDataSet";
            this.eBuyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sendersBindingSource
            // 
            this.sendersBindingSource.DataMember = "Senders";
            this.sendersBindingSource.DataSource = this.eBuyDataSet;
            // 
            // sendersTableAdapter
            // 
            this.sendersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ImportItemsTableAdapter = null;
            this.tableAdapterManager.ImportTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.SendersTableAdapter = this.sendersTableAdapter;
            this.tableAdapterManager.UpdateOrder = EBay.EBuyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sendersDataGridView
            // 
            this.sendersDataGridView.AutoGenerateColumns = false;
            this.sendersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sendersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.sendersDataGridView.DataSource = this.sendersBindingSource;
            this.sendersDataGridView.Location = new System.Drawing.Point(39, 210);
            this.sendersDataGridView.Name = "sendersDataGridView";
            this.sendersDataGridView.Size = new System.Drawing.Size(548, 220);
            this.sendersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SenderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SenderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SenderName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SenderName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SenderCompany";
            this.dataGridViewTextBoxColumn3.HeaderText = "SenderCompany";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SenderPhone";
            this.dataGridViewTextBoxColumn4.HeaderText = "SenderPhone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SenderMail";
            this.dataGridViewTextBoxColumn5.HeaderText = "SenderMail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // senderIDLabel
            // 
            senderIDLabel.AutoSize = true;
            senderIDLabel.Location = new System.Drawing.Point(80, 38);
            senderIDLabel.Name = "senderIDLabel";
            senderIDLabel.Size = new System.Drawing.Size(58, 13);
            senderIDLabel.TabIndex = 1;
            senderIDLabel.Text = "Sender ID:";
            // 
            // senderIDTextBox
            // 
            this.senderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sendersBindingSource, "SenderID", true));
            this.senderIDTextBox.Location = new System.Drawing.Point(177, 35);
            this.senderIDTextBox.Name = "senderIDTextBox";
            this.senderIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.senderIDTextBox.TabIndex = 2;
            // 
            // senderNameLabel
            // 
            senderNameLabel.AutoSize = true;
            senderNameLabel.Location = new System.Drawing.Point(80, 64);
            senderNameLabel.Name = "senderNameLabel";
            senderNameLabel.Size = new System.Drawing.Size(75, 13);
            senderNameLabel.TabIndex = 3;
            senderNameLabel.Text = "Sender Name:";
            // 
            // senderNameTextBox
            // 
            this.senderNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sendersBindingSource, "SenderName", true));
            this.senderNameTextBox.Location = new System.Drawing.Point(177, 61);
            this.senderNameTextBox.Name = "senderNameTextBox";
            this.senderNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.senderNameTextBox.TabIndex = 4;
            // 
            // senderCompanyLabel
            // 
            senderCompanyLabel.AutoSize = true;
            senderCompanyLabel.Location = new System.Drawing.Point(80, 90);
            senderCompanyLabel.Name = "senderCompanyLabel";
            senderCompanyLabel.Size = new System.Drawing.Size(91, 13);
            senderCompanyLabel.TabIndex = 5;
            senderCompanyLabel.Text = "Sender Company:";
            // 
            // senderCompanyTextBox
            // 
            this.senderCompanyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sendersBindingSource, "SenderCompany", true));
            this.senderCompanyTextBox.Location = new System.Drawing.Point(177, 87);
            this.senderCompanyTextBox.Name = "senderCompanyTextBox";
            this.senderCompanyTextBox.Size = new System.Drawing.Size(100, 20);
            this.senderCompanyTextBox.TabIndex = 6;
            // 
            // senderPhoneLabel
            // 
            senderPhoneLabel.AutoSize = true;
            senderPhoneLabel.Location = new System.Drawing.Point(80, 116);
            senderPhoneLabel.Name = "senderPhoneLabel";
            senderPhoneLabel.Size = new System.Drawing.Size(78, 13);
            senderPhoneLabel.TabIndex = 7;
            senderPhoneLabel.Text = "Sender Phone:";
            // 
            // senderPhoneTextBox
            // 
            this.senderPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sendersBindingSource, "SenderPhone", true));
            this.senderPhoneTextBox.Location = new System.Drawing.Point(177, 113);
            this.senderPhoneTextBox.Name = "senderPhoneTextBox";
            this.senderPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.senderPhoneTextBox.TabIndex = 8;
            // 
            // senderMailLabel
            // 
            senderMailLabel.AutoSize = true;
            senderMailLabel.Location = new System.Drawing.Point(80, 142);
            senderMailLabel.Name = "senderMailLabel";
            senderMailLabel.Size = new System.Drawing.Size(66, 13);
            senderMailLabel.TabIndex = 9;
            senderMailLabel.Text = "Sender Mail:";
            // 
            // senderMailTextBox
            // 
            this.senderMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sendersBindingSource, "SenderMail", true));
            this.senderMailTextBox.Location = new System.Drawing.Point(177, 139);
            this.senderMailTextBox.Name = "senderMailTextBox";
            this.senderMailTextBox.Size = new System.Drawing.Size(100, 20);
            this.senderMailTextBox.TabIndex = 10;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(595, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 37;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(513, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 36;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(431, 62);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(350, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(594, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "First";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Senders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 548);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(senderIDLabel);
            this.Controls.Add(this.senderIDTextBox);
            this.Controls.Add(senderNameLabel);
            this.Controls.Add(this.senderNameTextBox);
            this.Controls.Add(senderCompanyLabel);
            this.Controls.Add(this.senderCompanyTextBox);
            this.Controls.Add(senderPhoneLabel);
            this.Controls.Add(this.senderPhoneTextBox);
            this.Controls.Add(senderMailLabel);
            this.Controls.Add(this.senderMailTextBox);
            this.Controls.Add(this.sendersDataGridView);
            this.Name = "Senders";
            this.Text = "Senders";
            this.Load += new System.EventHandler(this.Senders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EBuyDataSet eBuyDataSet;
        private System.Windows.Forms.BindingSource sendersBindingSource;
        private EBuyDataSetTableAdapters.SendersTableAdapter sendersTableAdapter;
        private EBuyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sendersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox senderIDTextBox;
        private System.Windows.Forms.TextBox senderNameTextBox;
        private System.Windows.Forms.TextBox senderCompanyTextBox;
        private System.Windows.Forms.TextBox senderPhoneTextBox;
        private System.Windows.Forms.TextBox senderMailTextBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}