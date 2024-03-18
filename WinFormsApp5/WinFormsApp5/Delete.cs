using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Delete : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        private NotesView _notesView;

        public Delete(NotesView notesView)
        {
            InitializeComponent();
            _notesView = notesView;
        }

        private void dlt_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                cn.Open();
                using (cmd = new SqlCommand("Select * From Notes WHERE NoteID = @NoteID;", cn))
                {
                    cmd.Parameters.AddWithValue("@NoteID", NoteID.Text);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        using (cmd = new SqlCommand("DELETE FROM Notes WHERE NoteID=@NoteID", cn))
                        {
                            cmd.Parameters.AddWithValue("@NoteID", NoteID.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Note deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            _notesView.Hide();
                            using (NotesView userInputForm = new NotesView())
                            {
                                userInputForm.ShowDialog();
                            }
                            //reloads NotesView form so that the list is updated                       
                        }
                    }
                    else
                    {
                        MessageBox.Show("No such note exists", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            } 
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
