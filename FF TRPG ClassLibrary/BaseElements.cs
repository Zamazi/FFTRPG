namespace FF_TRPG_ClassLibrary
{
    ///<summary>
    /// Represents the school/type of magic the object represents
    ///</summary>
    ///<remarks> 
    /// MagicEffectType notes
    /// White: FFXI magic classes Divine & Healing, FFXII White
    /// Black: FFXI magic classes Elemental, and traditional black spells
    /// Green: FFXI Enhancing magic, Green magic
    /// Blue: Enemy Skills magic
    /// Dark: FFXI Enfebeling & Dark magic
    /// Time: FFXII Time Magic
    /// Summon: FF Summon Magic
    ///</remarks>
    public enum MagicSchoolType { White, Black, Green, Blue, Dark, Time, Summon }

    /// <summary>
    /// Core element types
    /// </summary>
    /// <remarks>
    /// Based on FFXI/FFXIV Elements. Void is unelemented.
    /// Light group is Fire, Light, Lightning, and Wind
    /// Darkness group is Water, Ice, Earth, and Dark
    /// </remarks>
    public enum ElementType { Fire, Water, Lightning, Earth, Wind, Ice, Light, Dark, Void }

    public enum EffectType { Heal, Damage, Status };

}
