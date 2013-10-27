using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FF_TRPG_ClassLibrary;

namespace FF_TRPG_Magic_And_Techniques
{
    public partial class MainEntry : Form
    {
        public MainEntry()
        {
            InitializeComponent();
        }

        private void PrintSpell_Click(object sender, EventArgs e)
        {
            Magic SpellForOutput = new Magic(name: Nametextbox.Text, cost: (int)CostnumericUpDown.Value,
                accuracy: (int)AccuracynumericUpDown.Value, potency: (int)PotencynumericUpDown.Value);

            OutputBox.Text = SpellForOutput.ReturnTextOutput();

        }
    }
}
