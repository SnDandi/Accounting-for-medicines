﻿namespace ULS
{
    partial class Form18_OtoRashodeMedSDate
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
            this.rashodTableAdapter = new ULS.BDDataSetTableAdapters.RashodTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rashodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Конечная дата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Начальная дата:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(109, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker2.TabIndex = 54;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::ULS.Properties.Resources._18;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(128, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Закрыть";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ULS.Properties.Resources._21;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(30, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 52;
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
            this.dateTimePicker1.TabIndex = 51;
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
            this.dataGridView1.Location = new System.Drawing.Point(242, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1074, 82);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.Visible = false;
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
            // rashodTableAdapter
            // 
            this.rashodTableAdapter.ClearBeforeFill = true;
            // 
            // Form18_OtoRashodeMedSDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 95);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form18_OtoRashodeMedSDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Общий расход с выводом даты";
            this.Load += new System.EventHandler(this.Form18_OtoRashodeMedSDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rashodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource rashodBindingSource;
        private BDDataSetTableAdapters.RashodTableAdapter rashodTableAdapter;
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
    }
}