
namespace C969AlishaCrockford
{
    partial class LoginScreen
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
            this.labelLoginScreenWelcome = new System.Windows.Forms.Label();
            this.labelLoginScreenCredentials = new System.Windows.Forms.Label();
            this.textBoxLoginUsername = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.labelLoginUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoginSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoginScreenWelcome
            // 
            this.labelLoginScreenWelcome.AutoSize = true;
            this.labelLoginScreenWelcome.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelLoginScreenWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginScreenWelcome.Location = new System.Drawing.Point(73, 44);
            this.labelLoginScreenWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoginScreenWelcome.Name = "labelLoginScreenWelcome";
            this.labelLoginScreenWelcome.Size = new System.Drawing.Size(564, 39);
            this.labelLoginScreenWelcome.TabIndex = 0;
            this.labelLoginScreenWelcome.Text = "Welcome to Global Constultations, Inc.";
            // 
            // labelLoginScreenCredentials
            // 
            this.labelLoginScreenCredentials.AutoSize = true;
            this.labelLoginScreenCredentials.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginScreenCredentials.Location = new System.Drawing.Point(205, 115);
            this.labelLoginScreenCredentials.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLoginScreenCredentials.Name = "labelLoginScreenCredentials";
            this.labelLoginScreenCredentials.Size = new System.Drawing.Size(298, 23);
            this.labelLoginScreenCredentials.TabIndex = 1;
            this.labelLoginScreenCredentials.Text = "Please enter your user credentials.";
            // 
            // textBoxLoginUsername
            // 
            this.textBoxLoginUsername.Location = new System.Drawing.Point(274, 215);
            this.textBoxLoginUsername.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxLoginUsername.Multiline = true;
            this.textBoxLoginUsername.Name = "textBoxLoginUsername";
            this.textBoxLoginUsername.Size = new System.Drawing.Size(250, 40);
            this.textBoxLoginUsername.TabIndex = 2;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Location = new System.Drawing.Point(274, 338);
            this.textBoxLoginPassword.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxLoginPassword.Multiline = true;
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(250, 40);
            this.textBoxLoginPassword.TabIndex = 3;
            // 
            // labelLoginUsername
            // 
            this.labelLoginUsername.AutoSize = true;
            this.labelLoginUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginUsername.Location = new System.Drawing.Point(158, 215);
            this.labelLoginUsername.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLoginUsername.Name = "labelLoginUsername";
            this.labelLoginUsername.Size = new System.Drawing.Size(99, 23);
            this.labelLoginUsername.TabIndex = 4;
            this.labelLoginUsername.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            // 
            // buttonLoginSubmit
            // 
            this.buttonLoginSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoginSubmit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLoginSubmit.Location = new System.Drawing.Point(424, 442);
            this.buttonLoginSubmit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonLoginSubmit.Name = "buttonLoginSubmit";
            this.buttonLoginSubmit.Size = new System.Drawing.Size(100, 50);
            this.buttonLoginSubmit.TabIndex = 6;
            this.buttonLoginSubmit.Text = "Submit";
            this.buttonLoginSubmit.UseVisualStyleBackColor = false;
            this.buttonLoginSubmit.Click += new System.EventHandler(this.buttonLoginSubmit_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.buttonLoginSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLoginUsername);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.textBoxLoginUsername);
            this.Controls.Add(this.labelLoginScreenCredentials);
            this.Controls.Add(this.labelLoginScreenWelcome);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginScreenWelcome;
        private System.Windows.Forms.Label labelLoginScreenCredentials;
        private System.Windows.Forms.TextBox textBoxLoginUsername;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label labelLoginUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoginSubmit;
    }
}

