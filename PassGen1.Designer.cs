using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace XCrypt {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.chkUseFirst = new System.Windows.Forms.CheckBox();
            this.lblNumFirst = new System.Windows.Forms.Label();
            this.txtNumFirst = new System.Windows.Forms.TextBox();
            this.chkUseSymb = new System.Windows.Forms.CheckBox();
            this.lblPassLen = new System.Windows.Forms.Label();
            this.txtPassLen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass.Location = new System.Drawing.Point(156, 230);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(342, 40);
            this.txtPass.TabIndex = 0;
            this.txtPass.WordWrap = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(153, 211);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(97, 20);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password:";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(259, 167);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(116, 37);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // txtBase
            // 
            this.txtBase.BackColor = System.Drawing.SystemColors.Window;
            this.txtBase.Location = new System.Drawing.Point(156, 111);
            this.txtBase.Multiline = true;
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(342, 40);
            this.txtBase.TabIndex = 0;
            this.txtBase.WordWrap = false;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(153, 92);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(58, 20);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Base:";
            // 
            // chkUseFirst
            // 
            this.chkUseFirst.AutoSize = true;
            this.chkUseFirst.Location = new System.Drawing.Point(23, 20);
            this.chkUseFirst.Name = "chkUseFirst";
            this.chkUseFirst.Size = new System.Drawing.Size(185, 24);
            this.chkUseFirst.TabIndex = 5;
            this.chkUseFirst.Text = "Use Base As Start";
            this.chkUseFirst.UseVisualStyleBackColor = true;
            // 
            // lblNumFirst
            // 
            this.lblNumFirst.AutoSize = true;
            this.lblNumFirst.Location = new System.Drawing.Point(23, 47);
            this.lblNumFirst.Name = "lblNumFirst";
            this.lblNumFirst.Size = new System.Drawing.Size(208, 20);
            this.lblNumFirst.TabIndex = 6;
            this.lblNumFirst.Text = "Numbers of Base First:";
            // 
            // txtNumFirst
            // 
            this.txtNumFirst.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumFirst.Location = new System.Drawing.Point(237, 44);
            this.txtNumFirst.MaxLength = 1;
            this.txtNumFirst.Name = "txtNumFirst";
            this.txtNumFirst.Size = new System.Drawing.Size(35, 27);
            this.txtNumFirst.TabIndex = 7;
            this.txtNumFirst.Text = "2";
            this.txtNumFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumFirst.WordWrap = false;
            this.txtNumFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumFirst_KeyDown);
            // 
            // chkUseSymb
            // 
            this.chkUseSymb.AutoSize = true;
            this.chkUseSymb.Checked = true;
            this.chkUseSymb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseSymb.Location = new System.Drawing.Point(459, 20);
            this.chkUseSymb.Name = "chkUseSymb";
            this.chkUseSymb.Size = new System.Drawing.Size(142, 24);
            this.chkUseSymb.TabIndex = 11;
            this.chkUseSymb.Text = "Use Symbols";
            this.chkUseSymb.UseVisualStyleBackColor = true;
            // 
            // lblPassLen
            // 
            this.lblPassLen.AutoSize = true;
            this.lblPassLen.Location = new System.Drawing.Point(459, 44);
            this.lblPassLen.Name = "lblPassLen";
            this.lblPassLen.Size = new System.Drawing.Size(76, 20);
            this.lblPassLen.TabIndex = 12;
            this.lblPassLen.Text = "Length:";
            // 
            // txtPassLen
            // 
            this.txtPassLen.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassLen.Location = new System.Drawing.Point(541, 40);
            this.txtPassLen.MaxLength = 2;
            this.txtPassLen.Name = "txtPassLen";
            this.txtPassLen.Size = new System.Drawing.Size(35, 27);
            this.txtPassLen.TabIndex = 13;
            this.txtPassLen.Text = "10";
            this.txtPassLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassLen.WordWrap = false;
            this.txtPassLen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassLen_KeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 301);
            this.Controls.Add(this.txtPassLen);
            this.Controls.Add(this.lblPassLen);
            this.Controls.Add(this.chkUseSymb);
            this.Controls.Add(this.txtNumFirst);
            this.Controls.Add(this.lblNumFirst);
            this.Controls.Add(this.chkUseFirst);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XCrypt Secure";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private TextBox txtPass;
		private Label lblPass;
		private Button btnGen;
		private TextBox txtBase;
		private Label lblBase;
		private CheckBox chkUseFirst;
		private Label lblNumFirst;
		private TextBox txtNumFirst;
		private CheckBox chkUseSymb;
		private Label lblPassLen;
		private TextBox txtPassLen;
	}
}

