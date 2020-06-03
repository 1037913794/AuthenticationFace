namespace ArcSoftFace
{
    partial class AuthenticationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationForm));
            this.groupBoxClass = new System.Windows.Forms.GroupBox();
            this.labelClassCount = new System.Windows.Forms.Label();
            this.labelClassStuNum = new System.Windows.Forms.Label();
            this.labelClassCname = new System.Windows.Forms.Label();
            this.labelClassCno = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.buttonClassEdit = new System.Windows.Forms.Button();
            this.buttonClassDelete = new System.Windows.Forms.Button();
            this.buttonClassNew = new System.Windows.Forms.Button();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.labelStudentAttendance = new System.Windows.Forms.Label();
            this.labelStudentGender = new System.Windows.Forms.Label();
            this.labelStudentSname = new System.Windows.Forms.Label();
            this.labelStudentSno = new System.Windows.Forms.Label();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.buttonStudentEdit = new System.Windows.Forms.Button();
            this.buttonStudentDelete = new System.Windows.Forms.Button();
            this.buttonStudentNew = new System.Windows.Forms.Button();
            this.groupBoxRecord = new System.Windows.Forms.GroupBox();
            this.labelRecordStatus = new System.Windows.Forms.Label();
            this.labelRecordName = new System.Windows.Forms.Label();
            this.labelRecordSkip = new System.Windows.Forms.Label();
            this.labelRecordAttendance = new System.Windows.Forms.Label();
            this.comboBoxRecord = new System.Windows.Forms.ComboBox();
            this.buttonRecordDisplay = new System.Windows.Forms.Button();
            this.buttonRecordDelete = new System.Windows.Forms.Button();
            this.buttonRecordNew = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.TextBox();
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.rgbVideoSource = new AForge.Controls.VideoSourcePlayer();
            this.irVideoSource = new AForge.Controls.VideoSourcePlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTeacherData = new System.Windows.Forms.Button();
            this.btnStudentData = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.groupBoxClass.SuspendLayout();
            this.groupBoxStudent.SuspendLayout();
            this.groupBoxRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.groupBoxOperation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClass
            // 
            this.groupBoxClass.Controls.Add(this.labelClassCount);
            this.groupBoxClass.Controls.Add(this.labelClassStuNum);
            this.groupBoxClass.Controls.Add(this.labelClassCname);
            this.groupBoxClass.Controls.Add(this.labelClassCno);
            this.groupBoxClass.Controls.Add(this.comboBoxClass);
            this.groupBoxClass.Controls.Add(this.buttonClassEdit);
            this.groupBoxClass.Controls.Add(this.buttonClassDelete);
            this.groupBoxClass.Controls.Add(this.buttonClassNew);
            this.groupBoxClass.Location = new System.Drawing.Point(11, 10);
            this.groupBoxClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxClass.Name = "groupBoxClass";
            this.groupBoxClass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxClass.Size = new System.Drawing.Size(533, 100);
            this.groupBoxClass.TabIndex = 0;
            this.groupBoxClass.TabStop = false;
            this.groupBoxClass.Text = "Class";
            // 
            // labelClassCount
            // 
            this.labelClassCount.AutoSize = true;
            this.labelClassCount.Location = new System.Drawing.Point(288, 80);
            this.labelClassCount.Name = "labelClassCount";
            this.labelClassCount.Size = new System.Drawing.Size(82, 15);
            this.labelClassCount.TabIndex = 7;
            this.labelClassCount.Text = "考勤次数：";
            // 
            // labelClassStuNum
            // 
            this.labelClassStuNum.AutoSize = true;
            this.labelClassStuNum.Location = new System.Drawing.Point(288, 60);
            this.labelClassStuNum.Name = "labelClassStuNum";
            this.labelClassStuNum.Size = new System.Drawing.Size(67, 15);
            this.labelClassStuNum.TabIndex = 6;
            this.labelClassStuNum.Text = "学生数：";
            // 
            // labelClassCname
            // 
            this.labelClassCname.AutoSize = true;
            this.labelClassCname.Location = new System.Drawing.Point(288, 40);
            this.labelClassCname.Name = "labelClassCname";
            this.labelClassCname.Size = new System.Drawing.Size(67, 15);
            this.labelClassCname.TabIndex = 5;
            this.labelClassCname.Text = "课程名：";
            // 
            // labelClassCno
            // 
            this.labelClassCno.AutoSize = true;
            this.labelClassCno.Location = new System.Drawing.Point(288, 20);
            this.labelClassCno.Name = "labelClassCno";
            this.labelClassCno.Size = new System.Drawing.Size(67, 15);
            this.labelClassCno.TabIndex = 4;
            this.labelClassCno.Text = "课程号：";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(5, 52);
            this.comboBoxClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(278, 23);
            this.comboBoxClass.TabIndex = 3;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // buttonClassEdit
            // 
            this.buttonClassEdit.Location = new System.Drawing.Point(194, 22);
            this.buttonClassEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClassEdit.Name = "buttonClassEdit";
            this.buttonClassEdit.Size = new System.Drawing.Size(89, 25);
            this.buttonClassEdit.TabIndex = 2;
            this.buttonClassEdit.Text = "Edit";
            this.buttonClassEdit.UseVisualStyleBackColor = true;
            this.buttonClassEdit.Click += new System.EventHandler(this.buttonClassEdit_Click);
            // 
            // buttonClassDelete
            // 
            this.buttonClassDelete.Location = new System.Drawing.Point(100, 22);
            this.buttonClassDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClassDelete.Name = "buttonClassDelete";
            this.buttonClassDelete.Size = new System.Drawing.Size(89, 25);
            this.buttonClassDelete.TabIndex = 1;
            this.buttonClassDelete.Text = "Delete";
            this.buttonClassDelete.UseVisualStyleBackColor = true;
            this.buttonClassDelete.Click += new System.EventHandler(this.buttonClassDelete_Click);
            // 
            // buttonClassNew
            // 
            this.buttonClassNew.Location = new System.Drawing.Point(5, 22);
            this.buttonClassNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClassNew.Name = "buttonClassNew";
            this.buttonClassNew.Size = new System.Drawing.Size(89, 25);
            this.buttonClassNew.TabIndex = 0;
            this.buttonClassNew.Text = "New";
            this.buttonClassNew.UseVisualStyleBackColor = true;
            this.buttonClassNew.Click += new System.EventHandler(this.buttonClassNew_Click);
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.labelStudentAttendance);
            this.groupBoxStudent.Controls.Add(this.labelStudentGender);
            this.groupBoxStudent.Controls.Add(this.labelStudentSname);
            this.groupBoxStudent.Controls.Add(this.labelStudentSno);
            this.groupBoxStudent.Controls.Add(this.comboBoxStudent);
            this.groupBoxStudent.Controls.Add(this.buttonStudentEdit);
            this.groupBoxStudent.Controls.Add(this.buttonStudentDelete);
            this.groupBoxStudent.Controls.Add(this.buttonStudentNew);
            this.groupBoxStudent.Location = new System.Drawing.Point(11, 115);
            this.groupBoxStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStudent.Size = new System.Drawing.Size(533, 100);
            this.groupBoxStudent.TabIndex = 1;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Student";
            // 
            // labelStudentAttendance
            // 
            this.labelStudentAttendance.AutoSize = true;
            this.labelStudentAttendance.Location = new System.Drawing.Point(288, 80);
            this.labelStudentAttendance.Name = "labelStudentAttendance";
            this.labelStudentAttendance.Size = new System.Drawing.Size(82, 15);
            this.labelStudentAttendance.TabIndex = 7;
            this.labelStudentAttendance.Text = "到课次数：";
            // 
            // labelStudentGender
            // 
            this.labelStudentGender.AutoSize = true;
            this.labelStudentGender.Location = new System.Drawing.Point(288, 60);
            this.labelStudentGender.Name = "labelStudentGender";
            this.labelStudentGender.Size = new System.Drawing.Size(52, 15);
            this.labelStudentGender.TabIndex = 6;
            this.labelStudentGender.Text = "性别：";
            // 
            // labelStudentSname
            // 
            this.labelStudentSname.AutoSize = true;
            this.labelStudentSname.Location = new System.Drawing.Point(288, 40);
            this.labelStudentSname.Name = "labelStudentSname";
            this.labelStudentSname.Size = new System.Drawing.Size(52, 15);
            this.labelStudentSname.TabIndex = 5;
            this.labelStudentSname.Text = "姓名：";
            // 
            // labelStudentSno
            // 
            this.labelStudentSno.AutoSize = true;
            this.labelStudentSno.Location = new System.Drawing.Point(288, 20);
            this.labelStudentSno.Name = "labelStudentSno";
            this.labelStudentSno.Size = new System.Drawing.Size(52, 15);
            this.labelStudentSno.TabIndex = 4;
            this.labelStudentSno.Text = "学号：";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(5, 52);
            this.comboBoxStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(278, 23);
            this.comboBoxStudent.TabIndex = 3;
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
            // 
            // buttonStudentEdit
            // 
            this.buttonStudentEdit.Location = new System.Drawing.Point(194, 22);
            this.buttonStudentEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudentEdit.Name = "buttonStudentEdit";
            this.buttonStudentEdit.Size = new System.Drawing.Size(89, 25);
            this.buttonStudentEdit.TabIndex = 2;
            this.buttonStudentEdit.Text = "Edit";
            this.buttonStudentEdit.UseVisualStyleBackColor = true;
            this.buttonStudentEdit.Click += new System.EventHandler(this.buttonStudentEdit_Click);
            // 
            // buttonStudentDelete
            // 
            this.buttonStudentDelete.Location = new System.Drawing.Point(100, 22);
            this.buttonStudentDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudentDelete.Name = "buttonStudentDelete";
            this.buttonStudentDelete.Size = new System.Drawing.Size(89, 25);
            this.buttonStudentDelete.TabIndex = 1;
            this.buttonStudentDelete.Text = "Delete";
            this.buttonStudentDelete.UseVisualStyleBackColor = true;
            this.buttonStudentDelete.Click += new System.EventHandler(this.buttonStudentDelete_Click);
            // 
            // buttonStudentNew
            // 
            this.buttonStudentNew.Location = new System.Drawing.Point(5, 22);
            this.buttonStudentNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStudentNew.Name = "buttonStudentNew";
            this.buttonStudentNew.Size = new System.Drawing.Size(89, 25);
            this.buttonStudentNew.TabIndex = 0;
            this.buttonStudentNew.Text = "New";
            this.buttonStudentNew.UseVisualStyleBackColor = true;
            this.buttonStudentNew.Click += new System.EventHandler(this.buttonStudentNew_Click);
            // 
            // groupBoxRecord
            // 
            this.groupBoxRecord.Controls.Add(this.labelRecordStatus);
            this.groupBoxRecord.Controls.Add(this.labelRecordName);
            this.groupBoxRecord.Controls.Add(this.labelRecordSkip);
            this.groupBoxRecord.Controls.Add(this.labelRecordAttendance);
            this.groupBoxRecord.Controls.Add(this.comboBoxRecord);
            this.groupBoxRecord.Controls.Add(this.buttonRecordDisplay);
            this.groupBoxRecord.Controls.Add(this.buttonRecordDelete);
            this.groupBoxRecord.Controls.Add(this.buttonRecordNew);
            this.groupBoxRecord.Location = new System.Drawing.Point(11, 220);
            this.groupBoxRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRecord.Name = "groupBoxRecord";
            this.groupBoxRecord.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRecord.Size = new System.Drawing.Size(533, 100);
            this.groupBoxRecord.TabIndex = 2;
            this.groupBoxRecord.TabStop = false;
            this.groupBoxRecord.Text = "Record";
            // 
            // labelRecordStatus
            // 
            this.labelRecordStatus.AutoSize = true;
            this.labelRecordStatus.Location = new System.Drawing.Point(288, 80);
            this.labelRecordStatus.Name = "labelRecordStatus";
            this.labelRecordStatus.Size = new System.Drawing.Size(52, 15);
            this.labelRecordStatus.TabIndex = 7;
            this.labelRecordStatus.Text = "状态：";
            // 
            // labelRecordName
            // 
            this.labelRecordName.AutoSize = true;
            this.labelRecordName.Location = new System.Drawing.Point(288, 60);
            this.labelRecordName.Name = "labelRecordName";
            this.labelRecordName.Size = new System.Drawing.Size(52, 15);
            this.labelRecordName.TabIndex = 6;
            this.labelRecordName.Text = "姓名：";
            // 
            // labelRecordSkip
            // 
            this.labelRecordSkip.AutoSize = true;
            this.labelRecordSkip.Location = new System.Drawing.Point(288, 40);
            this.labelRecordSkip.Name = "labelRecordSkip";
            this.labelRecordSkip.Size = new System.Drawing.Size(97, 15);
            this.labelRecordSkip.TabIndex = 5;
            this.labelRecordSkip.Text = "未到课人数：";
            // 
            // labelRecordAttendance
            // 
            this.labelRecordAttendance.AutoSize = true;
            this.labelRecordAttendance.Location = new System.Drawing.Point(288, 20);
            this.labelRecordAttendance.Name = "labelRecordAttendance";
            this.labelRecordAttendance.Size = new System.Drawing.Size(97, 15);
            this.labelRecordAttendance.TabIndex = 4;
            this.labelRecordAttendance.Text = "已到课人数：";
            // 
            // comboBoxRecord
            // 
            this.comboBoxRecord.FormattingEnabled = true;
            this.comboBoxRecord.Location = new System.Drawing.Point(5, 52);
            this.comboBoxRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRecord.Name = "comboBoxRecord";
            this.comboBoxRecord.Size = new System.Drawing.Size(278, 23);
            this.comboBoxRecord.TabIndex = 3;
            this.comboBoxRecord.SelectedIndexChanged += new System.EventHandler(this.comboBoxRecord_SelectedIndexChanged);
            // 
            // buttonRecordDisplay
            // 
            this.buttonRecordDisplay.Location = new System.Drawing.Point(194, 22);
            this.buttonRecordDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRecordDisplay.Name = "buttonRecordDisplay";
            this.buttonRecordDisplay.Size = new System.Drawing.Size(89, 25);
            this.buttonRecordDisplay.TabIndex = 2;
            this.buttonRecordDisplay.Text = "Display";
            this.buttonRecordDisplay.UseVisualStyleBackColor = true;
            this.buttonRecordDisplay.Click += new System.EventHandler(this.buttonRecordDisplay_Click);
            // 
            // buttonRecordDelete
            // 
            this.buttonRecordDelete.Location = new System.Drawing.Point(100, 22);
            this.buttonRecordDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRecordDelete.Name = "buttonRecordDelete";
            this.buttonRecordDelete.Size = new System.Drawing.Size(89, 25);
            this.buttonRecordDelete.TabIndex = 1;
            this.buttonRecordDelete.Text = "Delete";
            this.buttonRecordDelete.UseVisualStyleBackColor = true;
            this.buttonRecordDelete.Click += new System.EventHandler(this.buttonRecordDelete_Click);
            // 
            // buttonRecordNew
            // 
            this.buttonRecordNew.Location = new System.Drawing.Point(5, 22);
            this.buttonRecordNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRecordNew.Name = "buttonRecordNew";
            this.buttonRecordNew.Size = new System.Drawing.Size(89, 25);
            this.buttonRecordNew.TabIndex = 0;
            this.buttonRecordNew.Text = "New";
            this.buttonRecordNew.UseVisualStyleBackColor = true;
            this.buttonRecordNew.Click += new System.EventHandler(this.buttonRecordNew_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(549, 35);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(711, 533);
            this.pictureBoxImage.TabIndex = 3;
            this.pictureBoxImage.TabStop = false;
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Controls.Add(this.logBox);
            this.groupBoxOperation.Controls.Add(this.textBoxThreshold);
            this.groupBoxOperation.Controls.Add(this.labelThreshold);
            this.groupBoxOperation.Controls.Add(this.buttonStart);
            this.groupBoxOperation.Location = new System.Drawing.Point(10, 325);
            this.groupBoxOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOperation.Size = new System.Drawing.Size(533, 150);
            this.groupBoxOperation.TabIndex = 4;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "Operation";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(172, 22);
            this.logBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(358, 102);
            this.logBox.TabIndex = 3;
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Location = new System.Drawing.Point(64, 87);
            this.textBoxThreshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(100, 25);
            this.textBoxThreshold.TabIndex = 2;
            this.textBoxThreshold.Text = "0.8";
            // 
            // labelThreshold
            // 
            this.labelThreshold.AutoSize = true;
            this.labelThreshold.Location = new System.Drawing.Point(3, 90);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(52, 15);
            this.labelThreshold.TabIndex = 1;
            this.labelThreshold.Text = "阈值：";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStart.Location = new System.Drawing.Point(6, 33);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(160, 30);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "开始考勤";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(549, 10);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 15);
            this.labelInfo.TabIndex = 5;
            // 
            // rgbVideoSource
            // 
            this.rgbVideoSource.Location = new System.Drawing.Point(549, 35);
            this.rgbVideoSource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rgbVideoSource.Name = "rgbVideoSource";
            this.rgbVideoSource.Size = new System.Drawing.Size(711, 533);
            this.rgbVideoSource.TabIndex = 39;
            this.rgbVideoSource.Text = "videoSource";
            this.rgbVideoSource.VideoSource = null;
            this.rgbVideoSource.PlayingFinished += new AForge.Video.PlayingFinishedEventHandler(this.videoSource_PlayingFinished);
            this.rgbVideoSource.Paint += new System.Windows.Forms.PaintEventHandler(this.rgbVideoSource_Paint);
            // 
            // irVideoSource
            // 
            this.irVideoSource.BackColor = System.Drawing.SystemColors.Control;
            this.irVideoSource.Location = new System.Drawing.Point(1074, 35);
            this.irVideoSource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.irVideoSource.Name = "irVideoSource";
            this.irVideoSource.Size = new System.Drawing.Size(187, 133);
            this.irVideoSource.TabIndex = 40;
            this.irVideoSource.Text = "videoSource";
            this.irVideoSource.VideoSource = null;
            this.irVideoSource.Visible = false;
            this.irVideoSource.PlayingFinished += new AForge.Video.PlayingFinishedEventHandler(this.videoSource_PlayingFinished);
            this.irVideoSource.Paint += new System.Windows.Forms.PaintEventHandler(this.irVideoSource_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTeacherData);
            this.groupBox1.Controls.Add(this.btnStudentData);
            this.groupBox1.Location = new System.Drawing.Point(11, 492);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(355, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // btnTeacherData
            // 
            this.btnTeacherData.Location = new System.Drawing.Point(194, 23);
            this.btnTeacherData.Name = "btnTeacherData";
            this.btnTeacherData.Size = new System.Drawing.Size(146, 38);
            this.btnTeacherData.TabIndex = 1;
            this.btnTeacherData.Text = "Teacher-Data";
            this.btnTeacherData.UseVisualStyleBackColor = true;
            this.btnTeacherData.Click += new System.EventHandler(this.btnTeacherData_Click);
            // 
            // btnStudentData
            // 
            this.btnStudentData.Location = new System.Drawing.Point(20, 23);
            this.btnStudentData.Name = "btnStudentData";
            this.btnStudentData.Size = new System.Drawing.Size(143, 38);
            this.btnStudentData.TabIndex = 0;
            this.btnStudentData.Text = "Student-Data";
            this.btnStudentData.UseVisualStyleBackColor = true;
            this.btnStudentData.Click += new System.EventHandler(this.btnStudentData_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(382, 515);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(146, 38);
            this.btnLogOff.TabIndex = 41;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1275, 586);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.irVideoSource);
            this.Controls.Add(this.rgbVideoSource);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.groupBoxOperation);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.groupBoxRecord);
            this.Controls.Add(this.groupBoxStudent);
            this.Controls.Add(this.groupBoxClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1293, 633);
            this.MinimumSize = new System.Drawing.Size(1293, 633);
            this.Name = "AuthenticationForm";
            this.Text = "WHU离线人脸考勤系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthenticationForm_FormClosed);
            this.groupBoxClass.ResumeLayout(false);
            this.groupBoxClass.PerformLayout();
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.groupBoxRecord.ResumeLayout(false);
            this.groupBoxRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.groupBoxOperation.ResumeLayout(false);
            this.groupBoxOperation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClass;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Button buttonClassEdit;
        private System.Windows.Forms.Button buttonClassDelete;
        private System.Windows.Forms.Button buttonClassNew;
        private System.Windows.Forms.Label labelClassCno;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.Label labelStudentSno;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Button buttonStudentEdit;
        private System.Windows.Forms.Button buttonStudentDelete;
        private System.Windows.Forms.Button buttonStudentNew;
        private System.Windows.Forms.GroupBox groupBoxRecord;
        private System.Windows.Forms.Label labelRecordAttendance;
        private System.Windows.Forms.ComboBox comboBoxRecord;
        private System.Windows.Forms.Button buttonRecordDisplay;
        private System.Windows.Forms.Button buttonRecordDelete;
        private System.Windows.Forms.Button buttonRecordNew;
        private System.Windows.Forms.Label labelClassCount;
        private System.Windows.Forms.Label labelClassStuNum;
        private System.Windows.Forms.Label labelClassCname;
        private System.Windows.Forms.Label labelStudentAttendance;
        private System.Windows.Forms.Label labelStudentGender;
        private System.Windows.Forms.Label labelStudentSname;
        private System.Windows.Forms.Label labelRecordStatus;
        private System.Windows.Forms.Label labelRecordName;
        private System.Windows.Forms.Label labelRecordSkip;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.GroupBox groupBoxOperation;
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label labelInfo;
        private AForge.Controls.VideoSourcePlayer rgbVideoSource;
        private AForge.Controls.VideoSourcePlayer irVideoSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStudentData;
        private System.Windows.Forms.Button btnTeacherData;
        private System.Windows.Forms.Button btnLogOff;
    }
}