using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpcryptGUI {
	public partial class Epcrypt : Form {
		public Epcrypt() {
			InitializeComponent();
		}

		public static string filepath;

		// Function for updating all the boxes because im lazy ;)
		public void Update() {
			if (encryptBox.Checked == true) {
				textBox2.Text = EpcryptCMD.Encrypt(passwordBox.Text, textBox1.Text, false);
			}
			else {
				textBox2.Text = EpcryptCMD.Decrypt(passwordBox.Text, textBox1.Text, false);
			}
		}

		private void decryptBox_CheckedChanged(object sender, EventArgs e) {
			if (decryptCheck.Checked == true) {
				encryptBox.Checked = false;
				textToEncryptDecryptLabel.Text = "Text to decrypt: ";
				encryptDecryptFile.Text = "Decrypt file";
			}
			else {
				encryptBox.Checked = true;
			}
			Update();
		}

		private void encryptBox_CheckedChanged(object sender, EventArgs e) {
			if (encryptBox.Checked == true) {
				decryptCheck.Checked = false;
				textToEncryptDecryptLabel.Text = "Text to encrypt: ";
				encryptDecryptFile.Text = "Encrypt file";
			}
			else {
				decryptCheck.Checked = true;
			}
			Update();
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			Update();
		}

		private void textBox2_TextChanged(object sender, EventArgs e) {
			Update();
		}

		private void passwordBox_TextChanged(object sender, EventArgs e) {
			Update();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
			// Sets the filepath variable to the path given from the file dialog
			filepath = openFileDialog1.FileName;
		}

		private void encryptDecryptFile_Click(object sender, EventArgs e) {
			doneLabel.Text = "";
			// Adding a delay so that you can see that the program is actually responding by changing the text
			System.Threading.Thread.Sleep(2000);
			if (encryptBox.Checked == true) {
				EpcryptCMD.EncryptFile(passwordBox.Text, filepath, false);
			}
			else {
				EpcryptCMD.DecryptFile(passwordBox.Text, filepath, false);
			}
			doneLabel.Text = "Done!";
		}

		private void selectFile_Click(object sender, EventArgs e) {
			// Opening the file dialog on click
			openFileDialog1.ShowDialog();
		}

		private void Epcrypt_Load(object sender, EventArgs e) {

		}
	}
}
