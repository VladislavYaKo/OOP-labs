namespace OopLabs.MyForms
{
    partial class BicycleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWheelsNum = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtGearsNum = new System.Windows.Forms.TextBox();
            this.txtWheelDiam = new System.Windows.Forms.TextBox();
            this.cmbBrakeType = new System.Windows.Forms.ComboBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbWheelsNum
            // 
            this.lbWheelsNum.AutoSize = true;
            this.lbWheelsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWheelsNum.Location = new System.Drawing.Point(29, 120);
            this.lbWheelsNum.Name = "lbWheelsNum";
            this.lbWheelsNum.Size = new System.Drawing.Size(182, 25);
            this.lbWheelsNum.TabIndex = 0;
            this.lbWheelsNum.Text = "Количество колёс";
            this.lbWheelsNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(153, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(470, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество передач";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(515, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Диаметр колёс";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(530, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Тип тормозов";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtWheelsNum
            // 
            this.txtWheelsNum.Location = new System.Drawing.Point(229, 125);
            this.txtWheelsNum.Name = "txtWheelsNum";
            this.txtWheelsNum.Size = new System.Drawing.Size(76, 20);
            this.txtWheelsNum.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(229, 194);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(76, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // txtGearsNum
            // 
            this.txtGearsNum.Location = new System.Drawing.Point(701, 63);
            this.txtGearsNum.Name = "txtGearsNum";
            this.txtGearsNum.Size = new System.Drawing.Size(76, 20);
            this.txtGearsNum.TabIndex = 1;
            // 
            // txtWheelDiam
            // 
            this.txtWheelDiam.Location = new System.Drawing.Point(701, 127);
            this.txtWheelDiam.Name = "txtWheelDiam";
            this.txtWheelDiam.Size = new System.Drawing.Size(76, 20);
            this.txtWheelDiam.TabIndex = 1;
            // 
            // cmbBrakeType
            // 
            this.cmbBrakeType.FormattingEnabled = true;
            this.cmbBrakeType.Location = new System.Drawing.Point(701, 195);
            this.cmbBrakeType.Name = "cmbBrakeType";
            this.cmbBrakeType.Size = new System.Drawing.Size(76, 21);
            this.cmbBrakeType.TabIndex = 2;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDone.Location = new System.Drawing.Point(282, 340);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(182, 75);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Готово";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(112, 59);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(99, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Название";
            this.lbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(229, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 20);
            this.txtName.TabIndex = 1;
            // 
            // BicycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.cmbBrakeType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtWheelDiam);
            this.Controls.Add(this.txtGearsNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtWheelsNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbWheelsNum);
            this.Name = "BicycleForm";
            this.Text = "Bicycle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWheelsNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWheelsNum;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtGearsNum;
        private System.Windows.Forms.TextBox txtWheelDiam;
        private System.Windows.Forms.ComboBox cmbBrakeType;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
    }
}