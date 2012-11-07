using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EncryptFile
{
	public partial class MainForm : Form
	{
		private const string lblEncryptFileNameText = "暗号化するファイル(&F):";
		private const string lblDecryptFileNameText = "復号化するファイル(&F):";
		private const string normalFileDialogFilter = "すべてのファイル|*.*";
		private string encryptFileDialogFilter = "暗号化されたファイル|*" + Encrypt.EncryptExtension + "|すべてのファイル|*.*";

		public MainForm(string arg)
		{
			InitializeComponent();

			RadioButtonCheckedChanged();
			lblMessage.Text = "";
			btnOpen.Visible = false;

			if (arg != null)
			{
				txtFileName.Text = arg;
				int i = arg.LastIndexOf(Encrypt.EncryptExtension);
				if (i != -1)
				{
					rdbDecrypt.Checked = true;
					txtSaveFileName.Text = arg.Remove(i);
				}
				txtPassword1.Focus();
			}
		}

		private string message, detailMessage;

		private void SetMessage(string text, string detailText = "", Color? color = null)
		{
			lblMessage.Text = message = text;
			detailMessage = detailText;
			if (detailText != "") lblMessage.Text += " (詳細...)";
			if (color == null)
			{
				lblMessage.BackColor = SystemColors.Control;
			}
			else
			{
				lblMessage.BackColor = (Color)color;
			}
		}

		private void btnReferFileName_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = txtFileName.Text;
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtFileName.Text = openFileDialog1.FileName;
				if (rdbEncrypt.Checked)
				{
					txtSaveFileName.Text = openFileDialog1.FileName + Encrypt.EncryptExtension;
				}
				else
				{
					int a = openFileDialog1.FileName.LastIndexOf(Encrypt.EncryptExtension);
					txtSaveFileName.Text = openFileDialog1.FileName.Remove(a);
				}
			}
		}

		private void btnSaveFileName_Click(object sender, EventArgs e)
		{
			saveFileDialog1.FileName = txtSaveFileName.Text;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtSaveFileName.Text = saveFileDialog1.FileName;
			}
		}

		private void rdbEncrypt_CheckedChanged(object sender, EventArgs e)
		{
			RadioButtonCheckedChanged();
		}

		private void rdbDecrypt_CheckedChanged(object sender, EventArgs e)
		{
			RadioButtonCheckedChanged();
		}

		private void RadioButtonCheckedChanged()
		{
			if (rdbEncrypt.Checked)
			{
				lblFileName.Text = lblEncryptFileNameText;
				openFileDialog1.Filter = normalFileDialogFilter;
				saveFileDialog1.Filter = encryptFileDialogFilter;
				txtPassword2.Visible = lblPassword2.Visible = true;
			}
			else
			{
				lblFileName.Text = lblDecryptFileNameText;
				openFileDialog1.Filter = encryptFileDialogFilter;
				saveFileDialog1.Filter = normalFileDialogFilter;
				txtPassword2.Visible = lblPassword2.Visible = false;
			}
			txtFileName.Text = txtPassword1.Text = txtPassword2.Text = txtSaveFileName.Text = "";
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (InputCheck())
			{
				if (rdbEncrypt.Checked)
				{
					StartEncrypt();
				}
				else
				{
					StartDecrypt();
				}
			}
		}

		private bool InputCheck()
		{
			if (!File.Exists(txtFileName.Text))
			{
				txtFileName.Focus();
				SetMessage("暗号化するファイルが見つかりません", "", Color.Orange);
				return false;
			}
			else if (rdbEncrypt.Checked && txtPassword1.Text != txtPassword2.Text)
			{
				txtPassword2.Focus();
				SetMessage("パスワードが異なります", "", Color.Orange);
				return false;
			}
			else return true;
		}

		private void StartEncrypt()
		{
			try
			{
				Encrypt.EncryptFile(txtFileName.Text, txtSaveFileName.Text, txtPassword1.Text);
				SetMessage("暗号化に成功しました", "対象：" + txtFileName.Text + "\r\n保存先：" + txtSaveFileName.Text);
			}
			catch (Exception ex)
			{
				SetMessage(ex.Message, ex.ToString(), Color.Orange);
			}
		}

		private void StartDecrypt()
		{
			try
			{
				Encrypt.DecryptFile(txtFileName.Text, txtSaveFileName.Text, txtPassword1.Text);
				SetMessage("復号化に成功しました", "対象：" + txtFileName.Text + "\r\n保存先：" + txtSaveFileName.Text);
				btnOpen.Visible = true;
				btnOpen.Focus();
			}
			catch (System.Security.Cryptography.CryptographicException ex)
			{
				SetMessage("復号中に例外が発生しました。\r\nパスワードは合っていますか?", ex.Message + "\r\n\r\n" + ex.ToString(), Color.Orange);
			}
			catch (Exception ex)
			{
				SetMessage(ex.Message, ex.ToString(), Color.Orange);
			}
		}

		private void txtPassword1_TextChanged(object sender, EventArgs e)
		{
			ChangedTextBox();
			CheckPassword();
		}

		private void txtPassword2_TextChanged(object sender, EventArgs e)
		{
			ChangedTextBox();
			CheckPassword();
		}

		private void CheckPassword()
		{
			txtPassword2.BackColor = rdbEncrypt.Checked && txtPassword1.Text == txtPassword2.Text ?
				SystemColors.Window : Color.Orange;
		}

		private void lblMessage_Click(object sender, EventArgs e)
		{
			MessageBox.Show(detailMessage, message);
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			if (txtFileName.Text == "")
			{
				txtFileName.Focus();
			}
			else
			{
				txtPassword1.Focus();
			}
		}


		private void txtFileName_TextChanged(object sender, EventArgs e)
		{
			ChangedTextBox();
		}

		private void txtSaveFileName_TextChanged(object sender, EventArgs e)
		{
			ChangedTextBox();
		}

		private void ChangedTextBox()
		{
			if (btnOpen.Visible) btnOpen.Visible = false;
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(txtSaveFileName.Text);
			}
			catch (Exception ex)
			{
				SetMessage(ex.Message, ex.ToString(), Color.Orange);
			}
		}

		private void textBox_Enter(object sender, EventArgs e)
		{
			((TextBox)sender).SelectAll();
		}

	}
}
