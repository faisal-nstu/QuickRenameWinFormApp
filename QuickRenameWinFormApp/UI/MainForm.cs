﻿using System;
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
        private OpenFileDialog fileDialog = new OpenFileDialog();
        private bool _isReplaceOkClicked = false;
        

        public MainForm()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(251, 251, 251);
            fileDialog.Multiselect = true;
            fileDialog.ValidateNames = false;
            fileDialog.CheckFileExists = false;
            fileDialog.CheckPathExists = true;
            //fileDialog.FileName = "Folder Selection.";
            successLabel.Text = "Name Changed Successfully";
            successLabel.Hide();
            renameButton.Enabled = false;
            renameRadioButton.CheckedChanged += RenameRadioButtonOnCheckedChanged;
            appendRadioButton.CheckedChanged += AppendRadioButtonOnCheckedChanged;
            prependRadioButton.CheckedChanged += PrependRadioButtonOnCheckedChanged;
            changeExtensionRadioButton.CheckedChanged += ChangeExtensionRadioButtonOnCheckedChanged;
            newNameTextBox.GotFocus += NewNameTextBoxOnGotFocus;
            replaceableTextbox.GotFocus += ReplaceableTextboxOnGotFocus;
            renameRadioButton.Checked = true;
            replaceableTextbox.Visible = false;
        }

        private void ReplaceableTextboxOnGotFocus(object sender, EventArgs eventArgs)
        {
            replaceableTextbox.Text = "";
            replaceableTextbox.ForeColor = Color.White;
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
                newNameTextBox.Text = "Enter New File Extension...";
                newNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void PrependRadioButtonOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (prependRadioButton.Checked)
            {
                newNameTextBox.Text = "Enter Text to Prepend...";
                newNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void AppendRadioButtonOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (appendRadioButton.Checked)
            {
                newNameTextBox.Text = "Enter Text to Append...";
                newNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void RenameRadioButtonOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (renameRadioButton.Checked)
            {
                newNameTextBox.Text = "Enter New Name...";
                newNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void replaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (replaceRadioButton.Checked == true && _isReplaceOkClicked == false)
            {
                replaceableTextbox.Visible = true;
                replaceableTextbox.Text = "Enter Text to Replace with...";
                replaceableTextbox.ForeColor = Color.Silver;
                newNameTextBox.Text = "Enter Text to be Replaced...";
                newNameTextBox.ForeColor = Color.Silver;
                for (int i = 0; i < (264 - 222); i++)
                {
                    renameButton.Location = new Point(renameButton.Location.X, renameButton.Location.Y + 1);
                    successLabel.Location = new Point(successLabel.Location.X, successLabel.Location.Y + 1);
                    this.Height++;
                }
                _isReplaceOkClicked = true;
            }
            else if (replaceRadioButton.Checked == false && _isReplaceOkClicked == true)
            {
                replaceableTextbox.Visible = false;
                for (int i = 0; i < (264 - 222); i++)
                {
                    renameButton.Location = new Point(renameButton.Location.X, renameButton.Location.Y - 1);
                    successLabel.Location = new Point(successLabel.Location.X, successLabel.Location.Y - 1);
                    this.Height--;
                }
                _isReplaceOkClicked = false;
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
            else if (replaceRadioButton.Checked)
            {
                RenamingTasks.Replace(SelectedFileNames, newNameTextBox.Text, replaceableTextbox.Text);
            }
            SelectedFileNames = null;
            newNameTextBox.Text = "";
            replaceableTextbox.Text = "";
            SuccessMessage();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = fileDialog.ShowDialog();
            SelectedFileNames = new List<string>();
            if (result == DialogResult.OK)
            {
                foreach (string fileName in fileDialog.FileNames)
                {
                    SelectedFileNames.Add(fileName);
                    renameButton.Enabled = true;
                }
            }
        }

        private void SuccessMessage()
        {
            renameButton.Enabled = false;
            successLabel.Show(); 
            _successMessageTimer = 2;
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
