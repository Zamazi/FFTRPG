namespace FF_TRPG_ClassLibrary
{
    /// <summary>
    /// Base class for Magic and Techniques
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
    /// </remarks>
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
        /// <param name="spellmagiceffecttype">School of magic the spell falls under.</param>
        /// <param name="spellelementtype">Elemental effect of the spell.</param>
        /// <param name="spelleffecttype">Main effect type of the spell.</param>
        public Magic(string name, int cost, string description, int potency, double accuracy,
            MagicSchoolType spellmagiceffecttype, ElementType spellelementtype, EffectType spelleffecttype)
        {
            Name = name;
            Cost = cost;
            Description = description;
            Potency = potency;
            Accuracy = accuracy;
            SpellMagicSchoolType = spellmagiceffecttype;
            SpellElementType = spellelementtype;
        }

        public Magic()
        {
            Name = "";
            Cost = 0;
            Description = "";
            Potency = 0;
            Accuracy = 0;
            SkillEffectType = EffectType.Damage;
            SpellMagicSchoolType = MagicSchoolType.Black;
            SpellElementType = ElementType.Void;
        }

    }
}
