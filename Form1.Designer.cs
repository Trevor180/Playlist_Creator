namespace WootenT_Playlist
{
    partial class Form1
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
            this.songPlaylistListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.songTextBox = new System.Windows.Forms.TextBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songPlaylistListBox
            // 
            this.songPlaylistListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songPlaylistListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.songPlaylistListBox.FormattingEnabled = true;
            this.songPlaylistListBox.ItemHeight = 18;
            this.songPlaylistListBox.Location = new System.Drawing.Point(47, 32);
            this.songPlaylistListBox.Name = "songPlaylistListBox";
            this.songPlaylistListBox.Size = new System.Drawing.Size(378, 292);
            this.songPlaylistListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Song";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Song:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Artist:";
            // 
            // songTextBox
            // 
            this.songTextBox.Location = new System.Drawing.Point(110, 417);
            this.songTextBox.Multiline = true;
            this.songTextBox.Name = "songTextBox";
            this.songTextBox.Size = new System.Drawing.Size(100, 24);
            this.songTextBox.TabIndex = 1;
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(110, 380);
            this.artistTextBox.Multiline = true;
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(100, 24);
            this.artistTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(88, 461);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 30);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(304, 447);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 30);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(274, 384);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(169, 56);
            this.instructionsLabel.TabIndex = 8;
            this.instructionsLabel.Text = "To delete a song, highlight the track then press the delete button.";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instructionsLabel.Click += new System.EventHandler(this.instructionsLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(179, 542);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 30);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 56);
            this.label4.TabIndex = 9;
            this.label4.Text = "Or press Alt + D";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(460, 584);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.songTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songPlaylistListBox);
            this.Name = "Form1";
            this.Text = "Playlist";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox songPlaylistListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox songTextBox;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label4;
    }
}

