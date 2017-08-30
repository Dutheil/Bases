namespace bases
{
	partial class SelectDec
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
			if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDec));
			this.selectDec0 = new System.Windows.Forms.TextBox();
			this.selectDec1 = new System.Windows.Forms.TextBox();
			this.selectDec2 = new System.Windows.Forms.TextBox();
			this.copyDec0 = new System.Windows.Forms.Button();
			this.copyDec1 = new System.Windows.Forms.Button();
			this.copyDec2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// selectDec0
			// 
			this.selectDec0.BackColor = System.Drawing.Color.Gainsboro;
			this.selectDec0.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectDec0.Location = new System.Drawing.Point(12, 12);
			this.selectDec0.Name = "selectDec0";
			this.selectDec0.ReadOnly = true;
			this.selectDec0.Size = new System.Drawing.Size(423, 29);
			this.selectDec0.TabIndex = 35;
			this.selectDec0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// selectDec1
			// 
			this.selectDec1.BackColor = System.Drawing.Color.Gainsboro;
			this.selectDec1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectDec1.Location = new System.Drawing.Point(12, 47);
			this.selectDec1.Name = "selectDec1";
			this.selectDec1.ReadOnly = true;
			this.selectDec1.Size = new System.Drawing.Size(423, 29);
			this.selectDec1.TabIndex = 36;
			this.selectDec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// selectDec2
			// 
			this.selectDec2.BackColor = System.Drawing.Color.Gainsboro;
			this.selectDec2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectDec2.Location = new System.Drawing.Point(12, 82);
			this.selectDec2.Name = "selectDec2";
			this.selectDec2.ReadOnly = true;
			this.selectDec2.Size = new System.Drawing.Size(423, 29);
			this.selectDec2.TabIndex = 37;
			this.selectDec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// copyDec0
			// 
			this.copyDec0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(185)))));
			this.copyDec0.Location = new System.Drawing.Point(438, 11);
			this.copyDec0.Margin = new System.Windows.Forms.Padding(0);
			this.copyDec0.Name = "copyDec0";
			this.copyDec0.Size = new System.Drawing.Size(79, 31);
			this.copyDec0.TabIndex = 38;
			this.copyDec0.Text = "COPY";
			this.copyDec0.UseVisualStyleBackColor = false;
			this.copyDec0.Click += new System.EventHandler(this.CopyDec0_Click);
			// 
			// copyDec1
			// 
			this.copyDec1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(185)))));
			this.copyDec1.Location = new System.Drawing.Point(438, 46);
			this.copyDec1.Margin = new System.Windows.Forms.Padding(0);
			this.copyDec1.Name = "copyDec1";
			this.copyDec1.Size = new System.Drawing.Size(79, 31);
			this.copyDec1.TabIndex = 39;
			this.copyDec1.Text = "COPY";
			this.copyDec1.UseVisualStyleBackColor = false;
			this.copyDec1.Click += new System.EventHandler(this.CopyDec1_Click);
			// 
			// copyDec2
			// 
			this.copyDec2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(234)))), ((int)(((byte)(185)))));
			this.copyDec2.Location = new System.Drawing.Point(438, 81);
			this.copyDec2.Margin = new System.Windows.Forms.Padding(0);
			this.copyDec2.Name = "copyDec2";
			this.copyDec2.Size = new System.Drawing.Size(79, 31);
			this.copyDec2.TabIndex = 40;
			this.copyDec2.Text = "COPY";
			this.copyDec2.UseVisualStyleBackColor = false;
			this.copyDec2.Click += new System.EventHandler(this.CopyDec2_Click);
			// 
			// SelectDec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(526, 121);
			this.Controls.Add(this.copyDec2);
			this.Controls.Add(this.copyDec1);
			this.Controls.Add(this.copyDec0);
			this.Controls.Add(this.selectDec2);
			this.Controls.Add(this.selectDec1);
			this.Controls.Add(this.selectDec0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SelectDec";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select: Decimal";
			this.Load += new System.EventHandler(this.SelectDec_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox selectDec0;
		private System.Windows.Forms.TextBox selectDec1;
		private System.Windows.Forms.TextBox selectDec2;
		private System.Windows.Forms.Button copyDec0;
		private System.Windows.Forms.Button copyDec1;
		private System.Windows.Forms.Button copyDec2;
	}
}