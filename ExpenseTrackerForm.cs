using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace expensee
{
    public partial class ExpenseTrackerForm : Form
    {
        Entry entry = new Entry();
        public static List<string> Entries = new List<string>();
        public string dateRec = DateTime.Now.ToString("dd-MM-yyyy");
        public Int32 total = 0;

        public ExpenseTrackerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGift.Checked == true)
            {
                chkBills.Checked = false;
                chkEnt.Checked = false;
                chkFB.Checked = false;
                chkEdu.Checked = false;
                chkGroceries.Checked = false;
                chkMed.Checked = false;
                chkTrans.Checked = false;
                chkOthers.Checked = false;
                entry.category = "Gift";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGroceries.Checked == true)
            {
                chkBills.Checked = false;
                chkEnt.Checked = false;
                chkFB.Checked = false;
                chkGift.Checked = false;
                chkEdu.Checked = false;
                chkMed.Checked = false;
                chkTrans.Checked = false;
                chkOthers.Checked = false;
                entry.category = "Groceries";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnt.Checked == true)
            {
                chkBills.Checked = false;
                chkEdu.Checked = false;
                chkFB.Checked = false;
                chkGift.Checked = false;
                chkGroceries.Checked = false;
                chkMed.Checked = false;
                chkTrans.Checked = false;
                chkOthers.Checked = false;
                entry.category = "Entertainment";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtExpense.Text = "0";
            txtNotes.Text = "";
            txtTitle.Text = "";
            chkEdu.Checked = false;
            chkBills.Checked = false;
            chkEnt.Checked = false;
            chkFB.Checked = false;
            chkGift.Checked = false;
            chkGroceries.Checked = false;
            chkMed.Checked = false;
            chkTrans.Checked = false;
            chkOthers.Checked = false;
            lblTotal.Text = "0";
            rtbExpenses.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkEdu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEdu.Checked == true)
            {
                chkBills.Checked = false;
                chkEnt.Checked = false;
                chkFB.Checked = false;
                chkGift.Checked = false;
                chkGroceries.Checked = false;
                chkMed.Checked = false;
                chkTrans.Checked = false;
                chkOthers.Checked = false;
                entry.category = "Education";
            }
        }

        private void chkFB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFB.Checked == true)
            {
                chkBills.Checked = false;
                chkEnt.Checked = false;
                chkEdu.Checked = false;
                chkGift.Checked = false;
                chkGroceries.Checked = false;
                chkMed.Checked = false;
                chkTrans.Checked = false;
                chkOthers.Checked = false;
                entry.category = "Food-Beverages";
            }
        }

        private void chkMed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMed.Checked == true)
            {
                chkBills.Checked = false;
                chkEnt.Checked = false;
                chkFB.Checked = false;
                chkGift.Checked = false;
                chkGroceries.Checked = false;
                chkEdu.Checked = false;
                chkTrans.Checked = false;
                chkOthers.Checked = false;
                entry.category = "Medications";
            }
        }

        private void chkTrans_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrans.Checked == true)
            {
                chkBills.Checked = false;
                chkEnt.Checked = false;
                chkFB.Checked = false;
                chkGift.Checked = false;
                chkGroceries.Checked = false;
                chkMed.Checked = false;
                chkEdu.Checked = false;
                chkOthers.Checked = false;
                entry.category = "Transportation";
            }
        }

        private void chkBills_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBills.Checked == true)
            {
                chkEdu.Checked = false;
                chkEnt.Checked = false;
                chkFB.Checked = false;
                chkGift.Checked = false;
                chkGroceries.Checked = false;
                chkMed.Checked = false;
                chkTrans.Checked = false;
                chkOthers.Checked = false;
                entry.category = "Bills";
            }

        }

        private void chkOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOthers.Checked == true)
            {
                chkBills.Checked = false;
                chkEnt.Checked = false;
                chkFB.Checked = false;
                chkGift.Checked = false;
                chkGroceries.Checked = false;
                chkMed.Checked = false;
                chkTrans.Checked = false;
                chkEdu.Checked = false;
                entry.category = "Others";
            }
        }

        private void lstExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtExpense_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtExpense.Text, "[^0-9]"))
            {
                txtExpense.Text = "";
            }
        }

        private void txtExpense_DoubleClick(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtExpense.Text, "[^0-9]"))
            {
                txtExpense.Text = "";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            string combinedEntries = string.Join("\n", Entries);

            Int32 expenseP = Convert.ToInt32(txtExpense.Text);
            Int32 temp = expenseP;
            total = total + temp;
            lblTotal.Text = Convert.ToString(total);

            rtbExpenses.AppendText(combinedEntries);

            txtExpense.Text = "0";
            txtNotes.Text = "";
            txtTitle.Text = "";
            chkEdu.Checked = false;
            chkBills.Checked = false;
            chkEnt.Checked = false;
            chkFB.Checked = false;
            chkGift.Checked = false;
            chkGroceries.Checked = false;
            chkMed.Checked = false;
            chkTrans.Checked = false;
            chkOthers.Checked = false;
            txtExpense.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtbExpenses.Clear();
            lblTotal.ResetText();

            string categoryX = Convert.ToString(entry.category);

            Entries.Add("Title: " + txtTitle.Text);
            Entries.Add("Category: " + categoryX);
            Entries.Add("Expense: Rp" + txtExpense.Text);
            Entries.Add("Date: " + dateRec);
            Entries.Add("Notes: " + txtNotes.Text + "\n");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateRec = date.Value.ToString("dd-MM-yyyy");
        }
    }
}
