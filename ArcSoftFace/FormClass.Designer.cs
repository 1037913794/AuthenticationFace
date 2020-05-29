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
            this.listClasses = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textClassName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // new_edit
            // 
            this.new_edit.Location = new System.Drawing.Point(258, 536);
            this.new_edit.Margin = new System.Windows.Forms.Padding(6);
            this.new_edit.Name = "new_edit";
            this.new_edit.Size = new System.Drawing.Size(223, 90);
            this.new_edit.TabIndex = 0;
            this.new_edit.Text = "New/Edit";
            this.new_edit.UseVisualStyleBackColor = true;
            this.new_edit.Click += new System.EventHandler(this.new_edit_Click);
            // 
            // textClassNo
            // 
            this.textClassNo.Location = new System.Drawing.Point(292, 180);
            this.textClassNo.Margin = new System.Windows.Forms.Padding(6);
            this.textClassNo.Name = "textClassNo";
            this.textClassNo.Size = new System.Drawing.Size(396, 42);
            this.textClassNo.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(43, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
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
            this.splitContainer1.Panel2.Controls.Add(this.textClassName);
            this.splitContainer1.Panel2.Controls.Add(this.new_edit);
            this.splitContainer1.Panel2.Controls.Add(this.textClassNo);
            this.splitContainer1.Size = new System.Drawing.Size(1412, 852);
            this.splitContainer1.SplitterDistance = 685;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
            // 
            // listClasses
            // 
            this.listClasses.FormattingEnabled = true;
            this.listClasses.ItemHeight = 30;
            this.listClasses.Location = new System.Drawing.Point(34, 150);
            this.listClasses.Margin = new System.Windows.Forms.Padding(6);
            this.listClasses.Name = "listClasses";
            this.listClasses.Size = new System.Drawing.Size(623, 634);
            this.listClasses.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Existed classes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "className:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 516);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 43);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "classNo:";
            // 
            // textClassName
            // 
            this.textClassName.Location = new System.Drawing.Point(292, 352);
            this.textClassName.Margin = new System.Windows.Forms.Padding(6);
            this.textClassName.Name = "textClassName";
            this.textClassName.Size = new System.Drawing.Size(396, 42);
            this.textClassName.TabIndex = 2;
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.TextBox textClassName;
        private System.Windows.Forms.ListBox listClasses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}