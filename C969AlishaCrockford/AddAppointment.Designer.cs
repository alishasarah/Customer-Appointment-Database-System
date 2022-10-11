
namespace C969AlishaCrockford
{
    partial class AddAppointment
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
            this.buttonAppointmentBack = new System.Windows.Forms.Button();
            this.buttonAppointmentLogout = new System.Windows.Forms.Button();
            this.labelAppointmentsFilter = new System.Windows.Forms.Label();
            this.labelAddApptCustomer = new System.Windows.Forms.Label();
            this.labelAddApptType = new System.Windows.Forms.Label();
            this.labelAddApptStart = new System.Windows.Forms.Label();
            this.labelAddApptEnd = new System.Windows.Forms.Label();
            this.textAddApptCustomer = new System.Windows.Forms.TextBox();
            this.btnVirtual = new System.Windows.Forms.RadioButton();
            this.btnInPerson = new System.Windows.Forms.RadioButton();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textAddApptUser = new System.Windows.Forms.TextBox();
            this.labelAddApptUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAppointmentsWelcome
            // 
            this.labelAppointmentsWelcome.AutoSize = true;
            this.labelAppointmentsWelcome.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelAppointmentsWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentsWelcome.Location = new System.Drawing.Point(143, 36);
            this.labelAppointmentsWelcome.Name = "labelAppointmentsWelcome";
            this.labelAppointmentsWelcome.Size = new System.Drawing.Size(388, 39);
            this.labelAppointmentsWelcome.TabIndex = 10;
            this.labelAppointmentsWelcome.Text = "Global Constultations, Inc.";
            // 
            // buttonAppointmentBack
            // 
            this.buttonAppointmentBack.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentBack.Location = new System.Drawing.Point(12, 597);
            this.buttonAppointmentBack.Name = "buttonAppointmentBack";
            this.buttonAppointmentBack.Size = new System.Drawing.Size(100, 50);
            this.buttonAppointmentBack.TabIndex = 20;
            this.buttonAppointmentBack.Text = "Back";
            this.buttonAppointmentBack.UseVisualStyleBackColor = true;
            this.buttonAppointmentBack.Click += new System.EventHandler(this.buttonAppointmentBack_Click);
            // 
            // buttonAppointmentLogout
            // 
            this.buttonAppointmentLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentLogout.Location = new System.Drawing.Point(572, 599);
            this.buttonAppointmentLogout.Name = "buttonAppointmentLogout";
            this.buttonAppointmentLogout.Size = new System.Drawing.Size(100, 50);
            this.buttonAppointmentLogout.TabIndex = 19;
            this.buttonAppointmentLogout.Text = "Logout";
            this.buttonAppointmentLogout.UseVisualStyleBackColor = true;
            this.buttonAppointmentLogout.Click += new System.EventHandler(this.buttonAppointmentLogout_Click);
            // 
            // labelAppointmentsFilter
            // 
            this.labelAppointmentsFilter.AutoSize = true;
            this.labelAppointmentsFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointmentsFilter.Location = new System.Drawing.Point(171, 92);
            this.labelAppointmentsFilter.Name = "labelAppointmentsFilter";
            this.labelAppointmentsFilter.Size = new System.Drawing.Size(334, 23);
            this.labelAppointmentsFilter.TabIndex = 21;
            this.labelAppointmentsFilter.Text = "Please enter appointment information:";
            // 
            // labelAddApptCustomer
            // 
            this.labelAddApptCustomer.AutoSize = true;
            this.labelAddApptCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddApptCustomer.Location = new System.Drawing.Point(78, 158);
            this.labelAddApptCustomer.Name = "labelAddApptCustomer";
            this.labelAddApptCustomer.Size = new System.Drawing.Size(118, 23);
            this.labelAddApptCustomer.TabIndex = 22;
            this.labelAddApptCustomer.Text = "Customer ID:";
            // 
            // labelAddApptType
            // 
            this.labelAddApptType.AutoSize = true;
            this.labelAddApptType.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddApptType.Location = new System.Drawing.Point(78, 268);
            this.labelAddApptType.Name = "labelAddApptType";
            this.labelAddApptType.Size = new System.Drawing.Size(54, 23);
            this.labelAddApptType.TabIndex = 23;
            this.labelAddApptType.Text = "Type:";
            // 
            // labelAddApptStart
            // 
            this.labelAddApptStart.AutoSize = true;
            this.labelAddApptStart.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddApptStart.Location = new System.Drawing.Point(78, 319);
            this.labelAddApptStart.Name = "labelAddApptStart";
            this.labelAddApptStart.Size = new System.Drawing.Size(53, 23);
            this.labelAddApptStart.TabIndex = 24;
            this.labelAddApptStart.Text = "Start:";
            // 
            // labelAddApptEnd
            // 
            this.labelAddApptEnd.AutoSize = true;
            this.labelAddApptEnd.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddApptEnd.Location = new System.Drawing.Point(78, 379);
            this.labelAddApptEnd.Name = "labelAddApptEnd";
            this.labelAddApptEnd.Size = new System.Drawing.Size(46, 23);
            this.labelAddApptEnd.TabIndex = 25;
            this.labelAddApptEnd.Text = "End:";
            // 
            // textAddApptCustomer
            // 
            this.textAddApptCustomer.Location = new System.Drawing.Point(233, 154);
            this.textAddApptCustomer.Multiline = true;
            this.textAddApptCustomer.Name = "textAddApptCustomer";
            this.textAddApptCustomer.Size = new System.Drawing.Size(321, 27);
            this.textAddApptCustomer.TabIndex = 49;
            // 
            // btnVirtual
            // 
            this.btnVirtual.AutoSize = true;
            this.btnVirtual.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirtual.Location = new System.Drawing.Point(233, 266);
            this.btnVirtual.Name = "btnVirtual";
            this.btnVirtual.Size = new System.Drawing.Size(84, 27);
            this.btnVirtual.TabIndex = 50;
            this.btnVirtual.TabStop = true;
            this.btnVirtual.Text = "Virtual";
            this.btnVirtual.UseVisualStyleBackColor = true;
            this.btnVirtual.CheckedChanged += new System.EventHandler(this.btnVirtual_CheckedChanged);
            // 
            // btnInPerson
            // 
            this.btnInPerson.AutoSize = true;
            this.btnInPerson.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPerson.Location = new System.Drawing.Point(347, 266);
            this.btnInPerson.Name = "btnInPerson";
            this.btnInPerson.Size = new System.Drawing.Size(110, 27);
            this.btnInPerson.TabIndex = 51;
            this.btnInPerson.TabStop = true;
            this.btnInPerson.Text = "In-Person";
            this.btnInPerson.UseVisualStyleBackColor = true;
            this.btnInPerson.CheckedChanged += new System.EventHandler(this.btnInPerson_CheckedChanged);
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(233, 319);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimeStart.TabIndex = 52;
            this.dateTimeStart.Value = new System.DateTime(2022, 10, 9, 0, 0, 0, 0);
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEnd.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(233, 379);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEnd.TabIndex = 53;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(477, 502);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 50);
            this.btnSubmit.TabIndex = 54;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textAddApptUser
            // 
            this.textAddApptUser.Location = new System.Drawing.Point(233, 209);
            this.textAddApptUser.Multiline = true;
            this.textAddApptUser.Name = "textAddApptUser";
            this.textAddApptUser.Size = new System.Drawing.Size(321, 27);
            this.textAddApptUser.TabIndex = 56;
            // 
            // labelAddApptUser
            // 
            this.labelAddApptUser.AutoSize = true;
            this.labelAddApptUser.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddApptUser.Location = new System.Drawing.Point(78, 213);
            this.labelAddApptUser.Name = "labelAddApptUser";
            this.labelAddApptUser.Size = new System.Drawing.Size(75, 23);
            this.labelAddApptUser.TabIndex = 55;
            this.labelAddApptUser.Text = "User ID:";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.textAddApptUser);
            this.Controls.Add(this.labelAddApptUser);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.btnInPerson);
            this.Controls.Add(this.btnVirtual);
            this.Controls.Add(this.textAddApptCustomer);
            this.Controls.Add(this.labelAddApptEnd);
            this.Controls.Add(this.labelAddApptStart);
            this.Controls.Add(this.labelAddApptType);
            this.Controls.Add(this.labelAddApptCustomer);
            this.Controls.Add(this.labelAppointmentsFilter);
            this.Controls.Add(this.buttonAppointmentBack);
            this.Controls.Add(this.buttonAppointmentLogout);
            this.Controls.Add(this.labelAppointmentsWelcome);
            this.Name = "AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppointmentsWelcome;
        private System.Windows.Forms.Button buttonAppointmentBack;
        private System.Windows.Forms.Button buttonAppointmentLogout;
        private System.Windows.Forms.Label labelAppointmentsFilter;
        private System.Windows.Forms.Label labelAddApptCustomer;
        private System.Windows.Forms.Label labelAddApptType;
        private System.Windows.Forms.Label labelAddApptStart;
        private System.Windows.Forms.Label labelAddApptEnd;
        private System.Windows.Forms.TextBox textAddApptCustomer;
        private System.Windows.Forms.RadioButton btnVirtual;
        private System.Windows.Forms.RadioButton btnInPerson;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textAddApptUser;
        private System.Windows.Forms.Label labelAddApptUser;
    }
}