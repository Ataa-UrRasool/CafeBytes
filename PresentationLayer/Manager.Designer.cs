namespace DbProject.PresentationLayer
{
	partial class Manager
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
			tab_ViewManager = new TabControl();
			tab_createEmployeeProfile = new TabPage();
			cmb_gender = new ComboBox();
			txt_hourlyRate = new TextBox();
			lbl_hourlyRate = new Label();
			txt_password = new TextBox();
			lbl_password = new Label();
			txt_username = new TextBox();
			lbl_username = new Label();
			lbl_gender = new Label();
			txt_address = new TextBox();
			lbl_address = new Label();
			lbl_email = new Label();
			btn_createProfile = new Button();
			lbl_phoneNo = new Label();
			lbl_name = new Label();
			txt_email = new TextBox();
			txt_phoneNo = new TextBox();
			txt_name = new TextBox();
			tabPage2 = new TabPage();
			tab_ViewManager.SuspendLayout();
			tab_createEmployeeProfile.SuspendLayout();
			SuspendLayout();
			// 
			// tab_ViewManager
			// 
			tab_ViewManager.Controls.Add(tab_createEmployeeProfile);
			tab_ViewManager.Controls.Add(tabPage2);
			tab_ViewManager.Location = new Point(1, 2);
			tab_ViewManager.Name = "tab_ViewManager";
			tab_ViewManager.SelectedIndex = 0;
			tab_ViewManager.Size = new Size(1380, 751);
			tab_ViewManager.TabIndex = 0;
			// 
			// tab_createEmployeeProfile
			// 
			tab_createEmployeeProfile.BackColor = Color.DarkGray;
			tab_createEmployeeProfile.Controls.Add(cmb_gender);
			tab_createEmployeeProfile.Controls.Add(txt_hourlyRate);
			tab_createEmployeeProfile.Controls.Add(lbl_hourlyRate);
			tab_createEmployeeProfile.Controls.Add(txt_password);
			tab_createEmployeeProfile.Controls.Add(lbl_password);
			tab_createEmployeeProfile.Controls.Add(txt_username);
			tab_createEmployeeProfile.Controls.Add(lbl_username);
			tab_createEmployeeProfile.Controls.Add(lbl_gender);
			tab_createEmployeeProfile.Controls.Add(txt_address);
			tab_createEmployeeProfile.Controls.Add(lbl_address);
			tab_createEmployeeProfile.Controls.Add(lbl_email);
			tab_createEmployeeProfile.Controls.Add(btn_createProfile);
			tab_createEmployeeProfile.Controls.Add(lbl_phoneNo);
			tab_createEmployeeProfile.Controls.Add(lbl_name);
			tab_createEmployeeProfile.Controls.Add(txt_email);
			tab_createEmployeeProfile.Controls.Add(txt_phoneNo);
			tab_createEmployeeProfile.Controls.Add(txt_name);
			tab_createEmployeeProfile.Location = new Point(4, 29);
			tab_createEmployeeProfile.Name = "tab_createEmployeeProfile";
			tab_createEmployeeProfile.Padding = new Padding(3);
			tab_createEmployeeProfile.Size = new Size(1372, 718);
			tab_createEmployeeProfile.TabIndex = 0;
			tab_createEmployeeProfile.Text = "CreateEmployee";
			// 
			// cmb_gender
			// 
			cmb_gender.FormattingEnabled = true;
			cmb_gender.Items.AddRange(new object[] { "Male", "Female" });
			cmb_gender.Location = new Point(567, 360);
			cmb_gender.Name = "cmb_gender";
			cmb_gender.Size = new Size(364, 28);
			cmb_gender.TabIndex = 45;
			// 
			// txt_hourlyRate
			// 
			txt_hourlyRate.Location = new Point(567, 412);
			txt_hourlyRate.Name = "txt_hourlyRate";
			txt_hourlyRate.PlaceholderText = "hourly rate";
			txt_hourlyRate.Size = new Size(364, 27);
			txt_hourlyRate.TabIndex = 44;
			// 
			// lbl_hourlyRate
			// 
			lbl_hourlyRate.AutoSize = true;
			lbl_hourlyRate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_hourlyRate.Location = new Point(441, 408);
			lbl_hourlyRate.Name = "lbl_hourlyRate";
			lbl_hourlyRate.RightToLeft = RightToLeft.No;
			lbl_hourlyRate.Size = new Size(119, 28);
			lbl_hourlyRate.TabIndex = 43;
			lbl_hourlyRate.Text = "Hourly Rate";
			lbl_hourlyRate.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_password
			// 
			txt_password.Location = new Point(567, 534);
			txt_password.Name = "txt_password";
			txt_password.PlaceholderText = "password";
			txt_password.Size = new Size(364, 27);
			txt_password.TabIndex = 42;
			// 
			// lbl_password
			// 
			lbl_password.AutoSize = true;
			lbl_password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_password.Location = new Point(441, 530);
			lbl_password.Name = "lbl_password";
			lbl_password.Size = new Size(97, 28);
			lbl_password.TabIndex = 41;
			lbl_password.Text = "Password";
			lbl_password.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_username
			// 
			txt_username.Location = new Point(567, 474);
			txt_username.Name = "txt_username";
			txt_username.PlaceholderText = "username";
			txt_username.Size = new Size(364, 27);
			txt_username.TabIndex = 40;
			// 
			// lbl_username
			// 
			lbl_username.AutoSize = true;
			lbl_username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_username.Location = new Point(441, 470);
			lbl_username.Name = "lbl_username";
			lbl_username.Size = new Size(104, 28);
			lbl_username.TabIndex = 39;
			lbl_username.Text = "Username";
			lbl_username.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_gender
			// 
			lbl_gender.AutoSize = true;
			lbl_gender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_gender.Location = new Point(441, 360);
			lbl_gender.Name = "lbl_gender";
			lbl_gender.Size = new Size(79, 28);
			lbl_gender.TabIndex = 37;
			lbl_gender.Text = "Gender";
			lbl_gender.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_address
			// 
			txt_address.Location = new Point(567, 286);
			txt_address.Multiline = true;
			txt_address.Name = "txt_address";
			txt_address.PlaceholderText = "address";
			txt_address.Size = new Size(364, 52);
			txt_address.TabIndex = 36;
			// 
			// lbl_address
			// 
			lbl_address.AutoSize = true;
			lbl_address.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_address.Location = new Point(441, 301);
			lbl_address.Name = "lbl_address";
			lbl_address.Size = new Size(85, 28);
			lbl_address.TabIndex = 35;
			lbl_address.Text = "Address";
			lbl_address.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_email
			// 
			lbl_email.AutoSize = true;
			lbl_email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_email.Location = new Point(441, 230);
			lbl_email.Name = "lbl_email";
			lbl_email.Size = new Size(60, 28);
			lbl_email.TabIndex = 34;
			lbl_email.Text = "Email";
			lbl_email.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btn_createProfile
			// 
			btn_createProfile.BackColor = Color.Transparent;
			btn_createProfile.ForeColor = SystemColors.GrayText;
			btn_createProfile.Location = new Point(671, 592);
			btn_createProfile.Name = "btn_createProfile";
			btn_createProfile.Size = new Size(150, 40);
			btn_createProfile.TabIndex = 33;
			btn_createProfile.Text = "Create Profile";
			btn_createProfile.UseVisualStyleBackColor = false;
			btn_createProfile.Click += btn_createProfile_Click;
			// 
			// lbl_phoneNo
			// 
			lbl_phoneNo.AutoSize = true;
			lbl_phoneNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_phoneNo.Location = new Point(441, 174);
			lbl_phoneNo.Name = "lbl_phoneNo";
			lbl_phoneNo.Size = new Size(98, 28);
			lbl_phoneNo.TabIndex = 31;
			lbl_phoneNo.Text = "PhoneNo";
			lbl_phoneNo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_name
			// 
			lbl_name.AutoSize = true;
			lbl_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_name.Location = new Point(441, 117);
			lbl_name.Name = "lbl_name";
			lbl_name.Size = new Size(66, 28);
			lbl_name.TabIndex = 32;
			lbl_name.Text = "Name";
			lbl_name.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_email
			// 
			txt_email.Location = new Point(567, 231);
			txt_email.Name = "txt_email";
			txt_email.PlaceholderText = "email";
			txt_email.Size = new Size(364, 27);
			txt_email.TabIndex = 30;
			// 
			// txt_phoneNo
			// 
			txt_phoneNo.Location = new Point(567, 175);
			txt_phoneNo.Name = "txt_phoneNo";
			txt_phoneNo.PlaceholderText = "phone no";
			txt_phoneNo.Size = new Size(364, 27);
			txt_phoneNo.TabIndex = 29;
			// 
			// txt_name
			// 
			txt_name.Location = new Point(567, 118);
			txt_name.Name = "txt_name";
			txt_name.PlaceholderText = "name";
			txt_name.Size = new Size(364, 27);
			txt_name.TabIndex = 28;
			// 
			// tabPage2
			// 
			tabPage2.Location = new Point(4, 29);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1372, 718);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// Manager
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1382, 753);
			Controls.Add(tab_ViewManager);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "Manager";
			Text = "Manager View";
			tab_ViewManager.ResumeLayout(false);
			tab_createEmployeeProfile.ResumeLayout(false);
			tab_createEmployeeProfile.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tab_ViewManager;
		private TabPage tab_createEmployeeProfile;
		private TabPage tabPage2;
		private TextBox txt_hourlyRate;
		private Label lbl_hourlyRate;
		private TextBox txt_password;
		private Label lbl_password;
		private TextBox txt_username;
		private Label lbl_username;
		private Label lbl_gender;
		private TextBox txt_address;
		private Label lbl_address;
		private Label lbl_email;
		private Button btn_createProfile;
		private Label lbl_phoneNo;
		private Label lbl_name;
		private TextBox txt_email;
		private TextBox txt_phoneNo;
		private TextBox txt_name;
		private ComboBox cmb_gender;
	}
}