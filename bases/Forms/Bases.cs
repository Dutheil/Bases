using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bases
{
    [Flags]
    public enum TypeInput
    {
        Nobase,
        Decimal,
        Hexadecimal,
        Binary
    }

    public partial class Bases : Form
    {
        private TypeInput type = TypeInput.Nobase;
		private int value = 0;

        public Bases()
        {
            InitializeComponent();
        }

        private void FormatWindow_Load(object sender, EventArgs e)
        {

        }

		private void Input_TextChanged(object sender, EventArgs e)
		{
            String str = this.input.Text;
            int l = str.Length;

            if(l >= 1)
            {
                if(str[0] == '0')
                {
                    if(l >= 2)
                    {
                        if(str[1] == 'x' || str[1] == 'X')
                        {
                            this.type = TypeInput.Hexadecimal;
							this.input_base.Text = "Hexadecimal";
                        }

                        else if(str[1] == 'b' || str[1] == 'B')
                        {
                            this.type = TypeInput.Binary;
                            this.input_base.Text = "Binary";
                        }

                        else
                        {
                            this.type = TypeInput.Nobase;
							this.input_base.Text = "No base";
							this.SetValue(0);

							return;
                        }
                    }

                    else
                    {
                        this.type = TypeInput.Decimal;
						this.input_base.Text = "Decimal";
                    }
                }

				else
				{
					this.type = TypeInput.Decimal;
					this.input_base.Text = "Decimal";
				}
			}

            else
            {
                type = TypeInput.Nobase;
				this.input_base.Text = "No base";
				this.SetValue(0);

				return;
            }

			if(this.type == TypeInput.Decimal) // Decimal
			{
				if(!(int.TryParse(str, out int v)))
				{
					this.input_base.Text = "Error:Decimal";
					this.SetValue(0);

					return;
				}

				this.SetValue(v);

				return;
			}

			else if(this.type != TypeInput.Nobase) // Hexadecimal or Binary
			{
                if(l >= 3)
                {
					String v_str = str.Remove(0, 2);
					int v_l = v_str.Length;

					if(this.type == TypeInput.Hexadecimal) // Hexadecimal
					{
                        Regex rgx = new Regex("[^A-Fa-f0-9]");

                        if(rgx.IsMatch(v_str) || v_l >= 9)
                        {
							this.input_base.Text = "Error:Hex";
							this.SetValue(0);

							return;
                        }

						this.SetValue(Convert.ToInt32(v_str, 16));

						return;
					}

					else // Binary
					{
						Regex rgx = new Regex("[^0-1]");

						if(rgx.IsMatch(v_str) || v_l >= 33)
						{
							this.input_base.Text = "Error:Binary";
							this.SetValue(0);

							return;
						}

						this.SetValue(Convert.ToInt32(v_str, 2));

						return;
					}
                }
            }
        }

		private void SetValue(int value)
		{
			this.value = value;

			if(value > 0xFFFFFF || value < 0)
			{
				this.hex0.BackColor = Color.FromArgb(239, 154, 154);
				this.hex1.BackColor = Color.FromArgb(165, 214, 167);
				this.hex2.BackColor = Color.FromArgb(144, 202, 249);
				this.hex3.BackColor = Color.FromArgb(176, 190, 197);
			}

			else
			{
				this.hex0.BackColor = Color.Gainsboro;
				this.hex1.BackColor = Color.FromArgb(239, 154, 154);
				this.hex2.BackColor = Color.FromArgb(165, 214, 167);
				this.hex3.BackColor = Color.FromArgb(144, 202, 249);
			}

			this.dec.Text = value.ToString();

			String str_bin = Convert.ToString(value, 2);
			int l_bin = 32 - str_bin.Length;

			for(int i = 0; i < l_bin; i++)
				str_bin = "0" + str_bin;

			foreach(var octet in Regex.Matches(str_bin, ".{8}").Cast<Match>())
			{
				int o = octet.Index / 8;
				int v = Convert.ToInt32(octet.Value, 2);
				this.Controls["bin" + o].Text = octet.Value;
				this.Controls["dec" + o].Text = v.ToString();
				this.Controls["hex" + o].Text = v.ToString("X2");
			}

		}

		private void Dec_select_Click(object sender, EventArgs e)
        {
			SelectDec form = new SelectDec(this, this.value);
			form.ShowDialog();
        }

        private void Hex_select_Click(object sender, EventArgs e)
        {
			SelectHex form = new SelectHex(this, this.value);
			form.ShowDialog();
		}

        private void Bin_select_Click(object sender, EventArgs e)
        {
			SelectBin form = new SelectBin(this, this.value);
			form.ShowDialog();
		}
	}
}
