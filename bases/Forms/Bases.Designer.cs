namespace bases
{
	partial class Bases
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bases));
			this.bin_select = new System.Windows.Forms.Button();
			this.input = new System.Windows.Forms.TextBox();
			this.hex0 = new System.Windows.Forms.TextBox();
			this.hex2 = new System.Windows.Forms.TextBox();
			this.hex1 = new System.Windows.Forms.TextBox();
			this.hex3 = new System.Windows.Forms.TextBox();
			this.hex_select = new System.Windows.Forms.Button();
			this.input_base = new System.Windows.Forms.Button();
			this.dec_select = new System.Windows.Forms.Button();
			this.dec0 = new System.Windows.Forms.TextBox();
			this.dec2 = new System.Windows.Forms.TextBox();
			this.dec1 = new System.Windows.Forms.TextBox();
			this.dec3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dec = new System.Windows.Forms.TextBox();
			this.button7 = new System.Windows.Forms.Button();
			this.bin0 = new System.Windows.Forms.TextBox();
			this.bin2 = new System.Windows.Forms.TextBox();
			this.bin1 = new System.Windows.Forms.TextBox();
			this.bin3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bin_select
			// 
			this.bin_select.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.bin_select.Location = new System.Drawing.Point(688, 182);
			this.bin_select.Margin = new System.Windows.Forms.Padding(0);
			this.bin_select.Name = "bin_select";
			this.bin_select.Size = new System.Drawing.Size(79, 31);
			this.bin_select.TabIndex = 4;
			this.bin_select.Text = "SELECT";
			this.bin_select.UseVisualStyleBackColor = false;
			this.bin_select.Click += new System.EventHandler(this.Bin_select_Click);
			// 
			// input
			// 
			this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.input.Location = new System.Drawing.Point(12, 14);
			this.input.Name = "input";
			this.input.Size = new System.Drawing.Size(654, 26);
			this.input.TabIndex = 6;
			this.input.Text = "0";
			this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.input.TextChanged += new System.EventHandler(this.Input_TextChanged);
			// 
			// hex0
			// 
			this.hex0.BackColor = System.Drawing.Color.Gainsboro;
			this.hex0.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hex0.Location = new System.Drawing.Point(152, 148);
			this.hex0.Name = "hex0";
			this.hex0.ReadOnly = true;
			this.hex0.Size = new System.Drawing.Size(124, 29);
			this.hex0.TabIndex = 18;
			this.hex0.Text = "00";
			this.hex0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// hex2
			// 
			this.hex2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(214)))), ((int)(((byte)(167)))));
			this.hex2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hex2.Location = new System.Drawing.Point(412, 148);
			this.hex2.Name = "hex2";
			this.hex2.ReadOnly = true;
			this.hex2.Size = new System.Drawing.Size(124, 29);
			this.hex2.TabIndex = 17;
			this.hex2.Text = "00";
			this.hex2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// hex1
			// 
			this.hex1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
			this.hex1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hex1.Location = new System.Drawing.Point(282, 148);
			this.hex1.Name = "hex1";
			this.hex1.ReadOnly = true;
			this.hex1.Size = new System.Drawing.Size(124, 29);
			this.hex1.TabIndex = 16;
			this.hex1.Text = "00";
			this.hex1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// hex3
			// 
			this.hex3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
			this.hex3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hex3.Location = new System.Drawing.Point(542, 148);
			this.hex3.Name = "hex3";
			this.hex3.ReadOnly = true;
			this.hex3.Size = new System.Drawing.Size(124, 29);
			this.hex3.TabIndex = 15;
			this.hex3.Text = "00";
			this.hex3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// hex_select
			// 
			this.hex_select.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.hex_select.Location = new System.Drawing.Point(688, 147);
			this.hex_select.Margin = new System.Windows.Forms.Padding(0);
			this.hex_select.Name = "hex_select";
			this.hex_select.Size = new System.Drawing.Size(79, 31);
			this.hex_select.TabIndex = 23;
			this.hex_select.Text = "SELECT";
			this.hex_select.UseVisualStyleBackColor = false;
			this.hex_select.Click += new System.EventHandler(this.Hex_select_Click);
			// 
			// input_base
			// 
			this.input_base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.input_base.Enabled = false;
			this.input_base.FlatAppearance.BorderSize = 0;
			this.input_base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.input_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.input_base.ForeColor = System.Drawing.Color.Maroon;
			this.input_base.Location = new System.Drawing.Point(688, 14);
			this.input_base.Margin = new System.Windows.Forms.Padding(0);
			this.input_base.Name = "input_base";
			this.input_base.Size = new System.Drawing.Size(79, 26);
			this.input_base.TabIndex = 24;
			this.input_base.Text = "Decimal";
			this.input_base.UseVisualStyleBackColor = false;
			// 
			// dec_select
			// 
			this.dec_select.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.dec_select.Location = new System.Drawing.Point(688, 112);
			this.dec_select.Margin = new System.Windows.Forms.Padding(0);
			this.dec_select.Name = "dec_select";
			this.dec_select.Size = new System.Drawing.Size(79, 31);
			this.dec_select.TabIndex = 29;
			this.dec_select.Text = "SELECT";
			this.dec_select.UseVisualStyleBackColor = false;
			this.dec_select.Click += new System.EventHandler(this.Dec_select_Click);
			// 
			// dec0
			// 
			this.dec0.BackColor = System.Drawing.Color.Gainsboro;
			this.dec0.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dec0.Location = new System.Drawing.Point(152, 113);
			this.dec0.Name = "dec0";
			this.dec0.ReadOnly = true;
			this.dec0.Size = new System.Drawing.Size(124, 29);
			this.dec0.TabIndex = 28;
			this.dec0.Text = "0";
			this.dec0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// dec2
			// 
			this.dec2.BackColor = System.Drawing.Color.Gainsboro;
			this.dec2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dec2.Location = new System.Drawing.Point(412, 113);
			this.dec2.Name = "dec2";
			this.dec2.ReadOnly = true;
			this.dec2.Size = new System.Drawing.Size(124, 29);
			this.dec2.TabIndex = 27;
			this.dec2.Text = "0";
			this.dec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// dec1
			// 
			this.dec1.BackColor = System.Drawing.Color.Gainsboro;
			this.dec1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dec1.Location = new System.Drawing.Point(282, 113);
			this.dec1.Name = "dec1";
			this.dec1.ReadOnly = true;
			this.dec1.Size = new System.Drawing.Size(124, 29);
			this.dec1.TabIndex = 26;
			this.dec1.Text = "0";
			this.dec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// dec3
			// 
			this.dec3.BackColor = System.Drawing.Color.Gainsboro;
			this.dec3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dec3.Location = new System.Drawing.Point(542, 113);
			this.dec3.Name = "dec3";
			this.dec3.ReadOnly = true;
			this.dec3.Size = new System.Drawing.Size(124, 29);
			this.dec3.TabIndex = 25;
			this.dec3.Text = "0";
			this.dec3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightGray;
			this.button1.Enabled = false;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(11, 113);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 29);
			this.button1.TabIndex = 30;
			this.button1.Text = "Decimal | Octets";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightGray;
			this.button2.Enabled = false;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(11, 148);
			this.button2.Margin = new System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(138, 29);
			this.button2.TabIndex = 31;
			this.button2.Text = "Hexadecimal | Octets";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightGray;
			this.button4.Enabled = false;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(11, 60);
			this.button4.Margin = new System.Windows.Forms.Padding(0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(138, 29);
			this.button4.TabIndex = 33;
			this.button4.Text = "Decimal";
			this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button4.UseVisualStyleBackColor = false;
			// 
			// dec
			// 
			this.dec.BackColor = System.Drawing.Color.Gainsboro;
			this.dec.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dec.Location = new System.Drawing.Point(152, 60);
			this.dec.Name = "dec";
			this.dec.ReadOnly = true;
			this.dec.Size = new System.Drawing.Size(513, 29);
			this.dec.TabIndex = 34;
			this.dec.Text = "0";
			this.dec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.LightGray;
			this.button7.Enabled = false;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Black;
			this.button7.Location = new System.Drawing.Point(11, 183);
			this.button7.Margin = new System.Windows.Forms.Padding(0);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(138, 29);
			this.button7.TabIndex = 61;
			this.button7.Text = "Binary | Octets";
			this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button7.UseVisualStyleBackColor = false;
			// 
			// bin0
			// 
			this.bin0.BackColor = System.Drawing.Color.Gainsboro;
			this.bin0.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bin0.Location = new System.Drawing.Point(152, 183);
			this.bin0.Name = "bin0";
			this.bin0.ReadOnly = true;
			this.bin0.Size = new System.Drawing.Size(124, 29);
			this.bin0.TabIndex = 60;
			this.bin0.Text = "00000000";
			this.bin0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// bin2
			// 
			this.bin2.BackColor = System.Drawing.Color.Gainsboro;
			this.bin2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bin2.Location = new System.Drawing.Point(412, 183);
			this.bin2.Name = "bin2";
			this.bin2.ReadOnly = true;
			this.bin2.Size = new System.Drawing.Size(124, 29);
			this.bin2.TabIndex = 59;
			this.bin2.Text = "00000000";
			this.bin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// bin1
			// 
			this.bin1.BackColor = System.Drawing.Color.Gainsboro;
			this.bin1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bin1.Location = new System.Drawing.Point(282, 183);
			this.bin1.Name = "bin1";
			this.bin1.ReadOnly = true;
			this.bin1.Size = new System.Drawing.Size(124, 29);
			this.bin1.TabIndex = 58;
			this.bin1.Text = "00000000";
			this.bin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// bin3
			// 
			this.bin3.BackColor = System.Drawing.Color.Gainsboro;
			this.bin3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bin3.Location = new System.Drawing.Point(542, 183);
			this.bin3.Name = "bin3";
			this.bin3.ReadOnly = true;
			this.bin3.Size = new System.Drawing.Size(124, 29);
			this.bin3.TabIndex = 57;
			this.bin3.Text = "00000000";
			this.bin3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(733, 219);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 62;
			this.label1.Text = "C_far";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(716, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 20);
			this.label2.TabIndex = 63;
			this.label2.Text = "©";
			// 
			// Bases
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(776, 236);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.bin2);
			this.Controls.Add(this.bin1);
			this.Controls.Add(this.bin3);
			this.Controls.Add(this.dec);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dec_select);
			this.Controls.Add(this.dec2);
			this.Controls.Add(this.dec1);
			this.Controls.Add(this.dec3);
			this.Controls.Add(this.input_base);
			this.Controls.Add(this.hex_select);
			this.Controls.Add(this.hex2);
			this.Controls.Add(this.hex1);
			this.Controls.Add(this.hex3);
			this.Controls.Add(this.input);
			this.Controls.Add(this.bin_select);
			this.Controls.Add(this.bin0);
			this.Controls.Add(this.dec0);
			this.Controls.Add(this.hex0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Bases";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bases: Dec - Hex - Bin";
			this.Load += new System.EventHandler(this.FormatWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button bin_select;
		private System.Windows.Forms.TextBox input;
		private System.Windows.Forms.TextBox hex0;
		private System.Windows.Forms.TextBox hex2;
		private System.Windows.Forms.TextBox hex1;
		private System.Windows.Forms.TextBox hex3;
		private System.Windows.Forms.Button hex_select;
		private System.Windows.Forms.Button input_base;
		private System.Windows.Forms.Button dec_select;
		private System.Windows.Forms.TextBox dec0;
		private System.Windows.Forms.TextBox dec2;
		private System.Windows.Forms.TextBox dec1;
		private System.Windows.Forms.TextBox dec3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox dec;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox bin0;
		private System.Windows.Forms.TextBox bin2;
		private System.Windows.Forms.TextBox bin1;
		private System.Windows.Forms.TextBox bin3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

