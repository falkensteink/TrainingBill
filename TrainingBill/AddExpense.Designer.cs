namespace TrainingBill
{
    partial class AddExpense
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.Intro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbExpenseTypes = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(77, 248);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Intro
            // 
            this.Intro.Location = new System.Drawing.Point(47, 24);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(272, 40);
            this.Intro.TabIndex = 1;
            this.Intro.Text = "Title";
            this.Intro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expense Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expense Month";
            // 
            // cbExpenseTypes
            // 
            this.cbExpenseTypes.FormattingEnabled = true;
            this.cbExpenseTypes.Location = new System.Drawing.Point(149, 82);
            this.cbExpenseTypes.Name = "cbExpenseTypes";
            this.cbExpenseTypes.Size = new System.Drawing.Size(121, 21);
            this.cbExpenseTypes.TabIndex = 4;
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(149, 112);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 21);
            this.cbMonth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Expense Amount";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(149, 141);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(121, 20);
            this.txtExpenseAmount.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(219, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 317);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.cbExpenseTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Intro);
            this.Controls.Add(this.btnSubmit);
            this.Name = "AddExpense";
            this.Text = "AddExpense";
            this.Load += new System.EventHandler(this.AddExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label Intro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbExpenseTypes;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.Button btnCancel;
    }
}