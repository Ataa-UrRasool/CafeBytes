﻿namespace DbProject.PresentationLayer
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
			cmb_discountStatus = new ComboBox();
			btn_addDiscount = new Button();
			txt_dicountValue = new TextBox();
			txt_discountName = new TextBox();
			tab_addTaxes = new TabPage();
			cmb_taxStatus = new ComboBox();
			btn_addTax = new Button();
			txt_taxValue = new TextBox();
			txt_taxName = new TextBox();
			tab_ViewManager.SuspendLayout();
			tab_createEmployeeProfile.SuspendLayout();
			tab_addMenuItems.SuspendLayout();
			tab_addDiscounts.SuspendLayout();
			tab_addTaxes.SuspendLayout();
			SuspendLayout();
			// 
			// tab_ViewManager
			// 
			tab_ViewManager.Controls.Add(tab_createEmployeeProfile);
			tab_ViewManager.Controls.Add(tab_addMenuItems);
			tab_ViewManager.Controls.Add(tab_addDiscounts);
			tab_ViewManager.Controls.Add(tab_addTaxes);
			tab_ViewManager.Font = new Font("Segoe UI", 12F);
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
			tab_createEmployeeProfile.Font = new Font("Segoe UI", 10F);
			tab_createEmployeeProfile.Location = new Point(4, 37);
			tab_createEmployeeProfile.Name = "tab_createEmployeeProfile";
			tab_createEmployeeProfile.Padding = new Padding(3);
			tab_createEmployeeProfile.Size = new Size(1372, 710);
			tab_createEmployeeProfile.TabIndex = 0;
			tab_createEmployeeProfile.Text = "CreateEmployee";
			// 
			// cmb_gender
			// 
			cmb_gender.FormattingEnabled = true;
			cmb_gender.Items.AddRange(new object[] { "Male", "Female" });
			cmb_gender.Location = new Point(567, 360);
			cmb_gender.Name = "cmb_gender";
			cmb_gender.Size = new Size(364, 31);
			cmb_gender.TabIndex = 45;
			// 
			// txt_hourlyRate
			// 
			txt_hourlyRate.Location = new Point(567, 412);
			txt_hourlyRate.Name = "txt_hourlyRate";
			txt_hourlyRate.PlaceholderText = "hourly rate";
			txt_hourlyRate.Size = new Size(364, 30);
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
			txt_password.Size = new Size(364, 30);
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
			txt_username.Size = new Size(364, 30);
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
			txt_email.Size = new Size(364, 30);
			txt_email.TabIndex = 30;
			// 
			// txt_phoneNo
			// 
			txt_phoneNo.Location = new Point(567, 175);
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
			tab_addMenuItems.BackColor = Color.DarkGray;
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
			tab_addMenuItems.Text = "AddMenuItems";
			// 
			// cmb_taxInfo
			// 
			cmb_taxInfo.FormattingEnabled = true;
			cmb_taxInfo.Location = new Point(566, 483);
			cmb_taxInfo.Name = "cmb_taxInfo";
			cmb_taxInfo.Size = new Size(228, 31);
			cmb_taxInfo.TabIndex = 8;
			cmb_taxInfo.Text = "tax info";
			cmb_taxInfo.Click += cmb_taxInfo_Click;
			// 
			// cmb_discountInfo
			// 
			cmb_discountInfo.FormattingEnabled = true;
			cmb_discountInfo.Location = new Point(566, 429);
			cmb_discountInfo.Name = "cmb_discountInfo";
			cmb_discountInfo.Size = new Size(228, 31);
			cmb_discountInfo.TabIndex = 7;
			cmb_discountInfo.Text = "discount info";
			cmb_discountInfo.Click += cmb_discountInfo_Click;
			// 
			// btn_addItem
			// 
			btn_addItem.Cursor = Cursors.Hand;
			btn_addItem.Location = new Point(586, 552);
			btn_addItem.Name = "btn_addItem";
			btn_addItem.Size = new Size(94, 29);
			btn_addItem.TabIndex = 6;
			btn_addItem.Text = "Add Item";
			btn_addItem.UseVisualStyleBackColor = true;
			btn_addItem.Click += btn_addItem_Click;
			// 
			// txt_itemLoyaltyPointsReward
			// 
			txt_itemLoyaltyPointsReward.Location = new Point(566, 378);
			txt_itemLoyaltyPointsReward.Name = "txt_itemLoyaltyPointsReward";
			txt_itemLoyaltyPointsReward.PlaceholderText = "LP rewards";
			txt_itemLoyaltyPointsReward.Size = new Size(125, 30);
			txt_itemLoyaltyPointsReward.TabIndex = 5;
			// 
			// txt_itemLoyaltyPointsPrice
			// 
			txt_itemLoyaltyPointsPrice.Location = new Point(566, 319);
			txt_itemLoyaltyPointsPrice.Name = "txt_itemLoyaltyPointsPrice";
			txt_itemLoyaltyPointsPrice.PlaceholderText = "LP price";
			txt_itemLoyaltyPointsPrice.Size = new Size(125, 30);
			txt_itemLoyaltyPointsPrice.TabIndex = 4;
			// 
			// txt_itemNutritionalInfo
			// 
			txt_itemNutritionalInfo.Location = new Point(566, 260);
			txt_itemNutritionalInfo.Name = "txt_itemNutritionalInfo";
			txt_itemNutritionalInfo.PlaceholderText = "nutritional information";
			txt_itemNutritionalInfo.Size = new Size(125, 30);
			txt_itemNutritionalInfo.TabIndex = 3;
			// 
			// txt_itemPrice
			// 
			txt_itemPrice.Location = new Point(566, 198);
			txt_itemPrice.Name = "txt_itemPrice";
			txt_itemPrice.PlaceholderText = "item price";
			txt_itemPrice.Size = new Size(125, 30);
			txt_itemPrice.TabIndex = 2;
			// 
			// txt_itemDescription
			// 
			txt_itemDescription.Location = new Point(566, 135);
			txt_itemDescription.Name = "txt_itemDescription";
			txt_itemDescription.PlaceholderText = "item description";
			txt_itemDescription.Size = new Size(125, 30);
			txt_itemDescription.TabIndex = 1;
			// 
			// txt_itemName
			// 
			txt_itemName.Location = new Point(566, 79);
			txt_itemName.Name = "txt_itemName";
			txt_itemName.PlaceholderText = "item name";
			txt_itemName.Size = new Size(125, 30);
			txt_itemName.TabIndex = 0;
			// 
			// tab_addDiscounts
			// 
			tab_addDiscounts.BackColor = Color.DarkGray;
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
			tab_addDiscounts.Text = "AddDiscounts";
			// 
			// cmb_discountStatus
			// 
			cmb_discountStatus.Cursor = Cursors.Hand;
			cmb_discountStatus.DisplayMember = "(none)";
			cmb_discountStatus.FormattingEnabled = true;
			cmb_discountStatus.Items.AddRange(new object[] { "Active", "Inactive" });
			cmb_discountStatus.Location = new Point(513, 165);
			cmb_discountStatus.Name = "cmb_discountStatus";
			cmb_discountStatus.Size = new Size(166, 31);
			cmb_discountStatus.TabIndex = 4;
			cmb_discountStatus.Tag = "";
			// 
			// btn_addDiscount
			// 
			btn_addDiscount.Cursor = Cursors.Hand;
			btn_addDiscount.Location = new Point(534, 296);
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
			txt_dicountValue.Location = new Point(513, 231);
			txt_dicountValue.Name = "txt_dicountValue";
			txt_dicountValue.PlaceholderText = "discount value";
			txt_dicountValue.Size = new Size(166, 30);
			txt_dicountValue.TabIndex = 2;
			// 
			// txt_discountName
			// 
			txt_discountName.Location = new Point(513, 99);
			txt_discountName.Name = "txt_discountName";
			txt_discountName.PlaceholderText = "discount name";
			txt_discountName.Size = new Size(166, 30);
			txt_discountName.TabIndex = 0;
			// 
			// tab_addTaxes
			// 
			tab_addTaxes.BackColor = Color.DarkGray;
			tab_addTaxes.Controls.Add(cmb_taxStatus);
			tab_addTaxes.Controls.Add(btn_addTax);
			tab_addTaxes.Controls.Add(txt_taxValue);
			tab_addTaxes.Controls.Add(txt_taxName);
			tab_addTaxes.Font = new Font("Segoe UI", 10F);
			tab_addTaxes.Location = new Point(4, 37);
			tab_addTaxes.Name = "tab_addTaxes";
			tab_addTaxes.Padding = new Padding(3);
			tab_addTaxes.Size = new Size(1372, 710);
			tab_addTaxes.TabIndex = 3;
			tab_addTaxes.Text = "AddTaxes";
			// 
			// cmb_taxStatus
			// 
			cmb_taxStatus.Cursor = Cursors.Hand;
			cmb_taxStatus.FormattingEnabled = true;
			cmb_taxStatus.Items.AddRange(new object[] { "Active", "Inactive" });
			cmb_taxStatus.Location = new Point(580, 247);
			cmb_taxStatus.Name = "cmb_taxStatus";
			cmb_taxStatus.Size = new Size(166, 31);
			cmb_taxStatus.TabIndex = 8;
			// 
			// btn_addTax
			// 
			btn_addTax.Cursor = Cursors.Hand;
			btn_addTax.Location = new Point(597, 386);
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
			txt_taxValue.Location = new Point(580, 318);
			txt_taxValue.Name = "txt_taxValue";
			txt_taxValue.PlaceholderText = "tax value";
			txt_taxValue.Size = new Size(166, 30);
			txt_taxValue.TabIndex = 6;
			// 
			// txt_taxName
			// 
			txt_taxName.Location = new Point(580, 183);
			txt_taxName.Name = "txt_taxName";
			txt_taxName.PlaceholderText = "tax name";
			txt_taxName.Size = new Size(166, 30);
			txt_taxName.TabIndex = 4;
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
			tab_addMenuItems.ResumeLayout(false);
			tab_addMenuItems.PerformLayout();
			tab_addDiscounts.ResumeLayout(false);
			tab_addDiscounts.PerformLayout();
			tab_addTaxes.ResumeLayout(false);
			tab_addTaxes.PerformLayout();
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
	}
}