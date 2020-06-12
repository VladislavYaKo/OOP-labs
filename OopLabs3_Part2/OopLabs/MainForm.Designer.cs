namespace OopLabs
{
    partial class MainForm
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
            this.cmbChooseObjType = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lvObjects = new System.Windows.Forms.ListView();
            this.lbYourObjects = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuEditing = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbChooseObjType
            // 
            this.cmbChooseObjType.FormattingEnabled = true;
            this.cmbChooseObjType.Location = new System.Drawing.Point(33, 514);
            this.cmbChooseObjType.Name = "cmbChooseObjType";
            this.cmbChooseObjType.Size = new System.Drawing.Size(459, 21);
            this.cmbChooseObjType.TabIndex = 0;
            this.cmbChooseObjType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(606, 490);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(212, 67);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Создать";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lvObjects
            // 
            this.lvObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvObjects.HideSelection = false;
            this.lvObjects.Location = new System.Drawing.Point(33, 117);
            this.lvObjects.Name = "lvObjects";
            this.lvObjects.Size = new System.Drawing.Size(785, 341);
            this.lvObjects.TabIndex = 2;
            this.lvObjects.UseCompatibleStateImageBehavior = false;
            // 
            // lbYourObjects
            // 
            this.lbYourObjects.AutoSize = true;
            this.lbYourObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYourObjects.Location = new System.Drawing.Point(330, 71);
            this.lbYourObjects.Name = "lbYourObjects";
            this.lbYourObjects.Size = new System.Drawing.Size(198, 31);
            this.lbYourObjects.TabIndex = 3;
            this.lbYourObjects.Text = "Ваши объекты";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuFile,
            this.правкаToolStripMenuEditing});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuFile
            // 
            this.файлToolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuFile.Name = "файлToolStripMenuFile";
            this.файлToolStripMenuFile.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuFile.Text = "Файл";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuEditing
            // 
            this.правкаToolStripMenuEditing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.правкаToolStripMenuEditing.Name = "правкаToolStripMenuEditing";
            this.правкаToolStripMenuEditing.Size = new System.Drawing.Size(56, 20);
            this.правкаToolStripMenuEditing.Text = "Правка";
            // 
            // просмотретьToolStripMenuItem
            // 
            this.просмотретьToolStripMenuItem.Name = "просмотретьToolStripMenuItem";
            this.просмотретьToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.просмотретьToolStripMenuItem.Text = "Просмотреть";
            this.просмотретьToolStripMenuItem.Click += new System.EventHandler(this.просмотретьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 608);
            this.Controls.Add(this.lbYourObjects);
            this.Controls.Add(this.lvObjects);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbChooseObjType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChooseObjType;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListView lvObjects;
        private System.Windows.Forms.Label lbYourObjects;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuEditing;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

