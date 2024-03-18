namespace WinFormsApp5
{
    partial class NoteCreate
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
            Content = new RichTextBox();
            save = new Button();
            cancel = new Button();
            pictureBox1 = new PictureBox();
            Title = new TextBox();
            Timestamp = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Content
            // 
            Content.Location = new Point(12, 37);
            Content.Name = "Content";
            Content.Size = new Size(462, 173);
            Content.TabIndex = 0;
            Content.Text = "";
            // 
            // save
            // 
            save.BackColor = Color.FromArgb(255, 192, 192);
            save.Location = new Point(12, 216);
            save.Name = "save";
            save.Size = new Size(228, 23);
            save.TabIndex = 1;
            save.Text = "save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // cancel
            // 
            cancel.BackColor = Color.FromArgb(255, 192, 192);
            cancel.Location = new Point(246, 216);
            cancel.Name = "cancel";
            cancel.Size = new Size(228, 23);
            cancel.TabIndex = 2;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Illustration83;
            pictureBox1.Location = new Point(480, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Title
            // 
            Title.Location = new Point(12, 8);
            Title.Name = "Title";
            Title.PlaceholderText = "Title";
            Title.Size = new Size(462, 23);
            Title.TabIndex = 4;
            // 
            // Timestamp
            // 
            Timestamp.Location = new Point(480, 8);
            Timestamp.Name = "Timestamp";
            Timestamp.Size = new Size(204, 23);
            Timestamp.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 64);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 6;
            label1.Text = "WHAT NOTE WILL YOU CREATE USER??";
            // 
            // NoteCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(696, 256);
            Controls.Add(label1);
            Controls.Add(Timestamp);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            Controls.Add(cancel);
            Controls.Add(save);
            Controls.Add(Content);
            Name = "NoteCreate";
            Text = "NoteCreate";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Content;
        private Button save;
        private Button cancel;
        private PictureBox pictureBox1;
        private TextBox Title;
        private DateTimePicker Timestamp;
        private Label label1;
    }
}