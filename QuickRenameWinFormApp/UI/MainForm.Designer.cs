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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.BackColor = System.Drawing.SystemColors.Control;
            this.successLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.successLabel.Location = new System.Drawing.Point(63, 264);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(89, 13);
            this.successLabel.TabIndex = 10;
            this.successLabel.Text = "Succes Message";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(63, 69);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(288, 23);
            this.selectFileButton.TabIndex = 6;
            this.selectFileButton.Text = "<<< Select File >>>";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // openFileDialogcontrol
            // 
            this.openFileDialogcontrol.FileName = "openFileDialog1";
            // 
            // renameRadioButton
            // 
            this.renameRadioButton.AutoSize = true;
            this.renameRadioButton.Location = new System.Drawing.Point(71, 111);
            this.renameRadioButton.Name = "renameRadioButton";
            this.renameRadioButton.Size = new System.Drawing.Size(65, 17);
            this.renameRadioButton.TabIndex = 11;
            this.renameRadioButton.Text = "Rename";
            this.renameRadioButton.UseVisualStyleBackColor = true;
            // 
            // prependRadioButton
            // 
            this.prependRadioButton.AutoSize = true;
            this.prependRadioButton.Location = new System.Drawing.Point(176, 111);
            this.prependRadioButton.Name = "prependRadioButton";
            this.prependRadioButton.Size = new System.Drawing.Size(65, 17);
            this.prependRadioButton.TabIndex = 9;
            this.prependRadioButton.Text = "Prepend";
            this.prependRadioButton.UseVisualStyleBackColor = true;
            // 
            // changeExtensionRadioButton
            // 
            this.changeExtensionRadioButton.AutoSize = true;
            this.changeExtensionRadioButton.Location = new System.Drawing.Point(71, 147);
            this.changeExtensionRadioButton.Name = "changeExtensionRadioButton";
            this.changeExtensionRadioButton.Size = new System.Drawing.Size(111, 17);
            this.changeExtensionRadioButton.TabIndex = 7;
            this.changeExtensionRadioButton.Text = "Change Extension";
            this.changeExtensionRadioButton.UseVisualStyleBackColor = true;
            // 
            // appendRadioButton
            // 
            this.appendRadioButton.AutoSize = true;
            this.appendRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.appendRadioButton.Location = new System.Drawing.Point(287, 111);
            this.appendRadioButton.Name = "appendRadioButton";
            this.appendRadioButton.Size = new System.Drawing.Size(62, 17);
            this.appendRadioButton.TabIndex = 8;
            this.appendRadioButton.Text = "Append";
            this.appendRadioButton.UseVisualStyleBackColor = false;
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(63, 222);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(288, 23);
            this.renameButton.TabIndex = 13;
            this.renameButton.Text = "OK";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(63, 183);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(288, 20);
            this.newNameTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "© 2014, Nobody";
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(63, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 74);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

