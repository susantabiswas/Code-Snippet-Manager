using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Code_Snippet_Manager
{
    public partial class Form5 : Form
    {
        public Form5(string name)
        {
            InitializeComponent();
            label1.Text = name;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            SQLiteConnection Conn = new SQLiteConnection("Data Source=Snippetdb.sqlite;Version=3;");
            SQLiteCommand cmd = new SQLiteCommand("SELECT* FROM snippet WHERE (Name =@Name)");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = Conn;
            cmd.Parameters.AddWithValue("@Name",label1.Text);

            Conn.Open();
            cmd.ExecuteNonQuery();

            SQLiteDataReader reader = cmd.ExecuteReader();
            
            richTextBox1.Text = reader["Code"].ToString();

            Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }
    }
}
