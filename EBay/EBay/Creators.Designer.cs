namespace EBay
{
    partial class Creators
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
            System.Windows.Forms.Label creatorIDLabel;
            System.Windows.Forms.Label creatorNameLabel;
            System.Windows.Forms.Label creatorCountryLabel;
            this.eBuyDataSet = new EBay.EBuyDataSet();
            this.creatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creatorsTableAdapter = new EBay.EBuyDataSetTableAdapters.CreatorsTableAdapter();
            this.tableAdapterManager = new EBay.EBuyDataSetTableAdapters.TableAdapterManager();
            this.creatorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorIDTextBox = new System.Windows.Forms.TextBox();
            this.creatorNameTextBox = new System.Windows.Forms.TextBox();
            this.creatorCountryTextBox = new System.Windows.Forms.TextBox();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            creatorIDLabel = new System.Windows.Forms.Label();
            creatorNameLabel = new System.Windows.Forms.Label();
            creatorCountryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eBuyDataSet
            // 
            this.eBuyDataSet.DataSetName = "EBuyDataSet";
            this.eBuyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // creatorsBindingSource
            // 
            this.creatorsBindingSource.DataMember = "Creators";
            this.creatorsBindingSource.DataSource = this.eBuyDataSet;
            // 
            // creatorsTableAdapter
            // 
            this.creatorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchesTableAdapter = null;
            this.tableAdapterManager.BuyersTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CountriesTableAdapter = null;
            this.tableAdapterManager.CreatorsTableAdapter = this.creatorsTableAdapter;
            this.tableAdapterManager.DealItemsTableAdapter = null;
            this.tableAdapterManager.DealTableAdapter = null;
            this.tableAdapterManager.ImportersTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EBay.EBuyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // creatorsDataGridView
            // 
            this.creatorsDataGridView.AutoGenerateColumns = false;
            this.creatorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creatorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.creatorsDataGridView.DataSource = this.creatorsBindingSource;
            this.creatorsDataGridView.Location = new System.Drawing.Point(86, 188);
            this.creatorsDataGridView.Name = "creatorsDataGridView";
            this.creatorsDataGridView.Size = new System.Drawing.Size(462, 220);
            this.creatorsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CreatorID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CreatorID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreatorName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreatorName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CreatorCountry";
            this.dataGridViewTextBoxColumn3.HeaderText = "CreatorCountry";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // creatorIDLabel
            // 
            creatorIDLabel.AutoSize = true;
            creatorIDLabel.Location = new System.Drawing.Point(83, 23);
            creatorIDLabel.Name = "creatorIDLabel";
            creatorIDLabel.Size = new System.Drawing.Size(58, 13);
            creatorIDLabel.TabIndex = 1;
            creatorIDLabel.Text = "Creator ID:";
            // 
            // creatorIDTextBox
            // 
            this.creatorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creatorsBindingSource, "CreatorID", true));
            this.creatorIDTextBox.Enabled = false;
            this.creatorIDTextBox.Location = new System.Drawing.Point(172, 20);
            this.creatorIDTextBox.Name = "creatorIDTextBox";
            this.creatorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatorIDTextBox.TabIndex = 2;
            // 
            // creatorNameLabel
            // 
            creatorNameLabel.AutoSize = true;
            creatorNameLabel.Location = new System.Drawing.Point(83, 49);
            creatorNameLabel.Name = "creatorNameLabel";
            creatorNameLabel.Size = new System.Drawing.Size(75, 13);
            creatorNameLabel.TabIndex = 3;
            creatorNameLabel.Text = "Creator Name:";
            // 
            // creatorNameTextBox
            // 
            this.creatorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creatorsBindingSource, "CreatorName", true));
            this.creatorNameTextBox.Location = new System.Drawing.Point(172, 46);
            this.creatorNameTextBox.Name = "creatorNameTextBox";
            this.creatorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatorNameTextBox.TabIndex = 4;
            // 
            // creatorCountryLabel
            // 
            creatorCountryLabel.AutoSize = true;
            creatorCountryLabel.Location = new System.Drawing.Point(83, 75);
            creatorCountryLabel.Name = "creatorCountryLabel";
            creatorCountryLabel.Size = new System.Drawing.Size(83, 13);
            creatorCountryLabel.TabIndex = 5;
            creatorCountryLabel.Text = "Creator Country:";
            // 
            // creatorCountryTextBox
            // 
            this.creatorCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creatorsBindingSource, "CreatorCountry", true));
            this.creatorCountryTextBox.Location = new System.Drawing.Point(172, 72);
            this.creatorCountryTextBox.Name = "creatorCountryTextBox";
            this.creatorCountryTextBox.Size = new System.Drawing.Size(100, 20);
            this.creatorCountryTextBox.TabIndex = 6;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(552, 116);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 32;
            this.button10.Text = "Cancel";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(450, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 31;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(369, 88);
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
            this.button8.Location = new System.Drawing.Point(562, 41);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 29;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(480, 42);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 28;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(398, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(317, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "First";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(450, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 34;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(369, 138);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 33;
            this.button12.Text = "Search";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search by ID or Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Search by Country";
            // 
            // Creators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button12);
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
            this.Controls.Add(creatorIDLabel);
            this.Controls.Add(this.creatorIDTextBox);
            this.Controls.Add(creatorNameLabel);
            this.Controls.Add(this.creatorNameTextBox);
            this.Controls.Add(creatorCountryLabel);
            this.Controls.Add(this.creatorCountryTextBox);
            this.Controls.Add(this.creatorsDataGridView);
            this.Name = "Creators";
            this.Text = "Creators";
            this.Load += new System.EventHandler(this.Creators_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBuyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EBuyDataSet eBuyDataSet;
        private System.Windows.Forms.BindingSource creatorsBindingSource;
        private EBuyDataSetTableAdapters.CreatorsTableAdapter creatorsTableAdapter;
        private EBuyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView creatorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox creatorIDTextBox;
        private System.Windows.Forms.TextBox creatorNameTextBox;
        private System.Windows.Forms.TextBox creatorCountryTextBox;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}