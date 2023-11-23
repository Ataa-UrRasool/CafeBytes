namespace DbProject
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
			logInPanel = new Panel();
			signInBtn = new Button();
			passwordLbl = new Label();
			passwordBox = new TextBox();
			usernameLbl = new Label();
			usernameBox = new TextBox();
			title = new Label();
			logInPanel.SuspendLayout();
			SuspendLayout();
			// 
			// logInPanel
			// 
			logInPanel.BackColor = SystemColors.Desktop;
			logInPanel.Controls.Add(signInBtn);
			logInPanel.Controls.Add(passwordLbl);
			logInPanel.Controls.Add(passwordBox);
			logInPanel.Controls.Add(usernameLbl);
			logInPanel.Controls.Add(usernameBox);
			logInPanel.Location = new Point(339, 157);
			logInPanel.Name = "logInPanel";
			logInPanel.Size = new Size(700, 500);
			logInPanel.TabIndex = 0;
			// 
			// signInBtn
			// 
			signInBtn.BackColor = Color.White;
			signInBtn.Cursor = Cursors.Hand;
			signInBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			signInBtn.Location = new Point(279, 287);
			signInBtn.Name = "signInBtn";
			signInBtn.Size = new Size(150, 40);
			signInBtn.TabIndex = 4;
			signInBtn.Text = "Sign In";
			signInBtn.UseVisualStyleBackColor = false;
			signInBtn.Click += signInBtn_Click;
			// 
			// passwordLbl
			// 
			passwordLbl.AutoSize = true;
			passwordLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			passwordLbl.ForeColor = SystemColors.Control;
			passwordLbl.Location = new Point(47, 208);
			passwordLbl.Name = "passwordLbl";
			passwordLbl.Size = new Size(147, 38);
			passwordLbl.TabIndex = 3;
			passwordLbl.Text = "Password:";
			// 
			// passwordBox
			// 
			passwordBox.Location = new Point(227, 219);
			passwordBox.Name = "passwordBox";
			passwordBox.PlaceholderText = "password";
			passwordBox.Size = new Size(335, 27);
			passwordBox.TabIndex = 2;
			// 
			// usernameLbl
			// 
			usernameLbl.AutoSize = true;
			usernameLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			usernameLbl.ForeColor = SystemColors.Control;
			usernameLbl.Location = new Point(47, 138);
			usernameLbl.Name = "usernameLbl";
			usernameLbl.Size = new Size(156, 38);
			usernameLbl.TabIndex = 1;
			usernameLbl.Text = "Username:";
			usernameLbl.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// usernameBox
			// 
			usernameBox.BackColor = SystemColors.Control;
			usernameBox.ForeColor = SystemColors.InfoText;
			usernameBox.Location = new Point(227, 150);
			usernameBox.Multiline = true;
			usernameBox.Name = "usernameBox";
			usernameBox.PlaceholderText = "username";
			usernameBox.Size = new Size(335, 30);
			usernameBox.TabIndex = 0;
			// 
			// title
			// 
			title.BackColor = Color.Gray;
			title.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			title.Location = new Point(566, 44);
			title.Name = "title";
			title.Size = new Size(247, 78);
			title.TabIndex = 1;
			title.Text = "CafeBytes";
			title.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gray;
			ClientSize = new Size(1382, 753);
			Controls.Add(title);
			Controls.Add(logInPanel);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "Form1";
			Text = "Form1";
			logInPanel.ResumeLayout(false);
			logInPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel logInPanel;
		private Label title;
		private Label usernameLbl;
		private TextBox usernameBox;
		private Button signInBtn;
		private Label passwordLbl;
		private TextBox passwordBox;
	}
}
