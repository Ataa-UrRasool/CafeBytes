namespace DbProject.PresentationLayer
{
	partial class GuestUsers
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
			lbl_guestUserHeading.Location = new Point(405, 9);
			lbl_guestUserHeading.Name = "lbl_guestUserHeading";
			lbl_guestUserHeading.Size = new Size(140, 53);
			lbl_guestUserHeading.TabIndex = 1;
			lbl_guestUserHeading.Text = "Menu";
			lbl_guestUserHeading.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lv_guestUser
			// 
			lv_guestUser.Location = new Point(960, 64);
			lv_guestUser.Name = "lv_guestUser";
			lv_guestUser.Size = new Size(410, 677);
			lv_guestUser.TabIndex = 2;
			lv_guestUser.UseCompatibleStateImageBehavior = false;
			// 
			// GuestUsers
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1382, 753);
			Controls.Add(lv_guestUser);
			Controls.Add(lbl_guestUserHeading);
			Controls.Add(pnl_MenuItems);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "GuestUsers";
			Text = "GuestUsers";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel pnl_MenuItems;
		private Label lbl_guestUserHeading;
		private ListView lv_guestUser;
	}
}