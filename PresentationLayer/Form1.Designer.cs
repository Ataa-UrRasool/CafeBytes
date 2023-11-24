﻿namespace DbProject
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
			logInPanel.BackColor = SystemColors.Desktop;
			logInPanel.Controls.Add(lbl_guestScreen);
			logInPanel.Controls.Add(title);
			logInPanel.Controls.Add(signInBtn);
			logInPanel.Controls.Add(passwordLbl);
			logInPanel.Controls.Add(passwordBox);
			logInPanel.Controls.Add(usernameLbl);
			logInPanel.Controls.Add(usernameBox);
			logInPanel.Location = new Point(2, 1);
			logInPanel.Name = "logInPanel";
			logInPanel.Size = new Size(700, 500);
			logInPanel.TabIndex = 0;
			// 
			// lbl_guestScreen
			// 
			lbl_guestScreen.AutoSize = true;
			lbl_guestScreen.BorderStyle = BorderStyle.Fixed3D;
			lbl_guestScreen.Cursor = Cursors.Hand;
			lbl_guestScreen.FlatStyle = FlatStyle.Popup;
			lbl_guestScreen.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_guestScreen.ForeColor = SystemColors.Control;
			lbl_guestScreen.Location = new Point(288, 457);
			lbl_guestScreen.Name = "lbl_guestScreen";
			lbl_guestScreen.Size = new Size(156, 37);
			lbl_guestScreen.TabIndex = 5;
			lbl_guestScreen.Text = "For Guests";
			lbl_guestScreen.TextAlign = ContentAlignment.MiddleCenter;
			lbl_guestScreen.Click += lbl_guestScreen_Click;
			// 
			// title
			// 
			title.BackColor = Color.Transparent;
			title.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			title.ForeColor = SystemColors.Control;
			title.Location = new Point(165, 8);
			title.Name = "title";
			title.Size = new Size(397, 105);
			title.TabIndex = 1;
			title.Text = "CafeBytes";
			title.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// signInBtn
			// 
			signInBtn.BackColor = Color.White;
			signInBtn.Cursor = Cursors.Hand;
			signInBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			signInBtn.Location = new Point(288, 329);
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
			passwordLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			passwordLbl.ForeColor = SystemColors.Control;
			passwordLbl.Location = new Point(96, 253);
			passwordLbl.Name = "passwordLbl";
			passwordLbl.Size = new Size(120, 31);
			passwordLbl.TabIndex = 3;
			passwordLbl.Text = "Password:";
			// 
			// passwordBox
			// 
			passwordBox.Location = new Point(248, 259);
			passwordBox.Name = "passwordBox";
			passwordBox.PlaceholderText = "password";
			passwordBox.Size = new Size(335, 27);
			passwordBox.TabIndex = 2;
			// 
			// usernameLbl
			// 
			usernameLbl.AutoSize = true;
			usernameLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			usernameLbl.ForeColor = SystemColors.Control;
			usernameLbl.Location = new Point(89, 182);
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
			usernameBox.Location = new Point(248, 188);
			usernameBox.Multiline = true;
			usernameBox.Name = "usernameBox";
			usernameBox.PlaceholderText = "username";
			usernameBox.Size = new Size(335, 30);
			usernameBox.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gray;
			ClientSize = new Size(703, 502);
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
