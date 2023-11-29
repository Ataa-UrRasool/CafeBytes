namespace DbProject.PresentationLayer
{
	partial class EmployeeScreen
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
			pnl_orderInfoDisplay = new Panel();
			flp_orderView = new FlowLayoutPanel();
			lbl_employeeName = new Label();
			lbl_customerName = new Label();
			lbl_orderID = new Label();
			txt_employeeNameBox = new TextBox();
			txt_customerNameBox = new TextBox();
			txt_orderIDbox = new TextBox();
			button1 = new Button();
			lv_allOrdersPanel = new ListView();
			tab_ViewMenuEmp = new TabPage();
			panel1 = new Panel();
			label10 = new Label();
			lbl_taxEmp = new Label();
			lbl_discountEmp = new Label();
			lbl_itemLpReward = new Label();
			lbl_itemLpPrice = new Label();
			lbl_itemPriceEmp = new Label();
			lbl_nutriInfoEmp = new Label();
			lbl_itemDescrEmp = new Label();
			lbl_itemNameEmp = new Label();
			lbl_itemIdEmp = new Label();
			flp_displayMenuEmp = new FlowLayoutPanel();
			tab_ManageOrder.SuspendLayout();
			tab_createCustomer.SuspendLayout();
			tab_orderManager.SuspendLayout();
			pnl_orderInfoDisplay.SuspendLayout();
			tab_ViewMenuEmp.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// tab_ManageOrder
			// 
			tab_ManageOrder.Controls.Add(tab_createCustomer);
			tab_ManageOrder.Controls.Add(tab_orderManager);
			tab_ManageOrder.Controls.Add(tab_ViewMenuEmp);
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
			tab_orderManager.Controls.Add(pnl_orderInfoDisplay);
			tab_orderManager.Controls.Add(button1);
			tab_orderManager.Controls.Add(lv_allOrdersPanel);
			tab_orderManager.Location = new Point(4, 29);
			tab_orderManager.Name = "tab_orderManager";
			tab_orderManager.Padding = new Padding(3);
			tab_orderManager.Size = new Size(1372, 719);
			tab_orderManager.TabIndex = 1;
			tab_orderManager.Text = "Orders Manager";
			tab_orderManager.Enter += tab_orderManager_Enter;
			// 
			// pnl_orderInfoDisplay
			// 
			pnl_orderInfoDisplay.BackColor = Color.LightBlue;
			pnl_orderInfoDisplay.Controls.Add(flp_orderView);
			pnl_orderInfoDisplay.Controls.Add(lbl_employeeName);
			pnl_orderInfoDisplay.Controls.Add(lbl_customerName);
			pnl_orderInfoDisplay.Controls.Add(lbl_orderID);
			pnl_orderInfoDisplay.Controls.Add(txt_employeeNameBox);
			pnl_orderInfoDisplay.Controls.Add(txt_customerNameBox);
			pnl_orderInfoDisplay.Controls.Add(txt_orderIDbox);
			pnl_orderInfoDisplay.Location = new Point(0, 0);
			pnl_orderInfoDisplay.Name = "pnl_orderInfoDisplay";
			pnl_orderInfoDisplay.Size = new Size(920, 675);
			pnl_orderInfoDisplay.TabIndex = 3;
			// 
			// flp_orderView
			// 
			flp_orderView.BackColor = Color.Gray;
			flp_orderView.FlowDirection = FlowDirection.TopDown;
			flp_orderView.Location = new Point(2, 89);
			flp_orderView.Name = "flp_orderView";
			flp_orderView.Size = new Size(574, 462);
			flp_orderView.TabIndex = 6;
			// 
			// lbl_employeeName
			// 
			lbl_employeeName.AutoSize = true;
			lbl_employeeName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbl_employeeName.Location = new Point(685, 3);
			lbl_employeeName.Name = "lbl_employeeName";
			lbl_employeeName.Size = new Size(142, 25);
			lbl_employeeName.TabIndex = 5;
			lbl_employeeName.Text = "Employee Name";
			lbl_employeeName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_customerName
			// 
			lbl_customerName.AutoSize = true;
			lbl_customerName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbl_customerName.Location = new Point(344, 3);
			lbl_customerName.Name = "lbl_customerName";
			lbl_customerName.Size = new Size(141, 25);
			lbl_customerName.TabIndex = 4;
			lbl_customerName.Text = "Customer Name";
			lbl_customerName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_orderID
			// 
			lbl_orderID.AutoSize = true;
			lbl_orderID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbl_orderID.Location = new Point(3, 3);
			lbl_orderID.Name = "lbl_orderID";
			lbl_orderID.Size = new Size(81, 25);
			lbl_orderID.TabIndex = 3;
			lbl_orderID.Text = "Order ID";
			lbl_orderID.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_employeeNameBox
			// 
			txt_employeeNameBox.Location = new Point(685, 31);
			txt_employeeNameBox.Name = "txt_employeeNameBox";
			txt_employeeNameBox.PlaceholderText = "employee name";
			txt_employeeNameBox.Size = new Size(232, 27);
			txt_employeeNameBox.TabIndex = 2;
			// 
			// txt_customerNameBox
			// 
			txt_customerNameBox.Location = new Point(344, 31);
			txt_customerNameBox.Name = "txt_customerNameBox";
			txt_customerNameBox.PlaceholderText = "customer name";
			txt_customerNameBox.Size = new Size(232, 27);
			txt_customerNameBox.TabIndex = 1;
			// 
			// txt_orderIDbox
			// 
			txt_orderIDbox.Location = new Point(3, 31);
			txt_orderIDbox.Name = "txt_orderIDbox";
			txt_orderIDbox.PlaceholderText = "order id";
			txt_orderIDbox.Size = new Size(232, 27);
			txt_orderIDbox.TabIndex = 0;
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
			// lv_allOrdersPanel
			// 
			lv_allOrdersPanel.BackColor = Color.LightBlue;
			lv_allOrdersPanel.Location = new Point(947, 0);
			lv_allOrdersPanel.Name = "lv_allOrdersPanel";
			lv_allOrdersPanel.Size = new Size(425, 675);
			lv_allOrdersPanel.TabIndex = 0;
			lv_allOrdersPanel.UseCompatibleStateImageBehavior = false;
			// 
			// tab_ViewMenuEmp
			// 
			tab_ViewMenuEmp.BackColor = SystemColors.Desktop;
			tab_ViewMenuEmp.Controls.Add(panel1);
			tab_ViewMenuEmp.Controls.Add(flp_displayMenuEmp);
			tab_ViewMenuEmp.Location = new Point(4, 29);
			tab_ViewMenuEmp.Name = "tab_ViewMenuEmp";
			tab_ViewMenuEmp.Padding = new Padding(3);
			tab_ViewMenuEmp.Size = new Size(1372, 719);
			tab_ViewMenuEmp.TabIndex = 2;
			tab_ViewMenuEmp.Text = "View Menu";
			tab_ViewMenuEmp.Enter += tab_ViewMenuEmp_Enter;
			// 
			// panel1
			// 
			panel1.BackColor = Color.LightBlue;
			panel1.Controls.Add(label10);
			panel1.Controls.Add(lbl_taxEmp);
			panel1.Controls.Add(lbl_discountEmp);
			panel1.Controls.Add(lbl_itemLpReward);
			panel1.Controls.Add(lbl_itemLpPrice);
			panel1.Controls.Add(lbl_itemPriceEmp);
			panel1.Controls.Add(lbl_nutriInfoEmp);
			panel1.Controls.Add(lbl_itemDescrEmp);
			panel1.Controls.Add(lbl_itemNameEmp);
			panel1.Controls.Add(lbl_itemIdEmp);
			panel1.Location = new Point(922, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(454, 723);
			panel1.TabIndex = 1;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label10.Location = new Point(84, 3);
			label10.Name = "label10";
			label10.Size = new Size(283, 46);
			label10.TabIndex = 9;
			label10.Text = "Item Information";
			label10.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_taxEmp
			// 
			lbl_taxEmp.AutoSize = true;
			lbl_taxEmp.Font = new Font("Segoe UI", 12F);
			lbl_taxEmp.Location = new Point(114, 641);
			lbl_taxEmp.Name = "lbl_taxEmp";
			lbl_taxEmp.Size = new Size(65, 28);
			lbl_taxEmp.TabIndex = 8;
			lbl_taxEmp.Text = "label9";
			lbl_taxEmp.TextAlign = ContentAlignment.MiddleCenter;
			lbl_taxEmp.UseMnemonic = false;
			// 
			// lbl_discountEmp
			// 
			lbl_discountEmp.AutoSize = true;
			lbl_discountEmp.Font = new Font("Segoe UI", 12F);
			lbl_discountEmp.Location = new Point(114, 572);
			lbl_discountEmp.Name = "lbl_discountEmp";
			lbl_discountEmp.Size = new Size(65, 28);
			lbl_discountEmp.TabIndex = 7;
			lbl_discountEmp.Text = "label8";
			lbl_discountEmp.TextAlign = ContentAlignment.MiddleCenter;
			lbl_discountEmp.UseMnemonic = false;
			// 
			// lbl_itemLpReward
			// 
			lbl_itemLpReward.AutoSize = true;
			lbl_itemLpReward.Font = new Font("Segoe UI", 12F);
			lbl_itemLpReward.Location = new Point(114, 503);
			lbl_itemLpReward.Name = "lbl_itemLpReward";
			lbl_itemLpReward.Size = new Size(65, 28);
			lbl_itemLpReward.TabIndex = 6;
			lbl_itemLpReward.Text = "label7";
			lbl_itemLpReward.TextAlign = ContentAlignment.MiddleCenter;
			lbl_itemLpReward.UseMnemonic = false;
			// 
			// lbl_itemLpPrice
			// 
			lbl_itemLpPrice.AutoSize = true;
			lbl_itemLpPrice.Font = new Font("Segoe UI", 12F);
			lbl_itemLpPrice.Location = new Point(114, 434);
			lbl_itemLpPrice.Name = "lbl_itemLpPrice";
			lbl_itemLpPrice.Size = new Size(65, 28);
			lbl_itemLpPrice.TabIndex = 5;
			lbl_itemLpPrice.Text = "label6";
			lbl_itemLpPrice.TextAlign = ContentAlignment.MiddleCenter;
			lbl_itemLpPrice.UseMnemonic = false;
			// 
			// lbl_itemPriceEmp
			// 
			lbl_itemPriceEmp.AutoSize = true;
			lbl_itemPriceEmp.Font = new Font("Segoe UI", 12F);
			lbl_itemPriceEmp.Location = new Point(114, 365);
			lbl_itemPriceEmp.Name = "lbl_itemPriceEmp";
			lbl_itemPriceEmp.Size = new Size(98, 28);
			lbl_itemPriceEmp.TabIndex = 4;
			lbl_itemPriceEmp.Text = "Item Price";
			lbl_itemPriceEmp.TextAlign = ContentAlignment.MiddleCenter;
			lbl_itemPriceEmp.UseMnemonic = false;
			// 
			// lbl_nutriInfoEmp
			// 
			lbl_nutriInfoEmp.AutoSize = true;
			lbl_nutriInfoEmp.Font = new Font("Segoe UI", 12F);
			lbl_nutriInfoEmp.Location = new Point(114, 296);
			lbl_nutriInfoEmp.Name = "lbl_nutriInfoEmp";
			lbl_nutriInfoEmp.Size = new Size(215, 28);
			lbl_nutriInfoEmp.TabIndex = 3;
			lbl_nutriInfoEmp.Text = "Nutritional Information";
			lbl_nutriInfoEmp.TextAlign = ContentAlignment.MiddleCenter;
			lbl_nutriInfoEmp.UseMnemonic = false;
			// 
			// lbl_itemDescrEmp
			// 
			lbl_itemDescrEmp.AutoSize = true;
			lbl_itemDescrEmp.Font = new Font("Segoe UI", 12F);
			lbl_itemDescrEmp.Location = new Point(114, 227);
			lbl_itemDescrEmp.Name = "lbl_itemDescrEmp";
			lbl_itemDescrEmp.Size = new Size(156, 28);
			lbl_itemDescrEmp.TabIndex = 2;
			lbl_itemDescrEmp.Text = "Item Description";
			lbl_itemDescrEmp.TextAlign = ContentAlignment.MiddleCenter;
			lbl_itemDescrEmp.UseMnemonic = false;
			// 
			// lbl_itemNameEmp
			// 
			lbl_itemNameEmp.AutoSize = true;
			lbl_itemNameEmp.Font = new Font("Segoe UI", 12F);
			lbl_itemNameEmp.Location = new Point(114, 158);
			lbl_itemNameEmp.Name = "lbl_itemNameEmp";
			lbl_itemNameEmp.Size = new Size(108, 28);
			lbl_itemNameEmp.TabIndex = 1;
			lbl_itemNameEmp.Text = "Item Name";
			lbl_itemNameEmp.TextAlign = ContentAlignment.MiddleCenter;
			lbl_itemNameEmp.UseMnemonic = false;
			// 
			// lbl_itemIdEmp
			// 
			lbl_itemIdEmp.AutoSize = true;
			lbl_itemIdEmp.Font = new Font("Segoe UI", 12F);
			lbl_itemIdEmp.Location = new Point(114, 89);
			lbl_itemIdEmp.Name = "lbl_itemIdEmp";
			lbl_itemIdEmp.Size = new Size(73, 28);
			lbl_itemIdEmp.TabIndex = 0;
			lbl_itemIdEmp.Text = "Item Id";
			lbl_itemIdEmp.TextAlign = ContentAlignment.MiddleCenter;
			lbl_itemIdEmp.UseMnemonic = false;
			// 
			// flp_displayMenuEmp
			// 
			flp_displayMenuEmp.BackColor = Color.LightBlue;
			flp_displayMenuEmp.Location = new Point(0, 0);
			flp_displayMenuEmp.Name = "flp_displayMenuEmp";
			flp_displayMenuEmp.Size = new Size(893, 723);
			flp_displayMenuEmp.TabIndex = 0;
			// 
			// EmployeeScreen
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1382, 753);
			Controls.Add(tab_ManageOrder);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "EmployeeScreen";
			Text = "Employee View";
			tab_ManageOrder.ResumeLayout(false);
			tab_createCustomer.ResumeLayout(false);
			tab_createCustomer.PerformLayout();
			tab_orderManager.ResumeLayout(false);
			pnl_orderInfoDisplay.ResumeLayout(false);
			pnl_orderInfoDisplay.PerformLayout();
			tab_ViewMenuEmp.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
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
		private ListView lv_allOrdersPanel;
		private Panel pnl_orderInfoDisplay;
		private TextBox txt_customerNameBox;
		private TextBox txt_orderIDbox;
		private TextBox txt_employeeNameBox;
		private Label lbl_orderID;
		private Label lbl_customerName;
		private Label lbl_employeeName;
		private FlowLayoutPanel flp_orderView;
		private TabPage tab_ViewMenuEmp;
		private FlowLayoutPanel flp_displayMenuEmp;
		private Panel panel1;
		private Label label10;
		private Label lbl_taxEmp;
		private Label lbl_discountEmp;
		private Label lbl_itemLpReward;
		private Label lbl_itemLpPrice;
		private Label lbl_itemPriceEmp;
		private Label lbl_nutriInfoEmp;
		private Label lbl_itemDescrEmp;
		private Label lbl_itemNameEmp;
		private Label lbl_itemIdEmp;
	}
}