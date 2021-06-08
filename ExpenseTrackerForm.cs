using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace expensee
{
    public partial class ExpenseTrackerForm : Form
    {
        Entry entry = new Entry();
        Int32 expense, ID = 0;
        SqlConnection conn = new SqlConnection(@"Database=ExpenseeDB;Data Source=NRWFEBRIANI;Initial Catalog=ExpenseeDB;Integrated Security=True");
        SqlCommand command;
        DateTime dateRec = DateTime.Now;

        public ExpenseTrackerForm()
        {
            InitializeComponent();
        }

        private void ExpenseTrackerForm_Load(object sender, EventArgs e)
        {
            Load_Table();
            btnUpdate.Hide();
        }

        private void Load_Table()
        {
            conn.Open();
            command = new SqlCommand("SELECT * FROM Entries", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;
            DataTable dbtable = new DataTable();
            sda.Fill(dbtable);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbtable;
            dgvTable.DataSource = bSource;
            sda.Update(dbtable);
            conn.Close();
        }

        private void Load_Search()
        {
            conn.Open();
            command = new SqlCommand("SELECT * FROM Entries WHERE Title=@search", conn);
            command.Parameters.Add(new SqlParameter("@search", txtSearch.Text));
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;
            DataTable dbTable = new DataTable();
            sda.Fill(dbTable);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbTable;
            dgvTable.DataSource = bSource;
            sda.Update(dbTable);
            conn.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
            txtSearch.Text = "";
            Load_Table();
            btnUpdate.Hide();
            btnSave.Show();
        }

        private void ResetForm()
        {
            ID = 0;
            txtExpense.Text = "0";
            txtNotes.Text = "";
            txtTitle.Text = "";
            rbEdu.Checked = false;
            rbBills.Checked = false;
            rbEnt.Checked = false;
            rbFnB.Checked = false;
            rbGift.Checked = false;
            rbGroceries.Checked = false;
            rbMed.Checked = false;
            rbTrans.Checked = false;
            rbOthers.Checked = false;
            dtpDate.Value = DateTime.Now;
    }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtExpense_TextChanged(object sender, EventArgs e)
        {
            expense = Convert.ToInt32(txtExpense.Text);
        }

        private void GetCategory(RadioButton rb)
        {
            if (rb.Checked)
            {
                entry.category = rb.Text;
            }
        }

        private void GetCategory2()
        {
            GetCategory(rbEnt);
            GetCategory(rbEdu);
            GetCategory(rbFnB);
            GetCategory(rbMed);
            GetCategory(rbOthers);
            GetCategory(rbBills);
            GetCategory(rbGift);
            GetCategory(rbGroceries);
            GetCategory(rbTrans);
        }

        private void CheckCategory(RadioButton rb)
        {
            if (entry.category == rb.Text)
            {
                rb.Checked = true;
            }
        }        

        private void CheckCategory2()
        {
            CheckCategory(rbEnt);
            CheckCategory(rbEdu);
            CheckCategory(rbFnB);
            CheckCategory(rbMed);
            CheckCategory(rbOthers);
            CheckCategory(rbBills);
            CheckCategory(rbGift);
            CheckCategory(rbGroceries);
            CheckCategory(rbTrans);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            entry.title = txtTitle.Text;
            entry.date = dateRec;
            entry.expense = expense;
            entry.notes = txtNotes.Text;

            GetCategory2();

            conn.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Entries(Title, Category, Expense, Date, Notes) VALUES(@Title, @Category, @Expense, @Date, @Notes)", conn);

            command.Parameters.AddWithValue("@Title", txtTitle.Text);
            command.Parameters.AddWithValue("@Category", entry.category);
            command.Parameters.AddWithValue("@Expense", expense);
            command.Parameters.AddWithValue("@Date", dateRec);
            command.Parameters.AddWithValue("@Notes", txtNotes.Text);
            command.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Entry saved!");
            ResetForm();
            Load_Table();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dateRec = dtpDate.Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load_Search();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text != "" && ID != 0)
            {
                DialogResult dr = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    command = new SqlCommand("UPDATE Entries SET Title = @Title, Category = @Category, Expense = @Expense, Date = @Date, Notes = @Notes WHERE ID = @ID", conn);
                    conn.Open();
                    command.Parameters.AddWithValue("@Title", txtTitle.Text);
                    command.Parameters.AddWithValue("@Category", entry.category);
                    command.Parameters.AddWithValue("@Expense", expense);
                    command.Parameters.AddWithValue("@Date", dateRec);
                    command.Parameters.AddWithValue("@Notes", txtNotes.Text);
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Entry updated!");
                    conn.Close();
                    Load_Table();
                }
            }
            else
            {
                MessageBox.Show("Select a valid entry to update.");
            }
        }

        private void btnRefresher2_Click(object sender, EventArgs e)
        {
            ResetForm();
            txtSearch.Text = "";
            Load_Table();
            btnUpdate.Hide();
            btnSave.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && ID != 0)
            {
                DialogResult dr = MessageBox.Show("Delete entry?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    command = new SqlCommand("DELETE Entries WHERE ID=@id", conn);
                    conn.Open();
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Entry deleted.");
                    Load_Table();
                    ResetForm();
                    txtSearch.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Select a valid entry to delete.");
            }
        }

        private void dgvTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSave.Hide();
            btnUpdate.Show();
            if (dgvTable.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
            {
                ID = Convert.ToInt32(dgvTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTitle.Text = dgvTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                entry.category = dgvTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                CheckCategory2();
                txtExpense.Text = dgvTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpDate.Value = (DateTime)dgvTable.Rows[e.RowIndex].Cells[4].Value;
                txtNotes.Text = dgvTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}
