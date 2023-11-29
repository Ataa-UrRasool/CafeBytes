namespace DbProject.PresentationLayer
{
	partial class GuestUsersScreen
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
			pnl_MenuItems = new Panel();
			lbl_guestUserHeading = new Label();
			lv_guestUser = new ListView();
			pnl_2_guestUser = new Panel();
			btn_placeOrder = new Button();
			txt_custoID = new TextBox();
			lbl_customerIdGU = new Label();
			pnl_2_guestUser.SuspendLayout();
			SuspendLayout();
			// 
			// pnl_MenuItems
			// 
			pnl_MenuItems.AutoScroll = true;
			pnl_MenuItems.BackColor = Color.LightBlue;
			pnl_MenuItems.Location = new Point(7, 64);
			pnl_MenuItems.Name = "pnl_MenuItems";
			pnl_MenuItems.Size = new Size(936, 677);
			pnl_MenuItems.TabIndex = 0;
			// 
			// lbl_guestUserHeading
			// 
			lbl_guestUserHeading.AutoSize = true;
			lbl_guestUserHeading.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_guestUserHeading.ForeColor = SystemColors.Control;
			lbl_guestUserHeading.Location = new Point(405, 9);
			lbl_guestUserHeading.Name = "lbl_guestUserHeading";
			lbl_guestUserHeading.Size = new Size(140, 53);
			lbl_guestUserHeading.TabIndex = 1;
			lbl_guestUserHeading.Text = "Menu";
			lbl_guestUserHeading.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lv_guestUser
			// 
			lv_guestUser.BackColor = Color.LightBlue;
			lv_guestUser.Location = new Point(960, 64);
			lv_guestUser.Name = "lv_guestUser";
			lv_guestUser.Size = new Size(410, 433);
			lv_guestUser.TabIndex = 2;
			lv_guestUser.UseCompatibleStateImageBehavior = false;
			// 
			// pnl_2_guestUser
			// 
			pnl_2_guestUser.BackColor = Color.LightBlue;
			pnl_2_guestUser.Controls.Add(btn_placeOrder);
			pnl_2_guestUser.Controls.Add(txt_custoID);
			pnl_2_guestUser.Controls.Add(lbl_customerIdGU);
			pnl_2_guestUser.Location = new Point(960, 519);
			pnl_2_guestUser.Name = "pnl_2_guestUser";
			pnl_2_guestUser.Size = new Size(410, 222);
			pnl_2_guestUser.TabIndex = 3;
			// 
			// btn_placeOrder
			// 
			btn_placeOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btn_placeOrder.Location = new Point(151, 155);
			btn_placeOrder.Name = "btn_placeOrder";
			btn_placeOrder.Size = new Size(112, 37);
			btn_placeOrder.TabIndex = 2;
			btn_placeOrder.Text = "Place Order";
			btn_placeOrder.UseVisualStyleBackColor = true;
			btn_placeOrder.Click += btn_placeOrder_Click;
			// 
			// txt_custoID
			// 
			txt_custoID.Location = new Point(54, 97);
			txt_custoID.Name = "txt_custoID";
			txt_custoID.Size = new Size(323, 27);
			txt_custoID.TabIndex = 1;
			// 
			// lbl_customerIdGU
			// 
			lbl_customerIdGU.AutoSize = true;
			lbl_customerIdGU.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbl_customerIdGU.Location = new Point(128, 47);
			lbl_customerIdGU.Name = "lbl_customerIdGU";
			lbl_customerIdGU.Size = new Size(175, 38);
			lbl_customerIdGU.TabIndex = 0;
			lbl_customerIdGU.Text = "Customer ID";
			// 
			// GuestUsersScreen
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Desktop;
			ClientSize = new Size(1382, 753);
			Controls.Add(pnl_2_guestUser);
			Controls.Add(lv_guestUser);
			Controls.Add(lbl_guestUserHeading);
			Controls.Add(pnl_MenuItems);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "GuestUsersScreen";
			Text = "GuestUsers";
			pnl_2_guestUser.ResumeLayout(false);
			pnl_2_guestUser.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel pnl_MenuItems;
		private Label lbl_guestUserHeading;
		private ListView lv_guestUser;
		private Panel pnl_2_guestUser;
		private TextBox txt_custoID;
		private Label lbl_customerIdGU;
		private Button btn_placeOrder;
	}
}