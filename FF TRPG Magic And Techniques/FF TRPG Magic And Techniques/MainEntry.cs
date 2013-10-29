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
            SkillEffectTypecomboBox.DataSource = Enum.GetNames(typeof(EffectType));
        }

        private void PrintSpell_Click(object sender, EventArgs e)
        {
            EffectType temp;
            Enum.TryParse<EffectType>(SkillEffectTypecomboBox.SelectedItem.ToString(), out temp);

            

            Magic SpellForOutput = new Magic(name: Nametextbox.Text, cost: (int)CostnumericUpDown.Value,
                accuracy: (int)AccuracynumericUpDown.Value, potency: (int)PotencynumericUpDown.Value,
                spelleffecttype: (EffectType)Enum.Parse(typeof(EffectType),SkillEffectTypecomboBox.SelectedItem.ToString()),
                description: (string)DescriptionrichTextBox.Text
                );
            
            OutputBox.Text = SpellForOutput.ReturnTextOutput();

        }
    }
}
