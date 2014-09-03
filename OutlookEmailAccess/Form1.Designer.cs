namespace OutlookEmailAccess
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
            this.btnAccessEmail = new System.Windows.Forms.Button();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.lblSenderEmail = new System.Windows.Forms.Label();
            this.lblCreationdate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccessEmail
            // 
            this.btnAccessEmail.Location = new System.Drawing.Point(26, 440);
            this.btnAccessEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccessEmail.Name = "btnAccessEmail";
            this.btnAccessEmail.Size = new System.Drawing.Size(413, 73);
            this.btnAccessEmail.TabIndex = 0;
            this.btnAccessEmail.Text = "Access Email";
            this.btnAccessEmail.UseVisualStyleBackColor = true;
            this.btnAccessEmail.Click += new System.EventHandler(this.btnAccessEmail_Click);
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(26, 100);
            this.txtBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(413, 164);
            this.txtBody.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sender Information";
            // 
            // lblSenderName
            // 
            this.lblSenderName.BackColor = System.Drawing.Color.White;
            this.lblSenderName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderName.Location = new System.Drawing.Point(26, 299);
            this.lblSenderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(413, 25);
            this.lblSenderName.TabIndex = 7;
            // 
            // lblSenderEmail
            // 
            this.lblSenderEmail.BackColor = System.Drawing.Color.White;
            this.lblSenderEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderEmail.Location = new System.Drawing.Point(26, 338);
            this.lblSenderEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenderEmail.Name = "lblSenderEmail";
            this.lblSenderEmail.Size = new System.Drawing.Size(413, 35);
            this.lblSenderEmail.TabIndex = 6;
            // 
            // lblCreationdate
            // 
            this.lblCreationdate.BackColor = System.Drawing.Color.LightGray;
            this.lblCreationdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCreationdate.Location = new System.Drawing.Point(26, 404);
            this.lblCreationdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreationdate.Name = "lblCreationdate";
            this.lblCreationdate.Size = new System.Drawing.Size(413, 22);
            this.lblCreationdate.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 373);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Creation Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 588);
            this.Controls.Add(this.lblCreationdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSenderName);
            this.Controls.Add(this.lblSenderEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.btnAccessEmail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Access your Outlook Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccessEmail;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Label lblSenderEmail;
        private System.Windows.Forms.Label lblCreationdate;
        private System.Windows.Forms.Label label8;
    }
}

