namespace OneTwoThree.AddUserToGoServer
{
	partial class AddUserForm
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
			this.lblGoServer = new System.Windows.Forms.Label();
			this.txtGoServer = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.butAddUser = new System.Windows.Forms.Button();
			this.cmdExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblGoServer
			// 
			this.lblGoServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGoServer.Location = new System.Drawing.Point(18, 32);
			this.lblGoServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblGoServer.Name = "lblGoServer";
			this.lblGoServer.Size = new System.Drawing.Size(178, 32);
			this.lblGoServer.TabIndex = 0;
			this.lblGoServer.Text = "Go Server :";
			this.lblGoServer.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtGoServer
			// 
			this.txtGoServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGoServer.Location = new System.Drawing.Point(206, 32);
			this.txtGoServer.Margin = new System.Windows.Forms.Padding(4);
			this.txtGoServer.Name = "txtGoServer";
			this.txtGoServer.Size = new System.Drawing.Size(176, 24);
			this.txtGoServer.TabIndex = 1;
			this.txtGoServer.Text = "MachineName";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(206, 76);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(336, 24);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "firstname.lastname";
			// 
			// lblUserName
			// 
			this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserName.Location = new System.Drawing.Point(24, 76);
			this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(172, 32);
			this.lblUserName.TabIndex = 2;
			this.lblUserName.Text = "User Name :";
			this.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(206, 120);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(336, 24);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "TestPassword";
			this.textBox2.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 120);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 32);
			this.label1.TabIndex = 4;
			this.label1.Text = "User Name :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// butAddUser
			// 
			this.butAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.butAddUser.Location = new System.Drawing.Point(166, 172);
			this.butAddUser.Margin = new System.Windows.Forms.Padding(4);
			this.butAddUser.Name = "butAddUser";
			this.butAddUser.Size = new System.Drawing.Size(112, 39);
			this.butAddUser.TabIndex = 6;
			this.butAddUser.Text = "Add User";
			this.butAddUser.UseVisualStyleBackColor = true;
			this.butAddUser.Click += new System.EventHandler(this.butAddUser_Click);
			// 
			// cmdExit
			// 
			this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdExit.Location = new System.Drawing.Point(288, 172);
			this.cmdExit.Margin = new System.Windows.Forms.Padding(4);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(112, 39);
			this.cmdExit.TabIndex = 7;
			this.cmdExit.Text = "Exit";
			this.cmdExit.UseVisualStyleBackColor = true;
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// AddUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 227);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.butAddUser);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.txtGoServer);
			this.Controls.Add(this.lblGoServer);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "123 IT - Add User to Go Server";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblGoServer;
		private System.Windows.Forms.TextBox txtGoServer;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button butAddUser;
		private System.Windows.Forms.Button cmdExit;
	}
}

