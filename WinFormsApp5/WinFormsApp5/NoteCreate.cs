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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp5
{
    public partial class NoteCreate : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        public NoteCreate()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                cn.Open();
                using (cmd = new SqlCommand("INSERT INTO Notes (Title, Content, Timestamp) VALUES (@Title, @Content, @Timestamp)", cn))
                {
                    cmd.Parameters.AddWithValue("@Title", Title.Text);
                    cmd.Parameters.AddWithValue("@Content", Content.Text);
                    cmd.Parameters.AddWithValue("@Timestamp", Timestamp.Value);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Note created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
