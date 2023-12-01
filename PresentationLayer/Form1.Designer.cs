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
			lbl_guestScreen = new Label();
			title = new Label();
			signInBtn = new Button();
			passwordLbl = new Label();
			passwordBox = new TextBox();
			usernameLbl = new Label();
			usernameBox = new TextBox();
			logInPanel.SuspendLayout();
			SuspendLayout();
			// 
			// logInPanel
			// 
			logInPanel.BackColor = Color.LightBlue;
			logInPanel.Controls.Add(lbl_guestScreen);
			logInPanel.Controls.Add(title);
			logInPanel.Controls.Add(signInBtn);
			logInPanel.Controls.Add(passwordLbl);
			logInPanel.Controls.Add(passwordBox);
			logInPanel.Controls.Add(usernameLbl);
			logInPanel.Controls.Add(usernameBox);
			logInPanel.Location = new Point(-2, -2);
			logInPanel.Name = "logInPanel";
			logInPanel.Size = new Size(1384, 761);
			logInPanel.TabIndex = 0;
			// 
			// lbl_guestScreen
			// 
			lbl_guestScreen.AutoSize = true;
			lbl_guestScreen.BackColor = Color.Transparent;
			lbl_guestScreen.BorderStyle = BorderStyle.Fixed3D;
			lbl_guestScreen.Cursor = Cursors.Hand;
			lbl_guestScreen.FlatStyle = FlatStyle.Flat;
			lbl_guestScreen.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			lbl_guestScreen.ForeColor = SystemColors.Desktop;
			lbl_guestScreen.Location = new Point(566, 714);
			lbl_guestScreen.Name = "lbl_guestScreen";
			lbl_guestScreen.Size = new Size(208, 47);
			lbl_guestScreen.TabIndex = 5;
			lbl_guestScreen.Text = "For Guests";
			lbl_guestScreen.TextAlign = ContentAlignment.MiddleCenter;
			lbl_guestScreen.Click += lbl_guestScreen_Click;
			// 
			// title
			// 
			title.BackColor = Color.Transparent;
			title.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			title.ForeColor = SystemColors.Desktop;
			title.Location = new Point(472, 29);
			title.Name = "title";
			title.Size = new Size(397, 105);
			title.TabIndex = 1;
			title.Text = "CafeBytes";
			title.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// signInBtn
			// 
			signInBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			signInBtn.BackColor = Color.White;
			signInBtn.Cursor = Cursors.Hand;
			signInBtn.FlatAppearance.BorderSize = 10;
			signInBtn.FlatStyle = FlatStyle.System;
			signInBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			signInBtn.Location = new Point(520, 484);
			signInBtn.Name = "signInBtn";
			signInBtn.Size = new Size(301, 46);
			signInBtn.TabIndex = 4;
			signInBtn.Text = "Sign In";
			signInBtn.UseVisualStyleBackColor = false;
			signInBtn.Click += signInBtn_Click;
			// 
			// passwordLbl
			// 
			passwordLbl.AutoSize = true;
			passwordLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			passwordLbl.ForeColor = SystemColors.Desktop;
			passwordLbl.Location = new Point(610, 356);
			passwordLbl.Name = "passwordLbl";
			passwordLbl.Size = new Size(120, 31);
			passwordLbl.TabIndex = 3;
			passwordLbl.Text = "Password:";
			// 
			// passwordBox
			// 
			passwordBox.Location = new Point(503, 402);
			passwordBox.Name = "passwordBox";
			passwordBox.PlaceholderText = "password";
			passwordBox.Size = new Size(335, 27);
			passwordBox.TabIndex = 2;
			// 
			// usernameLbl
			// 
			usernameLbl.AutoSize = true;
			usernameLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			usernameLbl.ForeColor = SystemColors.Desktop;
			usernameLbl.Location = new Point(607, 268);
			usernameLbl.Name = "usernameLbl";
			usernameLbl.Size = new Size(127, 31);
			usernameLbl.TabIndex = 1;
			usernameLbl.Text = "Username:";
			usernameLbl.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// usernameBox
			// 
			usernameBox.BackColor = SystemColors.Control;
			usernameBox.ForeColor = SystemColors.InfoText;
			usernameBox.Location = new Point(503, 314);
			usernameBox.Multiline = true;
			usernameBox.Name = "usernameBox";
			usernameBox.PlaceholderText = "username";
			usernameBox.Size = new Size(335, 27);
			usernameBox.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1382, 753);
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
		private Label lbl_guestScreen;
	}
}
