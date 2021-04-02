using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFarmPath.ProjectForms
{
    public partial class NewMapForm : Form
    {
        string[] ImageMapFiles;

        public NewMapForm()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if(MapConstructor.MainMapConstructor.NewMap(MapName.Text, openFileDialogImageMapFiles.FileNames, checkBoxTeleports.Checked, checkBoxFreeTeleports.Checked))
            {
                Close();
            }
            else
            {
                MessageBox.Show(MapConstructor.MainMapConstructor.ErrorMessage);
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxTeleports_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTeleports.Checked)
            {
                checkBoxFreeTeleports.Enabled = true;
            }
            else
            {
                checkBoxFreeTeleports.Enabled = false;
                checkBoxFreeTeleports.Checked = false;
            }
        }

        private void buttonMapImageFile_Click(object sender, EventArgs e)
        {
            openFileDialogImageMapFiles.ShowDialog();
        }
    }
}
