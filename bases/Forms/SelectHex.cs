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
	public partial class SelectHex : Form
	{
		private Bases b;
		private int v;

		public SelectHex(Bases b, int v)
		{
			InitializeComponent();

			this.b = b;
			this.v = v;
		}

		private void SelectHex_Load(object sender, EventArgs e)
		{
			this.selectHex0.Text = "0x" + b.Controls["hex0"].Text + b.Controls["hex1"].Text + b.Controls["hex2"].Text + b.Controls["hex3"].Text;
			this.selectHex1.Text = b.Controls["hex0"].Text + b.Controls["hex1"].Text + b.Controls["hex2"].Text + b.Controls["hex3"].Text;
			this.selectHex2.Text = b.Controls["hex0"].Text + ", " + b.Controls["hex1"].Text + ", " + b.Controls["hex2"].Text + ", " + b.Controls["hex3"].Text;
			this.selectHex3.Text = "0x" + b.Controls["hex1"].Text + b.Controls["hex2"].Text + b.Controls["hex3"].Text;
			this.selectHex4.Text = b.Controls["hex1"].Text + b.Controls["hex2"].Text + b.Controls["hex3"].Text;
			this.selectHex5.Text = b.Controls["hex1"].Text + ", " + b.Controls["hex2"].Text + ", " + b.Controls["hex3"].Text;
		}

		private void copyHex0_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectHex0.Text);
		}

		private void copyHex2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectHex1.Text);
		}

		private void copyHex1_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectHex2.Text);
		}

		private void copyHex3_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectHex3.Text);
		}

		private void copyHex4_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectHex4.Text);
		}

		private void copyHex5_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectHex5.Text);
		}
	}
}
