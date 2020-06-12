namespace OopLabs
{
    partial class ChoosePluginForm
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
            this.cmbChoosePlugin = new System.Windows.Forms.ComboBox();
            this.btnChoosePlugin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbChoosePlugin
            // 
            this.cmbChoosePlugin.FormattingEnabled = true;
            this.cmbChoosePlugin.Location = new System.Drawing.Point(41, 73);
            this.cmbChoosePlugin.Name = "cmbChoosePlugin";
            this.cmbChoosePlugin.Size = new System.Drawing.Size(193, 21);
            this.cmbChoosePlugin.TabIndex = 0;
            // 
            // btnChoosePlugin
            // 
            this.btnChoosePlugin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChoosePlugin.Location = new System.Drawing.Point(288, 63);
            this.btnChoosePlugin.Name = "btnChoosePlugin";
            this.btnChoosePlugin.Size = new System.Drawing.Size(104, 38);
            this.btnChoosePlugin.TabIndex = 1;
            this.btnChoosePlugin.Text = "Выбрать";
            this.btnChoosePlugin.UseVisualStyleBackColor = true;
            this.btnChoosePlugin.Click += new System.EventHandler(this.btnChoosePlugin_Click);
            // 
            // ChoosePluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 169);
            this.Controls.Add(this.btnChoosePlugin);
            this.Controls.Add(this.cmbChoosePlugin);
            this.Name = "ChoosePluginForm";
            this.Text = "ChoosePlugin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChoosePluginForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChoosePlugin;
        private System.Windows.Forms.Button btnChoosePlugin;
    }
}