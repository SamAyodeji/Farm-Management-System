namespace Farm
{
    partial class Report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._FARM_DBDataSet = new Farm._FARM_DBDataSet();
            this.transDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transDBTableAdapter = new Farm._FARM_DBDataSetTableAdapters.TransDBTableAdapter();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicationAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._FARM_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.batchnumberDataGridViewTextBoxColumn,
            this.mortalityDataGridViewTextBoxColumn,
            this.feedDataGridViewTextBoxColumn,
            this.medicationTypeDataGridViewTextBoxColumn,
            this.medicationAmtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // _FARM_DBDataSet
            // 
            this._FARM_DBDataSet.DataSetName = "_FARM_DBDataSet";
            this._FARM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transDBBindingSource
            // 
            this.transDBBindingSource.DataMember = "TransDB";
            this.transDBBindingSource.DataSource = this._FARM_DBDataSet;
            // 
            // transDBTableAdapter
            // 
            this.transDBTableAdapter.ClearBeforeFill = true;
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "s/n";
            this.snDataGridViewTextBoxColumn.HeaderText = "s/n";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            this.snDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // batchnumberDataGridViewTextBoxColumn
            // 
            this.batchnumberDataGridViewTextBoxColumn.DataPropertyName = "Batch_number";
            this.batchnumberDataGridViewTextBoxColumn.HeaderText = "Batch_number";
            this.batchnumberDataGridViewTextBoxColumn.Name = "batchnumberDataGridViewTextBoxColumn";
            // 
            // mortalityDataGridViewTextBoxColumn
            // 
            this.mortalityDataGridViewTextBoxColumn.DataPropertyName = "Mortality";
            this.mortalityDataGridViewTextBoxColumn.HeaderText = "Mortality";
            this.mortalityDataGridViewTextBoxColumn.Name = "mortalityDataGridViewTextBoxColumn";
            // 
            // feedDataGridViewTextBoxColumn
            // 
            this.feedDataGridViewTextBoxColumn.DataPropertyName = "Feed";
            this.feedDataGridViewTextBoxColumn.HeaderText = "Feed";
            this.feedDataGridViewTextBoxColumn.Name = "feedDataGridViewTextBoxColumn";
            // 
            // medicationTypeDataGridViewTextBoxColumn
            // 
            this.medicationTypeDataGridViewTextBoxColumn.DataPropertyName = "Medication_Type";
            this.medicationTypeDataGridViewTextBoxColumn.HeaderText = "Medication_Type";
            this.medicationTypeDataGridViewTextBoxColumn.Name = "medicationTypeDataGridViewTextBoxColumn";
            // 
            // medicationAmtDataGridViewTextBoxColumn
            // 
            this.medicationAmtDataGridViewTextBoxColumn.DataPropertyName = "Medication_Amt";
            this.medicationAmtDataGridViewTextBoxColumn.HeaderText = "Medication_Amt";
            this.medicationAmtDataGridViewTextBoxColumn.Name = "medicationAmtDataGridViewTextBoxColumn";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 421);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report";
            this.Text = "REPORT";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._FARM_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _FARM_DBDataSet _FARM_DBDataSet;
        private System.Windows.Forms.BindingSource transDBBindingSource;
        private _FARM_DBDataSetTableAdapters.TransDBTableAdapter transDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicationAmtDataGridViewTextBoxColumn;

    }
}