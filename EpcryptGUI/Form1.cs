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
	}
}
