namespace TrainingBill
{
    partial class MonthlyRollup
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
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnMiscExpense = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvMonthlyRollup = new System.Windows.Forms.DataGridView();
            this.trainingBillDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingBillDataSet = new TrainingBill.TrainingBillDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyRollup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingBillDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingBillDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(489, 12);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(120, 41);
            this.btnAddExpense.TabIndex = 0;
            this.btnAddExpense.Text = "Add Expense To Horse";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnMiscExpense
            // 
            this.btnMiscExpense.Location = new System.Drawing.Point(489, 59);
            this.btnMiscExpense.Name = "btnMiscExpense";
            this.btnMiscExpense.Size = new System.Drawing.Size(120, 41);
            this.btnMiscExpense.TabIndex = 1;
            this.btnMiscExpense.Text = "Miscellaneous Expense";
            this.btnMiscExpense.UseVisualStyleBackColor = true;
            this.btnMiscExpense.Click += new System.EventHandler(this.btnMiscExpense_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(489, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reports";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(615, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvMonthlyRollup
            // 
            this.dgvMonthlyRollup.AllowUserToAddRows = false;
            this.dgvMonthlyRollup.AllowUserToDeleteRows = false;
            this.dgvMonthlyRollup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthlyRollup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyRollup.Location = new System.Drawing.Point(12, 61);
            this.dgvMonthlyRollup.MultiSelect = false;
            this.dgvMonthlyRollup.Name = "dgvMonthlyRollup";
            this.dgvMonthlyRollup.ReadOnly = true;
            this.dgvMonthlyRollup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonthlyRollup.Size = new System.Drawing.Size(349, 150);
            this.dgvMonthlyRollup.TabIndex = 4;
            this.dgvMonthlyRollup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonthlyRollup_CellContentClick);
            // 
            // trainingBillDataSetBindingSource
            // 
            this.trainingBillDataSetBindingSource.DataSource = this.trainingBillDataSet;
            this.trainingBillDataSetBindingSource.Position = 0;
            // 
            // trainingBillDataSet
            // 
            this.trainingBillDataSet.DataSetName = "TrainingBillDataSet";
            this.trainingBillDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MonthlyRollup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 406);
            this.Controls.Add(this.dgvMonthlyRollup);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMiscExpense);
            this.Controls.Add(this.btnAddExpense);
            this.Name = "MonthlyRollup";
            this.Text = "Monthly Rollup";
            this.Load += new System.EventHandler(this.MonthlyRollup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyRollup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingBillDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingBillDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnMiscExpense;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMonthlyRollup;
        private System.Windows.Forms.BindingSource trainingBillDataSetBindingSource;
        private TrainingBillDataSet trainingBillDataSet;
    }
}

