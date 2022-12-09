namespace AJS.UserPass.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.txtCreatePass = new System.Windows.Forms.TextBox();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCreateEmail = new System.Windows.Forms.TextBox();
            this.btnGeneratePass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(358, 230);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(458, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create a username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create a password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Login with your username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Login with your password:";
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(188, 66);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(125, 27);
            this.txtCreateUser.TabIndex = 1;
            // 
            // txtCreatePass
            // 
            this.txtCreatePass.Location = new System.Drawing.Point(188, 141);
            this.txtCreatePass.Name = "txtCreatePass";
            this.txtCreatePass.Size = new System.Drawing.Size(125, 27);
            this.txtCreatePass.TabIndex = 2;
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Location = new System.Drawing.Point(569, 145);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(125, 27);
            this.txtLoginPass.TabIndex = 5;
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Location = new System.Drawing.Point(569, 73);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(125, 27);
            this.txtLoginUser.TabIndex = 4;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Location = new System.Drawing.Point(557, 230);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(153, 29);
            this.btnCloseApp.TabIndex = 8;
            this.btnCloseApp.Text = "Close &Application";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "What email will \r\nyou be using:";
            // 
            // txtCreateEmail
            // 
            this.txtCreateEmail.Location = new System.Drawing.Point(188, 207);
            this.txtCreateEmail.Name = "txtCreateEmail";
            this.txtCreateEmail.Size = new System.Drawing.Size(125, 27);
            this.txtCreateEmail.TabIndex = 3;
            // 
            // btnGeneratePass
            // 
            this.btnGeneratePass.Location = new System.Drawing.Point(358, 265);
            this.btnGeneratePass.Name = "btnGeneratePass";
            this.btnGeneratePass.Size = new System.Drawing.Size(352, 29);
            this.btnGeneratePass.TabIndex = 9;
            this.btnGeneratePass.Text = "&Generate Password";
            this.btnGeneratePass.UseVisualStyleBackColor = true;
            this.btnGeneratePass.Click += new System.EventHandler(this.btnGeneratePass_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "&Forgot Password?";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 371);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.txtLoginPass);
            this.Controls.Add(this.txtCreateEmail);
            this.Controls.Add(this.txtCreatePass);
            this.Controls.Add(this.txtCreateUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGeneratePass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "UserPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCreate;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCreateUser;
        private TextBox txtCreatePass;
        private TextBox txtLoginPass;
        private TextBox txtLoginUser;
        private Button btnCloseApp;
        private Label label7;
        private TextBox txtCreateEmail;
        private Button btnGeneratePass;
        private Button button1;
    }
}