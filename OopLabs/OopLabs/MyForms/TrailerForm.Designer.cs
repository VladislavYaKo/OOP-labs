namespace OopLabs.MyForms
{
    partial class TrailerForm
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
            this.lbWheelsNum = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbMaxWeightCapacity = new System.Windows.Forms.Label();
            this.lbIsResidential = new System.Windows.Forms.Label();
            this.lbPersonsNum = new System.Windows.Forms.Label();
            this.txtWheelsNum = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMaxWeightCapacity = new System.Windows.Forms.TextBox();
            this.txtPersonsNum = new System.Windows.Forms.TextBox();
            this.chkbxIsResidential = new System.Windows.Forms.CheckBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWheelsNum
            // 
            this.lbWheelsNum.AutoSize = true;
            this.lbWheelsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWheelsNum.Location = new System.Drawing.Point(21, 105);
            this.lbWheelsNum.Name = "lbWheelsNum";
            this.lbWheelsNum.Size = new System.Drawing.Size(182, 25);
            this.lbWheelsNum.TabIndex = 1;
            this.lbWheelsNum.Text = "Количество колёс";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPrice.Location = new System.Drawing.Point(145, 168);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(58, 25);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "Цена";
            // 
            // lbMaxWeightCapacity
            // 
            this.lbMaxWeightCapacity.AutoSize = true;
            this.lbMaxWeightCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaxWeightCapacity.Location = new System.Drawing.Point(436, 104);
            this.lbMaxWeightCapacity.Name = "lbMaxWeightCapacity";
            this.lbMaxWeightCapacity.Size = new System.Drawing.Size(190, 25);
            this.lbMaxWeightCapacity.TabIndex = 1;
            this.lbMaxWeightCapacity.Text = "Максимальный вес";
            // 
            // lbIsResidential
            // 
            this.lbIsResidential.AutoSize = true;
            this.lbIsResidential.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIsResidential.Location = new System.Drawing.Point(448, 41);
            this.lbIsResidential.Name = "lbIsResidential";
            this.lbIsResidential.Size = new System.Drawing.Size(178, 25);
            this.lbIsResidential.TabIndex = 1;
            this.lbIsResidential.Text = "Является жилым";
            // 
            // lbPersonsNum
            // 
            this.lbPersonsNum.AutoSize = true;
            this.lbPersonsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPersonsNum.Location = new System.Drawing.Point(379, 172);
            this.lbPersonsNum.Name = "lbPersonsNum";
            this.lbPersonsNum.Size = new System.Drawing.Size(247, 25);
            this.lbPersonsNum.TabIndex = 1;
            this.lbPersonsNum.Text = "Количество жилых мест";
            // 
            // txtWheelsNum
            // 
            this.txtWheelsNum.Location = new System.Drawing.Point(224, 110);
            this.txtWheelsNum.Name = "txtWheelsNum";
            this.txtWheelsNum.Size = new System.Drawing.Size(76, 20);
            this.txtWheelsNum.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(224, 173);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(76, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtMaxWeightCapacity
            // 
            this.txtMaxWeightCapacity.Location = new System.Drawing.Point(651, 109);
            this.txtMaxWeightCapacity.Name = "txtMaxWeightCapacity";
            this.txtMaxWeightCapacity.Size = new System.Drawing.Size(76, 20);
            this.txtMaxWeightCapacity.TabIndex = 2;
            // 
            // txtPersonsNum
            // 
            this.txtPersonsNum.Location = new System.Drawing.Point(651, 177);
            this.txtPersonsNum.Name = "txtPersonsNum";
            this.txtPersonsNum.Size = new System.Drawing.Size(76, 20);
            this.txtPersonsNum.TabIndex = 2;
            // 
            // chkbxIsResidential
            // 
            this.chkbxIsResidential.AutoSize = true;
            this.chkbxIsResidential.Location = new System.Drawing.Point(670, 46);
            this.chkbxIsResidential.Name = "chkbxIsResidential";
            this.chkbxIsResidential.Size = new System.Drawing.Size(15, 14);
            this.chkbxIsResidential.TabIndex = 3;
            this.chkbxIsResidential.UseVisualStyleBackColor = true;
            this.chkbxIsResidential.CheckedChanged += new System.EventHandler(this.chkbxIsResidential_CheckedChanged);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDone.Location = new System.Drawing.Point(288, 324);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(198, 83);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Готово";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(224, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 20);
            this.txtName.TabIndex = 6;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(104, 41);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(99, 25);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Название";
            // 
            // TrailerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.chkbxIsResidential);
            this.Controls.Add(this.txtPersonsNum);
            this.Controls.Add(this.txtMaxWeightCapacity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtWheelsNum);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbPersonsNum);
            this.Controls.Add(this.lbIsResidential);
            this.Controls.Add(this.lbMaxWeightCapacity);
            this.Controls.Add(this.lbWheelsNum);
            this.Name = "TrailerForm";
            this.Text = "TrailerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWheelsNum;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbMaxWeightCapacity;
        private System.Windows.Forms.Label lbIsResidential;
        private System.Windows.Forms.Label lbPersonsNum;
        private System.Windows.Forms.TextBox txtWheelsNum;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMaxWeightCapacity;
        private System.Windows.Forms.TextBox txtPersonsNum;
        private System.Windows.Forms.CheckBox chkbxIsResidential;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
    }
}