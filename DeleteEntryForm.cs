using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expensee
{
    public partial class DeleteEntryForm : Form
    {
        public static string EnterID;
        public DeleteEntryForm()
        {
            InitializeComponent();
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            ExpenseTrackerForm mainForm = new ExpenseTrackerForm();
            EnterID = numID.Value.ToString();
            mainForm.DeleteData(EnterID);
            mainForm.GetData();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ExpenseTrackerForm mainForm = new ExpenseTrackerForm();
            mainForm.GetData();
            this.Hide();
        }

        private void numID_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
