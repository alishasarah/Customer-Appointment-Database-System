
namespace C969AlishaCrockford
{
    partial class Reports
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
            this.labelReportsWelcome = new System.Windows.Forms.Label();
            this.buttonReportsBack = new System.Windows.Forms.Button();
            this.buttonReportsLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelReportsWelcome
            // 
            this.labelReportsWelcome.AutoSize = true;
            this.labelReportsWelcome.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelReportsWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportsWelcome.Location = new System.Drawing.Point(150, 45);
            this.labelReportsWelcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelReportsWelcome.Name = "labelReportsWelcome";
            this.labelReportsWelcome.Size = new System.Drawing.Size(388, 39);
            this.labelReportsWelcome.TabIndex = 9;
            this.labelReportsWelcome.Text = "Global Constultations, Inc.";
            // 
            // buttonReportsBack
            // 
            this.buttonReportsBack.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportsBack.Location = new System.Drawing.Point(10, 601);
            this.buttonReportsBack.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonReportsBack.Name = "buttonReportsBack";
            this.buttonReportsBack.Size = new System.Drawing.Size(100, 50);
            this.buttonReportsBack.TabIndex = 20;
            this.buttonReportsBack.Text = "Back";
            this.buttonReportsBack.UseVisualStyleBackColor = true;
            this.buttonReportsBack.Click += new System.EventHandler(this.buttonReportsBack_Click);
            // 
            // buttonReportsLogout
            // 
            this.buttonReportsLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportsLogout.Location = new System.Drawing.Point(574, 601);
            this.buttonReportsLogout.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonReportsLogout.Name = "buttonReportsLogout";
            this.buttonReportsLogout.Size = new System.Drawing.Size(100, 50);
            this.buttonReportsLogout.TabIndex = 19;
            this.buttonReportsLogout.Text = "Logout";
            this.buttonReportsLogout.UseVisualStyleBackColor = true;
            this.buttonReportsLogout.Click += new System.EventHandler(this.buttonReportsLogout_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.buttonReportsBack);
            this.Controls.Add(this.buttonReportsLogout);
            this.Controls.Add(this.labelReportsWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReportsWelcome;
        private System.Windows.Forms.Button buttonReportsBack;
        private System.Windows.Forms.Button buttonReportsLogout;
    }
}