using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        private List<string> notesList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshNotesListBox()
        {
            // Clear the current items in the ListBox
            notesListBox.Items.Clear();

            // Add each note from the notesList to the ListBox
            foreach (string noteEntry in notesList)
            {
                notesListBox.Items.Add(noteEntry);
            }
        }



        private void addButton_Click(object sender, EventArgs e)
        {

            addButton.Text = "Click Me";
            // Get the title and content from the TextBox and RichTextBox
            string title = titleTextBox.Text;
                string content = contentRichTextBox.Text;

                // Combine title and content to create the note entry
                string noteEntry = $"{title}: {content}";

                // Add the note entry to the ListBox
                notesListBox.Items.Add(noteEntry);
                // Refresh the ListBox to display the updated list of notes
                RefreshNotesListBox();

                // Clear the TextBox and RichTextBox for the next note
                titleTextBox.Clear();
                contentRichTextBox.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Check if there is a selected item in the ListBox
            if (notesListBox.SelectedIndex >= 0)
            {
                // Remove the selected note from the ListBox
                notesListBox.Items.RemoveAt(notesListBox.SelectedIndex);

                // Also, remove the selected note from the notesList
                notesList.RemoveAt(notesListBox.SelectedIndex);
            }
        }

        private void notesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if there is a selected item in the ListBox
            if (notesListBox.SelectedIndex >= 0)
            {
                // Get the selected note entry from the ListBox
                string selectedNote = notesListBox.SelectedItem.ToString();

                // Split the selected note entry into title and content using the ":" separator
                string[] noteParts = selectedNote.Split(':');

                // Ensure that the noteParts array contains at least two elements (title and content)
                if (noteParts.Length >= 2)
                {
                    // Retrieve the title and content from the noteParts array
                    string title = noteParts[0].Trim();
                    string content = string.Join(":", noteParts.Skip(1)).Trim();

                    // Populate the TextBox and RichTextBox with the selected note's title and content
                    titleTextBox.Text = title;
                    contentRichTextBox.Text = content;
                }
            }
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}