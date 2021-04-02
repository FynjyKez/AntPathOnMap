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
    public partial class ItemsList : Form
    {
        string BUTTON_ADD = "Add Item";
        string BUTTON_EDIT = "Edit Item";
        bool button_switch = true;
        bool select_item = false;

        public ItemsList()
        {
            InitializeComponent();

            listViewItems.Items.Clear();
            foreach (string[] stringItem in MapConstructor.MainMapConstructor.GetListItems())
            {
                listViewItems.Items.Add(new ListViewItem(
                    stringItem,
                    -1)
                    );
            }
            
            


        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {     
            if (!select_item)
            {
                int ID = MapConstructor.MainMapConstructor.AddItem(textBoxNameItem.Text, Convert.ToInt32(comboBoxPriority.Text));
                listViewItems.Items.Add(new ListViewItem(
                         new string[] {
                             ID.ToString(),
                             textBoxNameItem.Text,
                             comboBoxPriority.Text
                            },
                        -1)
                    );
            }
            else
            {

            }
            textBoxNameItem.Text = BUTTON_ADD;
        }
    }
}
