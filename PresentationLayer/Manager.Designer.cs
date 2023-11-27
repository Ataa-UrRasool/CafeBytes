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
			tab_addMenuItems = new TabPage();
			lbl_taxInfo = new Label();
			lbl_discountInfo = new Label();
			lbl_lpReward = new Label();
			lbl_lpPrice = new Label();
			lbl_nutritionalInfo = new Label();
			lbl_itemPrice = new Label();
			lbl_itemDescript = new Label();
			lbl_itemName = new Label();
			cmb_taxInfo = new ComboBox();
			cmb_discountInfo = new ComboBox();
			btn_addItem = new Button();
			txt_itemLoyaltyPointsReward = new TextBox();
			txt_itemLoyaltyPointsPrice = new TextBox();
			txt_itemNutritionalInfo = new TextBox();
			txt_itemPrice = new TextBox();
			txt_itemDescription = new TextBox();
			txt_itemName = new TextBox();
			tab_addDiscounts = new TabPage();
			lbl_discTabValue = new Label();
			lbl_discTabStatus = new Label();
			lbl_discTabName = new Label();
			cmb_discountStatus = new ComboBox();
			btn_addDiscount = new Button();
			txt_dicountValue = new TextBox();
			txt_discountName = new TextBox();
			tab_addTaxes = new TabPage();
			lbl_taxTabValue = new Label();
			lbl_taxTabStatus = new Label();
			lbl_taxTabName = new Label();
			cmb_taxStatus = new ComboBox();
			btn_addTax = new Button();
			txt_taxValue = new TextBox();
			txt_taxName = new TextBox();
			tab_updateMenuItems = new TabPage();
			pnl_updateMenuitems = new Panel();
			btn_menuUpdate_update = new Button();
			label9 = new Label();
			txt_menuUpdateID = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			cmb_menuUpdateTaxInfo = new ComboBox();
			cmb_menuUpdateDiscountInfo = new ComboBox();
			txt_menuUpdateLpReward = new TextBox();
			txt_menuUpdateLpPrice = new TextBox();
			txt_menuUpdateNutriInfo = new TextBox();
			txt_menuUpdatePrice = new TextBox();
			txt_menuUpdateDescrip = new TextBox();
			txt_menuUpdateName = new TextBox();
			flp_menuDisplayUpdateMenu = new FlowLayoutPanel();
			tab_ViewManager.SuspendLayout();
			tab_createEmployeeProfile.SuspendLayout();
			tab_addMenuItems.SuspendLayout();
			tab_addDiscounts.SuspendLayout();
			tab_addTaxes.SuspendLayout();
			tab_updateMenuItems.SuspendLayout();
			pnl_updateMenuitems.SuspendLayout();
			SuspendLayout();
			// 
			// tab_ViewManager
			// 
			tab_ViewManager.Controls.Add(tab_createEmployeeProfile);
			tab_ViewManager.Controls.Add(tab_addMenuItems);
			tab_ViewManager.Controls.Add(tab_addDiscounts);
			tab_ViewManager.Controls.Add(tab_addTaxes);
			tab_ViewManager.Controls.Add(tab_updateMenuItems);
			tab_ViewManager.Font = new Font("Segoe UI", 12F);
			tab_ViewManager.Location = new Point(1, 2);
			tab_ViewManager.Name = "tab_ViewManager";
			tab_ViewManager.SelectedIndex = 0;
			tab_ViewManager.Size = new Size(1380, 751);
			tab_ViewManager.TabIndex = 0;
			// 
			// tab_createEmployeeProfile
			// 
			tab_createEmployeeProfile.BackColor = Color.LightBlue;
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
			tab_createEmployeeProfile.Font = new Font("Segoe UI", 10F);
			tab_createEmployeeProfile.Location = new Point(4, 37);
			tab_createEmployeeProfile.Margin = new Padding(0);
			tab_createEmployeeProfile.Name = "tab_createEmployeeProfile";
			tab_createEmployeeProfile.Padding = new Padding(3);
			tab_createEmployeeProfile.Size = new Size(1372, 710);
			tab_createEmployeeProfile.TabIndex = 0;
			tab_createEmployeeProfile.Text = "Create Employee";
			// 
			// cmb_gender
			// 
			cmb_gender.FormattingEnabled = true;
			cmb_gender.Items.AddRange(new object[] { "Male", "Female" });
			cmb_gender.Location = new Point(567, 377);
			cmb_gender.Name = "cmb_gender";
			cmb_gender.Size = new Size(364, 31);
			cmb_gender.TabIndex = 45;
			// 
			// txt_hourlyRate
			// 
			txt_hourlyRate.Location = new Point(567, 434);
			txt_hourlyRate.Name = "txt_hourlyRate";
			txt_hourlyRate.PlaceholderText = "hourly rate";
			txt_hourlyRate.Size = new Size(364, 30);
			txt_hourlyRate.TabIndex = 44;
			// 
			// lbl_hourlyRate
			// 
			lbl_hourlyRate.AutoSize = true;
			lbl_hourlyRate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_hourlyRate.Location = new Point(404, 424);
			lbl_hourlyRate.Name = "lbl_hourlyRate";
			lbl_hourlyRate.RightToLeft = RightToLeft.No;
			lbl_hourlyRate.Size = new Size(119, 28);
			lbl_hourlyRate.TabIndex = 43;
			lbl_hourlyRate.Text = "Hourly Rate";
			lbl_hourlyRate.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_password
			// 
			txt_password.Location = new Point(567, 546);
			txt_password.Name = "txt_password";
			txt_password.PlaceholderText = "password";
			txt_password.Size = new Size(364, 30);
			txt_password.TabIndex = 42;
			// 
			// lbl_password
			// 
			lbl_password.AutoSize = true;
			lbl_password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_password.Location = new Point(415, 546);
			lbl_password.Name = "lbl_password";
			lbl_password.Size = new Size(97, 28);
			lbl_password.TabIndex = 41;
			lbl_password.Text = "Password";
			lbl_password.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_username
			// 
			txt_username.Location = new Point(567, 490);
			txt_username.Name = "txt_username";
			txt_username.PlaceholderText = "username";
			txt_username.Size = new Size(364, 30);
			txt_username.TabIndex = 40;
			// 
			// lbl_username
			// 
			lbl_username.AutoSize = true;
			lbl_username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_username.Location = new Point(411, 486);
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
			lbl_gender.Location = new Point(424, 376);
			lbl_gender.Name = "lbl_gender";
			lbl_gender.Size = new Size(79, 28);
			lbl_gender.TabIndex = 37;
			lbl_gender.Text = "Gender";
			lbl_gender.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_address
			// 
			txt_address.Location = new Point(567, 282);
			txt_address.Multiline = true;
			txt_address.Name = "txt_address";
			txt_address.PlaceholderText = "address";
			txt_address.Size = new Size(364, 80);
			txt_address.TabIndex = 36;
			// 
			// lbl_address
			// 
			lbl_address.AutoSize = true;
			lbl_address.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_address.Location = new Point(421, 304);
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
			lbl_email.Location = new Point(433, 233);
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
			btn_createProfile.Location = new Point(674, 605);
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
			lbl_phoneNo.Location = new Point(414, 177);
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
			lbl_name.Location = new Point(430, 120);
			lbl_name.Name = "lbl_name";
			lbl_name.Size = new Size(66, 28);
			lbl_name.TabIndex = 32;
			lbl_name.Text = "Name";
			lbl_name.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_email
			// 
			txt_email.Location = new Point(567, 230);
			txt_email.Name = "txt_email";
			txt_email.PlaceholderText = "email";
			txt_email.Size = new Size(364, 30);
			txt_email.TabIndex = 30;
			// 
			// txt_phoneNo
			// 
			txt_phoneNo.Location = new Point(567, 174);
			txt_phoneNo.Name = "txt_phoneNo";
			txt_phoneNo.PlaceholderText = "phone no";
			txt_phoneNo.Size = new Size(364, 30);
			txt_phoneNo.TabIndex = 29;
			// 
			// txt_name
			// 
			txt_name.Location = new Point(567, 118);
			txt_name.Name = "txt_name";
			txt_name.PlaceholderText = "name";
			txt_name.Size = new Size(364, 30);
			txt_name.TabIndex = 28;
			// 
			// tab_addMenuItems
			// 
			tab_addMenuItems.BackColor = Color.LightBlue;
			tab_addMenuItems.Controls.Add(lbl_taxInfo);
			tab_addMenuItems.Controls.Add(lbl_discountInfo);
			tab_addMenuItems.Controls.Add(lbl_lpReward);
			tab_addMenuItems.Controls.Add(lbl_lpPrice);
			tab_addMenuItems.Controls.Add(lbl_nutritionalInfo);
			tab_addMenuItems.Controls.Add(lbl_itemPrice);
			tab_addMenuItems.Controls.Add(lbl_itemDescript);
			tab_addMenuItems.Controls.Add(lbl_itemName);
			tab_addMenuItems.Controls.Add(cmb_taxInfo);
			tab_addMenuItems.Controls.Add(cmb_discountInfo);
			tab_addMenuItems.Controls.Add(btn_addItem);
			tab_addMenuItems.Controls.Add(txt_itemLoyaltyPointsReward);
			tab_addMenuItems.Controls.Add(txt_itemLoyaltyPointsPrice);
			tab_addMenuItems.Controls.Add(txt_itemNutritionalInfo);
			tab_addMenuItems.Controls.Add(txt_itemPrice);
			tab_addMenuItems.Controls.Add(txt_itemDescription);
			tab_addMenuItems.Controls.Add(txt_itemName);
			tab_addMenuItems.Font = new Font("Segoe UI", 10F);
			tab_addMenuItems.Location = new Point(4, 37);
			tab_addMenuItems.Name = "tab_addMenuItems";
			tab_addMenuItems.Padding = new Padding(3);
			tab_addMenuItems.Size = new Size(1372, 710);
			tab_addMenuItems.TabIndex = 1;
			tab_addMenuItems.Text = "Add MenuItems";
			// 
			// lbl_taxInfo
			// 
			lbl_taxInfo.AutoSize = true;
			lbl_taxInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_taxInfo.Location = new Point(416, 523);
			lbl_taxInfo.Name = "lbl_taxInfo";
			lbl_taxInfo.Size = new Size(41, 28);
			lbl_taxInfo.TabIndex = 40;
			lbl_taxInfo.Text = "Tax";
			lbl_taxInfo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_discountInfo
			// 
			lbl_discountInfo.AutoSize = true;
			lbl_discountInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_discountInfo.Location = new Point(387, 463);
			lbl_discountInfo.Name = "lbl_discountInfo";
			lbl_discountInfo.Size = new Size(98, 28);
			lbl_discountInfo.TabIndex = 39;
			lbl_discountInfo.Text = "Discount ";
			lbl_discountInfo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_lpReward
			// 
			lbl_lpReward.AutoSize = true;
			lbl_lpReward.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_lpReward.Location = new Point(331, 403);
			lbl_lpReward.Name = "lbl_lpReward";
			lbl_lpReward.Size = new Size(210, 28);
			lbl_lpReward.TabIndex = 38;
			lbl_lpReward.Text = "Loyalty Points Reward";
			lbl_lpReward.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_lpPrice
			// 
			lbl_lpPrice.AutoSize = true;
			lbl_lpPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_lpPrice.Location = new Point(342, 342);
			lbl_lpPrice.Name = "lbl_lpPrice";
			lbl_lpPrice.Size = new Size(188, 28);
			lbl_lpPrice.TabIndex = 37;
			lbl_lpPrice.Text = "Loyalty Points Price";
			lbl_lpPrice.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_nutritionalInfo
			// 
			lbl_nutritionalInfo.AutoSize = true;
			lbl_nutritionalInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_nutritionalInfo.Location = new Point(360, 285);
			lbl_nutritionalInfo.Name = "lbl_nutritionalInfo";
			lbl_nutritionalInfo.Size = new Size(152, 28);
			lbl_nutritionalInfo.TabIndex = 36;
			lbl_nutritionalInfo.Text = "Nutritional Info";
			lbl_nutritionalInfo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_itemPrice
			// 
			lbl_itemPrice.AutoSize = true;
			lbl_itemPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_itemPrice.Location = new Point(408, 219);
			lbl_itemPrice.Name = "lbl_itemPrice";
			lbl_itemPrice.Size = new Size(56, 28);
			lbl_itemPrice.TabIndex = 35;
			lbl_itemPrice.Text = "Price";
			lbl_itemPrice.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_itemDescript
			// 
			lbl_itemDescript.AutoSize = true;
			lbl_itemDescript.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_itemDescript.Location = new Point(379, 143);
			lbl_itemDescript.Name = "lbl_itemDescript";
			lbl_itemDescript.Size = new Size(115, 28);
			lbl_itemDescript.TabIndex = 34;
			lbl_itemDescript.Text = "Description";
			lbl_itemDescript.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_itemName
			// 
			lbl_itemName.AutoSize = true;
			lbl_itemName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_itemName.Location = new Point(403, 77);
			lbl_itemName.Name = "lbl_itemName";
			lbl_itemName.Size = new Size(66, 28);
			lbl_itemName.TabIndex = 33;
			lbl_itemName.Text = "Name";
			lbl_itemName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// cmb_taxInfo
			// 
			cmb_taxInfo.FormattingEnabled = true;
			cmb_taxInfo.Location = new Point(566, 520);
			cmb_taxInfo.Name = "cmb_taxInfo";
			cmb_taxInfo.Size = new Size(380, 31);
			cmb_taxInfo.TabIndex = 8;
			cmb_taxInfo.Text = "tax info";
			cmb_taxInfo.Click += cmb_taxInfo_Click;
			// 
			// cmb_discountInfo
			// 
			cmb_discountInfo.FormattingEnabled = true;
			cmb_discountInfo.Location = new Point(566, 460);
			cmb_discountInfo.Name = "cmb_discountInfo";
			cmb_discountInfo.Size = new Size(380, 31);
			cmb_discountInfo.TabIndex = 7;
			cmb_discountInfo.Text = "discount info";
			cmb_discountInfo.Click += cmb_discountInfo_Click;
			// 
			// btn_addItem
			// 
			btn_addItem.Cursor = Cursors.Hand;
			btn_addItem.ForeColor = SystemColors.GrayText;
			btn_addItem.Location = new Point(681, 580);
			btn_addItem.Name = "btn_addItem";
			btn_addItem.Size = new Size(150, 50);
			btn_addItem.TabIndex = 6;
			btn_addItem.Text = "Add Item";
			btn_addItem.UseVisualStyleBackColor = true;
			btn_addItem.Click += btn_addItem_Click;
			// 
			// txt_itemLoyaltyPointsReward
			// 
			txt_itemLoyaltyPointsReward.Location = new Point(566, 401);
			txt_itemLoyaltyPointsReward.Name = "txt_itemLoyaltyPointsReward";
			txt_itemLoyaltyPointsReward.PlaceholderText = "LP reward";
			txt_itemLoyaltyPointsReward.Size = new Size(380, 30);
			txt_itemLoyaltyPointsReward.TabIndex = 5;
			// 
			// txt_itemLoyaltyPointsPrice
			// 
			txt_itemLoyaltyPointsPrice.Location = new Point(566, 342);
			txt_itemLoyaltyPointsPrice.Name = "txt_itemLoyaltyPointsPrice";
			txt_itemLoyaltyPointsPrice.PlaceholderText = "LP price";
			txt_itemLoyaltyPointsPrice.Size = new Size(380, 30);
			txt_itemLoyaltyPointsPrice.TabIndex = 4;
			// 
			// txt_itemNutritionalInfo
			// 
			txt_itemNutritionalInfo.Location = new Point(566, 283);
			txt_itemNutritionalInfo.Name = "txt_itemNutritionalInfo";
			txt_itemNutritionalInfo.PlaceholderText = "nutritional information";
			txt_itemNutritionalInfo.Size = new Size(380, 30);
			txt_itemNutritionalInfo.TabIndex = 3;
			// 
			// txt_itemPrice
			// 
			txt_itemPrice.Location = new Point(566, 224);
			txt_itemPrice.Name = "txt_itemPrice";
			txt_itemPrice.PlaceholderText = "item price";
			txt_itemPrice.Size = new Size(380, 30);
			txt_itemPrice.TabIndex = 2;
			// 
			// txt_itemDescription
			// 
			txt_itemDescription.Location = new Point(566, 133);
			txt_itemDescription.Multiline = true;
			txt_itemDescription.Name = "txt_itemDescription";
			txt_itemDescription.PlaceholderText = "item description";
			txt_itemDescription.Size = new Size(380, 66);
			txt_itemDescription.TabIndex = 1;
			// 
			// txt_itemName
			// 
			txt_itemName.Location = new Point(566, 79);
			txt_itemName.Name = "txt_itemName";
			txt_itemName.PlaceholderText = "item name";
			txt_itemName.Size = new Size(380, 30);
			txt_itemName.TabIndex = 0;
			// 
			// tab_addDiscounts
			// 
			tab_addDiscounts.BackColor = Color.LightBlue;
			tab_addDiscounts.Controls.Add(lbl_discTabValue);
			tab_addDiscounts.Controls.Add(lbl_discTabStatus);
			tab_addDiscounts.Controls.Add(lbl_discTabName);
			tab_addDiscounts.Controls.Add(cmb_discountStatus);
			tab_addDiscounts.Controls.Add(btn_addDiscount);
			tab_addDiscounts.Controls.Add(txt_dicountValue);
			tab_addDiscounts.Controls.Add(txt_discountName);
			tab_addDiscounts.Font = new Font("Segoe UI", 10F);
			tab_addDiscounts.Location = new Point(4, 37);
			tab_addDiscounts.Name = "tab_addDiscounts";
			tab_addDiscounts.Padding = new Padding(3);
			tab_addDiscounts.Size = new Size(1372, 710);
			tab_addDiscounts.TabIndex = 2;
			tab_addDiscounts.Text = "Add Discounts";
			// 
			// lbl_discTabValue
			// 
			lbl_discTabValue.AutoSize = true;
			lbl_discTabValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_discTabValue.Location = new Point(403, 337);
			lbl_discTabValue.Name = "lbl_discTabValue";
			lbl_discTabValue.Size = new Size(62, 28);
			lbl_discTabValue.TabIndex = 36;
			lbl_discTabValue.Text = "Value";
			lbl_discTabValue.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_discTabStatus
			// 
			lbl_discTabStatus.AutoSize = true;
			lbl_discTabStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_discTabStatus.Location = new Point(403, 272);
			lbl_discTabStatus.Name = "lbl_discTabStatus";
			lbl_discTabStatus.Size = new Size(67, 28);
			lbl_discTabStatus.TabIndex = 35;
			lbl_discTabStatus.Text = "Status";
			lbl_discTabStatus.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_discTabName
			// 
			lbl_discTabName.AutoSize = true;
			lbl_discTabName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_discTabName.Location = new Point(403, 202);
			lbl_discTabName.Name = "lbl_discTabName";
			lbl_discTabName.Size = new Size(66, 28);
			lbl_discTabName.TabIndex = 34;
			lbl_discTabName.Text = "Name";
			lbl_discTabName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// cmb_discountStatus
			// 
			cmb_discountStatus.Cursor = Cursors.Hand;
			cmb_discountStatus.DisplayMember = "(none)";
			cmb_discountStatus.FormattingEnabled = true;
			cmb_discountStatus.Items.AddRange(new object[] { "Active", "Inactive" });
			cmb_discountStatus.Location = new Point(545, 269);
			cmb_discountStatus.Name = "cmb_discountStatus";
			cmb_discountStatus.Size = new Size(380, 31);
			cmb_discountStatus.TabIndex = 4;
			cmb_discountStatus.Tag = "";
			// 
			// btn_addDiscount
			// 
			btn_addDiscount.Cursor = Cursors.Hand;
			btn_addDiscount.Location = new Point(675, 408);
			btn_addDiscount.Name = "btn_addDiscount";
			btn_addDiscount.RightToLeft = RightToLeft.No;
			btn_addDiscount.Size = new Size(121, 29);
			btn_addDiscount.TabIndex = 3;
			btn_addDiscount.Text = "Add Discount";
			btn_addDiscount.UseVisualStyleBackColor = true;
			btn_addDiscount.Click += btn_addDiscount_Click;
			// 
			// txt_dicountValue
			// 
			txt_dicountValue.Location = new Point(545, 339);
			txt_dicountValue.Name = "txt_dicountValue";
			txt_dicountValue.PlaceholderText = "discount value";
			txt_dicountValue.Size = new Size(380, 30);
			txt_dicountValue.TabIndex = 2;
			// 
			// txt_discountName
			// 
			txt_discountName.Location = new Point(545, 200);
			txt_discountName.Name = "txt_discountName";
			txt_discountName.PlaceholderText = "discount name";
			txt_discountName.Size = new Size(380, 30);
			txt_discountName.TabIndex = 0;
			// 
			// tab_addTaxes
			// 
			tab_addTaxes.BackColor = Color.LightBlue;
			tab_addTaxes.Controls.Add(lbl_taxTabValue);
			tab_addTaxes.Controls.Add(lbl_taxTabStatus);
			tab_addTaxes.Controls.Add(lbl_taxTabName);
			tab_addTaxes.Controls.Add(cmb_taxStatus);
			tab_addTaxes.Controls.Add(btn_addTax);
			tab_addTaxes.Controls.Add(txt_taxValue);
			tab_addTaxes.Controls.Add(txt_taxName);
			tab_addTaxes.Font = new Font("Segoe UI", 10F);
			tab_addTaxes.Location = new Point(4, 37);
			tab_addTaxes.Margin = new Padding(0);
			tab_addTaxes.Name = "tab_addTaxes";
			tab_addTaxes.Size = new Size(1372, 710);
			tab_addTaxes.TabIndex = 3;
			tab_addTaxes.Text = "Add Taxes";
			// 
			// lbl_taxTabValue
			// 
			lbl_taxTabValue.AutoSize = true;
			lbl_taxTabValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_taxTabValue.Location = new Point(401, 345);
			lbl_taxTabValue.Name = "lbl_taxTabValue";
			lbl_taxTabValue.Size = new Size(62, 28);
			lbl_taxTabValue.TabIndex = 37;
			lbl_taxTabValue.Text = "Value";
			lbl_taxTabValue.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_taxTabStatus
			// 
			lbl_taxTabStatus.AutoSize = true;
			lbl_taxTabStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_taxTabStatus.Location = new Point(399, 278);
			lbl_taxTabStatus.Name = "lbl_taxTabStatus";
			lbl_taxTabStatus.Size = new Size(67, 28);
			lbl_taxTabStatus.TabIndex = 36;
			lbl_taxTabStatus.Text = "Status";
			lbl_taxTabStatus.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lbl_taxTabName
			// 
			lbl_taxTabName.AutoSize = true;
			lbl_taxTabName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_taxTabName.Location = new Point(399, 211);
			lbl_taxTabName.Name = "lbl_taxTabName";
			lbl_taxTabName.Size = new Size(66, 28);
			lbl_taxTabName.TabIndex = 35;
			lbl_taxTabName.Text = "Name";
			lbl_taxTabName.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// cmb_taxStatus
			// 
			cmb_taxStatus.Cursor = Cursors.Hand;
			cmb_taxStatus.FormattingEnabled = true;
			cmb_taxStatus.Items.AddRange(new object[] { "Active", "Inactive" });
			cmb_taxStatus.Location = new Point(537, 284);
			cmb_taxStatus.Name = "cmb_taxStatus";
			cmb_taxStatus.Size = new Size(380, 31);
			cmb_taxStatus.TabIndex = 8;
			// 
			// btn_addTax
			// 
			btn_addTax.Cursor = Cursors.Hand;
			btn_addTax.Location = new Point(667, 429);
			btn_addTax.Name = "btn_addTax";
			btn_addTax.RightToLeft = RightToLeft.No;
			btn_addTax.Size = new Size(121, 29);
			btn_addTax.TabIndex = 7;
			btn_addTax.Text = "Add Tax";
			btn_addTax.UseVisualStyleBackColor = true;
			btn_addTax.Click += btn_addTax_Click;
			// 
			// txt_taxValue
			// 
			txt_taxValue.Location = new Point(537, 357);
			txt_taxValue.Name = "txt_taxValue";
			txt_taxValue.PlaceholderText = "tax value";
			txt_taxValue.Size = new Size(380, 30);
			txt_taxValue.TabIndex = 6;
			// 
			// txt_taxName
			// 
			txt_taxName.Location = new Point(537, 212);
			txt_taxName.Name = "txt_taxName";
			txt_taxName.PlaceholderText = "tax name";
			txt_taxName.Size = new Size(380, 30);
			txt_taxName.TabIndex = 4;
			// 
			// tab_updateMenuItems
			// 
			tab_updateMenuItems.BackColor = SystemColors.Control;
			tab_updateMenuItems.Controls.Add(pnl_updateMenuitems);
			tab_updateMenuItems.Controls.Add(flp_menuDisplayUpdateMenu);
			tab_updateMenuItems.Location = new Point(4, 37);
			tab_updateMenuItems.Name = "tab_updateMenuItems";
			tab_updateMenuItems.Padding = new Padding(3);
			tab_updateMenuItems.Size = new Size(1372, 710);
			tab_updateMenuItems.TabIndex = 4;
			tab_updateMenuItems.Text = "Update MenuItems";
			tab_updateMenuItems.Enter += tab_updateMenuItems_Enter;
			// 
			// pnl_updateMenuitems
			// 
			pnl_updateMenuitems.BackColor = Color.LightBlue;
			pnl_updateMenuitems.Controls.Add(btn_menuUpdate_update);
			pnl_updateMenuitems.Controls.Add(label9);
			pnl_updateMenuitems.Controls.Add(txt_menuUpdateID);
			pnl_updateMenuitems.Controls.Add(label1);
			pnl_updateMenuitems.Controls.Add(label2);
			pnl_updateMenuitems.Controls.Add(label3);
			pnl_updateMenuitems.Controls.Add(label4);
			pnl_updateMenuitems.Controls.Add(label5);
			pnl_updateMenuitems.Controls.Add(label6);
			pnl_updateMenuitems.Controls.Add(label7);
			pnl_updateMenuitems.Controls.Add(label8);
			pnl_updateMenuitems.Controls.Add(cmb_menuUpdateTaxInfo);
			pnl_updateMenuitems.Controls.Add(cmb_menuUpdateDiscountInfo);
			pnl_updateMenuitems.Controls.Add(txt_menuUpdateLpReward);
			pnl_updateMenuitems.Controls.Add(txt_menuUpdateLpPrice);
			pnl_updateMenuitems.Controls.Add(txt_menuUpdateNutriInfo);
			pnl_updateMenuitems.Controls.Add(txt_menuUpdatePrice);
			pnl_updateMenuitems.Controls.Add(txt_menuUpdateDescrip);
			pnl_updateMenuitems.Controls.Add(txt_menuUpdateName);
			pnl_updateMenuitems.Location = new Point(792, 6);
			pnl_updateMenuitems.Name = "pnl_updateMenuitems";
			pnl_updateMenuitems.Size = new Size(574, 698);
			pnl_updateMenuitems.TabIndex = 1;
			// 
			// btn_menuUpdate_update
			// 
			btn_menuUpdate_update.Location = new Point(305, 610);
			btn_menuUpdate_update.Name = "btn_menuUpdate_update";
			btn_menuUpdate_update.Size = new Size(123, 35);
			btn_menuUpdate_update.TabIndex = 59;
			btn_menuUpdate_update.Text = "Update";
			btn_menuUpdate_update.UseVisualStyleBackColor = true;
			btn_menuUpdate_update.Click += btn_menuUpdate_update_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label9.Location = new Point(117, 69);
			label9.Name = "label9";
			label9.Size = new Size(32, 28);
			label9.TabIndex = 58;
			label9.Text = "ID";
			label9.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txt_menuUpdateID
			// 
			txt_menuUpdateID.Location = new Point(215, 63);
			txt_menuUpdateID.Name = "txt_menuUpdateID";
			txt_menuUpdateID.PlaceholderText = "item id";
			txt_menuUpdateID.ReadOnly = true;
			txt_menuUpdateID.Size = new Size(303, 34);
			txt_menuUpdateID.TabIndex = 57;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(117, 548);
			label1.Name = "label1";
			label1.Size = new Size(41, 28);
			label1.TabIndex = 56;
			label1.Text = "Tax";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(84, 497);
			label2.Name = "label2";
			label2.Size = new Size(98, 28);
			label2.TabIndex = 55;
			label2.Text = "Discount ";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(80, 440);
			label3.Name = "label3";
			label3.Size = new Size(106, 28);
			label3.TabIndex = 54;
			label3.Text = "LP Reward";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(91, 381);
			label4.Name = "label4";
			label4.Size = new Size(84, 28);
			label4.TabIndex = 53;
			label4.Text = "LP Price";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(57, 322);
			label5.Name = "label5";
			label5.Size = new Size(152, 28);
			label5.TabIndex = 52;
			label5.Text = "Nutritional Info";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(105, 266);
			label6.Name = "label6";
			label6.Size = new Size(56, 28);
			label6.TabIndex = 51;
			label6.Text = "Price";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(71, 197);
			label7.Name = "label7";
			label7.Size = new Size(115, 28);
			label7.TabIndex = 50;
			label7.Text = "Description";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.Location = new Point(100, 118);
			label8.Name = "label8";
			label8.Size = new Size(66, 28);
			label8.TabIndex = 49;
			label8.Text = "Name";
			label8.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// cmb_menuUpdateTaxInfo
			// 
			cmb_menuUpdateTaxInfo.FormattingEnabled = true;
			cmb_menuUpdateTaxInfo.Location = new Point(215, 540);
			cmb_menuUpdateTaxInfo.Name = "cmb_menuUpdateTaxInfo";
			cmb_menuUpdateTaxInfo.Size = new Size(303, 36);
			cmb_menuUpdateTaxInfo.TabIndex = 48;
			cmb_menuUpdateTaxInfo.Text = "tax info";
			// 
			// cmb_menuUpdateDiscountInfo
			// 
			cmb_menuUpdateDiscountInfo.FormattingEnabled = true;
			cmb_menuUpdateDiscountInfo.Location = new Point(215, 489);
			cmb_menuUpdateDiscountInfo.Name = "cmb_menuUpdateDiscountInfo";
			cmb_menuUpdateDiscountInfo.Size = new Size(303, 36);
			cmb_menuUpdateDiscountInfo.TabIndex = 47;
			cmb_menuUpdateDiscountInfo.Text = "discount info";
			// 
			// txt_menuUpdateLpReward
			// 
			txt_menuUpdateLpReward.Location = new Point(215, 434);
			txt_menuUpdateLpReward.Name = "txt_menuUpdateLpReward";
			txt_menuUpdateLpReward.PlaceholderText = "LP reward";
			txt_menuUpdateLpReward.Size = new Size(303, 34);
			txt_menuUpdateLpReward.TabIndex = 46;
			// 
			// txt_menuUpdateLpPrice
			// 
			txt_menuUpdateLpPrice.Location = new Point(215, 375);
			txt_menuUpdateLpPrice.Name = "txt_menuUpdateLpPrice";
			txt_menuUpdateLpPrice.PlaceholderText = "LP price";
			txt_menuUpdateLpPrice.Size = new Size(303, 34);
			txt_menuUpdateLpPrice.TabIndex = 45;
			// 
			// txt_menuUpdateNutriInfo
			// 
			txt_menuUpdateNutriInfo.Location = new Point(215, 316);
			txt_menuUpdateNutriInfo.Name = "txt_menuUpdateNutriInfo";
			txt_menuUpdateNutriInfo.PlaceholderText = "nutritional information";
			txt_menuUpdateNutriInfo.Size = new Size(303, 34);
			txt_menuUpdateNutriInfo.TabIndex = 44;
			// 
			// txt_menuUpdatePrice
			// 
			txt_menuUpdatePrice.Location = new Point(215, 260);
			txt_menuUpdatePrice.Name = "txt_menuUpdatePrice";
			txt_menuUpdatePrice.PlaceholderText = "item price";
			txt_menuUpdatePrice.Size = new Size(303, 34);
			txt_menuUpdatePrice.TabIndex = 43;
			// 
			// txt_menuUpdateDescrip
			// 
			txt_menuUpdateDescrip.Location = new Point(215, 166);
			txt_menuUpdateDescrip.Multiline = true;
			txt_menuUpdateDescrip.Name = "txt_menuUpdateDescrip";
			txt_menuUpdateDescrip.PlaceholderText = "item description";
			txt_menuUpdateDescrip.Size = new Size(303, 85);
			txt_menuUpdateDescrip.TabIndex = 42;
			// 
			// txt_menuUpdateName
			// 
			txt_menuUpdateName.Location = new Point(215, 112);
			txt_menuUpdateName.Name = "txt_menuUpdateName";
			txt_menuUpdateName.PlaceholderText = "item name";
			txt_menuUpdateName.Size = new Size(303, 34);
			txt_menuUpdateName.TabIndex = 41;
			// 
			// flp_menuDisplayUpdateMenu
			// 
			flp_menuDisplayUpdateMenu.BackColor = Color.LightBlue;
			flp_menuDisplayUpdateMenu.Location = new Point(-4, 6);
			flp_menuDisplayUpdateMenu.Name = "flp_menuDisplayUpdateMenu";
			flp_menuDisplayUpdateMenu.Size = new Size(764, 698);
			flp_menuDisplayUpdateMenu.TabIndex = 0;
			// 
			// Manager
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(1382, 753);
			Controls.Add(tab_ViewManager);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "Manager";
			Text = "Manager View";
			tab_ViewManager.ResumeLayout(false);
			tab_createEmployeeProfile.ResumeLayout(false);
			tab_createEmployeeProfile.PerformLayout();
			tab_addMenuItems.ResumeLayout(false);
			tab_addMenuItems.PerformLayout();
			tab_addDiscounts.ResumeLayout(false);
			tab_addDiscounts.PerformLayout();
			tab_addTaxes.ResumeLayout(false);
			tab_addTaxes.PerformLayout();
			tab_updateMenuItems.ResumeLayout(false);
			pnl_updateMenuitems.ResumeLayout(false);
			pnl_updateMenuitems.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tab_ViewManager;
		private TabPage tab_createEmployeeProfile;
		private TabPage tab_addMenuItems;
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
		private TextBox txt_itemLoyaltyPointsReward;
		private TextBox txt_itemLoyaltyPointsPrice;
		private TextBox txt_itemNutritionalInfo;
		private TextBox txt_itemPrice;
		private TextBox txt_itemDescription;
		private TextBox txt_itemName;
		private TabPage tab_addDiscounts;
		private TextBox txt_discountName;
		private Button btn_addDiscount;
		private TextBox txt_dicountValue;
		private TabPage tab_addTaxes;
		private Button btn_addTax;
		private TextBox txt_taxValue;
		private TextBox txt_taxName;
		private Button btn_addItem;
		private ComboBox cmb_discountStatus;
		private ComboBox cmb_taxStatus;
		private ComboBox cmb_taxInfo;
		private ComboBox cmb_discountInfo;
		private Label lbl_itemDescript;
		private Label lbl_itemName;
		private Label lbl_discountInfo;
		private Label lbl_lpReward;
		private Label lbl_lpPrice;
		private Label lbl_nutritionalInfo;
		private Label lbl_itemPrice;
		private Label lbl_taxInfo;
		private Label lbl_discTabValue;
		private Label lbl_discTabStatus;
		private Label lbl_discTabName;
		private Label lbl_taxTabValue;
		private Label lbl_taxTabStatus;
		private Label lbl_taxTabName;
		private TabPage tab_updateMenuItems;
		private FlowLayoutPanel flp_menuDisplayUpdateMenu;
		private Panel pnl_updateMenuitems;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private ComboBox cmb_menuUpdateTaxInfo;
		private ComboBox cmb_menuUpdateDiscountInfo;
		private TextBox txt_menuUpdateLpReward;
		private TextBox txt_menuUpdateLpPrice;
		private TextBox txt_menuUpdateNutriInfo;
		private TextBox txt_menuUpdatePrice;
		private TextBox txt_menuUpdateDescrip;
		private TextBox txt_menuUpdateName;
		private Label label9;
		private TextBox txt_menuUpdateID;
		private Button btn_menuUpdate_update;
	}
}