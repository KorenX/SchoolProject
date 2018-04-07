namespace EBay
{
    partial class Deals
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
            System.Windows.Forms.Label dealIDLabel;
            System.Windows.Forms.Label dealDateLabel;
            System.Windows.Forms.Label dealPayedLabel;
            System.Windows.Forms.Label dealBuyerIDLabel1;
            System.Windows.Forms.Label dealBranchIDLabel1;
            System.Windows.Forms.Label dealIDLabel1;
            System.Windows.Forms.Label itemIDLabel;
            System.Windows.Forms.Label itemAmountLabel;
            System.Windows.Forms.Label senderIDLabel;
            System.Windows.Forms.Label dealSentLabel;
            System.Windows.Forms.Label sentDateLabel;
            System.Windows.Forms.Label itemAmountSentLabel;
            this.dealDataGridView = new System.Windows.Forms.DataGridView();
            this.dealIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealBuyerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealBranchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealPayedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.senderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealSentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBuyDataSet = new EBay.EBuyDataSet();
            this.dealItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dealIDTextBox = new System.Windows.Forms.TextBox();
            this.dealDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dealPayedCheckBox = new System.Windows.Forms.CheckBox();
            this.dealBuyerIDComboBox = new System.Windows.Forms.ComboBox();
            this.dealBranchIDComboBox = new System.Windows.Forms.ComboBox();
            this.buyersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.dealIDTextBox1 = new System.Windows.Forms.TextBox();
            this.itemIDComboBox = new System.Windows.Forms.ComboBox();
            this.itemAmountTextBox = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senderIDComboBox = new System.Windows.Forms.ComboBox();
            this.dealSentCheckBox = new System.Windows.Forms.CheckBox();
            this.sentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.itemAmountSentTextBox = new System.Windows.Forms.TextBox();
            this.dealTableAdapter = new EBay.EBuyDataSetTableAdapters.DealTableAdapter();
            this.tableAdapterManager = new EBay.EBuyDataSetTableAdapters.TableAdapterManager();
            this.branchesTableAdapter = new EBay.EBuyDataSetTableAdapters.BranchesTableAdapter();
            this.buyersTableAdapter = new EBay.EBuyDataSetTableAdapters.BuyersTableAdapter();
            this.dealItemsTableAdapter = new EBay.EBuyDataSetTableAdapters.DealItemsTableAdapter();
            this.itemsTableAdapter = new EBay.EBuyDataSetTableAdapters.ItemsTableAdapter();
            this.sendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sendersTableAdapter = new EBay.EBuyDataSetTableAdapters.SendersTableAdapter();
            this.sendersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dealItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dealIDLabel = new System.Windows.Forms.Label();
            dealDateLabel = new System.Windows.Forms.Label();
            dealPayedLabel = new System.Windows.Forms.Label();
            dealBuyerIDLabel1 = new System.Windows.Forms.Label();
            dealBranchIDLabel1 = new System.Windows.Forms.Label();
            dealIDLabel1 = new System.Windows.Forms.Label();
            itemIDLabel = new System.Windows.Forms.Label();
            itemAmountLabel = new System.Windows.Forms.Label();
            senderIDLabel = new System.Windows.Forms.Label();
            dealSentLabel = new System.Windows.Forms.Label();
            sentDateLabel = new System.Windows.Forms.Label();
            itemAmountSentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dealDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dealIDLabel
            // 
            dealIDLabel.AutoSize = true;
            dealIDLabel.Location = new System.Drawing.Point(796, 101);
            dealIDLabel.Name = "dealIDLabel";
            dealIDLabel.Size = new System.Drawing.Size(46, 13);
            dealIDLabel.TabIndex = 45;
            dealIDLabel.Text = "Deal ID:";
            // 
            // dealDateLabel
            // 
            dealDateLabel.AutoSize = true;
            dealDateLabel.Location = new System.Drawing.Point(796, 128);
            dealDateLabel.Name = "dealDateLabel";
            dealDateLabel.Size = new System.Drawing.Size(58, 13);
            dealDateLabel.TabIndex = 47;
            dealDateLabel.Text = "Deal Date:";
            // 
            // dealPayedLabel
            // 
            dealPayedLabel.AutoSize = true;
            dealPayedLabel.Location = new System.Drawing.Point(796, 207);
            dealPayedLabel.Name = "dealPayedLabel";
            dealPayedLabel.Size = new System.Drawing.Size(65, 13);
            dealPayedLabel.TabIndex = 53;
            dealPayedLabel.Text = "Deal Payed:";
            // 
            // dealBuyerIDLabel1
            // 
            dealBuyerIDLabel1.AutoSize = true;
            dealBuyerIDLabel1.Location = new System.Drawing.Point(796, 154);
            dealBuyerIDLabel1.Name = "dealBuyerIDLabel1";
            dealBuyerIDLabel1.Size = new System.Drawing.Size(76, 13);
            dealBuyerIDLabel1.TabIndex = 54;
            dealBuyerIDLabel1.Text = "Deal Buyer ID:";
            // 
            // dealBranchIDLabel1
            // 
            dealBranchIDLabel1.AutoSize = true;
            dealBranchIDLabel1.Location = new System.Drawing.Point(796, 178);
            dealBranchIDLabel1.Name = "dealBranchIDLabel1";
            dealBranchIDLabel1.Size = new System.Drawing.Size(83, 13);
            dealBranchIDLabel1.TabIndex = 55;
            dealBranchIDLabel1.Text = "Deal Branch ID:";
            // 
            // dealIDLabel1
            // 
            dealIDLabel1.AutoSize = true;
            dealIDLabel1.Location = new System.Drawing.Point(870, 456);
            dealIDLabel1.Name = "dealIDLabel1";
            dealIDLabel1.Size = new System.Drawing.Size(46, 13);
            dealIDLabel1.TabIndex = 64;
            dealIDLabel1.Text = "Deal ID:";
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Location = new System.Drawing.Point(868, 487);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new System.Drawing.Size(44, 13);
            itemIDLabel.TabIndex = 66;
            itemIDLabel.Text = "Item ID:";
            // 
            // itemAmountLabel
            // 
            itemAmountLabel.AutoSize = true;
            itemAmountLabel.Location = new System.Drawing.Point(847, 516);
            itemAmountLabel.Name = "itemAmountLabel";
            itemAmountLabel.Size = new System.Drawing.Size(69, 13);
            itemAmountLabel.TabIndex = 68;
            itemAmountLabel.Text = "Item Amount:";
            // 
            // senderIDLabel
            // 
            senderIDLabel.AutoSize = true;
            senderIDLabel.Location = new System.Drawing.Point(796, 234);
            senderIDLabel.Name = "senderIDLabel";
            senderIDLabel.Size = new System.Drawing.Size(58, 13);
            senderIDLabel.TabIndex = 70;
            senderIDLabel.Text = "Sender ID:";
            // 
            // dealSentLabel
            // 
            dealSentLabel.AutoSize = true;
            dealSentLabel.Location = new System.Drawing.Point(796, 255);
            dealSentLabel.Name = "dealSentLabel";
            dealSentLabel.Size = new System.Drawing.Size(57, 13);
            dealSentLabel.TabIndex = 71;
            dealSentLabel.Text = "Deal Sent:";
            // 
            // sentDateLabel
            // 
            sentDateLabel.AutoSize = true;
            sentDateLabel.Location = new System.Drawing.Point(799, 277);
            sentDateLabel.Name = "sentDateLabel";
            sentDateLabel.Size = new System.Drawing.Size(58, 13);
            sentDateLabel.TabIndex = 72;
            sentDateLabel.Text = "Sent Date:";
            // 
            // itemAmountSentLabel
            // 
            itemAmountSentLabel.AutoSize = true;
            itemAmountSentLabel.Location = new System.Drawing.Point(829, 543);
            itemAmountSentLabel.Name = "itemAmountSentLabel";
            itemAmountSentLabel.Size = new System.Drawing.Size(94, 13);
            itemAmountSentLabel.TabIndex = 73;
            itemAmountSentLabel.Text = "Item Amount Sent:";
            // 
            // dealDataGridView
            // 
            this.dealDataGridView.AutoGenerateColumns = false;
            this.dealDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dealIDDataGridViewTextBoxColumn,
            this.dealDateDataGridViewTextBoxColumn,
            this.dealBuyerIDDataGridViewTextBoxColumn,
            this.dealBranchIDDataGridViewTextBoxColumn,
            this.dealPayedDataGridViewCheckBoxColumn,
            this.senderIDDataGridViewTextBoxColumn,
            this.sentDateDataGridViewTextBoxColumn,
            this.dealSentDataGridViewCheckBoxColumn});
            this.dealDataGridView.DataSource = this.dealBindingSource;
            this.dealDataGridView.Location = new System.Drawing.Point(-38, 98);
            this.dealDataGridView.Name = "dealDataGridView";
            this.dealDataGridView.Size = new System.Drawing.Size(828, 233);
            this.dealDataGridView.TabIndex = 1;
            this.dealDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dealDataGridView_CellContentClick);
            // 
            // dealIDDataGridViewTextBoxColumn
            // 
            this.dealIDDataGridViewTextBoxColumn.DataPropertyName = "DealID";
            this.dealIDDataGridViewTextBoxColumn.HeaderText = "DealID";
            this.dealIDDataGridViewTextBoxColumn.Name = "dealIDDataGridViewTextBoxColumn";
            // 
            // dealDateDataGridViewTextBoxColumn
            // 
            this.dealDateDataGridViewTextBoxColumn.DataPropertyName = "DealDate";
            this.dealDateDataGridViewTextBoxColumn.HeaderText = "DealDate";
            this.dealDateDataGridViewTextBoxColumn.Name = "dealDateDataGridViewTextBoxColumn";
            // 
            // dealBuyerIDDataGridViewTextBoxColumn
            // 
            this.dealBuyerIDDataGridViewTextBoxColumn.DataPropertyName = "DealBuyerID";
            this.dealBuyerIDDataGridViewTextBoxColumn.HeaderText = "DealBuyerID";
            this.dealBuyerIDDataGridViewTextBoxColumn.Name = "dealBuyerIDDataGridViewTextBoxColumn";
            // 
            // dealBranchIDDataGridViewTextBoxColumn
            // 
            this.dealBranchIDDataGridViewTextBoxColumn.DataPropertyName = "DealBranchID";
            this.dealBranchIDDataGridViewTextBoxColumn.HeaderText = "DealBranchID";
            this.dealBranchIDDataGridViewTextBoxColumn.Name = "dealBranchIDDataGridViewTextBoxColumn";
            // 
            // dealPayedDataGridViewCheckBoxColumn
            // 
            this.dealPayedDataGridViewCheckBoxColumn.DataPropertyName = "DealPayed";
            this.dealPayedDataGridViewCheckBoxColumn.HeaderText = "DealPayed";
            this.dealPayedDataGridViewCheckBoxColumn.Name = "dealPayedDataGridViewCheckBoxColumn";
            // 
            // senderIDDataGridViewTextBoxColumn
            // 
            this.senderIDDataGridViewTextBoxColumn.DataPropertyName = "SenderID";
            this.senderIDDataGridViewTextBoxColumn.HeaderText = "SenderID";
            this.senderIDDataGridViewTextBoxColumn.Name = "senderIDDataGridViewTextBoxColumn";
            // 
            // sentDateDataGridViewTextBoxColumn
            // 
            this.sentDateDataGridViewTextBoxColumn.DataPropertyName = "SentDate";
            this.sentDateDataGridViewTextBoxColumn.HeaderText = "SentDate";
            this.sentDateDataGridViewTextBoxColumn.Name = "sentDateDataGridViewTextBoxColumn";
            // 
            // dealSentDataGridViewCheckBoxColumn
            // 
            this.dealSentDataGridViewCheckBoxColumn.DataPropertyName = "DealSent";
            this.dealSentDataGridViewCheckBoxColumn.HeaderText = "DealSent";
            this.dealSentDataGridViewCheckBoxColumn.Name = "dealSentDataGridViewCheckBoxColumn";
            // 
            // dealBindingSource
            // 
            this.dealBindingSource.DataMember = "Deal";
            this.dealBindingSource.DataSource = this.eBuyDataSet;
            // 
            // eBuyDataSet
            // 
            this.eBuyDataSet.DataSetName = "EBuyDataSet";
            this.eBuyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dealItemsBindingSource
            // 
            this.dealItemsBindingSource.DataMember = "DealItems";
            this.dealItemsBindingSource.DataSource = this.eBuyDataSet;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(1175, 186);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 45;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1094, 186);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 44;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1175, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 43;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1094, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 42;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1175, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1094, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1175, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1094, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "First";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dealIDTextBox
            // 
            this.dealIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dealBindingSource, "DealID", true));
            this.dealIDTextBox.Enabled = false;
            this.dealIDTextBox.Location = new System.Drawing.Point(885, 98);
            this.dealIDTextBox.Name = "dealIDTextBox";
            this.dealIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.dealIDTextBox.TabIndex = 46;
            // 
            // dealDateDateTimePicker
            // 
            this.dealDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dealBindingSource, "DealDate", true));
            this.dealDateDateTimePicker.Enabled = false;
            this.dealDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dealDateDateTimePicker.Location = new System.Drawing.Point(885, 124);
            this.dealDateDateTimePicker.Name = "dealDateDateTimePicker";
            this.dealDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dealDateDateTimePicker.TabIndex = 48;
            this.dealDateDateTimePicker.Value = new System.DateTime(2018, 3, 13, 14, 23, 0, 0);
            // 
            // dealPayedCheckBox
            // 
            this.dealPayedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.dealBindingSource, "DealPayed", true));
            this.dealPayedCheckBox.Location = new System.Drawing.Point(888, 202);
            this.dealPayedCheckBox.Name = "dealPayedCheckBox";
            this.dealPayedCheckBox.Size = new System.Drawing.Size(200, 24);
            this.dealPayedCheckBox.TabIndex = 54;
            this.dealPayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // dealBuyerIDComboBox
            // 
            this.dealBuyerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dealBindingSource, "DealBuyerID", true));
            this.dealBuyerIDComboBox.FormattingEnabled = true;
            this.dealBuyerIDComboBox.Location = new System.Drawing.Point(885, 151);
            this.dealBuyerIDComboBox.Name = "dealBuyerIDComboBox";
            this.dealBuyerIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.dealBuyerIDComboBox.TabIndex = 55;
            // 
            // dealBranchIDComboBox
            // 
            this.dealBranchIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dealBindingSource, "DealBranchID", true));
            this.dealBranchIDComboBox.FormattingEnabled = true;
            this.dealBranchIDComboBox.Location = new System.Drawing.Point(885, 175);
            this.dealBranchIDComboBox.Name = "dealBranchIDComboBox";
            this.dealBranchIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.dealBranchIDComboBox.TabIndex = 56;
            // 
            // buyersDataGridView
            // 
            this.buyersDataGridView.AutoGenerateColumns = false;
            this.buyersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.buyersDataGridView.DataSource = this.buyersBindingSource;
            this.buyersDataGridView.Location = new System.Drawing.Point(19, 672);
            this.buyersDataGridView.Name = "buyersDataGridView";
            this.buyersDataGridView.Size = new System.Drawing.Size(300, 220);
            this.buyersDataGridView.TabIndex = 56;
            this.buyersDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BuyerID";
            this.dataGridViewTextBoxColumn8.HeaderText = "BuyerID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "BuyerName";
            this.dataGridViewTextBoxColumn9.HeaderText = "BuyerName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "BuyerAddress";
            this.dataGridViewTextBoxColumn10.HeaderText = "BuyerAddress";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "BuyerPhone";
            this.dataGridViewTextBoxColumn11.HeaderText = "BuyerPhone";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "BuyerMail";
            this.dataGridViewTextBoxColumn12.HeaderText = "BuyerMail";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // buyersBindingSource
            // 
            this.buyersBindingSource.DataMember = "Buyers";
            this.buyersBindingSource.DataSource = this.eBuyDataSet;
            // 
            // branchesDataGridView
            // 
            this.branchesDataGridView.AutoGenerateColumns = false;
            this.branchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.branchesDataGridView.DataSource = this.branchesBindingSource;
            this.branchesDataGridView.Location = new System.Drawing.Point(163, 663);
            this.branchesDataGridView.Name = "branchesDataGridView";
            this.branchesDataGridView.Size = new System.Drawing.Size(300, 220);
            this.branchesDataGridView.TabIndex = 56;
            this.branchesDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "BranchID";
            this.dataGridViewTextBoxColumn13.HeaderText = "BranchID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "BranchName";
            this.dataGridViewTextBoxColumn14.HeaderText = "BranchName";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "BranchAddress";
            this.dataGridViewTextBoxColumn15.HeaderText = "BranchAddress";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "BranchPhone";
            this.dataGridViewTextBoxColumn16.HeaderText = "BranchPhone";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "BranchManager";
            this.dataGridViewTextBoxColumn17.HeaderText = "BranchManager";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "Branches";
            this.branchesBindingSource.DataSource = this.eBuyDataSet;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(1177, 538);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 64;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1096, 538);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 63;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1177, 509);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 62;
            this.button11.Text = "Edit";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1096, 509);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 61;
            this.button12.Text = "Add";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1177, 480);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 60;
            this.button13.Text = "Last";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(1096, 480);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 59;
            this.button14.Text = "Prev";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1177, 451);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 58;
            this.button15.Text = "Next";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(1096, 451);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 57;
            this.button16.Text = "First";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // dealIDTextBox1
            // 
            this.dealIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dealItemsBindingSource, "DealID", true));
            this.dealIDTextBox1.Enabled = false;
            this.dealIDTextBox1.Location = new System.Drawing.Point(938, 453);
            this.dealIDTextBox1.Name = "dealIDTextBox1";
            this.dealIDTextBox1.Size = new System.Drawing.Size(121, 20);
            this.dealIDTextBox1.TabIndex = 65;
            // 
            // itemIDComboBox
            // 
            this.itemIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dealItemsBindingSource, "ItemID", true));
            this.itemIDComboBox.FormattingEnabled = true;
            this.itemIDComboBox.Location = new System.Drawing.Point(938, 484);
            this.itemIDComboBox.Name = "itemIDComboBox";
            this.itemIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemIDComboBox.TabIndex = 67;
            this.itemIDComboBox.SelectedIndexChanged += new System.EventHandler(this.itemIDComboBox_SelectedIndexChanged);
            // 
            // itemAmountTextBox
            // 
            this.itemAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dealItemsBindingSource, "ItemAmount", true));
            this.itemAmountTextBox.Location = new System.Drawing.Point(938, 513);
            this.itemAmountTextBox.Name = "itemAmountTextBox";
            this.itemAmountTextBox.Size = new System.Drawing.Size(121, 20);
            this.itemAmountTextBox.TabIndex = 69;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(829, 318);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(179, 23);
            this.button17.TabIndex = 70;
            this.button17.Text = "ערוך מוצרים של העסקה";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AutoGenerateColumns = false;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26});
            this.itemsDataGridView.DataSource = this.itemsBindingSource;
            this.itemsDataGridView.Location = new System.Drawing.Point(873, -212);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.itemsDataGridView.TabIndex = 70;
            this.itemsDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn18.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn19.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ItemDiscription";
            this.dataGridViewTextBoxColumn20.HeaderText = "ItemDiscription";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn21.HeaderText = "Category";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "CreatorID";
            this.dataGridViewTextBoxColumn22.HeaderText = "CreatorID";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "ImportID";
            this.dataGridViewTextBoxColumn23.HeaderText = "ImportID";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "ItemCost";
            this.dataGridViewTextBoxColumn24.HeaderText = "ItemCost";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "ItemQuantity";
            this.dataGridViewTextBoxColumn25.HeaderText = "ItemQuantity";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "ItemPic";
            this.dataGridViewTextBoxColumn26.HeaderText = "ItemPic";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.eBuyDataSet;
            // 
            // senderIDComboBox
            // 
            this.senderIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dealBindingSource, "SenderID", true));
            this.senderIDComboBox.FormattingEnabled = true;
            this.senderIDComboBox.Location = new System.Drawing.Point(885, 226);
            this.senderIDComboBox.Name = "senderIDComboBox";
            this.senderIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.senderIDComboBox.TabIndex = 71;
            // 
            // dealSentCheckBox
            // 
            this.dealSentCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.dealBindingSource, "DealSent", true));
            this.dealSentCheckBox.Location = new System.Drawing.Point(885, 250);
            this.dealSentCheckBox.Name = "dealSentCheckBox";
            this.dealSentCheckBox.Size = new System.Drawing.Size(104, 24);
            this.dealSentCheckBox.TabIndex = 72;
            this.dealSentCheckBox.UseVisualStyleBackColor = true;
            // 
            // sentDateDateTimePicker
            // 
            this.sentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dealBindingSource, "SentDate", true));
            this.sentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sentDateDateTimePicker.Location = new System.Drawing.Point(885, 271);
            this.sentDateDateTimePicker.Name = "sentDateDateTimePicker";
            this.sentDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.sentDateDateTimePicker.TabIndex = 73;
            // 
            // itemAmountSentTextBox
            // 
            this.itemAmountSentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dealItemsBindingSource, "ItemAmountSent", true));
            this.itemAmountSentTextBox.Location = new System.Drawing.Point(938, 538);
            this.itemAmountSentTextBox.Name = "itemAmountSentTextBox";
            this.itemAmountSentTextBox.Size = new System.Drawing.Size(121, 20);
            this.itemAmountSentTextBox.TabIndex = 74;
            // 
            // dealTableAdapter
            // 
            this.dealTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchesTableAdapter = this.branchesTableAdapter;
            this.tableAdapterManager.BuyersTableAdapter = this.buyersTableAdapter;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CountriesTableAdapter = null;
            this.tableAdapterManager.CreatorsTableAdapter = null;
            this.tableAdapterManager.DealItemsTableAdapter = this.dealItemsTableAdapter;
            this.tableAdapterManager.DealTableAdapter = this.dealTableAdapter;
            this.tableAdapterManager.ImportersTableAdapter = null;
            this.tableAdapterManager.ImportItemsTableAdapter = null;
            this.tableAdapterManager.ImportTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.SendersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EBay.EBuyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // buyersTableAdapter
            // 
            this.buyersTableAdapter.ClearBeforeFill = true;
            // 
            // dealItemsTableAdapter
            // 
            this.dealItemsTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
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
            this.sendersDataGridView.Location = new System.Drawing.Point(1252, 58);
            this.sendersDataGridView.Name = "sendersDataGridView";
            this.sendersDataGridView.Size = new System.Drawing.Size(300, 220);
            this.sendersDataGridView.TabIndex = 74;
            this.sendersDataGridView.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(796, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 75;
            // 
            // itemsDataGridView1
            // 
            this.itemsDataGridView1.AutoGenerateColumns = false;
            this.itemsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34});
            this.itemsDataGridView1.DataSource = this.itemsBindingSource;
            this.itemsDataGridView1.Location = new System.Drawing.Point(561, -212);
            this.itemsDataGridView1.Name = "itemsDataGridView1";
            this.itemsDataGridView1.Size = new System.Drawing.Size(300, 220);
            this.itemsDataGridView1.TabIndex = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn7.HeaderText = "ItemName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "ItemDiscription";
            this.dataGridViewTextBoxColumn27.HeaderText = "ItemDiscription";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn28.HeaderText = "Category";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "CreatorID";
            this.dataGridViewTextBoxColumn29.HeaderText = "CreatorID";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "ImportID";
            this.dataGridViewTextBoxColumn30.HeaderText = "ImportID";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "ItemCost";
            this.dataGridViewTextBoxColumn31.HeaderText = "ItemCost";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "ItemQuantity";
            this.dataGridViewTextBoxColumn32.HeaderText = "ItemQuantity";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "ItemPic";
            this.dataGridViewTextBoxColumn33.HeaderText = "ItemPic";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "ItemWanted";
            this.dataGridViewTextBoxColumn34.HeaderText = "ItemWanted";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(139, -142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 76;
            // 
            // dealItemsDataGridView
            // 
            this.dealItemsDataGridView.AutoGenerateColumns = false;
            this.dealItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38});
            this.dealItemsDataGridView.DataSource = this.dealItemsBindingSource;
            this.dealItemsDataGridView.Location = new System.Drawing.Point(79, 378);
            this.dealItemsDataGridView.Name = "dealItemsDataGridView";
            this.dealItemsDataGridView.Size = new System.Drawing.Size(492, 249);
            this.dealItemsDataGridView.TabIndex = 76;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "DealID";
            this.dataGridViewTextBoxColumn35.HeaderText = "DealID";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn36.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "ItemAmount";
            this.dataGridViewTextBoxColumn37.HeaderText = "ItemAmount";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "ItemAmountSent";
            this.dataGridViewTextBoxColumn38.HeaderText = "ItemAmountSent";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // Deals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1276, 694);
            this.Controls.Add(this.dealItemsDataGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.itemsDataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendersDataGridView);
            this.Controls.Add(itemAmountSentLabel);
            this.Controls.Add(this.itemAmountSentTextBox);
            this.Controls.Add(sentDateLabel);
            this.Controls.Add(this.sentDateDateTimePicker);
            this.Controls.Add(dealSentLabel);
            this.Controls.Add(this.dealSentCheckBox);
            this.Controls.Add(senderIDLabel);
            this.Controls.Add(this.senderIDComboBox);
            this.Controls.Add(this.itemsDataGridView);
            this.Controls.Add(this.button17);
            this.Controls.Add(dealIDLabel1);
            this.Controls.Add(this.dealIDTextBox1);
            this.Controls.Add(itemIDLabel);
            this.Controls.Add(this.itemIDComboBox);
            this.Controls.Add(itemAmountLabel);
            this.Controls.Add(this.itemAmountTextBox);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.branchesDataGridView);
            this.Controls.Add(this.buyersDataGridView);
            this.Controls.Add(dealBranchIDLabel1);
            this.Controls.Add(this.dealBranchIDComboBox);
            this.Controls.Add(dealBuyerIDLabel1);
            this.Controls.Add(this.dealBuyerIDComboBox);
            this.Controls.Add(dealIDLabel);
            this.Controls.Add(this.dealIDTextBox);
            this.Controls.Add(dealDateLabel);
            this.Controls.Add(this.dealDateDateTimePicker);
            this.Controls.Add(dealPayedLabel);
            this.Controls.Add(this.dealPayedCheckBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dealDataGridView);
            this.Name = "Deals";
            this.Text = "Deals";
            this.Load += new System.EventHandler(this.Deals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dealDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EBuyDataSet eBuyDataSet;
        private System.Windows.Forms.BindingSource dealBindingSource;
        private EBuyDataSetTableAdapters.DealTableAdapter dealTableAdapter;
        private EBuyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dealDataGridView;
        private EBuyDataSetTableAdapters.DealItemsTableAdapter dealItemsTableAdapter;
        private System.Windows.Forms.BindingSource dealItemsBindingSource;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dealIDTextBox;
        private System.Windows.Forms.DateTimePicker dealDateDateTimePicker;
        private System.Windows.Forms.CheckBox dealPayedCheckBox;
        private System.Windows.Forms.ComboBox dealBuyerIDComboBox;
        private System.Windows.Forms.ComboBox dealBranchIDComboBox;
        private EBuyDataSetTableAdapters.BuyersTableAdapter buyersTableAdapter;
        private System.Windows.Forms.BindingSource buyersBindingSource;
        private EBuyDataSetTableAdapters.BranchesTableAdapter branchesTableAdapter;
        private System.Windows.Forms.DataGridView buyersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private System.Windows.Forms.DataGridView branchesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox dealIDTextBox1;
        private System.Windows.Forms.ComboBox itemIDComboBox;
        private System.Windows.Forms.TextBox itemAmountTextBox;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private EBuyDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealBuyerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealBranchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dealPayedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dealSentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox senderIDComboBox;
        private System.Windows.Forms.CheckBox dealSentCheckBox;
        private System.Windows.Forms.DateTimePicker sentDateDateTimePicker;
        private System.Windows.Forms.TextBox itemAmountSentTextBox;
        private System.Windows.Forms.BindingSource sendersBindingSource;
        private EBuyDataSetTableAdapters.SendersTableAdapter sendersTableAdapter;
        private System.Windows.Forms.DataGridView sendersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView itemsDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dealItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
    }
}