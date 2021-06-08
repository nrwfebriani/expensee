
namespace expensee
{
    partial class ExpenseTrackerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbEdu = new System.Windows.Forms.RadioButton();
            this.rbEnt = new System.Windows.Forms.RadioButton();
            this.rbFnB = new System.Windows.Forms.RadioButton();
            this.rbGift = new System.Windows.Forms.RadioButton();
            this.rbGroceries = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbTrans = new System.Windows.Forms.RadioButton();
            this.rbBills = new System.Windows.Forms.RadioButton();
            this.rbOthers = new System.Windows.Forms.RadioButton();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresher2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 52);
            this.panel1.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Webdings", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(667, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 34);
            this.label19.TabIndex = 25;
            this.label19.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Webdings", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(371, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 34);
            this.label18.TabIndex = 24;
            this.label18.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Beauty and the Beast", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(459, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "e x p e n s e e";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(29, 101);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(262, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(31, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Expense:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(35, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "IDR";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExpense
            // 
            this.txtExpense.Location = new System.Drawing.Point(77, 408);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.PlaceholderText = "ex: 100000";
            this.txtExpense.Size = new System.Drawing.Size(185, 23);
            this.txtExpense.TabIndex = 16;
            this.txtExpense.TextChanged += new System.EventHandler(this.txtExpense_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(31, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Date:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Location = new System.Drawing.Point(35, 325);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(159, 25);
            this.dtpDate.TabIndex = 16;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(30, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Notes: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(98, 454);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(317, 86);
            this.txtNotes.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Futura Md BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(758, 852);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "Expense:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(26, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(341, 560);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(746, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(773, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Title: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbEdu
            // 
            this.rbEdu.AutoSize = true;
            this.rbEdu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEdu.Location = new System.Drawing.Point(14, 35);
            this.rbEdu.Name = "rbEdu";
            this.rbEdu.Size = new System.Drawing.Size(87, 23);
            this.rbEdu.TabIndex = 25;
            this.rbEdu.TabStop = true;
            this.rbEdu.Text = "Education";
            this.rbEdu.UseVisualStyleBackColor = true;
            // 
            // rbEnt
            // 
            this.rbEnt.AutoSize = true;
            this.rbEnt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEnt.Location = new System.Drawing.Point(14, 64);
            this.rbEnt.Name = "rbEnt";
            this.rbEnt.Size = new System.Drawing.Size(114, 23);
            this.rbEnt.TabIndex = 26;
            this.rbEnt.TabStop = true;
            this.rbEnt.Text = "Entertainment";
            this.rbEnt.UseVisualStyleBackColor = true;
            // 
            // rbFnB
            // 
            this.rbFnB.AutoSize = true;
            this.rbFnB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFnB.Location = new System.Drawing.Point(14, 93);
            this.rbFnB.Name = "rbFnB";
            this.rbFnB.Size = new System.Drawing.Size(126, 23);
            this.rbFnB.TabIndex = 27;
            this.rbFnB.TabStop = true;
            this.rbFnB.Text = "Food-Beverages";
            this.rbFnB.UseVisualStyleBackColor = true;
            // 
            // rbGift
            // 
            this.rbGift.AutoSize = true;
            this.rbGift.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbGift.Location = new System.Drawing.Point(157, 35);
            this.rbGift.Name = "rbGift";
            this.rbGift.Size = new System.Drawing.Size(49, 23);
            this.rbGift.TabIndex = 28;
            this.rbGift.TabStop = true;
            this.rbGift.Text = "Gift";
            this.rbGift.UseVisualStyleBackColor = true;
            // 
            // rbGroceries
            // 
            this.rbGroceries.AutoSize = true;
            this.rbGroceries.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbGroceries.Location = new System.Drawing.Point(157, 64);
            this.rbGroceries.Name = "rbGroceries";
            this.rbGroceries.Size = new System.Drawing.Size(84, 23);
            this.rbGroceries.TabIndex = 29;
            this.rbGroceries.TabStop = true;
            this.rbGroceries.Text = "Groceries";
            this.rbGroceries.UseVisualStyleBackColor = true;
            // 
            // rbMed
            // 
            this.rbMed.AutoSize = true;
            this.rbMed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMed.Location = new System.Drawing.Point(157, 93);
            this.rbMed.Name = "rbMed";
            this.rbMed.Size = new System.Drawing.Size(95, 23);
            this.rbMed.TabIndex = 30;
            this.rbMed.TabStop = true;
            this.rbMed.Text = "Medication";
            this.rbMed.UseVisualStyleBackColor = true;
            // 
            // rbTrans
            // 
            this.rbTrans.AutoSize = true;
            this.rbTrans.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbTrans.Location = new System.Drawing.Point(267, 35);
            this.rbTrans.Name = "rbTrans";
            this.rbTrans.Size = new System.Drawing.Size(116, 23);
            this.rbTrans.TabIndex = 31;
            this.rbTrans.TabStop = true;
            this.rbTrans.Text = "Transportation";
            this.rbTrans.UseVisualStyleBackColor = true;
            // 
            // rbBills
            // 
            this.rbBills.AutoSize = true;
            this.rbBills.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbBills.Location = new System.Drawing.Point(267, 64);
            this.rbBills.Name = "rbBills";
            this.rbBills.Size = new System.Drawing.Size(50, 23);
            this.rbBills.TabIndex = 32;
            this.rbBills.TabStop = true;
            this.rbBills.Text = "Bills";
            this.rbBills.UseVisualStyleBackColor = true;
            // 
            // rbOthers
            // 
            this.rbOthers.AutoSize = true;
            this.rbOthers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbOthers.Location = new System.Drawing.Point(267, 93);
            this.rbOthers.Name = "rbOthers";
            this.rbOthers.Size = new System.Drawing.Size(69, 23);
            this.rbOthers.TabIndex = 33;
            this.rbOthers.TabStop = true;
            this.rbOthers.Text = "Others";
            this.rbOthers.UseVisualStyleBackColor = true;
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
            this.gbCategory.Location = new System.Drawing.Point(26, 147);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(389, 136);
            this.gbCategory.TabIndex = 34;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Select category:";
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(451, 131);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowTemplate.Height = 25;
            this.dgvTable.Size = new System.Drawing.Size(641, 409);
            this.dgvTable.TabIndex = 36;
            this.dgvTable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTable_RowHeaderMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(451, 89);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by title";
            this.txtSearch.Size = new System.Drawing.Size(303, 23);
            this.txtSearch.TabIndex = 37;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(26, 560);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1017, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresher2
            // 
            this.btnRefresher2.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresher2.Location = new System.Drawing.Point(877, 86);
            this.btnRefresher2.Name = "btnRefresher2";
            this.btnRefresher2.Size = new System.Drawing.Size(29, 27);
            this.btnRefresher2.TabIndex = 41;
            this.btnRefresher2.Text = "";
            this.btnRefresher2.UseVisualStyleBackColor = true;
            this.btnRefresher2.Click += new System.EventHandler(this.btnRefresher2_Click);
            // 
            // ExpenseTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1103, 589);
            this.Controls.Add(this.btnRefresher2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "ExpenseTrackerForm";
            this.Text = "expensee";
            this.Load += new System.EventHandler(this.ExpenseTrackerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbEdu;
        private System.Windows.Forms.RadioButton rbEnt;
        private System.Windows.Forms.RadioButton rbFnB;
        private System.Windows.Forms.RadioButton rbGift;
        private System.Windows.Forms.RadioButton rbGroceries;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbTrans;
        private System.Windows.Forms.RadioButton rbBills;
        private System.Windows.Forms.RadioButton rbOthers;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresher2;
    }
}

