namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            create = new Button();
            view = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Illustration83;
            pictureBox1.Location = new Point(10, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // create
            // 
            create.BackColor = Color.FromArgb(255, 192, 192);
            create.Location = new Point(10, 228);
            create.Name = "create";
            create.Size = new Size(123, 25);
            create.TabIndex = 1;
            create.Text = "create a note";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // view
            // 
            view.BackColor = Color.FromArgb(255, 192, 192);
            view.Location = new Point(139, 228);
            view.Name = "view";
            view.Size = new Size(123, 25);
            view.TabIndex = 7;
            view.Text = "view past notes";
            view.UseVisualStyleBackColor = false;
            view.Click += view_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-1, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 37);
            label1.TabIndex = 0;
            label1.Text = "HELLO THERE USER !!!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(274, 264);
            Controls.Add(label1);
            Controls.Add(view);
            Controls.Add(pictureBox1);
            Controls.Add(create);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button create;
        private Button view;
        private Label label1;
    }
}