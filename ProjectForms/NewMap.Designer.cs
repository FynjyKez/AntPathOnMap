
namespace BestFarmPath.ProjectForms
{
    partial class NewMapForm
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
            this.Create = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.checkBoxTeleports = new System.Windows.Forms.CheckBox();
            this.checkBoxFreeTeleports = new System.Windows.Forms.CheckBox();
            this.MapName = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.openFileDialogImageMapFiles = new System.Windows.Forms.OpenFileDialog();
            this.buttonMapImageFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(218, 524);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(300, 524);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // checkBoxTeleports
            // 
            this.checkBoxTeleports.AutoSize = true;
            this.checkBoxTeleports.Location = new System.Drawing.Point(25, 102);
            this.checkBoxTeleports.Name = "checkBoxTeleports";
            this.checkBoxTeleports.Size = new System.Drawing.Size(70, 17);
            this.checkBoxTeleports.TabIndex = 2;
            this.checkBoxTeleports.Text = "Teleports";
            this.checkBoxTeleports.UseVisualStyleBackColor = true;
            this.checkBoxTeleports.CheckedChanged += new System.EventHandler(this.checkBoxTeleports_CheckedChanged);
            // 
            // checkBoxFreeTeleports
            // 
            this.checkBoxFreeTeleports.AutoSize = true;
            this.checkBoxFreeTeleports.Enabled = false;
            this.checkBoxFreeTeleports.Location = new System.Drawing.Point(101, 102);
            this.checkBoxFreeTeleports.Name = "checkBoxFreeTeleports";
            this.checkBoxFreeTeleports.Size = new System.Drawing.Size(94, 17);
            this.checkBoxFreeTeleports.TabIndex = 3;
            this.checkBoxFreeTeleports.Text = "Free Teleports";
            this.checkBoxFreeTeleports.UseVisualStyleBackColor = true;
            // 
            // MapName
            // 
            this.MapName.Location = new System.Drawing.Point(25, 12);
            this.MapName.Name = "MapName";
            this.MapName.Size = new System.Drawing.Size(155, 20);
            this.MapName.TabIndex = 4;
            this.MapName.Text = "Name";
            // 
            // openFileDialogImageMapFiles
            // 
            this.openFileDialogImageMapFiles.FileName = "openFileDialogImageMapFiles";
            this.openFileDialogImageMapFiles.Filter = "Images(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files (*.*)|*.*";
            this.openFileDialogImageMapFiles.Multiselect = true;
            this.openFileDialogImageMapFiles.Title = "Image Map Files";
            // 
            // buttonMapImageFile
            // 
            this.buttonMapImageFile.Location = new System.Drawing.Point(25, 38);
            this.buttonMapImageFile.Name = "buttonMapImageFile";
            this.buttonMapImageFile.Size = new System.Drawing.Size(101, 23);
            this.buttonMapImageFile.TabIndex = 5;
            this.buttonMapImageFile.Text = "Image Map Files";
            this.buttonMapImageFile.UseVisualStyleBackColor = true;
            this.buttonMapImageFile.Click += new System.EventHandler(this.buttonMapImageFile_Click);
            // 
            // NewMapForm
            // 
            this.AcceptButton = this.Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(634, 559);
            this.ControlBox = false;
            this.Controls.Add(this.buttonMapImageFile);
            this.Controls.Add(this.MapName);
            this.Controls.Add(this.checkBoxFreeTeleports);
            this.Controls.Add(this.checkBoxTeleports);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Create);
            this.Name = "NewMapForm";
            this.ShowInTaskbar = false;
            this.Text = "NewMap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.CheckBox checkBoxTeleports;
        private System.Windows.Forms.CheckBox checkBoxFreeTeleports;
        private System.Windows.Forms.TextBox MapName;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialogImageMapFiles;
        private System.Windows.Forms.Button buttonMapImageFile;
    }
}