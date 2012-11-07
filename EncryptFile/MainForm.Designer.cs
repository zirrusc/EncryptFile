namespace EncryptFile
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.lblFileName = new System.Windows.Forms.Label();
			this.btnReferFileName = new System.Windows.Forms.Button();
			this.btnSaveFileName = new System.Windows.Forms.Button();
			this.txtSaveFileName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassword1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword2 = new System.Windows.Forms.TextBox();
			this.lblPassword2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.rdbEncrypt = new System.Windows.Forms.RadioButton();
			this.rdbDecrypt = new System.Windows.Forms.RadioButton();
			this.lblMessage = new System.Windows.Forms.Label();
			this.btnOpen = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtFileName
			// 
			this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtFileName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.txtFileName.Location = new System.Drawing.Point(156, 54);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(285, 25);
			this.txtFileName.TabIndex = 3;
			this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
			// 
			// lblFileName
			// 
			this.lblFileName.AutoSize = true;
			this.lblFileName.Location = new System.Drawing.Point(12, 57);
			this.lblFileName.Name = "lblFileName";
			this.lblFileName.Size = new System.Drawing.Size(138, 18);
			this.lblFileName.TabIndex = 2;
			this.lblFileName.Text = "暗号化するファイル(&F):";
			// 
			// btnReferFileName
			// 
			this.btnReferFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReferFileName.Location = new System.Drawing.Point(447, 54);
			this.btnReferFileName.Name = "btnReferFileName";
			this.btnReferFileName.Size = new System.Drawing.Size(35, 25);
			this.btnReferFileName.TabIndex = 4;
			this.btnReferFileName.Text = "...";
			this.btnReferFileName.UseVisualStyleBackColor = true;
			this.btnReferFileName.Click += new System.EventHandler(this.btnReferFileName_Click);
			// 
			// btnSaveFileName
			// 
			this.btnSaveFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveFileName.Location = new System.Drawing.Point(447, 85);
			this.btnSaveFileName.Name = "btnSaveFileName";
			this.btnSaveFileName.Size = new System.Drawing.Size(35, 25);
			this.btnSaveFileName.TabIndex = 7;
			this.btnSaveFileName.Text = "...";
			this.btnSaveFileName.UseVisualStyleBackColor = true;
			this.btnSaveFileName.Click += new System.EventHandler(this.btnSaveFileName_Click);
			// 
			// txtSaveFileName
			// 
			this.txtSaveFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSaveFileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtSaveFileName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.txtSaveFileName.Location = new System.Drawing.Point(156, 85);
			this.txtSaveFileName.Name = "txtSaveFileName";
			this.txtSaveFileName.Size = new System.Drawing.Size(285, 25);
			this.txtSaveFileName.TabIndex = 6;
			this.txtSaveFileName.TextChanged += new System.EventHandler(this.txtSaveFileName_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "保存先(&S):";
			// 
			// txtPassword1
			// 
			this.txtPassword1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword1.Location = new System.Drawing.Point(156, 116);
			this.txtPassword1.Name = "txtPassword1";
			this.txtPassword1.PasswordChar = '●';
			this.txtPassword1.Size = new System.Drawing.Size(285, 25);
			this.txtPassword1.TabIndex = 9;
			this.txtPassword1.TextChanged += new System.EventHandler(this.txtPassword1_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "パスワード(&P):";
			// 
			// txtPassword2
			// 
			this.txtPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword2.Location = new System.Drawing.Point(156, 147);
			this.txtPassword2.Name = "txtPassword2";
			this.txtPassword2.PasswordChar = '●';
			this.txtPassword2.Size = new System.Drawing.Size(285, 25);
			this.txtPassword2.TabIndex = 11;
			this.txtPassword2.TextChanged += new System.EventHandler(this.txtPassword2_TextChanged);
			// 
			// lblPassword2
			// 
			this.lblPassword2.AutoSize = true;
			this.lblPassword2.Location = new System.Drawing.Point(12, 150);
			this.lblPassword2.Name = "lblPassword2";
			this.lblPassword2.Size = new System.Drawing.Size(139, 18);
			this.lblPassword2.TabIndex = 10;
			this.lblPassword2.Text = "パスワードの再入力(&R):";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(282, 186);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 35);
			this.tableLayoutPanel1.TabIndex = 13;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnClose.Location = new System.Drawing.Point(103, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(94, 29);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "閉じる(&C)";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnStart
			// 
			this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStart.Location = new System.Drawing.Point(3, 3);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(94, 29);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "開始(&S)";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.SupportMultiDottedExtensions = true;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.SupportMultiDottedExtensions = true;
			// 
			// rdbEncrypt
			// 
			this.rdbEncrypt.AutoSize = true;
			this.rdbEncrypt.Checked = true;
			this.rdbEncrypt.Location = new System.Drawing.Point(12, 12);
			this.rdbEncrypt.Name = "rdbEncrypt";
			this.rdbEncrypt.Size = new System.Drawing.Size(79, 22);
			this.rdbEncrypt.TabIndex = 0;
			this.rdbEncrypt.TabStop = true;
			this.rdbEncrypt.Text = "暗号化(&E)";
			this.rdbEncrypt.UseVisualStyleBackColor = true;
			this.rdbEncrypt.CheckedChanged += new System.EventHandler(this.rdbEncrypt_CheckedChanged);
			// 
			// rdbDecrypt
			// 
			this.rdbDecrypt.AutoSize = true;
			this.rdbDecrypt.Location = new System.Drawing.Point(97, 12);
			this.rdbDecrypt.Name = "rdbDecrypt";
			this.rdbDecrypt.Size = new System.Drawing.Size(81, 22);
			this.rdbDecrypt.TabIndex = 1;
			this.rdbDecrypt.Text = "復号化(&D)";
			this.rdbDecrypt.UseVisualStyleBackColor = true;
			this.rdbDecrypt.CheckedChanged += new System.EventHandler(this.rdbDecrypt_CheckedChanged);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoEllipsis = true;
			this.lblMessage.Location = new System.Drawing.Point(12, 175);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(264, 49);
			this.lblMessage.TabIndex = 12;
			this.lblMessage.Text = "lblMessage";
			this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.Location = new System.Drawing.Point(385, 150);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(94, 30);
			this.btnOpen.TabIndex = 14;
			this.btnOpen.Text = "開く(&O)";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(494, 233);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.rdbDecrypt);
			this.Controls.Add(this.rdbEncrypt);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.lblPassword2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPassword2);
			this.Controls.Add(this.txtPassword1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSaveFileName);
			this.Controls.Add(this.txtSaveFileName);
			this.Controls.Add(this.btnReferFileName);
			this.Controls.Add(this.lblFileName);
			this.Controls.Add(this.txtFileName);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "ファイルを暗号化";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Label lblFileName;
		private System.Windows.Forms.Button btnReferFileName;
		private System.Windows.Forms.Button btnSaveFileName;
		private System.Windows.Forms.TextBox txtSaveFileName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword2;
		private System.Windows.Forms.Label lblPassword2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.RadioButton rdbEncrypt;
		private System.Windows.Forms.RadioButton rdbDecrypt;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Button btnOpen;
	}
}

