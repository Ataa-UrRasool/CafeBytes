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
			tabPage2 = new TabPage();
			txt_name = new TextBox();
			txt_phoneNo = new TextBox();
			txt_email = new TextBox();
			label1 = new Label();
			btn_createProfile = new Button();
			tab_ViewManager.SuspendLayout();
			tab_createEmployeeProfile.SuspendLayout();
			SuspendLayout();
			// 
			// tab_ViewManager
			// 
			tab_ViewManager.Controls.Add(tab_createEmployeeProfile);
			tab_ViewManager.Controls.Add(tabPage2);
			tab_ViewManager.Location = new Point(3, 12);
			tab_ViewManager.Name = "tab_ViewManager";
			tab_ViewManager.SelectedIndex = 0;
			tab_ViewManager.Size = new Size(785, 426);
			tab_ViewManager.TabIndex = 0;
			// 
			// tab_createEmployeeProfile
			// 
			tab_createEmployeeProfile.Controls.Add(btn_createProfile);
			tab_createEmployeeProfile.Controls.Add(label1);
			tab_createEmployeeProfile.Controls.Add(txt_email);
			tab_createEmployeeProfile.Controls.Add(txt_phoneNo);
			tab_createEmployeeProfile.Controls.Add(txt_name);
			tab_createEmployeeProfile.Location = new Point(4, 29);
			tab_createEmployeeProfile.Name = "tab_createEmployeeProfile";
			tab_createEmployeeProfile.Padding = new Padding(3);
			tab_createEmployeeProfile.Size = new Size(777, 393);
			tab_createEmployeeProfile.TabIndex = 0;
			tab_createEmployeeProfile.Text = "CreateEmployee";
			tab_createEmployeeProfile.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			tabPage2.Location = new Point(4, 29);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(242, 92);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// txt_name
			// 
			txt_name.Location = new Point(128, 25);
			txt_name.Name = "txt_name";
			txt_name.Size = new Size(125, 27);
			txt_name.TabIndex = 0;
			// 
			// txt_phoneNo
			// 
			txt_phoneNo.Location = new Point(139, 72);
			txt_phoneNo.Name = "txt_phoneNo";
			txt_phoneNo.Size = new Size(125, 27);
			txt_phoneNo.TabIndex = 1;
			// 
			// txt_email
			// 
			txt_email.Location = new Point(141, 132);
			txt_email.Name = "txt_email";
			txt_email.Size = new Size(125, 27);
			txt_email.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(15, 32);
			label1.Name = "label1";
			label1.Size = new Size(50, 20);
			label1.TabIndex = 4;
			label1.Text = "label1";
			// 
			// btn_createProfile
			// 
			btn_createProfile.Location = new Point(137, 191);
			btn_createProfile.Name = "btn_createProfile";
			btn_createProfile.Size = new Size(127, 29);
			btn_createProfile.TabIndex = 5;
			btn_createProfile.Text = "Create Profile";
			btn_createProfile.UseVisualStyleBackColor = true;
			btn_createProfile.Click += btn_createProfile_Click;
			// 
			// Manager
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tab_ViewManager);
			Name = "Manager";
			Text = "Manager";
			tab_ViewManager.ResumeLayout(false);
			tab_createEmployeeProfile.ResumeLayout(false);
			tab_createEmployeeProfile.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tab_ViewManager;
		private TabPage tab_createEmployeeProfile;
		private TabPage tabPage2;
		private Button btn_createProfile;
		private Label label1;
		private TextBox txt_email;
		private TextBox txt_phoneNo;
		private TextBox txt_name;
	}
}