namespace ULS
{
    partial class Form21OtPoOdnomuOtdeleniu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prihodndokumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izgotovitelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datepoluchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edinicizmereniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countizrashodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokgodnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarashodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otdelenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rashodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new ULS.BDDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbaseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrashodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otdelenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rashodTableAdapter = new ULS.BDDataSetTableAdapters.RashodTableAdapter();
            this.otdelenieTableAdapter = new ULS.BDDataSetTableAdapters.OtdelenieTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rashodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelenieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Конечная дата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Начальная дата:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(109, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker2.TabIndex = 72;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ULS.Properties.Resources._18;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(127, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 71;
            this.button2.Text = "Закрыть";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ULS.Properties.Resources._21;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(29, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 70;
            this.button1.Text = "Создать";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Отделение:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idbaseDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.postavkaDataGridViewTextBoxColumn,
            this.prihodndokumDataGridViewTextBoxColumn,
            this.izgotovitelDataGridViewTextBoxColumn,
            this.seriaDataGridViewTextBoxColumn,
            this.datepoluchDataGridViewTextBoxColumn,
            this.edinicizmereniaDataGridViewTextBoxColumn,
            this.countizrashodDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.srokgodnostiDataGridViewTextBoxColumn,
            this.datarashodDataGridViewTextBoxColumn,
            this.otdelenieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rashodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(236, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1074, 82);
            this.dataGridView1.TabIndex = 77;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idbaseDataGridViewTextBoxColumn
            // 
            this.idbaseDataGridViewTextBoxColumn.DataPropertyName = "idbase";
            this.idbaseDataGridViewTextBoxColumn.HeaderText = "idbase";
            this.idbaseDataGridViewTextBoxColumn.Name = "idbaseDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // postavkaDataGridViewTextBoxColumn
            // 
            this.postavkaDataGridViewTextBoxColumn.DataPropertyName = "postavka";
            this.postavkaDataGridViewTextBoxColumn.HeaderText = "postavka";
            this.postavkaDataGridViewTextBoxColumn.Name = "postavkaDataGridViewTextBoxColumn";
            // 
            // prihodndokumDataGridViewTextBoxColumn
            // 
            this.prihodndokumDataGridViewTextBoxColumn.DataPropertyName = "prihodndokum";
            this.prihodndokumDataGridViewTextBoxColumn.HeaderText = "prihodndokum";
            this.prihodndokumDataGridViewTextBoxColumn.Name = "prihodndokumDataGridViewTextBoxColumn";
            // 
            // izgotovitelDataGridViewTextBoxColumn
            // 
            this.izgotovitelDataGridViewTextBoxColumn.DataPropertyName = "izgotovitel";
            this.izgotovitelDataGridViewTextBoxColumn.HeaderText = "izgotovitel";
            this.izgotovitelDataGridViewTextBoxColumn.Name = "izgotovitelDataGridViewTextBoxColumn";
            // 
            // seriaDataGridViewTextBoxColumn
            // 
            this.seriaDataGridViewTextBoxColumn.DataPropertyName = "seria";
            this.seriaDataGridViewTextBoxColumn.HeaderText = "seria";
            this.seriaDataGridViewTextBoxColumn.Name = "seriaDataGridViewTextBoxColumn";
            // 
            // datepoluchDataGridViewTextBoxColumn
            // 
            this.datepoluchDataGridViewTextBoxColumn.DataPropertyName = "datepoluch";
            this.datepoluchDataGridViewTextBoxColumn.HeaderText = "datepoluch";
            this.datepoluchDataGridViewTextBoxColumn.Name = "datepoluchDataGridViewTextBoxColumn";
            // 
            // edinicizmereniaDataGridViewTextBoxColumn
            // 
            this.edinicizmereniaDataGridViewTextBoxColumn.DataPropertyName = "edinicizmerenia";
            this.edinicizmereniaDataGridViewTextBoxColumn.HeaderText = "edinicizmerenia";
            this.edinicizmereniaDataGridViewTextBoxColumn.Name = "edinicizmereniaDataGridViewTextBoxColumn";
            // 
            // countizrashodDataGridViewTextBoxColumn
            // 
            this.countizrashodDataGridViewTextBoxColumn.DataPropertyName = "countizrashod";
            this.countizrashodDataGridViewTextBoxColumn.HeaderText = "countizrashod";
            this.countizrashodDataGridViewTextBoxColumn.Name = "countizrashodDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // srokgodnostiDataGridViewTextBoxColumn
            // 
            this.srokgodnostiDataGridViewTextBoxColumn.DataPropertyName = "srokgodnosti";
            this.srokgodnostiDataGridViewTextBoxColumn.HeaderText = "srokgodnosti";
            this.srokgodnostiDataGridViewTextBoxColumn.Name = "srokgodnostiDataGridViewTextBoxColumn";
            // 
            // datarashodDataGridViewTextBoxColumn
            // 
            this.datarashodDataGridViewTextBoxColumn.DataPropertyName = "datarashod";
            this.datarashodDataGridViewTextBoxColumn.HeaderText = "datarashod";
            this.datarashodDataGridViewTextBoxColumn.Name = "datarashodDataGridViewTextBoxColumn";
            // 
            // otdelenieDataGridViewTextBoxColumn
            // 
            this.otdelenieDataGridViewTextBoxColumn.DataPropertyName = "otdelenie";
            this.otdelenieDataGridViewTextBoxColumn.HeaderText = "otdelenie";
            this.otdelenieDataGridViewTextBoxColumn.Name = "otdelenieDataGridViewTextBoxColumn";
            // 
            // rashodBindingSource
            // 
            this.rashodBindingSource.DataMember = "Rashod";
            this.rashodBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.idbaseDataGridViewTextBoxColumn1,
            this.idrashodDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.otdelenieBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(236, 97);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(246, 79);
            this.dataGridView2.TabIndex = 78;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // idbaseDataGridViewTextBoxColumn1
            // 
            this.idbaseDataGridViewTextBoxColumn1.DataPropertyName = "idbase";
            this.idbaseDataGridViewTextBoxColumn1.HeaderText = "idbase";
            this.idbaseDataGridViewTextBoxColumn1.Name = "idbaseDataGridViewTextBoxColumn1";
            // 
            // idrashodDataGridViewTextBoxColumn
            // 
            this.idrashodDataGridViewTextBoxColumn.DataPropertyName = "idrashod";
            this.idrashodDataGridViewTextBoxColumn.HeaderText = "idrashod";
            this.idrashodDataGridViewTextBoxColumn.Name = "idrashodDataGridViewTextBoxColumn";
            // 
            // otdelenieBindingSource
            // 
            this.otdelenieBindingSource.DataMember = "Otdelenie";
            this.otdelenieBindingSource.DataSource = this.bDDataSet;
            // 
            // rashodTableAdapter
            // 
            this.rashodTableAdapter.ClearBeforeFill = true;
            // 
            // otdelenieTableAdapter
            // 
            this.otdelenieTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImage = global::ULS.Properties.Resources._20;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(201, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(19, 20);
            this.button3.TabIndex = 80;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 79;
            // 
            // Form21OtPoOdnomuOtdeleniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 121);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form21OtPoOdnomuOtdeleniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отёт по отделению";
            this.Load += new System.EventHandler(this.Form21OtPoOdnomuOtdeleniu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rashodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelenieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource rashodBindingSource;
        private BDDataSetTableAdapters.RashodTableAdapter rashodTableAdapter;
        private System.Windows.Forms.BindingSource otdelenieBindingSource;
        private BDDataSetTableAdapters.OtdelenieTableAdapter otdelenieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbaseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrashodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prihodndokumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izgotovitelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datepoluchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edinicizmereniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countizrashodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokgodnostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarashodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otdelenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}