using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bases
{
	public partial class SelectDec : Form
	{
		private Bases b;
		private int v;

		public SelectDec(Bases b, int v)
		{
			InitializeComponent();

			this.b = b;
			this.v = v;
		}

		private void SelectDec_Load(object sender, EventArgs e)
		{
			this.selectDec0.Text = b.Controls["dec0"].Text + ", " + b.Controls["dec1"].Text + ", " + b.Controls["dec2"].Text + ", " + b.Controls["dec3"].Text;
			this.selectDec1.Text = b.Controls["dec3"].Text + ", " + b.Controls["dec1"].Text + ", " + b.Controls["dec2"].Text + ", " + b.Controls["dec0"].Text;

			if(this.v > 0xFFFFFF || this.v < 0)
			{
				this.selectDec2.Text = b.Controls["dec0"].Text + ", " + b.Controls["dec1"].Text + ", " + b.Controls["dec2"].Text + ", " + b.Controls["dec3"].Text;
			}

			else
			{
				this.selectDec2.Text = b.Controls["dec1"].Text + ", " + b.Controls["dec2"].Text + ", " + b.Controls["dec3"].Text;
			}
		}

		private void CopyDec0_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectDec0.Text);
		}

		private void CopyDec1_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectDec1.Text);
		}

		private void CopyDec2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectDec2.Text);
		}
	}
}
