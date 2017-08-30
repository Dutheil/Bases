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
	public partial class SelectBin : Form
	{
		private Bases b;
		private int v;

		public SelectBin(Bases b, int v)
		{
			InitializeComponent();

			this.b = b;
			this.v = v;
		}

		private void SelectBin_Load(object sender, EventArgs e)
		{
			this.selectBin0.Text = "0b" + b.Controls["bin0"].Text + b.Controls["bin1"].Text + b.Controls["bin2"].Text + b.Controls["bin3"].Text;
			this.selectBin1.Text = b.Controls["bin0"].Text + b.Controls["bin1"].Text + b.Controls["bin2"].Text + b.Controls["bin3"].Text;
			this.selectBin2.Text = b.Controls["bin0"].Text + ", " + b.Controls["bin1"].Text + ", " + b.Controls["bin2"].Text + ", " + b.Controls["bin3"].Text;
			this.selectBin3.Text = b.Controls["bin3"].Text + ", " + b.Controls["bin1"].Text + ", " + b.Controls["bin2"].Text + ", " + b.Controls["bin0"].Text;
		}

		private void copyBin0_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectBin0.Text);
		}

		private void copyBin1_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectBin1.Text);
		}

		private void copyBin2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectBin2.Text);
		}

		private void copyBin3_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.selectBin3.Text);
		}
	}
}
