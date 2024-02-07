namespace PasswordGenerator
{
    partial class Generator
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
            this.lbPassword = new System.Windows.Forms.Label();
            this.passwordLenghtLabel = new System.Windows.Forms.Label();
            this.passwordLenghtSlider = new System.Windows.Forms.TrackBar();
            this.copyPasswordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLenghtSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(130, 86);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(642, 58);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "label1";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPassword.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // passwordLenghtLabel
            // 
            this.passwordLenghtLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLenghtLabel.Location = new System.Drawing.Point(130, 375);
            this.passwordLenghtLabel.Name = "passwordLenghtLabel";
            this.passwordLenghtLabel.Size = new System.Drawing.Size(642, 58);
            this.passwordLenghtLabel.TabIndex = 1;
            this.passwordLenghtLabel.Text = "Password Length: 5";
            this.passwordLenghtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLenghtSlider
            // 
            this.passwordLenghtSlider.Location = new System.Drawing.Point(121, 436);
            this.passwordLenghtSlider.Name = "passwordLenghtSlider";
            this.passwordLenghtSlider.Size = new System.Drawing.Size(642, 69);
            this.passwordLenghtSlider.TabIndex = 2;
            this.passwordLenghtSlider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // copyPasswordButton
            // 
            this.copyPasswordButton.BackColor = System.Drawing.Color.White;
            this.copyPasswordButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyPasswordButton.Location = new System.Drawing.Point(121, 511);
            this.copyPasswordButton.Name = "copyPasswordButton";
            this.copyPasswordButton.Size = new System.Drawing.Size(642, 69);
            this.copyPasswordButton.TabIndex = 3;
            this.copyPasswordButton.Text = "Copy Password";
            this.copyPasswordButton.UseVisualStyleBackColor = false;
            this.copyPasswordButton.Click += new System.EventHandler(this.copyPasswordButton_Click);
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(902, 622);
            this.Controls.Add(this.copyPasswordButton);
            this.Controls.Add(this.passwordLenghtSlider);
            this.Controls.Add(this.passwordLenghtLabel);
            this.Controls.Add(this.lbPassword);
            this.Name = "Generator";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Generator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordLenghtSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label passwordLenghtLabel;
        private System.Windows.Forms.TrackBar passwordLenghtSlider;
        private System.Windows.Forms.Button copyPasswordButton;
    }
}

