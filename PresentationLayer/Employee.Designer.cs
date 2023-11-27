namespace DbProject.PresentationLayer
{
	partial class Employee
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
			tab_ManageOrder = new TabControl();
			tab_createCustomer = new TabPage();
			cmb_gender = new ComboBox();
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
			tab_orderManager = new TabPage();
			button1 = new Button();
			listView2 = new ListView();
			listView1 = new ListView();
			tab_ManageOrder.SuspendLayout();
			tab_createCustomer.SuspendLayout();
			tab_orderManager.SuspendLayout();
			SuspendLayout();
			// 
			// tab_ManageOrder
			// 
			tab_ManageOrder.Controls.Add(tab_createCustomer);
			tab_ManageOrder.Controls.Add(tab_orderManager);
			tab_ManageOrder.Location = new Point(2, 2);
			tab_ManageOrder.Name = "tab_ManageOrder";
			tab_ManageOrder.SelectedIndex = 0;
			tab_ManageOrder.Size = new Size(1380, 752);
			tab_ManageOrder.TabIndex = 0;
			// 
			// tab_createCustomer
			// 
			tab_createCustomer.BackColor = Color.LightBlue;
			tab_createCustomer.Controls.Add(cmb_gender);
			tab_createCustomer.Controls.Add(txt_password);
			tab_createCustomer.Controls.Add(lbl_password);
			tab_createCustomer.Controls.Add(txt_username);
			tab_createCustomer.Controls.Add(lbl_username);
			tab_createCustomer.Controls.Add(lbl_gender);
			tab_createCustomer.Controls.Add(txt_address);
			tab_createCustomer.Controls.Add(lbl_address);
			tab_createCustomer.Controls.Add(lbl_email);
			tab_createCustomer.Controls.Add(btn_createProfile);
			tab_createCustomer.Controls.Add(lbl_phoneNo);
			tab_createCustomer.Controls.Add(lbl_name);
			tab_createCustomer.Controls.Add(txt_email);
			tab_createCustomer.Controls.Add(txt_phoneNo);
			tab_createCustomer.Controls.Add(txt_name);
			tab_createCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			tab_createCustomer.Location = new Point(4, 29);
			tab_createCustomer.Name = "tab_createCustomer";
			tab_createCustomer.Padding = new Padding(3);
			tab_createCustomer.Size = new Size(1372, 719);
			tab_createCustomer.TabIndex = 0;
			tab_createCustomer.Text = "Create Customer";
			// 
			// cmb_gender
			// 
			cmb_gender.FormattingEnabled = true;
			cmb_gender.Items.AddRange(new object[] { "Male", "Female" });
			cmb_gender.Location = new Point(559, 387);
			cmb_gender.Name = "cmb_gender";
			cmb_gender.Size = new Size(364, 28);
			cmb_gender.TabIndex = 28;
			// 
			// txt_password
			// 
			txt_password.Location = new Point(559, 517);
			txt_password.Name = "txt_password";
			txt_password.PlaceholderText = "password";
			txt_password.Size = new Size(364, 27);
			txt_password.TabIndex = 27;
			// 
			// lbl_password
			// 
			lbl_password.AutoSize = true;
			lbl_password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_password.Location = new Point(433, 513);
			lbl_password.Name = "lbl_password";
			lbl_password.Size = new Size(97, 28);
			lbl_password.TabIndex = 26;
			lbl_password.Text = "Password";
			lbl_password.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_username
			// 
			txt_username.Location = new Point(559, 457);
			txt_username.Name = "txt_username";
			txt_username.PlaceholderText = "username";
			txt_username.Size = new Size(364, 27);
			txt_username.TabIndex = 25;
			// 
			// lbl_username
			// 
			lbl_username.AutoSize = true;
			lbl_username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_username.Location = new Point(429, 453);
			lbl_username.Name = "lbl_username";
			lbl_username.Size = new Size(104, 28);
			lbl_username.TabIndex = 24;
			lbl_username.Text = "Username";
			lbl_username.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_gender
			// 
			lbl_gender.AutoSize = true;
			lbl_gender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_gender.Location = new Point(442, 387);
			lbl_gender.Name = "lbl_gender";
			lbl_gender.Size = new Size(79, 28);
			lbl_gender.TabIndex = 22;
			lbl_gender.Text = "Gender";
			lbl_gender.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_address
			// 
			txt_address.Location = new Point(559, 281);
			txt_address.Multiline = true;
			txt_address.Name = "txt_address";
			txt_address.PlaceholderText = "address";
			txt_address.Size = new Size(364, 80);
			txt_address.TabIndex = 21;
			// 
			// lbl_address
			// 
			lbl_address.AutoSize = true;
			lbl_address.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_address.Location = new Point(439, 296);
			lbl_address.Name = "lbl_address";
			lbl_address.Size = new Size(85, 28);
			lbl_address.TabIndex = 20;
			lbl_address.Text = "Address";
			lbl_address.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_email
			// 
			lbl_email.AutoSize = true;
			lbl_email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_email.Location = new Point(451, 222);
			lbl_email.Name = "lbl_email";
			lbl_email.Size = new Size(60, 28);
			lbl_email.TabIndex = 19;
			lbl_email.Text = "Email";
			lbl_email.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btn_createProfile
			// 
			btn_createProfile.BackColor = Color.Transparent;
			btn_createProfile.ForeColor = SystemColors.GrayText;
			btn_createProfile.Location = new Point(666, 580);
			btn_createProfile.Name = "btn_createProfile";
			btn_createProfile.Size = new Size(150, 40);
			btn_createProfile.TabIndex = 18;
			btn_createProfile.Text = "Create Profile";
			btn_createProfile.UseVisualStyleBackColor = false;
			btn_createProfile.Click += btn_createProfile_Click;
			// 
			// lbl_phoneNo
			// 
			lbl_phoneNo.AutoSize = true;
			lbl_phoneNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_phoneNo.Location = new Point(432, 169);
			lbl_phoneNo.Name = "lbl_phoneNo";
			lbl_phoneNo.Size = new Size(98, 28);
			lbl_phoneNo.TabIndex = 16;
			lbl_phoneNo.Text = "PhoneNo";
			lbl_phoneNo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_name
			// 
			lbl_name.AutoSize = true;
			lbl_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_name.Location = new Point(448, 112);
			lbl_name.Name = "lbl_name";
			lbl_name.Size = new Size(66, 28);
			lbl_name.TabIndex = 17;
			lbl_name.Text = "Name";
			lbl_name.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_email
			// 
			txt_email.Location = new Point(559, 223);
			txt_email.Name = "txt_email";
			txt_email.PlaceholderText = "email";
			txt_email.Size = new Size(364, 27);
			txt_email.TabIndex = 15;
			// 
			// txt_phoneNo
			// 
			txt_phoneNo.Location = new Point(559, 170);
			txt_phoneNo.Name = "txt_phoneNo";
			txt_phoneNo.PlaceholderText = "phone no";
			txt_phoneNo.Size = new Size(364, 27);
			txt_phoneNo.TabIndex = 14;
			// 
			// txt_name
			// 
			txt_name.Location = new Point(559, 113);
			txt_name.Name = "txt_name";
			txt_name.PlaceholderText = "name";
			txt_name.Size = new Size(364, 27);
			txt_name.TabIndex = 13;
			// 
			// tab_orderManager
			// 
			tab_orderManager.BackColor = SystemColors.Desktop;
			tab_orderManager.Controls.Add(button1);
			tab_orderManager.Controls.Add(listView2);
			tab_orderManager.Controls.Add(listView1);
			tab_orderManager.Location = new Point(4, 29);
			tab_orderManager.Name = "tab_orderManager";
			tab_orderManager.Padding = new Padding(3);
			tab_orderManager.Size = new Size(1372, 719);
			tab_orderManager.TabIndex = 1;
			tab_orderManager.Text = "Orders Manager";
			tab_orderManager.Enter += tab_orderManager_Enter;
			// 
			// button1
			// 
			button1.Location = new Point(947, 681);
			button1.Name = "button1";
			button1.Size = new Size(417, 29);
			button1.TabIndex = 2;
			button1.Text = "Refresh";
			button1.UseVisualStyleBackColor = true;
			// 
			// listView2
			// 
			listView2.BackColor = Color.LightBlue;
			listView2.Location = new Point(18, 19);
			listView2.Name = "listView2";
			listView2.Size = new Size(912, 592);
			listView2.TabIndex = 1;
			listView2.UseCompatibleStateImageBehavior = false;
			// 
			// listView1
			// 
			listView1.BackColor = Color.LightBlue;
			listView1.Location = new Point(947, 19);
			listView1.Name = "listView1";
			listView1.Size = new Size(417, 656);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			// 
			// Employee
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1382, 753);
			Controls.Add(tab_ManageOrder);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "Employee";
			Text = "Employee View";
			tab_ManageOrder.ResumeLayout(false);
			tab_createCustomer.ResumeLayout(false);
			tab_createCustomer.PerformLayout();
			tab_orderManager.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl tab_ManageOrder;
		private TabPage tab_createCustomer;
		private TabPage tab_orderManager;
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
		private TextBox txt_username;
		private Label lbl_username;
		private TextBox txt_password;
		private Label lbl_password;
		private ComboBox cmb_gender;
		private Button button1;
		private ListView listView2;
		private ListView listView1;
	}
}