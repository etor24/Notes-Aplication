namespace WinFormsApp5
{
    partial class NotesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Notes = new ListView();
            NoteID = new ColumnHeader();
            Title = new ColumnHeader();
            Content = new ColumnHeader();
            Timestamp = new ColumnHeader();
            delete = new Button();
            back = new Button();
            edit = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Notes
            // 
            Notes.Columns.AddRange(new ColumnHeader[] { NoteID, Title, Content, Timestamp });
            Notes.Location = new Point(12, 12);
            Notes.Name = "Notes";
            Notes.Size = new Size(540, 269);
            Notes.TabIndex = 0;
            Notes.UseCompatibleStateImageBehavior = false;
            Notes.View = View.Details;
            // 
            // NoteID
            // 
            NoteID.Text = "NoteID";
            NoteID.Width = 50;
            // 
            // Title
            // 
            Title.Text = "Title";
            Title.Width = 100;
            // 
            // Content
            // 
            Content.Text = "Content";
            Content.Width = 300;
            // 
            // Timestamp
            // 
            Timestamp.Text = "Timestamp";
            Timestamp.Width = 80;
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(255, 192, 192);
            delete.Location = new Point(12, 287);
            delete.Name = "delete";
            delete.Size = new Size(176, 23);
            delete.TabIndex = 1;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 192, 192);
            back.Location = new Point(376, 287);
            back.Name = "back";
            back.Size = new Size(176, 23);
            back.TabIndex = 3;
            back.Text = "back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // edit
            // 
            edit.BackColor = Color.FromArgb(255, 192, 192);
            edit.Location = new Point(194, 287);
            edit.Name = "edit";
            edit.Size = new Size(176, 23);
            edit.TabIndex = 2;
            edit.Text = "edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Illustration83;
            pictureBox1.Location = new Point(558, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(584, 92);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 5;
            label1.Text = "THESE ARE YOUR NOTES USER!!!";
            // 
            // NotesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(771, 329);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(edit);
            Controls.Add(back);
            Controls.Add(delete);
            Controls.Add(Notes);
            Name = "NotesView";
            Text = "NotesView";
            Load += NotesView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView Notes;
        private Button delete;
        private Button back;
        private ColumnHeader NoteID;
        private ColumnHeader Title;
        private ColumnHeader Content;
        private ColumnHeader Timestamp;
        private Button edit;
        private PictureBox pictureBox1;
        private Label label1;
    }
}