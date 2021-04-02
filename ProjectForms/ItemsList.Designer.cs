
namespace BestFarmPath.ProjectForms
{
    partial class ItemsList
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Experience",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "12",
            "Morra",
            "1"}, -1);
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.textBoxNameItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewItems
            // 
            this.listViewItems.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName,
            this.columnHeaderPriority});
            this.listViewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewItems.HideSelection = false;
            this.listViewItems.HotTracking = true;
            this.listViewItems.HoverSelection = true;
            this.listViewItems.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewItems.LabelWrap = false;
            this.listViewItems.Location = new System.Drawing.Point(12, 72);
            this.listViewItems.MultiSelect = false;
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(379, 470);
            this.listViewItems.TabIndex = 0;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 68;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 210;
            // 
            // columnHeaderPriority
            // 
            this.columnHeaderPriority.Text = "Priority";
            this.columnHeaderPriority.Width = 97;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxPriority.Location = new System.Drawing.Point(295, 34);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(92, 32);
            this.comboBoxPriority.TabIndex = 1;
            this.comboBoxPriority.Text = "1";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(13, 34);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(64, 32);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // textBoxNameItem
            // 
            this.textBoxNameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameItem.Location = new System.Drawing.Point(80, 37);
            this.textBoxNameItem.Name = "textBoxNameItem";
            this.textBoxNameItem.Size = new System.Drawing.Size(209, 29);
            this.textBoxNameItem.TabIndex = 3;
            // 
            // ItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 554);
            this.Controls.Add(this.textBoxNameItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.listViewItems);
            this.Name = "ItemsList";
            this.Text = "Список предметов фарма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderPriority;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.TextBox textBoxNameItem;
    }
}