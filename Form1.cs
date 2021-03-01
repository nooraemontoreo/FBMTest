using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace FBMTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-94GO48G;Initial Catalog=FBM;Integrated Security=True");
        public int No; //primary key needed for updation and deletion of row
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getRecord();
        }
        private void getRecord()        //to get data
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-94GO48G;Initial Catalog=FBM;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from TableTest", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            fbmdatagridview.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TableTest VALUES (@GradeID, @GradeName)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@GradeID", txtgradeid.Text);
                cmd.Parameters.AddWithValue("@GradeName", txtgradename.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Grade is added successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getRecord();
                refresh();       //to clear data from labels after insert pressed
            }
        }
        private bool IsValid()
        {
            if (txtgradeid.Text == string.Empty)
            {
                MessageBox.Show("Grade Id is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void refresh()   // to clear values in label
        {
            No = 0;
            txtgradeid.Clear();
            txtgradename.Clear();
            txtgradeid.Focus();

        }

        private void fbmdatagridview_CellClick(object sender, DataGridViewCellEventArgs e) //to select       dataGridView->properties->fullrowselectionmode->cellClick
        {
            No = Convert.ToInt32(fbmdatagridview.SelectedRows[0].Cells[0].Value);
            txtgradeid.Text = fbmdatagridview.SelectedRows[0].Cells[1].Value.ToString();
            txtgradename.Text = fbmdatagridview.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)  //update button
        {
            if (No > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TableTest SET GradeID = @GradeID, GradeName = @GradeName where No = @N", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@GradeID", txtgradeid.Text);
                cmd.Parameters.AddWithValue("@GradeName", txtgradename.Text);
                cmd.Parameters.AddWithValue("@N", this.No);  //@N variable declared above in cmd

                cmd.ExecuteNonQuery();


                MessageBox.Show("Grade values is updated successfully", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                getRecord();
                refresh();       //to clear data from labels after insert pressed

            }
            else
            {
                MessageBox.Show("Please select a row to update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)   // Delete button
        {
            if (No > 0)   //bcz if No = 0 , no row is selected
            {
                SqlCommand cmd = new SqlCommand("Delete from TableTest  where No = @N", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@N", this.No);  //@N variable declared above in cmd
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Grade values is deleted successfully", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                getRecord();
                refresh();       //to clear data from labels after insert pressed
            }
            else
            {
                MessageBox.Show("Please select a row to delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
