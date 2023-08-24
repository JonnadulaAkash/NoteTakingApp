namespace NoteTakingApp
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.titleTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(435, 20);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(221, 68);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentRichTextBox.Location = new System.Drawing.Point(266, 94);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(522, 336);
            this.contentRichTextBox.TabIndex = 1;
            this.contentRichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notesListBox
            // 
            this.notesListBox.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.ItemHeight = 20;
            this.notesListBox.Location = new System.Drawing.Point(12, 94);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(238, 344);
            this.notesListBox.TabIndex = 3;
            this.notesListBox.SelectedIndexChanged += new System.EventHandler(this.notesListBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(691, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(292, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            //this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(292, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 28);
            this.button4.TabIndex = 6;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.notesListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox notesListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

