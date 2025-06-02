using System.Data;

namespace Task_Phone_Book
{
    public partial class PhoneBook : Form
    {
        DataTable dt = new DataTable();
        bool edit = false;
        public PhoneBook()
        {
            InitializeComponent();
        }

        private void NewB_Click(object sender, EventArgs e)
        {
            Fname.Text = "";
            Lname.Text = "";
            Pnumber.Text = "";
            Email.Text = "";
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["First Name"] = Fname.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Last Name"] = Lname.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Phone Number"] = Pnumber.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Email"] = Email.Text;
            }
            else
            {
                dt.Rows.Add(Fname.Text, Lname.Text, Pnumber.Text, Email.Text);
            }
            Fname.Text = "";
            Lname.Text = "";
            Pnumber.Text = "";
            Email.Text = "";
            edit = false;
        }

        private void LoadB_Click(object sender, EventArgs e)
        {
            Fname.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            Lname.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
            Pnumber.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[2].ToString();
            Email.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[3].ToString();
            edit = true;
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Error: Not a valid row!"); }



        }



        private void PhoneBook_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("PhoneNumber");
            dt.Columns.Add("Email");
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Fname.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            Lname.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
            Pnumber.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[2].ToString();
            Email.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[3].ToString();
            edit = true;
        }
    }
}