using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace expensee
{
    public partial class ExpenseTrackerForm : Form
    {
        Entry entry = new Entry();
        public static List<string> Entries = new List<string>();
        public string dateRec = DateTime.Now.ToString("dd-MM-yyyy");
        public Int32 total = 0;

        public void GetData()
        {
            string strConnect = @"Database=ExpenseeDB;Data Source=NRWFEBRIANI;Initial Catalog=ExpenseeDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConnect);
            conn.Open();
            string CommandText, Output = "";
            CommandText = "SELECT ID,Title,Category,Expense,Date,Notes FROM Entries";
            SqlCommand command = new SqlCommand(CommandText, conn);       
            SqlDataReader dataReader = command.ExecuteReader();
                    
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + ". " + "Title: " + dataReader.GetValue(1) + "\n" + "Category: " + dataReader.GetValue(2) + "\n" + "Expense: " + dataReader.GetValue(3) + "\n" + "Date: " + dataReader.GetValue(4) + "\n" + "Notes: " + dataReader.GetValue(5) + "\n\n";
            }
            rtbExpenses.Text = Output;
            dataReader.Close();
            command.Dispose();
            conn.Close();
        }

        public void DeleteData(string EnterID)
        {
            string strConnect = @"Database=ExpenseeDB;Data Source=NRWFEBRIANI;Initial Catalog=ExpenseeDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConnect);
            conn.Open();
            String Command = "Delete Entries where ID=" + EnterID;
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand commands = new SqlCommand(Command, conn);

            adapter.DeleteCommand = new SqlCommand(Command, conn);
            adapter.DeleteCommand.ExecuteNonQuery();
            
            commands.Dispose();
            conn.Close();

            GetData();
        }

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
            GetData();
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
            GetData();

            Refresher();
        }

        public void Refresher()
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
            txtExpense.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtbExpenses.Clear();
            lblTotal.ResetText();

            string categoryX = Convert.ToString(entry.category);

            DataSet1TableAdapters.EntriesTableAdapter ada = new DataSet1TableAdapters.EntriesTableAdapter();
            ada.AddEntry(txtTitle.Text, categoryX, txtExpense.Text, dateRec, txtNotes.Text);

            Entries.Add("Title: " + txtTitle.Text);
            Entries.Add("Category: " + categoryX);
            Entries.Add("Expense: Rp" + txtExpense.Text);
            Entries.Add("Date: " + dateRec);
            Entries.Add("Notes: " + txtNotes.Text + "\n");

            MessageBox.Show("Entry saved!");
            GetData();
            Refresher();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateRec = date.Value.ToString("dd-MM-yyyy");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEntryForm delForm = new DeleteEntryForm();
            delForm.Show();
        }
    }
}
