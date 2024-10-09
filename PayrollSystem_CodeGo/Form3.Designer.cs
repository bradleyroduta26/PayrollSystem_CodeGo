using System.Runtime.CompilerServices;

namespace PayrollSystem_CodeGo
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnManageDeductions = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblContactResult = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.TableResult = new System.Windows.Forms.Label();
            this.lblJobSalaryResult = new System.Windows.Forms.Label();
            this.lblPastSalaryResult = new System.Windows.Forms.Label();
            this.lblJobSalary = new System.Windows.Forms.Label();
            this.lblPastSalary = new System.Windows.Forms.Label();
            this.lblAddressResult = new System.Windows.Forms.Label();
            this.lblEmailResult = new System.Windows.Forms.Label();
            this.lblJtitleResult = new System.Windows.Forms.Label();
            this.lblMnameResult = new System.Windows.Forms.Label();
            this.lblFnameResult = new System.Windows.Forms.Label();
            this.lblLnameResult = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblJobtitle = new System.Windows.Forms.Label();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddepmloyee = new System.Windows.Forms.Button();
            this.btnComputeSalary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnManageDeductions);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAddepmloyee);
            this.panel1.Controls.Add(this.btnComputeSalary);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblSearchEmployee);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 612);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sans Serif Collection", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(416, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "CODEGO PAYROLL";
            // 
            // btnManageDeductions
            // 
            this.btnManageDeductions.BackColor = System.Drawing.Color.DarkCyan;
            this.btnManageDeductions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageDeductions.Font = new System.Drawing.Font("Sans Serif Collection", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDeductions.ForeColor = System.Drawing.Color.White;
            this.btnManageDeductions.Location = new System.Drawing.Point(192, 523);
            this.btnManageDeductions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageDeductions.Name = "btnManageDeductions";
            this.btnManageDeductions.Size = new System.Drawing.Size(212, 34);
            this.btnManageDeductions.TabIndex = 10;
            this.btnManageDeductions.Text = "Manage Deduction";
            this.btnManageDeductions.UseVisualStyleBackColor = false;
            this.btnManageDeductions.Click += new System.EventHandler(this.btnManageDeductions_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.lblContactResult);
            this.panel2.Controls.Add(this.lblNum);
            this.panel2.Controls.Add(this.TableResult);
            this.panel2.Controls.Add(this.lblJobSalaryResult);
            this.panel2.Controls.Add(this.lblPastSalaryResult);
            this.panel2.Controls.Add(this.lblJobSalary);
            this.panel2.Controls.Add(this.lblPastSalary);
            this.panel2.Controls.Add(this.lblAddressResult);
            this.panel2.Controls.Add(this.lblEmailResult);
            this.panel2.Controls.Add(this.lblJtitleResult);
            this.panel2.Controls.Add(this.lblMnameResult);
            this.panel2.Controls.Add(this.lblFnameResult);
            this.panel2.Controls.Add(this.lblLnameResult);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblJobtitle);
            this.panel2.Controls.Add(this.lblMiddlename);
            this.panel2.Controls.Add(this.lblFirstname);
            this.panel2.Controls.Add(this.lblLastname);
            this.panel2.Location = new System.Drawing.Point(13, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 414);
            this.panel2.TabIndex = 9;
            // 
            // lblContactResult
            // 
            this.lblContactResult.AutoSize = true;
            this.lblContactResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactResult.ForeColor = System.Drawing.Color.Black;
            this.lblContactResult.Location = new System.Drawing.Point(232, 262);
            this.lblContactResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactResult.Name = "lblContactResult";
            this.lblContactResult.Size = new System.Drawing.Size(0, 16);
            this.lblContactResult.TabIndex = 18;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.Black;
            this.lblNum.Location = new System.Drawing.Point(68, 255);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(156, 29);
            this.lblNum.TabIndex = 17;
            this.lblNum.Text = "Contact No :";
            // 
            // TableResult
            // 
            this.TableResult.BackColor = System.Drawing.Color.DimGray;
            this.TableResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableResult.ForeColor = System.Drawing.Color.White;
            this.TableResult.Location = new System.Drawing.Point(1, 0);
            this.TableResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TableResult.Name = "TableResult";
            this.TableResult.Size = new System.Drawing.Size(972, 34);
            this.TableResult.TabIndex = 16;
            this.TableResult.Text = "SEARCH RESULT";
            this.TableResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJobSalaryResult
            // 
            this.lblJobSalaryResult.AutoSize = true;
            this.lblJobSalaryResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobSalaryResult.ForeColor = System.Drawing.Color.Black;
            this.lblJobSalaryResult.Location = new System.Drawing.Point(636, 262);
            this.lblJobSalaryResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobSalaryResult.Name = "lblJobSalaryResult";
            this.lblJobSalaryResult.Size = new System.Drawing.Size(0, 16);
            this.lblJobSalaryResult.TabIndex = 15;
            // 
            // lblPastSalaryResult
            // 
            this.lblPastSalaryResult.AutoSize = true;
            this.lblPastSalaryResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastSalaryResult.ForeColor = System.Drawing.Color.Black;
            this.lblPastSalaryResult.Location = new System.Drawing.Point(636, 186);
            this.lblPastSalaryResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPastSalaryResult.Name = "lblPastSalaryResult";
            this.lblPastSalaryResult.Size = new System.Drawing.Size(0, 16);
            this.lblPastSalaryResult.TabIndex = 14;
            // 
            // lblJobSalary
            // 
            this.lblJobSalary.AutoSize = true;
            this.lblJobSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobSalary.ForeColor = System.Drawing.Color.Black;
            this.lblJobSalary.Location = new System.Drawing.Point(478, 255);
            this.lblJobSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobSalary.Name = "lblJobSalary";
            this.lblJobSalary.Size = new System.Drawing.Size(150, 29);
            this.lblJobSalary.TabIndex = 13;
            this.lblJobSalary.Text = "Job Salary :";
            // 
            // lblPastSalary
            // 
            this.lblPastSalary.AutoSize = true;
            this.lblPastSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastSalary.ForeColor = System.Drawing.Color.Black;
            this.lblPastSalary.Location = new System.Drawing.Point(470, 179);
            this.lblPastSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPastSalary.Name = "lblPastSalary";
            this.lblPastSalary.Size = new System.Drawing.Size(158, 29);
            this.lblPastSalary.TabIndex = 12;
            this.lblPastSalary.Text = "Past Salary :";
            // 
            // lblAddressResult
            // 
            this.lblAddressResult.AutoSize = true;
            this.lblAddressResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressResult.ForeColor = System.Drawing.Color.Black;
            this.lblAddressResult.Location = new System.Drawing.Point(636, 118);
            this.lblAddressResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressResult.Name = "lblAddressResult";
            this.lblAddressResult.Size = new System.Drawing.Size(0, 16);
            this.lblAddressResult.TabIndex = 11;
            // 
            // lblEmailResult
            // 
            this.lblEmailResult.AutoSize = true;
            this.lblEmailResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailResult.ForeColor = System.Drawing.Color.Black;
            this.lblEmailResult.Location = new System.Drawing.Point(636, 53);
            this.lblEmailResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailResult.Name = "lblEmailResult";
            this.lblEmailResult.Size = new System.Drawing.Size(0, 16);
            this.lblEmailResult.TabIndex = 10;
            // 
            // lblJtitleResult
            // 
            this.lblJtitleResult.AutoSize = true;
            this.lblJtitleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJtitleResult.ForeColor = System.Drawing.Color.Black;
            this.lblJtitleResult.Location = new System.Drawing.Point(232, 337);
            this.lblJtitleResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJtitleResult.Name = "lblJtitleResult";
            this.lblJtitleResult.Size = new System.Drawing.Size(0, 16);
            this.lblJtitleResult.TabIndex = 9;
            // 
            // lblMnameResult
            // 
            this.lblMnameResult.AutoSize = true;
            this.lblMnameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnameResult.ForeColor = System.Drawing.Color.Black;
            this.lblMnameResult.Location = new System.Drawing.Point(232, 194);
            this.lblMnameResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMnameResult.Name = "lblMnameResult";
            this.lblMnameResult.Size = new System.Drawing.Size(0, 16);
            this.lblMnameResult.TabIndex = 8;
            // 
            // lblFnameResult
            // 
            this.lblFnameResult.AutoSize = true;
            this.lblFnameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFnameResult.ForeColor = System.Drawing.Color.Black;
            this.lblFnameResult.Location = new System.Drawing.Point(232, 121);
            this.lblFnameResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFnameResult.Name = "lblFnameResult";
            this.lblFnameResult.Size = new System.Drawing.Size(0, 16);
            this.lblFnameResult.TabIndex = 7;
            // 
            // lblLnameResult
            // 
            this.lblLnameResult.AutoSize = true;
            this.lblLnameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLnameResult.ForeColor = System.Drawing.Color.Black;
            this.lblLnameResult.Location = new System.Drawing.Point(232, 55);
            this.lblLnameResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLnameResult.Name = "lblLnameResult";
            this.lblLnameResult.Size = new System.Drawing.Size(0, 16);
            this.lblLnameResult.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(505, 111);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(123, 29);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(535, 47);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(93, 29);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email :";
            // 
            // lblJobtitle
            // 
            this.lblJobtitle.AutoSize = true;
            this.lblJobtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobtitle.ForeColor = System.Drawing.Color.Black;
            this.lblJobtitle.Location = new System.Drawing.Point(94, 330);
            this.lblJobtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobtitle.Name = "lblJobtitle";
            this.lblJobtitle.Size = new System.Drawing.Size(130, 29);
            this.lblJobtitle.TabIndex = 3;
            this.lblJobtitle.Text = "Job Title :";
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.ForeColor = System.Drawing.Color.Black;
            this.lblMiddlename.Location = new System.Drawing.Point(53, 187);
            this.lblMiddlename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(171, 29);
            this.lblMiddlename.TabIndex = 2;
            this.lblMiddlename.Text = "Middlename :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.Color.Black;
            this.lblFirstname.Location = new System.Drawing.Point(81, 114);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(143, 29);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Firstname :";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.Black;
            this.lblLastname.Location = new System.Drawing.Point(85, 47);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(139, 29);
            this.lblLastname.TabIndex = 0;
            this.lblLastname.Text = "Lastname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(345, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "SEARCH EMPLOYEE";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Sans Serif Collection", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(673, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 27);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddepmloyee
            // 
            this.btnAddepmloyee.BackColor = System.Drawing.Color.Green;
            this.btnAddepmloyee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddepmloyee.Font = new System.Drawing.Font("Sans Serif Collection", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddepmloyee.ForeColor = System.Drawing.Color.White;
            this.btnAddepmloyee.Location = new System.Drawing.Point(13, 524);
            this.btnAddepmloyee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddepmloyee.Name = "btnAddepmloyee";
            this.btnAddepmloyee.Size = new System.Drawing.Size(172, 34);
            this.btnAddepmloyee.TabIndex = 6;
            this.btnAddepmloyee.Text = "Register Employee";
            this.btnAddepmloyee.UseVisualStyleBackColor = false;
            this.btnAddepmloyee.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnComputeSalary
            // 
            this.btnComputeSalary.BackColor = System.Drawing.Color.DarkCyan;
            this.btnComputeSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputeSalary.Font = new System.Drawing.Font("Sans Serif Collection", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputeSalary.ForeColor = System.Drawing.Color.White;
            this.btnComputeSalary.Location = new System.Drawing.Point(410, 523);
            this.btnComputeSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComputeSalary.Name = "btnComputeSalary";
            this.btnComputeSalary.Size = new System.Drawing.Size(183, 34);
            this.btnComputeSalary.TabIndex = 5;
            this.btnComputeSalary.Text = "Manage Salary";
            this.btnComputeSalary.UseVisualStyleBackColor = false;
            this.btnComputeSalary.Click += new System.EventHandler(this.btnComputeSalary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(419, 77);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Sans Serif Collection", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmployee.ForeColor = System.Drawing.Color.White;
            this.lblSearchEmployee.Location = new System.Drawing.Point(188, 78);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(165, 24);
            this.lblSearchEmployee.TabIndex = 1;
            this.lblSearchEmployee.Text = "Search Employee ID ";
            this.lblSearchEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sans Serif Collection", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(854, 524);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 568);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEARCH";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.Button btnComputeSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddepmloyee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblJobtitle;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblLnameResult;
        private System.Windows.Forms.Label lblAddressResult;
        private System.Windows.Forms.Label lblEmailResult;
        private System.Windows.Forms.Label lblJtitleResult;
        private System.Windows.Forms.Label lblMnameResult;
        private System.Windows.Forms.Label lblFnameResult;
        private System.Windows.Forms.Button btnManageDeductions;
        private System.Windows.Forms.Label lblJobSalaryResult;
        private System.Windows.Forms.Label lblPastSalaryResult;
        private System.Windows.Forms.Label lblJobSalary;
        private System.Windows.Forms.Label lblPastSalary;
        private System.Windows.Forms.Label TableResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblContactResult;
        private System.Windows.Forms.Button button1;
    }
}