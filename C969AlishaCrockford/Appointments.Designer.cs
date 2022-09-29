
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
            this.labelAppointmentsFilter.Location = new System.Drawing.Point(243, 84);
            this.labelAppointmentsFilter.Name = "labelAppointmentsFilter";
            this.labelAppointmentsFilter.Size = new System.Drawing.Size(202, 23);
            this.labelAppointmentsFilter.TabIndex = 10;
            this.labelAppointmentsFilter.Text = "Filter appointments by:";
            // 
            // radioButtonApptAll
            // 
            this.radioButtonApptAll.AutoSize = true;
            this.radioButtonApptAll.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonApptAll.Location = new System.Drawing.Point(144, 123);
            this.radioButtonApptAll.Name = "radioButtonApptAll";
            this.radioButtonApptAll.Size = new System.Drawing.Size(46, 25);
            this.radioButtonApptAll.TabIndex = 11;
            this.radioButtonApptAll.TabStop = true;
            this.radioButtonApptAll.Text = "All";
            this.radioButtonApptAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonApptWeek
            // 
            this.radioButtonApptWeek.AutoSize = true;
            this.radioButtonApptWeek.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonApptWeek.Location = new System.Drawing.Point(297, 123);
            this.radioButtonApptWeek.Name = "radioButtonApptWeek";
            this.radioButtonApptWeek.Size = new System.Drawing.Size(99, 25);
            this.radioButtonApptWeek.TabIndex = 12;
            this.radioButtonApptWeek.TabStop = true;
            this.radioButtonApptWeek.Text = "This Week";
            this.radioButtonApptWeek.UseVisualStyleBackColor = true;
            // 
            // radioButtonApptMonth
            // 
            this.radioButtonApptMonth.AutoSize = true;
            this.radioButtonApptMonth.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonApptMonth.Location = new System.Drawing.Point(485, 123);
            this.radioButtonApptMonth.Name = "radioButtonApptMonth";
            this.radioButtonApptMonth.Size = new System.Drawing.Size(106, 25);
            this.radioButtonApptMonth.TabIndex = 13;
            this.radioButtonApptMonth.TabStop = true;
            this.radioButtonApptMonth.Text = "This Month";
            this.radioButtonApptMonth.UseVisualStyleBackColor = true;
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
            this.buttonAppointmentModify.Location = new System.Drawing.Point(305, 524);
            this.buttonAppointmentModify.Name = "buttonAppointmentModify";
            this.buttonAppointmentModify.Size = new System.Drawing.Size(100, 50);
            this.buttonAppointmentModify.TabIndex = 16;
            this.buttonAppointmentModify.Text = "Modify";
            this.buttonAppointmentModify.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentDelete
            // 
            this.buttonAppointmentDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentDelete.Location = new System.Drawing.Point(459, 524);
            this.buttonAppointmentDelete.Name = "buttonAppointmentDelete";
            this.buttonAppointmentDelete.Size = new System.Drawing.Size(100, 50);
            this.buttonAppointmentDelete.TabIndex = 15;
            this.buttonAppointmentDelete.Text = "Delete";
            this.buttonAppointmentDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentAdd
            // 
            this.buttonAppointmentAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppointmentAdd.Location = new System.Drawing.Point(145, 524);
            this.buttonAppointmentAdd.Name = "buttonAppointmentAdd";
            this.buttonAppointmentAdd.Size = new System.Drawing.Size(100, 50);
            this.buttonAppointmentAdd.TabIndex = 14;
            this.buttonAppointmentAdd.Text = "Add";
            this.buttonAppointmentAdd.UseVisualStyleBackColor = true;
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
            // Appointments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 661);
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
    }
}