namespace ArcSoftFace
{
    partial class FormRecord
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listPreRecord = new System.Windows.Forms.ListBox();
            this.txtRecordName = new System.Windows.Forms.TextBox();
            this.labelClassName = new System.Windows.Forms.Label();
            this.labelClassID = new System.Windows.Forms.Label();
            this.cmboxTime = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(429, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pre Record Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(57, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(57, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "ClassID:";
            // 
            // btnCreat
            // 
            this.btnCreat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreat.Location = new System.Drawing.Point(195, 457);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(106, 60);
            this.btnCreat.TabIndex = 4;
            this.btnCreat.Text = "Create";
            this.btnCreat.UseVisualStyleBackColor = true;
            this.btnCreat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCreat_MouseClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(474, 457);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 60);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(57, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "RecordName:";
            // 
            // listPreRecord
            // 
            this.listPreRecord.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listPreRecord.FormattingEnabled = true;
            this.listPreRecord.ItemHeight = 23;
            this.listPreRecord.Location = new System.Drawing.Point(433, 80);
            this.listPreRecord.Name = "listPreRecord";
            this.listPreRecord.Size = new System.Drawing.Size(301, 211);
            this.listPreRecord.TabIndex = 8;
            // 
            // txtRecordName
            // 
            this.txtRecordName.Location = new System.Drawing.Point(61, 242);
            this.txtRecordName.Multiline = true;
            this.txtRecordName.Name = "txtRecordName";
            this.txtRecordName.Size = new System.Drawing.Size(208, 49);
            this.txtRecordName.TabIndex = 9;
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelClassName.Location = new System.Drawing.Point(154, 37);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(58, 24);
            this.labelClassName.TabIndex = 10;
            this.labelClassName.Text = "Name";
            // 
            // labelClassID
            // 
            this.labelClassID.AutoSize = true;
            this.labelClassID.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelClassID.Location = new System.Drawing.Point(169, 120);
            this.labelClassID.Name = "labelClassID";
            this.labelClassID.Size = new System.Drawing.Size(34, 24);
            this.labelClassID.TabIndex = 11;
            this.labelClassID.Text = "ID";
            // 
            // cmboxTime
            // 
            this.cmboxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxTime.FormattingEnabled = true;
            this.cmboxTime.Location = new System.Drawing.Point(61, 355);
            this.cmboxTime.Name = "cmboxTime";
            this.cmboxTime.Size = new System.Drawing.Size(208, 23);
            this.cmboxTime.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(61, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Begin-End Time";
            // 
            // FormRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 539);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmboxTime);
            this.Controls.Add(this.labelClassID);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.txtRecordName);
            this.Controls.Add(this.listPreRecord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRecord";
            this.Text = "FormRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listPreRecord;
        private System.Windows.Forms.TextBox txtRecordName;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.Label labelClassID;
        private System.Windows.Forms.ComboBox cmboxTime;
        private System.Windows.Forms.Label label7;
    }
}