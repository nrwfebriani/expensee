
namespace expensee
{
    partial class ViewAllForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.rbEdu = new System.Windows.Forms.RadioButton();
            this.rbOthers = new System.Windows.Forms.RadioButton();
            this.rbEnt = new System.Windows.Forms.RadioButton();
            this.rbBills = new System.Windows.Forms.RadioButton();
            this.rbFnB = new System.Windows.Forms.RadioButton();
            this.rbTrans = new System.Windows.Forms.RadioButton();
            this.rbGift = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbGroceries = new System.Windows.Forms.RadioButton();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(442, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(523, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(56, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Expense:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(30, 268);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(159, 25);
            this.date.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(26, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Date:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.rbEdu);
            this.gbCategory.Controls.Add(this.rbOthers);
            this.gbCategory.Controls.Add(this.rbEnt);
            this.gbCategory.Controls.Add(this.rbBills);
            this.gbCategory.Controls.Add(this.rbFnB);
            this.gbCategory.Controls.Add(this.rbTrans);
            this.gbCategory.Controls.Add(this.rbGift);
            this.gbCategory.Controls.Add(this.rbMed);
            this.gbCategory.Controls.Add(this.rbGroceries);
            this.gbCategory.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCategory.Location = new System.Drawing.Point(23, 98);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(389, 125);
            this.gbCategory.TabIndex = 40;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Select category:";
            // 
            // rbEdu
            // 
            this.rbEdu.AutoSize = true;
            this.rbEdu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEdu.Location = new System.Drawing.Point(14, 26);
            this.rbEdu.Name = "rbEdu";
            this.rbEdu.Size = new System.Drawing.Size(87, 23);
            this.rbEdu.TabIndex = 25;
            this.rbEdu.TabStop = true;
            this.rbEdu.Text = "Education";
            this.rbEdu.UseVisualStyleBackColor = true;
            // 
            // rbOthers
            // 
            this.rbOthers.AutoSize = true;
            this.rbOthers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbOthers.Location = new System.Drawing.Point(267, 84);
            this.rbOthers.Name = "rbOthers";
            this.rbOthers.Size = new System.Drawing.Size(69, 23);
            this.rbOthers.TabIndex = 33;
            this.rbOthers.TabStop = true;
            this.rbOthers.Text = "Others";
            this.rbOthers.UseVisualStyleBackColor = true;
            // 
            // rbEnt
            // 
            this.rbEnt.AutoSize = true;
            this.rbEnt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEnt.Location = new System.Drawing.Point(14, 55);
            this.rbEnt.Name = "rbEnt";
            this.rbEnt.Size = new System.Drawing.Size(114, 23);
            this.rbEnt.TabIndex = 26;
            this.rbEnt.TabStop = true;
            this.rbEnt.Text = "Entertainment";
            this.rbEnt.UseVisualStyleBackColor = true;
            // 
            // rbBills
            // 
            this.rbBills.AutoSize = true;
            this.rbBills.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbBills.Location = new System.Drawing.Point(267, 55);
            this.rbBills.Name = "rbBills";
            this.rbBills.Size = new System.Drawing.Size(50, 23);
            this.rbBills.TabIndex = 32;
            this.rbBills.TabStop = true;
            this.rbBills.Text = "Bills";
            this.rbBills.UseVisualStyleBackColor = true;
            // 
            // rbFnB
            // 
            this.rbFnB.AutoSize = true;
            this.rbFnB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFnB.Location = new System.Drawing.Point(14, 84);
            this.rbFnB.Name = "rbFnB";
            this.rbFnB.Size = new System.Drawing.Size(126, 23);
            this.rbFnB.TabIndex = 27;
            this.rbFnB.TabStop = true;
            this.rbFnB.Text = "Food-Beverages";
            this.rbFnB.UseVisualStyleBackColor = true;
            // 
            // rbTrans
            // 
            this.rbTrans.AutoSize = true;
            this.rbTrans.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbTrans.Location = new System.Drawing.Point(267, 26);
            this.rbTrans.Name = "rbTrans";
            this.rbTrans.Size = new System.Drawing.Size(116, 23);
            this.rbTrans.TabIndex = 31;
            this.rbTrans.TabStop = true;
            this.rbTrans.Text = "Transportation";
            this.rbTrans.UseVisualStyleBackColor = true;
            // 
            // rbGift
            // 
            this.rbGift.AutoSize = true;
            this.rbGift.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbGift.Location = new System.Drawing.Point(157, 26);
            this.rbGift.Name = "rbGift";
            this.rbGift.Size = new System.Drawing.Size(49, 23);
            this.rbGift.TabIndex = 28;
            this.rbGift.TabStop = true;
            this.rbGift.Text = "Gift";
            this.rbGift.UseVisualStyleBackColor = true;
            // 
            // rbMed
            // 
            this.rbMed.AutoSize = true;
            this.rbMed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMed.Location = new System.Drawing.Point(157, 84);
            this.rbMed.Name = "rbMed";
            this.rbMed.Size = new System.Drawing.Size(95, 23);
            this.rbMed.TabIndex = 30;
            this.rbMed.TabStop = true;
            this.rbMed.Text = "Medication";
            this.rbMed.UseVisualStyleBackColor = true;
            // 
            // rbGroceries
            // 
            this.rbGroceries.AutoSize = true;
            this.rbGroceries.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbGroceries.Location = new System.Drawing.Point(157, 55);
            this.rbGroceries.Name = "rbGroceries";
            this.rbGroceries.Size = new System.Drawing.Size(84, 23);
            this.rbGroceries.TabIndex = 29;
            this.rbGroceries.TabStop = true;
            this.rbGroceries.Text = "Groceries";
            this.rbGroceries.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(30, 52);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(211, 23);
            this.txtTitle.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Title: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewAllForm";
            this.Text = "expensee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.RadioButton rbEdu;
        private System.Windows.Forms.RadioButton rbOthers;
        private System.Windows.Forms.RadioButton rbEnt;
        private System.Windows.Forms.RadioButton rbBills;
        private System.Windows.Forms.RadioButton rbFnB;
        private System.Windows.Forms.RadioButton rbTrans;
        private System.Windows.Forms.RadioButton rbGift;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbGroceries;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
    }
}