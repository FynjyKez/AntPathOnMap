
namespace BestFarmPath
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainWindow = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameObject = new System.Windows.Forms.Label();
            this.pictureObject = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйМетодФармаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьМетодФармаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureObject)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.MainWindow.Location = new System.Drawing.Point(308, 27);
            this.MainWindow.Name = "MainWindow";
            this.MainWindow.Size = new System.Drawing.Size(1363, 812);
            this.MainWindow.TabIndex = 0;
            this.MainWindow.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox1.Controls.Add(this.NameObject);
            this.groupBox1.Controls.Add(this.pictureObject);
            this.groupBox1.Location = new System.Drawing.Point(2, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 812);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // NameObject
            // 
            this.NameObject.AutoSize = true;
            this.NameObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameObject.Location = new System.Drawing.Point(6, 16);
            this.NameObject.Name = "NameObject";
            this.NameObject.Size = new System.Drawing.Size(130, 25);
            this.NameObject.TabIndex = 1;
            this.NameObject.Text = "NameObject";
            // 
            // pictureObject
            // 
            this.pictureObject.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureObject.Location = new System.Drawing.Point(6, 44);
            this.pictureObject.Name = "pictureObject";
            this.pictureObject.Size = new System.Drawing.Size(195, 204);
            this.pictureObject.TabIndex = 0;
            this.pictureObject.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 842);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1671, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.toolStripMenuItem1,
            this.картаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1671, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйМетодФармаToolStripMenuItem,
            this.загрузитьМетодФармаToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // создатьНовыйМетодФармаToolStripMenuItem
            // 
            this.создатьНовыйМетодФармаToolStripMenuItem.Name = "создатьНовыйМетодФармаToolStripMenuItem";
            this.создатьНовыйМетодФармаToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.создатьНовыйМетодФармаToolStripMenuItem.Text = "Создать новый метод фарма";
            this.создатьНовыйМетодФармаToolStripMenuItem.Click += new System.EventHandler(this.создатьНовыйМетодФармаToolStripMenuItem_Click);
            // 
            // загрузитьМетодФармаToolStripMenuItem
            // 
            this.загрузитьМетодФармаToolStripMenuItem.Name = "загрузитьМетодФармаToolStripMenuItem";
            this.загрузитьМетодФармаToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.загрузитьМетодФармаToolStripMenuItem.Text = "Загрузить метод фарма";
            this.загрузитьМетодФармаToolStripMenuItem.Click += new System.EventHandler(this.загрузитьМетодФармаToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "Данные";
            // 
            // AddItemToolStripMenuItem
            // 
            this.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem";
            this.AddItemToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.AddItemToolStripMenuItem.Text = "Добавить объект для фарма";
            this.AddItemToolStripMenuItem.Click += new System.EventHandler(this.AddItemToolStripMenuItem_Click);
            // 
            // картаToolStripMenuItem
            // 
            this.картаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьКартуToolStripMenuItem});
            this.картаToolStripMenuItem.Enabled = false;
            this.картаToolStripMenuItem.Name = "картаToolStripMenuItem";
            this.картаToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.картаToolStripMenuItem.Text = "Карта";
            // 
            // загрузитьКартуToolStripMenuItem
            // 
            this.загрузитьКартуToolStripMenuItem.Name = "загрузитьКартуToolStripMenuItem";
            this.загрузитьКартуToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.загрузитьКартуToolStripMenuItem.Text = "Загрузить изображение карты";
            this.загрузитьКартуToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКартуToolStripMenuItem_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 864);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainWindow);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "BestFarmPath";
            ((System.ComponentModel.ISupportInitialize)(this.MainWindow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureObject)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainWindow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem картаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКартуToolStripMenuItem;
        private System.Windows.Forms.Label NameObject;
        private System.Windows.Forms.PictureBox pictureObject;
        private System.Windows.Forms.ToolStripMenuItem AddItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНовыйМетодФармаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьМетодФармаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

