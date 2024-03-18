namespace WinFormsApp5
{
    partial class Delete
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
            label1 = new Label();
            NoteID = new TextBox();
            dlt = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 0;
            label1.Text = "Which note would you like to delete?";
            // 
            // NoteID
            // 
            NoteID.Location = new Point(12, 38);
            NoteID.Name = "NoteID";
            NoteID.PlaceholderText = "NoteID";
            NoteID.Size = new Size(204, 23);
            NoteID.TabIndex = 1;
            // 
            // dlt
            // 
            dlt.BackColor = Color.FromArgb(255, 192, 192);
            dlt.Location = new Point(12, 67);
            dlt.Name = "dlt";
            dlt.Size = new Size(90, 23);
            dlt.TabIndex = 2;
            dlt.Text = "Delete";
            dlt.UseVisualStyleBackColor = false;
            dlt.Click += dlt_Click;
            // 
            // cancel
            // 
            cancel.BackColor = Color.FromArgb(255, 192, 192);
            cancel.Location = new Point(126, 67);
            cancel.Name = "cancel";
            cancel.Size = new Size(90, 23);
            cancel.TabIndex = 3;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(228, 105);
            Controls.Add(cancel);
            Controls.Add(dlt);
            Controls.Add(NoteID);
            Controls.Add(label1);
            Name = "Delete";
            Text = "Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NoteID;
        private Button dlt;
        private Button cancel;
    }
}