namespace WinFormsApp5
{
    partial class Edit
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
            Title = new TextBox();
            Content = new RichTextBox();
            save = new Button();
            cancel = new Button();
            Timestamp = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            NoteID = new TextBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Location = new Point(8, 51);
            Title.Name = "Title";
            Title.PlaceholderText = "Title";
            Title.Size = new Size(462, 23);
            Title.TabIndex = 5;
            // 
            // Content
            // 
            Content.Location = new Point(8, 80);
            Content.Name = "Content";
            Content.Size = new Size(462, 173);
            Content.TabIndex = 6;
            Content.Text = "";
            // 
            // save
            // 
            save.BackColor = Color.FromArgb(255, 192, 192);
            save.Location = new Point(8, 259);
            save.Name = "save";
            save.Size = new Size(228, 23);
            save.TabIndex = 7;
            save.Text = "save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // cancel
            // 
            cancel.BackColor = Color.FromArgb(255, 192, 192);
            cancel.Location = new Point(242, 259);
            cancel.Name = "cancel";
            cancel.Size = new Size(228, 23);
            cancel.TabIndex = 8;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // Timestamp
            // 
            Timestamp.Location = new Point(476, 51);
            Timestamp.Name = "Timestamp";
            Timestamp.Size = new Size(204, 23);
            Timestamp.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Illustration83;
            pictureBox1.Location = new Point(476, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(257, 15);
            label1.TabIndex = 11;
            label1.Text = "Insert NoteID of the note you would like to edit:";
            // 
            // NoteID
            // 
            NoteID.Location = new Point(275, 18);
            NoteID.Name = "NoteID";
            NoteID.Size = new Size(81, 23);
            NoteID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(539, 99);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 12;
            label2.Text = "EDIT YOUR NOTES USER!!!";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(362, 18);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 13;
            button1.Text = "add text";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(692, 298);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(NoteID);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Timestamp);
            Controls.Add(cancel);
            Controls.Add(save);
            Controls.Add(Content);
            Controls.Add(Title);
            Name = "Edit";
            Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title;
        private RichTextBox Content;
        private Button save;
        private Button cancel;
        private DateTimePicker Timestamp;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox NoteID;
        private Label label2;
        private Button button1;
    }
}