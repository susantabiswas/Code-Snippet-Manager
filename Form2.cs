using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Code_Snippet_Manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //save button
        private void button1_Click(object sender, EventArgs e)
        {
            //check whether the title is empty or not
            if (String.IsNullOrEmpty(snippet_title_txt.Text))
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

            Conn = new SQLiteConnection("Data Source=Snippetdb.sqlite;Version=3;");

            //check if there exist any snippet with the same title
            cmd = new SQLiteCommand("SELECT Name FROM snippet WHERE (Name=@Name)");
            cmd.Parameters.AddWithValue("@Name", snippet_title_txt.Text);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = Conn;
            Conn.Open();
            cmd.ExecuteNonQuery();

            SQLiteDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                ++count;
            }

            Conn.Close();
            if (count == 1)
            {
                MessageBox.Show("Snippet with same Title already exist!!");
                return;
            }


            cmd = new SQLiteCommand("INSERT INTO snippet (Name, Code) VALUES (@Name, @Code)");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = Conn;
            cmd.Parameters.AddWithValue("@Name", snippet_title_txt.Text);
            cmd.Parameters.AddWithValue("@Code", code_richtxt.Text);

            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();

        }

        //home button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
