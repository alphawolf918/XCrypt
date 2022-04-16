using System;
using System.Windows.Forms;

namespace XCrypt {
	public partial class frmMain : Form {

		bool hasRanOnce = false;
		int minLen = 10;

		public frmMain() => InitializeComponent();

		private void btnGen_Click(object sender, EventArgs e) {
			string strBase = txtBase.Text;
			bool useFirst = chkUseFirst.Checked;
			bool useSymbols = chkUseSymb.Checked;
			int numFirst = CInt(txtNumFirst.Text);
			int passLen = CInt(txtPassLen.Text);
			if (passLen < minLen) {
				txtPassLen.Text = CStr(minLen);
				passLen = minLen;
			}
			txtPass.Text = generatePassword(strBase, passLen, useSymbols, useFirst, numFirst);
		}

		private string[] getLetters() => new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i",
								  "j", "k", "l", "m", "n", "o", "p", "q", "r",
								  "s", "t", "u", "v", "w", "x", "y", "z"};

		private string[] getSymbols() => new string[] {"!", "@", "#", "$", "%", "^", "&", "*",
								 "(",")","{","}","`", "~", ",", "[", "]",
								 ".", "<", ">", ":", ";", "=", "+", "-",
								 "/", "?", "\"", "'", "|", "_"};

		private int[] getNumbers() => new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		private string generatePassword(string strBase = "", int passLen = 13, bool useSymbols = true, bool useFirst = true, int firstNum = 2) {
			string strPass = "";
			strBase = (strBase == "") ? "xcryptpw" : strBase;
			char[] strPw = strBase.ToCharArray();
			if (useFirst) {
				int b = 0;
				while (b < firstNum) {
					string strFirst = strPw[b].ToString();
					if (b == 0) {
						char[] strSubPass = strFirst.ToCharArray();
						strPass += strSubPass[0].ToString().ToUpper();
						b = 1;
					}
					strPass += strPw[b].ToString();
					b++;
				}
			}
			int i = 0;
			int ns = 0;
			Random rand = new Random();
			while (strPass.Length < passLen) {
				int x = rand.Next(0, strPw.Length - 1);
				int y = rand.Next(0, 2);
				string[] ltrs = getLetters();
				if (i == rand.Next(5, passLen)) {
					strPass += rand.Next(strPw.Length);
				}
				strPass += ltrs[rand.Next(0, 25)];
				int h = rand.Next(0, 25);
				strPass += (y == 0) ? ltrs[h].ToUpper() : ltrs[h].ToLower();
				int[] nums = getNumbers();
				if (useSymbols) {
					string[] symbs = getSymbols();
					int symbLen = symbs.Length - 1;
					string u = symbs[rand.Next(0, symbLen)];
					if (u != "" && ns < rand.Next(2, 6)) {
						strPass += u;
						ns++;
					} else {
						if (rand.Next(0, 10) < 5) {
							strPass += nums[rand.Next(0, 9)];
						} else {
							strPass += ltrs[rand.Next(0, 9)];
						}
					}
					strPass += nums[rand.Next(0, 9)];
				}
				i++;
			}
			strPass = strPass.Replace(" ", "");
			if (!hasRanOnce) {
				hasRanOnce = true;
				strPass = generatePassword(strPass, passLen, useSymbols, useFirst, firstNum);
			}
			strPass = strPass.Substring(0, passLen);
			return strPass;
		}

		private void txtNumFirst_KeyDown(object sender, KeyEventArgs e) {
			string[] keyNums = { CStr(Keys.D0), CStr(Keys.D1), CStr(Keys.D2), CStr(Keys.D3), CStr(Keys.Back) };
			if (!(Array.Exists(keyNums, el => el == CStr(e.KeyCode)))) {
				e.SuppressKeyPress = true;
			}
		}

		private void txtPassLen_KeyDown(object sender, KeyEventArgs e) {
			string[] keyNums = { CStr(Keys.D0), CStr(Keys.D1), CStr(Keys.D2), CStr(Keys.D3), CStr(Keys.D4),
								 CStr(Keys.D5), CStr(Keys.D6), CStr(Keys.D7), CStr(Keys.D8), CStr(Keys.D9),
								 CStr(Keys.Back) };
			if (!(Array.Exists(keyNums, el => el == CStr(e.KeyCode)))) {
				e.SuppressKeyPress = true;
			}
		}

		private string CStr(object exp) => Convert.ToString(exp);
		private int CInt(object exp) => Convert.ToInt32(exp);
	}
}