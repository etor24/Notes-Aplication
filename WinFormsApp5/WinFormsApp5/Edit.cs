using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Edit : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        private NotesView _notesView;
        public Edit(NotesView notesView)
        {
            InitializeComponent();
            _notesView = notesView;


        }

        private void save_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                cn.Open();
                using (cmd = new SqlCommand("UPDATE Notes SET Title = @Title,  Content = @Content,  Timestamp = @Timestamp WHERE NoteID = @NoteID;", cn))

                {
                    cmd.Parameters.AddWithValue("@NoteID", NoteID.Text);
                    cmd.Parameters.AddWithValue("@Title", Title.Text);
                    cmd.Parameters.AddWithValue("@Content", Content.Text);
                    cmd.Parameters.AddWithValue("@Timestamp", Timestamp.Value);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Note edited and saved.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    _notesView.Hide();
                    using (NotesView userInputForm = new NotesView())
                    {
                        userInputForm.ShowDialog();
                    }
                    //reloads NotesView form so that the list is updated
                }
            }


        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                cn.Open();
                using (cmd = new SqlCommand("Select Title From Notes WHERE NoteID = @NoteID;", cn))

                {
                    cmd.Parameters.AddWithValue("@NoteID", NoteID.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {  
                        Title.Text = (string)cmd.ExecuteScalar();
                    }
                    else
                    {
                        MessageBox.Show("No such note exists", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                using (cmd = new SqlCommand("Select Content From Notes WHERE NoteID = @NoteID;", cn))

                {
                    cmd.Parameters.AddWithValue("@NoteID", NoteID.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        Content.Text = (string)cmd.ExecuteScalar();
                    }
                }
            }
        }
    }
}
