using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpcryptGUI {
	public class EpcryptCMD {

		// All the alphabets used for encryption
		static string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.,!?-;:/(){}[]=*\"\\#0123456789 ";
		static string customUnicodeAlphabet = "¥¢£¤%@!¡å$±ł®ª©↓→←πæßðđŋ€øʘ♠♦♣♥♪♫☺☻☯⚘☮⚰⚱♡♢♤♧♬⌘▹◁▷◅▻◬⊿∆∇◭◮◉⬔▨₡ḠḴḀḚṖṀṘ₷Ḩℇ₩฿₹™μψƔꗦꕬ";
		static string customASCIIAlphabet = "mMnNbBvVcCxXzZaAsSdDfFgGhHjJkKlLpPoOiIuUyYtTrReEwWqQ1234567890+-.,\\/#;:()}{%&<>|?!";

		static int amountOfCharactersInAlphabet = 82;

		// For encrypting one character
		private static string Echar(int shift, string character, bool unicode) {
			int characterPosition;
			characterPosition = alphabet.IndexOf(character);

			int newCharacterPosition = characterPosition + shift;

			// The shift number has to be smaller than the amount of characters in the custom alphabet
			while (newCharacterPosition >= amountOfCharactersInAlphabet) {
				newCharacterPosition -= amountOfCharactersInAlphabet;
			}

			if (unicode == true) {
				// Converts string to char because Replace() only takes char as the first argument
				character = character.Replace((Convert.ToChar(character)), customUnicodeAlphabet[newCharacterPosition]);
			}
			else if (unicode == false) {
				// Converts string to char because Replace() only takes char as the first argument
				character = character.Replace((Convert.ToChar(character)), customASCIIAlphabet[newCharacterPosition]);
			}
			return character;
		}

		// For decrypting one character
		private static string Dchar(int shift, string character, bool unicode) {
			int characterPosition;
			characterPosition = 0;

			if (unicode == true) {
				characterPosition = customUnicodeAlphabet.IndexOf(character);
			}
			else if (unicode == false) {
				characterPosition = customASCIIAlphabet.IndexOf(character);
			}

			int newCharacterPosition = characterPosition - shift;

			// The shift number have to be between 1 and the amount of characters in the custom alphabet for the algorithm to work
			while (newCharacterPosition <= 0) {
				newCharacterPosition += amountOfCharactersInAlphabet;
			}
			while (newCharacterPosition >= amountOfCharactersInAlphabet) {
				newCharacterPosition -= amountOfCharactersInAlphabet;
			}

			character = character.Replace((Convert.ToChar(character)), alphabet[newCharacterPosition]);
			return character;
		}

		// For encrypting a whole string
		public static string Encrypt(string password, string text, bool unicode) {
			string encryptedText = "";
			int shift = ShiftGenerator(password);

			foreach (char character in text) {
				encryptedText += Echar(shift, Convert.ToString(character), unicode);
			}
			return encryptedText;
		}

		// For decrypting a whole string
		public static string Decrypt(string password, string text, bool unicode) {
			string decryptedText = "";
			int shift = ShiftGenerator(password);

			foreach (char character in text) {
				decryptedText += Dchar(shift, Convert.ToString(character), unicode);
			}
			return decryptedText;
		}

		// For generating a shift number from string
		private static int ShiftGenerator(string password) {
			int s = 0;

			foreach (char character in password) {
				s += (alphabet.IndexOf(character));
			}

			return s;
		}

	}

	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Epcrypt());
		}
	}
}
