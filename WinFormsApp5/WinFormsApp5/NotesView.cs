using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp5
{
    public partial class NotesView : Form
    {
        public NotesView()
        {
            InitializeComponent();
        }

        private void NotesView_Load(object sender, EventArgs e)
        {
            // Establish a connection to the database
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // SQL query to select rooms based on the selected room type
                string query = "select * from Notes";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string dateAsString = ((DateTime)reader["Timestamp"]).ToString("yyyy-MM-dd");
                    // Create an array to hold the data for each row
                    string[] row = {
                                reader["NoteID"].ToString(),
                                reader["Title"].ToString(),
                                reader["Content"].ToString(),
                                dateAsString
                            };

                    // Create a ListViewItem with the row data and add it to the ListView
                    Notes.Items.Add(new ListViewItem(row));
                }

                reader.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            using (Delete userInputForm = new Delete(this))
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            using (Edit userInputForm = new Edit(this))
            {
                userInputForm.ShowDialog();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
