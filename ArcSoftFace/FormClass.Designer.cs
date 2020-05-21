namespace ArcSoftFace
{
    partial class FormClass
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
            this.new_edit = new System.Windows.Forms.Button();
            this.textClassNo = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textClassName = new System.Windows.Forms.TextBox();
            this.textClassRecord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listClasses = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // new_edit
            // 
            this.new_edit.Location = new System.Drawing.Point(156, 314);
            this.new_edit.Name = "new_edit";
            this.new_edit.Size = new System.Drawing.Size(119, 45);
            this.new_edit.TabIndex = 0;
            this.new_edit.Text = "New/Edit";
            this.new_edit.UseVisualStyleBackColor = true;
            this.new_edit.Click += new System.EventHandler(this.new_edit_Click);
            // 
            // textClassNo
            // 
            this.textClassNo.Location = new System.Drawing.Point(156, 90);
            this.textClassNo.Name = "textClassNo";
            this.textClassNo.Size = new System.Drawing.Size(213, 25);
            this.textClassNo.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listClasses);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textClassRecord);
            this.splitContainer1.Panel2.Controls.Add(this.textClassName);
            this.splitContainer1.Panel2.Controls.Add(this.new_edit);
            this.splitContainer1.Panel2.Controls.Add(this.textClassNo);
            this.splitContainer1.Size = new System.Drawing.Size(753, 426);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 2;
            // 
            // textClassName
            // 
            this.textClassName.Location = new System.Drawing.Point(156, 176);
            this.textClassName.Name = "textClassName";
            this.textClassName.Size = new System.Drawing.Size(213, 25);
            this.textClassName.TabIndex = 2;
            // 
            // textClassRecord
            // 
            this.textClassRecord.Location = new System.Drawing.Point(156, 258);
            this.textClassRecord.Name = "textClassRecord";
            this.textClassRecord.Size = new System.Drawing.Size(213, 25);
            this.textClassRecord.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "classNo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "classRecord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "className:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Existed classes";
            // 
            // listClasses
            // 
            this.listClasses.FormattingEnabled = true;
            this.listClasses.ItemHeight = 15;
            this.listClasses.Location = new System.Drawing.Point(18, 75);
            this.listClasses.Name = "listClasses";
            this.listClasses.Size = new System.Drawing.Size(334, 319);
            this.listClasses.TabIndex = 6;
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormClass";
            this.Text = "FormClass";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button new_edit;
        private System.Windows.Forms.TextBox textClassNo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textClassRecord;
        private System.Windows.Forms.TextBox textClassName;
        private System.Windows.Forms.ListBox listClasses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}