namespace ArcSoftFace
{
    partial class Teacher
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
            this.groBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBoxClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelClassName = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnPie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groBox
            // 
            this.groBox.Location = new System.Drawing.Point(26, 144);
            this.groBox.Name = "groBox";
            this.groBox.Size = new System.Drawing.Size(1120, 373);
            this.groBox.TabIndex = 0;
            this.groBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(157, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class:";
            // 
            // cmBoxClass
            // 
            this.cmBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxClass.FormattingEnabled = true;
            this.cmBoxClass.Location = new System.Drawing.Point(234, 54);
            this.cmBoxClass.Name = "cmBoxClass";
            this.cmBoxClass.Size = new System.Drawing.Size(121, 23);
            this.cmBoxClass.TabIndex = 2;
            this.cmBoxClass.SelectedIndexChanged += new System.EventHandler(this.cmBoxClass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(627, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelClassName.Location = new System.Drawing.Point(703, 58);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(49, 19);
            this.labelClassName.TabIndex = 4;
            this.labelClassName.Text = "name";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(257, 105);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(81, 42);
            this.btnList.TabIndex = 6;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(455, 105);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(112, 42);
            this.btnBar.TabIndex = 7;
            this.btnBar.Text = "Bar-Graph";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // btnPie
            // 
            this.btnPie.Location = new System.Drawing.Point(656, 105);
            this.btnPie.Name = "btnPie";
            this.btnPie.Size = new System.Drawing.Size(110, 42);
            this.btnPie.TabIndex = 8;
            this.btnPie.Text = "Pie-Graph";
            this.btnPie.UseVisualStyleBackColor = true;
            this.btnPie.Click += new System.EventHandler(this.btnPie_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 548);
            this.Controls.Add(this.btnPie);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBoxClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groBox);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnPie;
        private System.Windows.Forms.ComboBox cmBoxClass;
    }
}