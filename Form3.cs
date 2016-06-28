using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Code_Snippet_Manager
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        #region Search button
        private void button2_Click(object sender, EventArgs e)
        {

            //check whether the title is empty or not
            if (String.IsNullOrEmpty(snippetname_txt.Text))
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
            cmd.Parameters.AddWithValue("@Name", "%" + snippetname_txt.Text + "%");

            Conn.Open();
            cmd.ExecuteNonQuery();

            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                search_result_listbox.Items.Add(reader["Name"]);
            }
            Conn.Close();
        }
        #endregion

        #region HOME button

        private void home_b_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion


        #region COPY button
        private void copy_clipboard_b_Click(object sender, EventArgs e)
        {
            string query = search_result_listbox.SelectedItem.ToString();

            search_result_listbox.Items.Clear();
            SQLiteConnection Conn = new SQLiteConnection("Data Source=Snippetdb.sqlite;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand("SELECT* FROM snippet WHERE (Name = @Name)");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = Conn;
            cmd.Parameters.AddWithValue("@Name",query);

            Conn.Open();
            cmd.ExecuteNonQuery();

            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                richTextBox1.Text = reader["Code"].ToString();
            }
            Conn.Close();
        } 
        #endregion
    }
}
