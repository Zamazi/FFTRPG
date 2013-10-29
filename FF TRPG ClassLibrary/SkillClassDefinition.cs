namespace FF_TRPG_ClassLibrary
{
    /// <summary>
    /// Base class for Magic and Techniques.
    /// This class should implement interfaces that would allow it to be bestowed on a monster or character.
    /// </summary>
    public class Skill
    {
        public string Name;
        public int Cost;
        public string Description;
        public int Potency;
        public double Accuracy;
        public EffectType SkillEffectType;
    }

    /// <summary>
    /// Base class for spells
    /// </summary>
    /// <remarks>
    /// This serves as the base for all spells. 
    /// The primary effect of any spell is considered to be damage. 
    /// 
    /// </remarks>
    /// 
    public class Magic : Skill
    {
        public MagicSchoolType SpellMagicSchoolType;
        public ElementType SpellElementType;

        /// <summary>
        /// Primary constructor for Magic class. For single-effect spells.
        /// </summary>
        /// <param name="name">Name of the Spell.</param>
        /// <param name="cost">Cost of the Spell</param>
        /// <param name="description">Detailed Description of the Spell. Should not include Flavor Text.</param>
        /// <param name="potency">Numerical modifier for primary effect of spell.</param>
        /// <param name="accuracy">Base accuracy of the spell.</param>
        /// <param name="spellmagicschooltype">School of magic the spell falls under.</param>
        /// <param name="spellelementtype">Elemental effect of the spell.</param>
        /// <param name="spelleffecttype">Main effect type of the spell.</param>
        public Magic(string name = "", int cost = 0, string description = "", int potency = 0, double accuracy = 0,
            MagicSchoolType spellmagicschooltype = MagicSchoolType.Black, ElementType spellelementtype = ElementType.Light,
            EffectType spelleffecttype = EffectType.Damage)
        {
            Name = name;
            Cost = cost;
            Description = description;
            Potency = potency;
            Accuracy = accuracy;
            SpellMagicSchoolType = spellmagicschooltype;
            SpellElementType = spellelementtype;
            SkillEffectType = spelleffecttype;
        }

        /// <summary>
        /// Converts the spell in question to a string
        /// </summary>
        /// <returns>Formatted with new lines and colons. </returns>
        public string ReturnTextOutput()
        {
            string x = SpellMagicSchoolType.ToString();

            return "Name: " + Name.ToString() + "\n" + "Cost: " + Cost.ToString() + " mp\n"
                + "Description: " + Description.ToString() + "\n" + "Potency: " + Potency.ToString() + "\n"
                + "Accuracy: " + Accuracy.ToString() + "\n" + "Magic School: " + SpellMagicSchoolType.ToString() + "\n"
                + "Element: " + SpellElementType.ToString() + "\n" + "Effect Type: " + SkillEffectType.ToString() + "\n";
        }

    }
}
