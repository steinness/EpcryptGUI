namespace EpcryptGUI {
	partial class Epcrypt {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textToEncryptDecryptLabel = new System.Windows.Forms.Label();
			this.resultLabel = new System.Windows.Forms.Label();
			this.encryptBox = new System.Windows.Forms.CheckBox();
			this.decryptCheck = new System.Windows.Forms.CheckBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.selectFile = new System.Windows.Forms.Button();
			this.encryptDecryptFile = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.doneLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(12, 195);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(166, 191);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.textBox2.ForeColor = System.Drawing.Color.White;
			this.textBox2.Location = new System.Drawing.Point(206, 195);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox2.Size = new System.Drawing.Size(166, 191);
			this.textBox2.TabIndex = 1;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textToEncryptDecryptLabel
			// 
			this.textToEncryptDecryptLabel.BackColor = System.Drawing.Color.Transparent;
			this.textToEncryptDecryptLabel.ForeColor = System.Drawing.Color.White;
			this.textToEncryptDecryptLabel.Location = new System.Drawing.Point(12, 176);
			this.textToEncryptDecryptLabel.Name = "textToEncryptDecryptLabel";
			this.textToEncryptDecryptLabel.Size = new System.Drawing.Size(125, 16);
			this.textToEncryptDecryptLabel.TabIndex = 2;
			this.textToEncryptDecryptLabel.Text = "Text to encrypt:";
			// 
			// resultLabel
			// 
			this.resultLabel.BackColor = System.Drawing.Color.Transparent;
			this.resultLabel.ForeColor = System.Drawing.Color.White;
			this.resultLabel.Location = new System.Drawing.Point(203, 176);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(125, 16);
			this.resultLabel.TabIndex = 3;
			this.resultLabel.Text = "Result: ";
			// 
			// encryptBox
			// 
			this.encryptBox.Checked = true;
			this.encryptBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.encryptBox.ForeColor = System.Drawing.Color.White;
			this.encryptBox.Location = new System.Drawing.Point(12, 35);
			this.encryptBox.Name = "encryptBox";
			this.encryptBox.Size = new System.Drawing.Size(104, 24);
			this.encryptBox.TabIndex = 4;
			this.encryptBox.Text = "Encrypt";
			this.encryptBox.UseVisualStyleBackColor = true;
			this.encryptBox.CheckedChanged += new System.EventHandler(this.encryptBox_CheckedChanged);
			// 
			// decryptCheck
			// 
			this.decryptCheck.ForeColor = System.Drawing.Color.White;
			this.decryptCheck.Location = new System.Drawing.Point(12, 54);
			this.decryptCheck.Name = "decryptCheck";
			this.decryptCheck.Size = new System.Drawing.Size(104, 24);
			this.decryptCheck.TabIndex = 5;
			this.decryptCheck.Text = "Decrypt";
			this.decryptCheck.UseVisualStyleBackColor = true;
			this.decryptCheck.CheckedChanged += new System.EventHandler(this.decryptBox_CheckedChanged);
			// 
			// passwordBox
			// 
			this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.passwordBox.ForeColor = System.Drawing.Color.White;
			this.passwordBox.Location = new System.Drawing.Point(12, 144);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(166, 20);
			this.passwordBox.TabIndex = 7;
			this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.ForeColor = System.Drawing.Color.White;
			this.passwordLabel.Location = new System.Drawing.Point(9, 128);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(56, 13);
			this.passwordLabel.TabIndex = 8;
			this.passwordLabel.Text = "Password:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(184, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 26);
			this.label1.TabIndex = 9;
			this.label1.Text = "The password is used to encrypt\r\n and decrypt the text\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(9, 389);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "© Vegard Steinnes 2017";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(100, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 36);
			this.label3.TabIndex = 11;
			this.label3.Text = "EpcryptGUI 2.0";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// selectFile
			// 
			this.selectFile.Location = new System.Drawing.Point(12, 88);
			this.selectFile.Name = "selectFile";
			this.selectFile.Size = new System.Drawing.Size(75, 21);
			this.selectFile.TabIndex = 12;
			this.selectFile.Text = "Select file";
			this.selectFile.UseVisualStyleBackColor = true;
			this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
			// 
			// encryptDecryptFile
			// 
			this.encryptDecryptFile.Location = new System.Drawing.Point(106, 88);
			this.encryptDecryptFile.Name = "encryptDecryptFile";
			this.encryptDecryptFile.Size = new System.Drawing.Size(75, 21);
			this.encryptDecryptFile.TabIndex = 13;
			this.encryptDecryptFile.Text = "Encrypt file";
			this.encryptDecryptFile.UseVisualStyleBackColor = true;
			this.encryptDecryptFile.Click += new System.EventHandler(this.encryptDecryptFile_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(203, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 13);
			this.label4.TabIndex = 14;
			// 
			// doneLabel
			// 
			this.doneLabel.AutoSize = true;
			this.doneLabel.ForeColor = System.Drawing.Color.White;
			this.doneLabel.Location = new System.Drawing.Point(187, 92);
			this.doneLabel.Name = "doneLabel";
			this.doneLabel.Size = new System.Drawing.Size(31, 13);
			this.doneLabel.TabIndex = 15;
			this.doneLabel.Text = "        ";
			// 
			// Epcrypt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(384, 411);
			this.Controls.Add(this.doneLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.encryptDecryptFile);
			this.Controls.Add(this.selectFile);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.decryptCheck);
			this.Controls.Add(this.encryptBox);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.textToEncryptDecryptLabel);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.MaximumSize = new System.Drawing.Size(400, 450);
			this.MinimumSize = new System.Drawing.Size(400, 450);
			this.Name = "Epcrypt";
			this.ShowIcon = false;
			this.Text = "EpcryptGUI 2.0";
			this.Load += new System.EventHandler(this.Epcrypt_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label textToEncryptDecryptLabel;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.CheckBox encryptBox;
		private System.Windows.Forms.CheckBox decryptCheck;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button selectFile;
		private System.Windows.Forms.Button encryptDecryptFile;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label doneLabel;
	}
}

