namespace ArcSoftFace
{
    partial class FormRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(126, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(126, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxID.Location = new System.Drawing.Point(244, 51);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(186, 30);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPW.Location = new System.Drawing.Point(244, 116);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PasswordChar = '*';
            this.textBoxPW.Size = new System.Drawing.Size(186, 30);
            this.textBoxPW.TabIndex = 3;
            this.textBoxPW.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(126, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rewrite:";
            // 
            // textBoxRW
            // 
            this.textBoxRW.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRW.Location = new System.Drawing.Point(244, 184);
            this.textBoxRW.Name = "textBoxRW";
            this.textBoxRW.PasswordChar = '*';
            this.textBoxRW.Size = new System.Drawing.Size(186, 30);
            this.textBoxRW.TabIndex = 5;
            this.textBoxRW.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(126, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Identity:";
            // 
            // comboBoxID
            // 
            this.comboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Dean\'s Office",
            "Administrator"});
            this.comboBoxID.Location = new System.Drawing.Point(244, 255);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(186, 28);
            this.comboBoxID.TabIndex = 8;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(244, 318);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(186, 40);
            this.buttonRegister.TabIndex = 9;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 388);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Button buttonRegister;
    }
}