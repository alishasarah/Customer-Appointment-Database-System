
namespace C969AlishaCrockford
{
    partial class Appointments
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
            this.labelAppointmentsWelcome = new System.Windows.Forms.Label();
            this.labelAppointmentsFilter = new System.Windows.Forms.Label();
            this.radioButtonApptAll = new System.Windows.Forms.RadioButton();
            this.radioButtonApptWeek = new System.Windows.Forms.RadioButton();
            this.radioButtonApptMonth = new System.Windows.Forms.RadioButton();
            this.buttonAppointmentLogout = new System.Windows.Forms.Button();
            this.buttonAppointmentModify = new System.Windows.Forms.Button();
            this.buttonAppointmentDelete = new System.Windows.Forms.Button();
            this.buttonAppointmentAdd = new System.Windows.Forms.Button();
            this.buttonAppointmentBack = new System.Windows.Forms.Button();
            this.dataGridViewAppt = new System.Windows.Forms.DataGridView();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.btnInPerson = new System.Windows.Forms.RadioButton();
            this.btnVirtual = new System.Windows.Forms.RadioButton();
            this.textAddApptCustomer = new System.Windows.Forms.TextBox();
            this.labelAddApptEnd = new System.Windows.Forms.Label();
            this.labelAddApptStart = new System.Windows.Forms.Label();
            this.labelAddApptType = new System.Windows.Forms.Label();
            this.labelAddApptCustomer = new System.Windows.Forms.Label();
            this.buttonApptSave = new System.Windows.Forms.Button();
            this.textAddApptUser = new System.Windows.Forms.TextBox();
            this.labelAddApptUser = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchApptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppt)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAppointmentsWelcome
            // 
            this.labelAppointmentsWelcome.AutoSize = true;
            this.labelAppointmentsWelcome.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelAppointmentsWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentsWelcome.Location = new System.Drawing.Point(149, 33);
            this.labelAppointmentsWelcome.Name = "labelAppointmentsWelcome";
            this.labelAppointmentsWelcome.Size = new System.Drawing.Size(388, 39);
            this.labelAppointmentsWelcome.TabIndex = 9;
            this.labelAppointmentsWelcome.Text = "Global Constultations, Inc.";
            // 
            // labelAppointmentsFilter
            // 
            this.labelAppointmentsFilter.AutoSize = true;
            this.labelAppointmentsFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentsFilter.Location = new System.Drawing.Point(241, 81);
            this.labelAppointmentsFilter.Name = "labelAppointmentsFilter";
            this.labelAppointmentsFilter.Size = new System.Drawing.Size(202, 23);
            this.labelAppointmentsFilter.TabIndex = 10;
            this.labelAppointmentsFilter.Text = "Filter appointments by:";
            // 
            // radioButtonApptAll
            // 
            this.radioButtonApptAll.AutoSize = true;
            this.radioButtonApptAll.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonApptAll.Location = new System.Drawing.Point(138, 109);
            this.radioButtonApptAll.Name = "radioButtonApptAll";
            this.radioButtonApptAll.Size = new System.Drawing.Size(46, 25);
            this.radioButtonApptAll.TabIndex = 11;
            this.radioButtonApptAll.TabStop = true;
            this.radioButtonApptAll.Text = "All";
            this.radioButtonApptAll.UseVisualStyleBackColor = true;
            this.radioButtonApptAll.CheckedChanged += new System.EventHandler(this.radioButtonApptAll_CheckedChanged);
            // 
            // radioButtonApptWeek
            // 
            this.radioButtonApptWeek.AutoSize = true;
            this.radioButtonApptWeek.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonApptWeek.Location = new System.Drawing.Point(291, 109);
            this.radioButtonApptWeek.Name = "radioButtonApptWeek";
            this.radioButtonApptWeek.Size = new System.Drawing.Size(111, 25);
            this.radioButtonApptWeek.TabIndex = 12;
            this.radioButtonApptWeek.TabStop = true;
            this.radioButtonApptWeek.Text = "Next 7 Days";
            this.radioButtonApptWeek.UseVisualStyleBackColor = true;
            this.radioButtonApptWeek.CheckedChanged += new System.EventHandler(this.radioButtonApptWeek_CheckedChanged);
            // 
            // radioButtonApptMonth
            // 
            this.radioButtonApptMonth.AutoSize = true;
            this.radioButtonApptMonth.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonApptMonth.Location = new System.Drawing.Point(479, 109);
            this.radioButtonApptMonth.Name = "radioButtonApptMonth";
            this.radioButtonApptMonth.Size = new System.Drawing.Size(120, 25);
            this.radioButtonApptMonth.TabIndex = 13;
            this.radioButtonApptMonth.TabStop = true;
            this.radioButtonApptMonth.Text = "Next 30 Days";
            this.radioButtonApptMonth.UseVisualStyleBackColor = true;
            this.radioButtonApptMonth.CheckedChanged += new System.EventHandler(this.radioButtonApptMonth_CheckedChanged);
            // 
            // buttonAppointmentLogout
            // 
            this.buttonAppointmentLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentLogout.Location = new System.Drawing.Point(572, 601);
            this.buttonAppointmentLogout.Name = "buttonAppointmentLogout";
            this.buttonAppointmentLogout.Size = new System.Drawing.Size(100, 50);
            this.buttonAppointmentLogout.TabIndex = 17;
            this.buttonAppointmentLogout.Text = "Logout";
            this.buttonAppointmentLogout.UseVisualStyleBackColor = true;
            this.buttonAppointmentLogout.Click += new System.EventHandler(this.buttonAppointmentLogout_Click);
            // 
            // buttonAppointmentModify
            // 
            this.buttonAppointmentModify.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentModify.Location = new System.Drawing.Point(297, 599);
            this.buttonAppointmentModify.Name = "buttonAppointmentModify";
            this.buttonAppointmentModify.Size = new System.Drawing.Size(100, 50);
            this.buttonAppointmentModify.TabIndex = 16;
            this.buttonAppointmentModify.Text = "Modify";
            this.buttonAppointmentModify.UseVisualStyleBackColor = true;
            this.buttonAppointmentModify.Click += new System.EventHandler(this.buttonAppointmentModify_Click);
            // 
            // buttonAppointmentDelete
            // 
            this.buttonAppointmentDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentDelete.Location = new System.Drawing.Point(451, 599);
            this.buttonAppointmentDelete.Name = "buttonAppointmentDelete";
            this.buttonAppointmentDelete.Size = new System.Drawing.Size(100, 50);
            this.buttonAppointmentDelete.TabIndex = 15;
            this.buttonAppointmentDelete.Text = "Delete";
            this.buttonAppointmentDelete.UseVisualStyleBackColor = true;
            this.buttonAppointmentDelete.Click += new System.EventHandler(this.buttonAppointmentDelete_Click);
            // 
            // buttonAppointmentAdd
            // 
            this.buttonAppointmentAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentAdd.Location = new System.Drawing.Point(137, 599);
            this.buttonAppointmentAdd.Name = "buttonAppointmentAdd";
            this.buttonAppointmentAdd.Size = new System.Drawing.Size(100, 50);
            this.buttonAppointmentAdd.TabIndex = 14;
            this.buttonAppointmentAdd.Text = "Add";
            this.buttonAppointmentAdd.UseVisualStyleBackColor = true;
            this.buttonAppointmentAdd.Click += new System.EventHandler(this.buttonAppointmentAdd_Click);
            // 
            // buttonAppointmentBack
            // 
            this.buttonAppointmentBack.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentBack.Location = new System.Drawing.Point(12, 599);
            this.buttonAppointmentBack.Name = "buttonAppointmentBack";
            this.buttonAppointmentBack.Size = new System.Drawing.Size(100, 50);
            this.buttonAppointmentBack.TabIndex = 18;
            this.buttonAppointmentBack.Text = "Back";
            this.buttonAppointmentBack.UseVisualStyleBackColor = true;
            this.buttonAppointmentBack.Click += new System.EventHandler(this.buttonAppointmentBack_Click);
            // 
            // dataGridViewAppt
            // 
            this.dataGridViewAppt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppt.Location = new System.Drawing.Point(70, 186);
            this.dataGridViewAppt.Name = "dataGridViewAppt";
            this.dataGridViewAppt.Size = new System.Drawing.Size(549, 174);
            this.dataGridViewAppt.TabIndex = 19;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimeEnd.Enabled = false;
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(288, 516);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEnd.TabIndex = 62;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimeStart.Enabled = false;
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(288, 481);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimeStart.TabIndex = 61;
            this.dateTimeStart.Value = new System.DateTime(2022, 10, 10, 15, 18, 15, 0);
            // 
            // btnInPerson
            // 
            this.btnInPerson.AutoSize = true;
            this.btnInPerson.Enabled = false;
            this.btnInPerson.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPerson.Location = new System.Drawing.Point(402, 443);
            this.btnInPerson.Name = "btnInPerson";
            this.btnInPerson.Size = new System.Drawing.Size(110, 27);
            this.btnInPerson.TabIndex = 60;
            this.btnInPerson.TabStop = true;
            this.btnInPerson.Text = "In-Person";
            this.btnInPerson.UseVisualStyleBackColor = true;
            this.btnInPerson.CheckedChanged += new System.EventHandler(this.btnInPerson_CheckedChanged);
            // 
            // btnVirtual
            // 
            this.btnVirtual.AutoSize = true;
            this.btnVirtual.Enabled = false;
            this.btnVirtual.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirtual.Location = new System.Drawing.Point(288, 443);
            this.btnVirtual.Name = "btnVirtual";
            this.btnVirtual.Size = new System.Drawing.Size(84, 27);
            this.btnVirtual.TabIndex = 59;
            this.btnVirtual.TabStop = true;
            this.btnVirtual.Text = "Virtual";
            this.btnVirtual.UseVisualStyleBackColor = true;
            this.btnVirtual.CheckedChanged += new System.EventHandler(this.btnVirtual_CheckedChanged);
            // 
            // textAddApptCustomer
            // 
            this.textAddApptCustomer.Enabled = false;
            this.textAddApptCustomer.Location = new System.Drawing.Point(288, 377);
            this.textAddApptCustomer.Multiline = true;
            this.textAddApptCustomer.Name = "textAddApptCustomer";
            this.textAddApptCustomer.ReadOnly = true;
            this.textAddApptCustomer.Size = new System.Drawing.Size(200, 27);
            this.textAddApptCustomer.TabIndex = 58;
            // 
            // labelAddApptEnd
            // 
            this.labelAddApptEnd.AutoSize = true;
            this.labelAddApptEnd.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddApptEnd.Location = new System.Drawing.Point(133, 513);
            this.labelAddApptEnd.Name = "labelAddApptEnd";
            this.labelAddApptEnd.Size = new System.Drawing.Size(46, 23);
            this.labelAddApptEnd.TabIndex = 57;
            this.labelAddApptEnd.Text = "End:";
            // 
            // labelAddApptStart
            // 
            this.labelAddApptStart.AutoSize = true;
            this.labelAddApptStart.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddApptStart.Location = new System.Drawing.Point(133, 478);
            this.labelAddApptStart.Name = "labelAddApptStart";
            this.labelAddApptStart.Size = new System.Drawing.Size(53, 23);
            this.labelAddApptStart.TabIndex = 56;
            this.labelAddApptStart.Text = "Start:";
            // 
            // labelAddApptType
            // 
            this.labelAddApptType.AutoSize = true;
            this.labelAddApptType.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddApptType.Location = new System.Drawing.Point(133, 443);
            this.labelAddApptType.Name = "labelAddApptType";
            this.labelAddApptType.Size = new System.Drawing.Size(54, 23);
            this.labelAddApptType.TabIndex = 55;
            this.labelAddApptType.Text = "Type:";
            // 
            // labelAddApptCustomer
            // 
            this.labelAddApptCustomer.AutoSize = true;
            this.labelAddApptCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddApptCustomer.Location = new System.Drawing.Point(133, 381);
            this.labelAddApptCustomer.Name = "labelAddApptCustomer";
            this.labelAddApptCustomer.Size = new System.Drawing.Size(118, 23);
            this.labelAddApptCustomer.TabIndex = 54;
            this.labelAddApptCustomer.Text = "Customer ID:";
            // 
            // buttonApptSave
            // 
            this.buttonApptSave.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApptSave.Location = new System.Drawing.Point(460, 542);
            this.buttonApptSave.Name = "buttonApptSave";
            this.buttonApptSave.Size = new System.Drawing.Size(76, 37);
            this.buttonApptSave.TabIndex = 63;
            this.buttonApptSave.Text = "Save";
            this.buttonApptSave.UseVisualStyleBackColor = true;
            this.buttonApptSave.Click += new System.EventHandler(this.buttonApptSave_Click);
            // 
            // textAddApptUser
            // 
            this.textAddApptUser.Enabled = false;
            this.textAddApptUser.Location = new System.Drawing.Point(288, 410);
            this.textAddApptUser.Multiline = true;
            this.textAddApptUser.Name = "textAddApptUser";
            this.textAddApptUser.ReadOnly = true;
            this.textAddApptUser.Size = new System.Drawing.Size(200, 27);
            this.textAddApptUser.TabIndex = 65;
            // 
            // labelAddApptUser
            // 
            this.labelAddApptUser.AutoSize = true;
            this.labelAddApptUser.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddApptUser.Location = new System.Drawing.Point(133, 414);
            this.labelAddApptUser.Name = "labelAddApptUser";
            this.labelAddApptUser.Size = new System.Drawing.Size(75, 23);
            this.labelAddApptUser.TabIndex = 64;
            this.labelAddApptUser.Text = "User ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(271, 149);
            this.customerIDTextBox.Multiline = true;
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(217, 27);
            this.customerIDTextBox.TabIndex = 66;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.customerIDTextBox_TextChanged);
            // 
            // searchApptBtn
            // 
            this.searchApptBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchApptBtn.Location = new System.Drawing.Point(505, 148);
            this.searchApptBtn.Name = "searchApptBtn";
            this.searchApptBtn.Size = new System.Drawing.Size(76, 28);
            this.searchApptBtn.TabIndex = 67;
            this.searchApptBtn.Text = "Search";
            this.searchApptBtn.UseVisualStyleBackColor = true;
            this.searchApptBtn.Click += new System.EventHandler(this.searchApptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 68;
            this.label1.Text = "Search by customer ID:";
            // 
            // Appointments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchApptBtn);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.textAddApptUser);
            this.Controls.Add(this.labelAddApptUser);
            this.Controls.Add(this.buttonApptSave);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.btnInPerson);
            this.Controls.Add(this.btnVirtual);
            this.Controls.Add(this.textAddApptCustomer);
            this.Controls.Add(this.labelAddApptEnd);
            this.Controls.Add(this.labelAddApptStart);
            this.Controls.Add(this.labelAddApptType);
            this.Controls.Add(this.labelAddApptCustomer);
            this.Controls.Add(this.dataGridViewAppt);
            this.Controls.Add(this.buttonAppointmentBack);
            this.Controls.Add(this.buttonAppointmentLogout);
            this.Controls.Add(this.buttonAppointmentModify);
            this.Controls.Add(this.buttonAppointmentDelete);
            this.Controls.Add(this.buttonAppointmentAdd);
            this.Controls.Add(this.radioButtonApptMonth);
            this.Controls.Add(this.radioButtonApptWeek);
            this.Controls.Add(this.radioButtonApptAll);
            this.Controls.Add(this.labelAppointmentsFilter);
            this.Controls.Add(this.labelAppointmentsWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppointmentsWelcome;
        private System.Windows.Forms.Label labelAppointmentsFilter;
        private System.Windows.Forms.RadioButton radioButtonApptAll;
        private System.Windows.Forms.RadioButton radioButtonApptWeek;
        private System.Windows.Forms.RadioButton radioButtonApptMonth;
        private System.Windows.Forms.Button buttonAppointmentLogout;
        private System.Windows.Forms.Button buttonAppointmentModify;
        private System.Windows.Forms.Button buttonAppointmentDelete;
        private System.Windows.Forms.Button buttonAppointmentAdd;
        private System.Windows.Forms.Button buttonAppointmentBack;
        private System.Windows.Forms.DataGridView dataGridViewAppt;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.RadioButton btnInPerson;
        private System.Windows.Forms.RadioButton btnVirtual;
        private System.Windows.Forms.TextBox textAddApptCustomer;
        private System.Windows.Forms.Label labelAddApptEnd;
        private System.Windows.Forms.Label labelAddApptStart;
        private System.Windows.Forms.Label labelAddApptType;
        private System.Windows.Forms.Label labelAddApptCustomer;
        private System.Windows.Forms.Button buttonApptSave;
        private System.Windows.Forms.TextBox textAddApptUser;
        private System.Windows.Forms.Label labelAddApptUser;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button searchApptBtn;
        private System.Windows.Forms.Label label1;
    }
}