using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MapConstructor;

namespace BestFarmPath
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void загрузитьКартуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.FilesOperation.FilesOperation.SaveFile();
        }

        private void создатьНовыйМетодФармаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new ProjectForms.NewMapForm();
            fr.ShowDialog();
            //MainMapConstructor.NewMap("test", new string[] {"1", "2" }, true, true);
        }

        private void AddItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new ProjectForms.ItemsList();
            fr.ShowDialog();
            //System.Random rand = new Random();
            //MainMapConstructor.AddItem("name_" + rand.Next(), rand.Next(), rand.Next());
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainMapConstructor.SaveMap();
                MessageBox.Show("Сохранено", MainMapConstructor.MapName);
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }

        private void загрузитьМетодФармаToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            folderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MainMapConstructor.LoadMap(folderBrowserDialog1.SelectedPath);
            }  
        }
    }
}
