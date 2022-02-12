namespace RegisterStudent
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabStudentList = new System.Windows.Forms.TabPage();
            this.chkShowGraduated = new System.Windows.Forms.CheckBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.tabStudentRegister = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEntryYear = new System.Windows.Forms.Label();
            this.lblStudentStudyField = new System.Windows.Forms.Label();
            this.lblStudentCode = new System.Windows.Forms.Label();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblBirthCertificateLoc = new System.Windows.Forms.Label();
            this.txtBirthCertificateLoc = new System.Windows.Forms.TextBox();
            this.lblBirthCertificateNo = new System.Windows.Forms.Label();
            this.txtBirthCertificateNo = new System.Windows.Forms.TextBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.chkGraduated = new System.Windows.Forms.CheckBox();
            this.cmbEntryYear = new System.Windows.Forms.ComboBox();
            this.cmbStudentStudyField = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBirthdayY = new System.Windows.Forms.ComboBox();
            this.cmbBirthdayM = new System.Windows.Forms.ComboBox();
            this.cmbBirthdayD = new System.Windows.Forms.ComboBox();
            this.lblBirthdayD = new System.Windows.Forms.Label();
            this.lblBirthdayM = new System.Windows.Forms.Label();
            this.lblBirthdayY = new System.Windows.Forms.Label();
            this.lblSaveNewStudentResult = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewStudyFields = new System.Windows.Forms.DataGridView();
            this.study_field_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.study_field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNewStudyfield = new System.Windows.Forms.TextBox();
            this.lblNewStudyField = new System.Windows.Forms.Label();
            this.btnNewStudyField = new System.Windows.Forms.Button();
            this.lblStudyFieldResult = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.father_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_certificate_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_certificate_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_study_field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graduated = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabMain.SuspendLayout();
            this.tabStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabStudentRegister.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudyFields)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabStudentList);
            this.tabMain.Controls.Add(this.tabStudentRegister);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Persian-Zar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabMain.RightToLeftLayout = true;
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1479, 580);
            this.tabMain.TabIndex = 0;
            // 
            // tabStudentList
            // 
            this.tabStudentList.Controls.Add(this.chkShowGraduated);
            this.tabStudentList.Controls.Add(this.dataGridViewStudents);
            this.tabStudentList.Location = new System.Drawing.Point(4, 36);
            this.tabStudentList.Name = "tabStudentList";
            this.tabStudentList.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentList.Size = new System.Drawing.Size(1471, 540);
            this.tabStudentList.TabIndex = 0;
            this.tabStudentList.Text = "لیست دانشجویان";
            this.tabStudentList.UseVisualStyleBackColor = true;
            // 
            // chkShowGraduated
            // 
            this.chkShowGraduated.AutoSize = true;
            this.chkShowGraduated.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkShowGraduated.Location = new System.Drawing.Point(3, 3);
            this.chkShowGraduated.Name = "chkShowGraduated";
            this.chkShowGraduated.Size = new System.Drawing.Size(1465, 31);
            this.chkShowGraduated.TabIndex = 1;
            this.chkShowGraduated.Text = "نمایش دانشجویان فارغ التحصیل";
            this.chkShowGraduated.UseVisualStyleBackColor = true;
            this.chkShowGraduated.CheckedChanged += new System.EventHandler(this.chkShowGraduated_CheckedChanged);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AllowUserToResizeColumns = false;
            this.dataGridViewStudents.AllowUserToResizeRows = false;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Persian-Zar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.code,
            this.birthday,
            this.father_name,
            this.birth_certificate_no,
            this.birth_certificate_location,
            this.entry_year,
            this.student_study_field,
            this.graduated});
            this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewStudents.Location = new System.Drawing.Point(3, 40);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1465, 497);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            this.dataGridViewStudents.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewStudents_CellMouseClick);
            // 
            // tabStudentRegister
            // 
            this.tabStudentRegister.Controls.Add(this.tableLayoutPanel1);
            this.tabStudentRegister.Location = new System.Drawing.Point(4, 36);
            this.tabStudentRegister.Name = "tabStudentRegister";
            this.tabStudentRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabStudentRegister.Size = new System.Drawing.Size(1403, 540);
            this.tabStudentRegister.TabIndex = 1;
            this.tabStudentRegister.Text = "ثبت نام دانشجوی جدید";
            this.tabStudentRegister.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.37131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.62869F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblEntryYear, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblStudentStudyField, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblStudentCode, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtStudentCode, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblBirthday, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBirthCertificateLoc, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBirthCertificateLoc, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblBirthCertificateNo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBirthCertificateNo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFatherName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFatherName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNewStudent, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.chkGraduated, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cmbEntryYear, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbStudentStudyField, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSaveNewStudentResult, 1, 10);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1391, 528);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1167, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 47);
            this.label7.TabIndex = 18;
            this.label7.Text = "فارغ التحصیل";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEntryYear
            // 
            this.lblEntryYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntryYear.AutoSize = true;
            this.lblEntryYear.Location = new System.Drawing.Point(1167, 376);
            this.lblEntryYear.Name = "lblEntryYear";
            this.lblEntryYear.Size = new System.Drawing.Size(221, 47);
            this.lblEntryYear.TabIndex = 16;
            this.lblEntryYear.Text = "سال ورود";
            this.lblEntryYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStudentStudyField
            // 
            this.lblStudentStudyField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentStudyField.AutoSize = true;
            this.lblStudentStudyField.Location = new System.Drawing.Point(1167, 329);
            this.lblStudentStudyField.Name = "lblStudentStudyField";
            this.lblStudentStudyField.Size = new System.Drawing.Size(221, 47);
            this.lblStudentStudyField.TabIndex = 14;
            this.lblStudentStudyField.Text = "رشته تحصیلی";
            this.lblStudentStudyField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStudentCode
            // 
            this.lblStudentCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentCode.AutoSize = true;
            this.lblStudentCode.Location = new System.Drawing.Point(1167, 282);
            this.lblStudentCode.Name = "lblStudentCode";
            this.lblStudentCode.Size = new System.Drawing.Size(221, 47);
            this.lblStudentCode.TabIndex = 12;
            this.lblStudentCode.Text = "شماره دانشجویی";
            this.lblStudentCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentCode.Location = new System.Drawing.Point(3, 285);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(1158, 34);
            this.txtStudentCode.TabIndex = 6;
            // 
            // lblBirthday
            // 
            this.lblBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(1167, 235);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(221, 47);
            this.lblBirthday.TabIndex = 10;
            this.lblBirthday.Text = "تاریخ تولد";
            this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthCertificateLoc
            // 
            this.lblBirthCertificateLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirthCertificateLoc.AutoSize = true;
            this.lblBirthCertificateLoc.Location = new System.Drawing.Point(1167, 188);
            this.lblBirthCertificateLoc.Name = "lblBirthCertificateLoc";
            this.lblBirthCertificateLoc.Size = new System.Drawing.Size(221, 47);
            this.lblBirthCertificateLoc.TabIndex = 8;
            this.lblBirthCertificateLoc.Text = "محل صدور";
            this.lblBirthCertificateLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBirthCertificateLoc
            // 
            this.txtBirthCertificateLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBirthCertificateLoc.Location = new System.Drawing.Point(3, 191);
            this.txtBirthCertificateLoc.Name = "txtBirthCertificateLoc";
            this.txtBirthCertificateLoc.Size = new System.Drawing.Size(1158, 34);
            this.txtBirthCertificateLoc.TabIndex = 4;
            // 
            // lblBirthCertificateNo
            // 
            this.lblBirthCertificateNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirthCertificateNo.AutoSize = true;
            this.lblBirthCertificateNo.Location = new System.Drawing.Point(1167, 141);
            this.lblBirthCertificateNo.Name = "lblBirthCertificateNo";
            this.lblBirthCertificateNo.Size = new System.Drawing.Size(221, 47);
            this.lblBirthCertificateNo.TabIndex = 6;
            this.lblBirthCertificateNo.Text = "شماره شناسنامه";
            this.lblBirthCertificateNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBirthCertificateNo
            // 
            this.txtBirthCertificateNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBirthCertificateNo.Location = new System.Drawing.Point(3, 144);
            this.txtBirthCertificateNo.Name = "txtBirthCertificateNo";
            this.txtBirthCertificateNo.Size = new System.Drawing.Size(1158, 34);
            this.txtBirthCertificateNo.TabIndex = 3;
            // 
            // lblFatherName
            // 
            this.lblFatherName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(1167, 94);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(221, 47);
            this.lblFatherName.TabIndex = 4;
            this.lblFatherName.Text = "نام پدر";
            this.lblFatherName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFatherName.Location = new System.Drawing.Point(3, 97);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(1158, 34);
            this.txtFatherName.TabIndex = 2;
            // 
            // lblLname
            // 
            this.lblLname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(1167, 47);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(221, 47);
            this.lblLname.TabIndex = 2;
            this.lblLname.Text = "نام خانوادگی";
            this.lblLname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLname
            // 
            this.txtLname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLname.Location = new System.Drawing.Point(3, 50);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(1158, 34);
            this.txtLname.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1167, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(221, 47);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "نام";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(1158, 34);
            this.txtName.TabIndex = 0;
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewStudent.Location = new System.Drawing.Point(1167, 473);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(221, 52);
            this.btnNewStudent.TabIndex = 10;
            this.btnNewStudent.Text = "ثبت نام";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // chkGraduated
            // 
            this.chkGraduated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGraduated.AutoSize = true;
            this.chkGraduated.Location = new System.Drawing.Point(3, 426);
            this.chkGraduated.Name = "chkGraduated";
            this.chkGraduated.Size = new System.Drawing.Size(1158, 41);
            this.chkGraduated.TabIndex = 9;
            this.chkGraduated.UseVisualStyleBackColor = true;
            // 
            // cmbEntryYear
            // 
            this.cmbEntryYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEntryYear.DropDownHeight = 150;
            this.cmbEntryYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntryYear.FormattingEnabled = true;
            this.cmbEntryYear.IntegralHeight = false;
            this.cmbEntryYear.Items.AddRange(new object[] {
            "1340",
            "1341",
            "1342",
            "1343",
            "1344",
            "1345",
            "1346",
            "1347",
            "1348",
            "1349",
            "1350",
            "1351",
            "1352",
            "1353",
            "1354",
            "1355",
            "1356",
            "1357",
            "1358",
            "1359",
            "1360",
            "1361",
            "1362",
            "1363",
            "1364",
            "1365",
            "1366",
            "1367",
            "1368",
            "1369",
            "1370",
            "1371",
            "1372",
            "1373",
            "1374",
            "1375",
            "1376",
            "1377",
            "1378",
            "1379",
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
            "1387",
            "1388",
            "1389",
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400"});
            this.cmbEntryYear.Location = new System.Drawing.Point(3, 379);
            this.cmbEntryYear.Name = "cmbEntryYear";
            this.cmbEntryYear.Size = new System.Drawing.Size(1158, 35);
            this.cmbEntryYear.TabIndex = 8;
            // 
            // cmbStudentStudyField
            // 
            this.cmbStudentStudyField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStudentStudyField.DropDownHeight = 150;
            this.cmbStudentStudyField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentStudyField.FormattingEnabled = true;
            this.cmbStudentStudyField.IntegralHeight = false;
            this.cmbStudentStudyField.Location = new System.Drawing.Point(3, 332);
            this.cmbStudentStudyField.Name = "cmbStudentStudyField";
            this.cmbStudentStudyField.Size = new System.Drawing.Size(1158, 35);
            this.cmbStudentStudyField.TabIndex = 7;
            this.cmbStudentStudyField.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.cmbBirthdayY, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbBirthdayM, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbBirthdayD, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBirthdayD, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBirthdayM, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBirthdayY, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 238);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1158, 41);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // cmbBirthdayY
            // 
            this.cmbBirthdayY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBirthdayY.DropDownHeight = 150;
            this.cmbBirthdayY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirthdayY.FormattingEnabled = true;
            this.cmbBirthdayY.IntegralHeight = false;
            this.cmbBirthdayY.Items.AddRange(new object[] {
            "1340",
            "1341",
            "1342",
            "1343",
            "1344",
            "1345",
            "1346",
            "1347",
            "1348",
            "1349",
            "1350",
            "1351",
            "1352",
            "1353",
            "1354",
            "1355",
            "1356",
            "1357",
            "1358",
            "1359",
            "1360",
            "1361",
            "1362",
            "1363",
            "1364",
            "1365",
            "1366",
            "1367",
            "1368",
            "1369",
            "1370",
            "1371",
            "1372",
            "1373",
            "1374",
            "1375",
            "1376",
            "1377",
            "1378",
            "1379",
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
            "1387",
            "1388",
            "1389",
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400"});
            this.cmbBirthdayY.Location = new System.Drawing.Point(3, 3);
            this.cmbBirthdayY.Name = "cmbBirthdayY";
            this.cmbBirthdayY.Size = new System.Drawing.Size(337, 35);
            this.cmbBirthdayY.TabIndex = 2;
            // 
            // cmbBirthdayM
            // 
            this.cmbBirthdayM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBirthdayM.DropDownHeight = 150;
            this.cmbBirthdayM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirthdayM.FormattingEnabled = true;
            this.cmbBirthdayM.IntegralHeight = false;
            this.cmbBirthdayM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbBirthdayM.Location = new System.Drawing.Point(393, 3);
            this.cmbBirthdayM.Name = "cmbBirthdayM";
            this.cmbBirthdayM.Size = new System.Drawing.Size(337, 35);
            this.cmbBirthdayM.TabIndex = 1;
            // 
            // cmbBirthdayD
            // 
            this.cmbBirthdayD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBirthdayD.DropDownHeight = 150;
            this.cmbBirthdayD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirthdayD.FormattingEnabled = true;
            this.cmbBirthdayD.IntegralHeight = false;
            this.cmbBirthdayD.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbBirthdayD.Location = new System.Drawing.Point(775, 3);
            this.cmbBirthdayD.Name = "cmbBirthdayD";
            this.cmbBirthdayD.Size = new System.Drawing.Size(337, 35);
            this.cmbBirthdayD.TabIndex = 0;
            // 
            // lblBirthdayD
            // 
            this.lblBirthdayD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirthdayD.AutoSize = true;
            this.lblBirthdayD.Location = new System.Drawing.Point(1118, 0);
            this.lblBirthdayD.Name = "lblBirthdayD";
            this.lblBirthdayD.Size = new System.Drawing.Size(37, 41);
            this.lblBirthdayD.TabIndex = 25;
            this.lblBirthdayD.Text = "روز:";
            this.lblBirthdayD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthdayM
            // 
            this.lblBirthdayM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirthdayM.AutoSize = true;
            this.lblBirthdayM.Location = new System.Drawing.Point(736, 0);
            this.lblBirthdayM.Name = "lblBirthdayM";
            this.lblBirthdayM.Size = new System.Drawing.Size(33, 41);
            this.lblBirthdayM.TabIndex = 26;
            this.lblBirthdayM.Text = "ماه:";
            this.lblBirthdayM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthdayY
            // 
            this.lblBirthdayY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBirthdayY.AutoSize = true;
            this.lblBirthdayY.Location = new System.Drawing.Point(346, 0);
            this.lblBirthdayY.Name = "lblBirthdayY";
            this.lblBirthdayY.Size = new System.Drawing.Size(41, 41);
            this.lblBirthdayY.TabIndex = 27;
            this.lblBirthdayY.Text = "سال:";
            this.lblBirthdayY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSaveNewStudentResult
            // 
            this.lblSaveNewStudentResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaveNewStudentResult.AutoSize = true;
            this.lblSaveNewStudentResult.ForeColor = System.Drawing.Color.Red;
            this.lblSaveNewStudentResult.Location = new System.Drawing.Point(3, 485);
            this.lblSaveNewStudentResult.Name = "lblSaveNewStudentResult";
            this.lblSaveNewStudentResult.Size = new System.Drawing.Size(1158, 27);
            this.lblSaveNewStudentResult.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1403, 540);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "رشته های تحصیلی";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewStudyFields, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.90521F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.09479F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1391, 528);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dataGridViewStudyFields
            // 
            this.dataGridViewStudyFields.AllowUserToAddRows = false;
            this.dataGridViewStudyFields.AllowUserToDeleteRows = false;
            this.dataGridViewStudyFields.AllowUserToResizeColumns = false;
            this.dataGridViewStudyFields.AllowUserToResizeRows = false;
            this.dataGridViewStudyFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudyFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudyFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudyFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.study_field_Id,
            this.study_field});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Persian-Zar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudyFields.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudyFields.Location = new System.Drawing.Point(3, 108);
            this.dataGridViewStudyFields.Name = "dataGridViewStudyFields";
            this.dataGridViewStudyFields.ReadOnly = true;
            this.dataGridViewStudyFields.RowHeadersVisible = false;
            this.dataGridViewStudyFields.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewStudyFields.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudyFields.RowTemplate.Height = 24;
            this.dataGridViewStudyFields.Size = new System.Drawing.Size(1385, 417);
            this.dataGridViewStudyFields.TabIndex = 0;
            // 
            // study_field_Id
            // 
            this.study_field_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.study_field_Id.DataPropertyName = "Id";
            this.study_field_Id.FillWeight = 106.9519F;
            this.study_field_Id.HeaderText = "آیدی";
            this.study_field_Id.MinimumWidth = 6;
            this.study_field_Id.Name = "study_field_Id";
            this.study_field_Id.ReadOnly = true;
            this.study_field_Id.Width = 76;
            // 
            // study_field
            // 
            this.study_field.DataPropertyName = "name";
            this.study_field.FillWeight = 93.04813F;
            this.study_field.HeaderText = "رشته تحصیلی";
            this.study_field.MinimumWidth = 6;
            this.study_field.Name = "study_field";
            this.study_field.ReadOnly = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.14863F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.85137F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 511F));
            this.tableLayoutPanel4.Controls.Add(this.txtNewStudyfield, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblNewStudyField, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnNewStudyField, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblStudyFieldResult, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1385, 99);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // txtNewStudyfield
            // 
            this.txtNewStudyfield.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNewStudyfield.Location = new System.Drawing.Point(834, 32);
            this.txtNewStudyfield.Name = "txtNewStudyfield";
            this.txtNewStudyfield.Size = new System.Drawing.Size(344, 34);
            this.txtNewStudyfield.TabIndex = 1;
            // 
            // lblNewStudyField
            // 
            this.lblNewStudyField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewStudyField.AutoSize = true;
            this.lblNewStudyField.Location = new System.Drawing.Point(1184, 36);
            this.lblNewStudyField.Name = "lblNewStudyField";
            this.lblNewStudyField.Size = new System.Drawing.Size(198, 27);
            this.lblNewStudyField.TabIndex = 0;
            this.lblNewStudyField.Text = "رشته تحصیلی جدید";
            // 
            // btnNewStudyField
            // 
            this.btnNewStudyField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewStudyField.Location = new System.Drawing.Point(559, 32);
            this.btnNewStudyField.Name = "btnNewStudyField";
            this.btnNewStudyField.Size = new System.Drawing.Size(188, 34);
            this.btnNewStudyField.TabIndex = 2;
            this.btnNewStudyField.Text = "ثبت";
            this.btnNewStudyField.UseVisualStyleBackColor = true;
            this.btnNewStudyField.Click += new System.EventHandler(this.btnNewStudyField_Click);
            // 
            // lblStudyFieldResult
            // 
            this.lblStudyFieldResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStudyFieldResult.AutoSize = true;
            this.lblStudyFieldResult.Location = new System.Drawing.Point(509, 36);
            this.lblStudyFieldResult.Name = "lblStudyFieldResult";
            this.lblStudyFieldResult.Size = new System.Drawing.Size(0, 27);
            this.lblStudyFieldResult.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "شناسه سیستمی";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام دانشجو";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "شماره دانشحویی";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "تاریخ تولد";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            // 
            // father_name
            // 
            this.father_name.DataPropertyName = "father_name";
            this.father_name.HeaderText = "نام پدر";
            this.father_name.MinimumWidth = 6;
            this.father_name.Name = "father_name";
            this.father_name.ReadOnly = true;
            // 
            // birth_certificate_no
            // 
            this.birth_certificate_no.DataPropertyName = "birth_certificate_no";
            this.birth_certificate_no.HeaderText = "شماره شناسنامه";
            this.birth_certificate_no.MinimumWidth = 6;
            this.birth_certificate_no.Name = "birth_certificate_no";
            this.birth_certificate_no.ReadOnly = true;
            // 
            // birth_certificate_location
            // 
            this.birth_certificate_location.DataPropertyName = "birth_certificate_location";
            this.birth_certificate_location.HeaderText = "محل صدور";
            this.birth_certificate_location.MinimumWidth = 6;
            this.birth_certificate_location.Name = "birth_certificate_location";
            this.birth_certificate_location.ReadOnly = true;
            // 
            // entry_year
            // 
            this.entry_year.DataPropertyName = "entry_year";
            this.entry_year.HeaderText = "سال ورود";
            this.entry_year.MinimumWidth = 6;
            this.entry_year.Name = "entry_year";
            this.entry_year.ReadOnly = true;
            // 
            // student_study_field
            // 
            this.student_study_field.DataPropertyName = "study_field";
            this.student_study_field.HeaderText = "رشته تحصیلی";
            this.student_study_field.MinimumWidth = 6;
            this.student_study_field.Name = "student_study_field";
            this.student_study_field.ReadOnly = true;
            // 
            // graduated
            // 
            this.graduated.DataPropertyName = "graduated";
            this.graduated.HeaderText = "فارغ التحصیل شده";
            this.graduated.MinimumWidth = 6;
            this.graduated.Name = "graduated";
            this.graduated.ReadOnly = true;
            this.graduated.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.graduated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 580);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ثبت نام دانشجویان";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabStudentList.ResumeLayout(false);
            this.tabStudentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabStudentRegister.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudyFields)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabStudentList;
        private System.Windows.Forms.TabPage tabStudentRegister;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStudentStudyField;
        private System.Windows.Forms.Label lblStudentCode;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblBirthCertificateLoc;
        private System.Windows.Forms.TextBox txtBirthCertificateLoc;
        private System.Windows.Forms.Label lblBirthCertificateNo;
        private System.Windows.Forms.TextBox txtBirthCertificateNo;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Label lblEntryYear;
        private System.Windows.Forms.CheckBox chkGraduated;
        private System.Windows.Forms.ComboBox cmbEntryYear;
        private System.Windows.Forms.ComboBox cmbStudentStudyField;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbBirthdayY;
        private System.Windows.Forms.ComboBox cmbBirthdayM;
        private System.Windows.Forms.ComboBox cmbBirthdayD;
        private System.Windows.Forms.Label lblBirthdayD;
        private System.Windows.Forms.Label lblBirthdayM;
        private System.Windows.Forms.Label lblBirthdayY;
        private System.Windows.Forms.CheckBox chkShowGraduated;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridViewStudyFields;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblNewStudyField;
        private System.Windows.Forms.TextBox txtNewStudyfield;
        private System.Windows.Forms.Button btnNewStudyField;
        private System.Windows.Forms.Label lblStudyFieldResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn study_field_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn study_field;
        private System.Windows.Forms.Label lblSaveNewStudentResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn father_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_certificate_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_certificate_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_study_field;
        private System.Windows.Forms.DataGridViewCheckBoxColumn graduated;
    }
}

