using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Code_Snippet_Manager
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        #region DELETE button
        private void button1_Click(object sender, EventArgs e)
        {
            //check whether any searched item is selected or not
            if (string.IsNullOrEmpty(search_result_listbox.GetItemText(search_result_listbox.SelectedItem)))
            {
                MessageBox.Show("First select something!!");
                return;
            }

            //ask for confirmation before deletion
            DialogResult result = MessageBox.Show("Are you sure don't want it? Proceed Deletion ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                SQLiteConnection Conn = new SQLiteConnection("Data Source=Snippetdb.sqlite;Version=3;");
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM snippet WHERE (Name LIKE @Name)");
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = Conn;
                cmd.Parameters.AddWithValue("@Name", search_result_listbox.SelectedItem.ToString());
                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();

                //update the list box
                search_b_Click(sender, e);

            }
            else
            {
                return;
            }
        }
        #endregion

        #region HOME button
        private void home_b_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region SEARCH button
        private void search_b_Click(object sender, EventArgs e)
        {
            //check whether the title is empty or not
            if (String.IsNullOrEmpty(title_txt.Text))
            {
                MessageBox.Show("Enter Title!! ");
                return;
            }

            SQLiteConnection Conn;
            SQLiteCommand cmd;

            //check whether the database already exist in the target machine
            if (System.IO.File.Exists("Snippetdb.sqlite") == false)
            {

                SQLiteConnection.CreateFile("Snippetdb.sqlite");
                Conn = new SQLiteConnection("Data Source=Snippetdb.sqlite;Version=3;");

                //connect to database
                Conn.Open();
                string query = "create table snippet (Name TEXT, Code TEXT)";
                cmd = new SQLiteCommand(query, Conn);
                cmd.ExecuteNonQuery();
                //close conection
                Conn.Close();
            }

            //clear the list box
            search_result_listbox.Items.Clear();
            Conn = new SQLiteConnection("Data Source=Snippetdb.sqlite;Version=3;");
            cmd = new SQLiteCommand("SELECT* FROM snippet WHERE (Name LIKE @Name)");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = Conn;
            cmd.Parameters.AddWithValue("@Name", "%" + title_txt.Text + "%");

            Conn.Open();
            cmd.ExecuteNonQuery();

            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == false)
                MessageBox.Show("No results Found!!!");
            while (reader.Read())
            {
                search_result_listbox.Items.Add(reader["Name"]);
            }

            Conn.Close();
        }
        #endregion

        private void preview_snippet_b_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(search_result_listbox.GetItemText(search_result_listbox.SelectedItem)))
            {
                MessageBox.Show("First select something!!");
                return;
            }

            Form5 f5 = new Form5(search_result_listbox.SelectedItem.ToString());
            f5.ShowDialog();
        }

        /// <summary>
        /// for displaying the code snippet of the currently selected title from the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_result_listbox_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conn = new SQLiteConnection("Data Source=Snippetdb.sqlite;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand("SELECT* FROM snippet WHERE (Name = @Name)");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = Conn;
            cmd.Parameters.AddWithValue("@Name", search_result_listbox.SelectedItem.ToString());

            Conn.Open();
            cmd.ExecuteNonQuery();

            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //giving rich text box its contents
                richTextBox1.Text = reader["Code"].ToString();

            }
            Conn.Close();
        }
    }
}
