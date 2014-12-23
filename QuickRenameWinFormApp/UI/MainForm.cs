using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuickRenameWinFormApp.BL;

namespace QuickRenameWinFormApp.UI
{
    public partial class MainForm : Form
    {
        public List<string> SelectedFileNames;
        private string _newFileName;
        private int _successMessageTimer;

        public MainForm()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(251, 251, 251);
            openFileDialogcontrol.Multiselect = true;
            successLabel.Text = "Name Changed Successfully";
            successLabel.Hide();
            renameButton.Enabled = false;
            renameRadioButton.CheckedChanged += RenameRadioButtonOnCheckedChanged;
            appendRadioButton.CheckedChanged += AppendRadioButtonOnCheckedChanged;
            prependRadioButton.CheckedChanged += PrependRadioButtonOnCheckedChanged;
            changeExtensionRadioButton.CheckedChanged += ChangeExtensionRadioButtonOnCheckedChanged;
            newNameTextBox.GotFocus += NewNameTextBoxOnGotFocus;
            renameRadioButton.Checked = true;
        }

        private void NewNameTextBoxOnGotFocus(object sender, EventArgs eventArgs)
        {
            newNameTextBox.Text = "";
            newNameTextBox.ForeColor = Color.White;
        }

        private void ChangeExtensionRadioButtonOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (changeExtensionRadioButton.Checked)
            {
                newNameTextBox.Text = "Enter New File Extension";
                newNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void PrependRadioButtonOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (prependRadioButton.Checked)
            {
                newNameTextBox.Text = "Enter Text to Prepend";
                newNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void AppendRadioButtonOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (appendRadioButton.Checked)
            {
                newNameTextBox.Text = "Enter Text to Append";
                newNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void RenameRadioButtonOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (renameRadioButton.Checked)
            {
                newNameTextBox.Text = "Enter New Name";
                newNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            var newName = newNameTextBox.Text;
            if (renameRadioButton.Checked)
            {
                RenamingTasks.Rename(SelectedFileNames, newName);
            }
            else if (prependRadioButton.Checked)
            {
                RenamingTasks.Prepend(SelectedFileNames, newName);
            }
            else if (appendRadioButton.Checked)
            {
                RenamingTasks.Append(SelectedFileNames, newName);
            }
            else if (changeExtensionRadioButton.Checked)
            {
                RenamingTasks.ChangeExtension(SelectedFileNames, newName);
            }
            SelectedFileNames = null;
            newNameTextBox.Text = "";
            SuccessMessage();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogcontrol.ShowDialog();
            SelectedFileNames = new List<string>();
            if (result == DialogResult.OK)
            {
                foreach (string fileName in openFileDialogcontrol.FileNames)
                {
                    SelectedFileNames.Add(fileName);
                    renameButton.Enabled = true;
                }
            }
        }

        private void SuccessMessage()
        {
            renameButton.Enabled = false;
            successLabel.Show(); _successMessageTimer = 2;
            Timer msgTimer = new Timer();
            msgTimer.Interval = 1000;
            msgTimer.Enabled = true;
            msgTimer.Start();
            msgTimer.Tick += new System.EventHandler(this.timer_tick);
        }

        private void timer_tick(object sender, EventArgs e)
        {
            _successMessageTimer--;

            if (_successMessageTimer == 0)
            {
                successLabel.Hide();
            }
        }
    }
}
