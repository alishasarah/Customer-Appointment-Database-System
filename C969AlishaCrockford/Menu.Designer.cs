
namespace C969AlishaCrockford
{
    partial class Menu
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
            this.labelMenuWelcome = new System.Windows.Forms.Label();
            this.buttonMenuCustomers = new System.Windows.Forms.Button();
            this.buttonMenuAppointments = new System.Windows.Forms.Button();
            this.buttonMenuReports = new System.Windows.Forms.Button();
            this.labelMenuExtra = new System.Windows.Forms.Label();
            this.buttonMenuLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMenuWelcome
            // 
            this.labelMenuWelcome.AutoSize = true;
            this.labelMenuWelcome.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelMenuWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuWelcome.Location = new System.Drawing.Point(73, 25);
            this.labelMenuWelcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelMenuWelcome.Name = "labelMenuWelcome";
            this.labelMenuWelcome.Size = new System.Drawing.Size(564, 39);
            this.labelMenuWelcome.TabIndex = 1;
            this.labelMenuWelcome.Text = "Welcome to Global Constultations, Inc.";
            // 
            // buttonMenuCustomers
            // 
            this.buttonMenuCustomers.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuCustomers.Location = new System.Drawing.Point(211, 169);
            this.buttonMenuCustomers.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonMenuCustomers.Name = "buttonMenuCustomers";
            this.buttonMenuCustomers.Size = new System.Drawing.Size(250, 75);
            this.buttonMenuCustomers.TabIndex = 2;
            this.buttonMenuCustomers.Text = "View Customer Databases";
            this.buttonMenuCustomers.UseVisualStyleBackColor = true;
            this.buttonMenuCustomers.Click += new System.EventHandler(this.buttonMenuCustomers_Click);
            // 
            // buttonMenuAppointments
            // 
            this.buttonMenuAppointments.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuAppointments.Location = new System.Drawing.Point(211, 289);
            this.buttonMenuAppointments.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonMenuAppointments.Name = "buttonMenuAppointments";
            this.buttonMenuAppointments.Size = new System.Drawing.Size(250, 75);
            this.buttonMenuAppointments.TabIndex = 3;
            this.buttonMenuAppointments.Text = "View Appointments";
            this.buttonMenuAppointments.UseVisualStyleBackColor = true;
            this.buttonMenuAppointments.Click += new System.EventHandler(this.buttonMenuAppointments_Click);
            // 
            // buttonMenuReports
            // 
            this.buttonMenuReports.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuReports.Location = new System.Drawing.Point(214, 404);
            this.buttonMenuReports.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonMenuReports.Name = "buttonMenuReports";
            this.buttonMenuReports.Size = new System.Drawing.Size(250, 75);
            this.buttonMenuReports.TabIndex = 4;
            this.buttonMenuReports.Text = "View Reports";
            this.buttonMenuReports.UseVisualStyleBackColor = true;
            this.buttonMenuReports.Click += new System.EventHandler(this.buttonMenuReports_Click);
            // 
            // labelMenuExtra
            // 
            this.labelMenuExtra.AutoSize = true;
            this.labelMenuExtra.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuExtra.Location = new System.Drawing.Point(210, 85);
            this.labelMenuExtra.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelMenuExtra.Name = "labelMenuExtra";
            this.labelMenuExtra.Size = new System.Drawing.Size(251, 23);
            this.labelMenuExtra.TabIndex = 5;
            this.labelMenuExtra.Text = "We are so glad you are here.";
            // 
            // buttonMenuLogout
            // 
            this.buttonMenuLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuLogout.Location = new System.Drawing.Point(599, 601);
            this.buttonMenuLogout.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonMenuLogout.Name = "buttonMenuLogout";
            this.buttonMenuLogout.Size = new System.Drawing.Size(75, 50);
            this.buttonMenuLogout.TabIndex = 6;
            this.buttonMenuLogout.Text = "Logout";
            this.buttonMenuLogout.UseVisualStyleBackColor = true;
            this.buttonMenuLogout.Click += new System.EventHandler(this.buttonMenuLogout_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.buttonMenuLogout);
            this.Controls.Add(this.labelMenuExtra);
            this.Controls.Add(this.buttonMenuReports);
            this.Controls.Add(this.buttonMenuAppointments);
            this.Controls.Add(this.buttonMenuCustomers);
            this.Controls.Add(this.labelMenuWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenuWelcome;
        private System.Windows.Forms.Button buttonMenuCustomers;
        private System.Windows.Forms.Button buttonMenuAppointments;
        private System.Windows.Forms.Button buttonMenuReports;
        private System.Windows.Forms.Label labelMenuExtra;
        private System.Windows.Forms.Button buttonMenuLogout;
    }
}