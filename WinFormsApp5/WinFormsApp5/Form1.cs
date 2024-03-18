namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            using (NoteCreate userInputForm = new NoteCreate())
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            using (NotesView userInputForm = new NotesView())
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();
            }
        }
    }
}