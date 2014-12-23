namespace QuickRenameWinFormApp.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.successLabel = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.openFileDialogcontrol = new System.Windows.Forms.OpenFileDialog();
            this.renameRadioButton = new System.Windows.Forms.RadioButton();
            this.prependRadioButton = new System.Windows.Forms.RadioButton();
            this.changeExtensionRadioButton = new System.Windows.Forms.RadioButton();
            this.appendRadioButton = new System.Windows.Forms.RadioButton();
            this.renameButton = new System.Windows.Forms.Button();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.BackColor = System.Drawing.Color.Transparent;
            this.successLabel.ForeColor = System.Drawing.Color.White;
            this.successLabel.Location = new System.Drawing.Point(63, 264);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(89, 13);
            this.successLabel.TabIndex = 10;
            this.successLabel.Text = "Succes Message";
            // 
            // selectFileButton
            // 
            this.selectFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFileButton.FlatAppearance.BorderSize = 0;
            this.selectFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFileButton.ForeColor = System.Drawing.Color.White;
            this.selectFileButton.Location = new System.Drawing.Point(63, 69);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(288, 23);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "<<< Select File >>>";
            this.selectFileButton.UseVisualStyleBackColor = false;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // openFileDialogcontrol
            // 
            this.openFileDialogcontrol.FileName = "openFileDialog1";
            // 
            // renameRadioButton
            // 
            this.renameRadioButton.AutoSize = true;
            this.renameRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.renameRadioButton.ForeColor = System.Drawing.Color.White;
            this.renameRadioButton.Location = new System.Drawing.Point(71, 111);
            this.renameRadioButton.Name = "renameRadioButton";
            this.renameRadioButton.Size = new System.Drawing.Size(65, 17);
            this.renameRadioButton.TabIndex = 1;
            this.renameRadioButton.Text = "Rename";
            this.renameRadioButton.UseVisualStyleBackColor = false;
            // 
            // prependRadioButton
            // 
            this.prependRadioButton.AutoSize = true;
            this.prependRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.prependRadioButton.ForeColor = System.Drawing.Color.White;
            this.prependRadioButton.Location = new System.Drawing.Point(176, 111);
            this.prependRadioButton.Name = "prependRadioButton";
            this.prependRadioButton.Size = new System.Drawing.Size(65, 17);
            this.prependRadioButton.TabIndex = 2;
            this.prependRadioButton.Text = "Prepend";
            this.prependRadioButton.UseVisualStyleBackColor = false;
            // 
            // changeExtensionRadioButton
            // 
            this.changeExtensionRadioButton.AutoSize = true;
            this.changeExtensionRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.changeExtensionRadioButton.ForeColor = System.Drawing.Color.White;
            this.changeExtensionRadioButton.Location = new System.Drawing.Point(71, 147);
            this.changeExtensionRadioButton.Name = "changeExtensionRadioButton";
            this.changeExtensionRadioButton.Size = new System.Drawing.Size(111, 17);
            this.changeExtensionRadioButton.TabIndex = 4;
            this.changeExtensionRadioButton.Text = "Change Extension";
            this.changeExtensionRadioButton.UseVisualStyleBackColor = false;
            // 
            // appendRadioButton
            // 
            this.appendRadioButton.AutoSize = true;
            this.appendRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.appendRadioButton.ForeColor = System.Drawing.Color.White;
            this.appendRadioButton.Location = new System.Drawing.Point(287, 111);
            this.appendRadioButton.Name = "appendRadioButton";
            this.appendRadioButton.Size = new System.Drawing.Size(62, 17);
            this.appendRadioButton.TabIndex = 3;
            this.appendRadioButton.Text = "Append";
            this.appendRadioButton.UseVisualStyleBackColor = false;
            // 
            // renameButton
            // 
            this.renameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.renameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renameButton.FlatAppearance.BorderSize = 0;
            this.renameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renameButton.ForeColor = System.Drawing.Color.White;
            this.renameButton.Location = new System.Drawing.Point(63, 222);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(288, 23);
            this.renameButton.TabIndex = 6;
            this.renameButton.Text = "OK";
            this.renameButton.UseVisualStyleBackColor = false;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newNameTextBox.ForeColor = System.Drawing.Color.White;
            this.newNameTextBox.Location = new System.Drawing.Point(63, 183);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(288, 13);
            this.newNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "© 2014, Nobody";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::QuickRenameWinFormApp.Properties.Resources.video_overlay;
            this.ClientSize = new System.Drawing.Size(415, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.renameRadioButton);
            this.Controls.Add(this.prependRadioButton);
            this.Controls.Add(this.changeExtensionRadioButton);
            this.Controls.Add(this.appendRadioButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.newNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Rename 1.0.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogcontrol;
        private System.Windows.Forms.RadioButton renameRadioButton;
        private System.Windows.Forms.RadioButton prependRadioButton;
        private System.Windows.Forms.RadioButton changeExtensionRadioButton;
        private System.Windows.Forms.RadioButton appendRadioButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}

