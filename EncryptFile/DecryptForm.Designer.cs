namespace EncryptFile
{
	partial class DecryptForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnReferFileName = new System.Windows.Forms.Button();
			this.btnSaveFileName = new System.Windows.Forms.Button();
			this.txtSaveFileName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassword1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtFileName
			// 
			this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtFileName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.txtFileName.Location = new System.Drawing.Point(156, 12);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(285, 25);
			this.txtFileName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "暗号化するファイル(&E):";
			// 
			// btnReferFileName
			// 
			this.btnReferFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReferFileName.Location = new System.Drawing.Point(447, 12);
			this.btnReferFileName.Name = "btnReferFileName";
			this.btnReferFileName.Size = new System.Drawing.Size(35, 25);
			this.btnReferFileName.TabIndex = 2;
			this.btnReferFileName.Text = "...";
			this.btnReferFileName.UseVisualStyleBackColor = true;
			// 
			// btnSaveFileName
			// 
			this.btnSaveFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveFileName.Location = new System.Drawing.Point(447, 43);
			this.btnSaveFileName.Name = "btnSaveFileName";
			this.btnSaveFileName.Size = new System.Drawing.Size(35, 25);
			this.btnSaveFileName.TabIndex = 4;
			this.btnSaveFileName.Text = "...";
			this.btnSaveFileName.UseVisualStyleBackColor = true;
			// 
			// txtSaveFileName
			// 
			this.txtSaveFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSaveFileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtSaveFileName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.txtSaveFileName.Location = new System.Drawing.Point(156, 43);
			this.txtSaveFileName.Name = "txtSaveFileName";
			this.txtSaveFileName.Size = new System.Drawing.Size(285, 25);
			this.txtSaveFileName.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "保存先(&F):";
			// 
			// txtPassword1
			// 
			this.txtPassword1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword1.Location = new System.Drawing.Point(156, 74);
			this.txtPassword1.Name = "txtPassword1";
			this.txtPassword1.PasswordChar = '●';
			this.txtPassword1.Size = new System.Drawing.Size(285, 25);
			this.txtPassword1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "パスワード(&P):";
			// 
			// txtPassword2
			// 
			this.txtPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword2.Location = new System.Drawing.Point(156, 105);
			this.txtPassword2.Name = "txtPassword2";
			this.txtPassword2.PasswordChar = '●';
			this.txtPassword2.Size = new System.Drawing.Size(285, 25);
			this.txtPassword2.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "パスワードの再入力(&R):";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(282, 143);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 35);
			this.tableLayoutPanel1.TabIndex = 8;
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
			// 
			// DecryptForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(494, 190);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPassword2);
			this.Controls.Add(this.txtPassword1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSaveFileName);
			this.Controls.Add(this.txtSaveFileName);
			this.Controls.Add(this.btnReferFileName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFileName);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "DecryptForm";
			this.Text = "ファイルを暗号化";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReferFileName;
		private System.Windows.Forms.Button btnSaveFileName;
		private System.Windows.Forms.TextBox txtSaveFileName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

