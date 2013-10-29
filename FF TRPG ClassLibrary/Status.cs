namespace FF_TRPG_ClassLibrary
{
    /// <summary><remarks>
    /// All statuses are hardcoded. They can only be changed by altering the code. This class
    /// defines the base class from which all other statuses must be derived.
    /// </remarks>
    public class Status
    {
        public string Name;
        public int Potency;
        public string Description;
    }

    /* TODO: Wiki list of statuses:
    Positive Status Enhancements
     
    Blink/Image - 
    /// Base class for a status.
    /// </summary>
    /// Avoid physical attacks for some turns.
    Bravery - Has a different effect based on the game. In Final Fantasy XII and Final Fantasy XIII it increases physical attack power, while in Final Fantasy Tactics it is a measure for some attacks' power rather than a status effect.
    Clear - Physical attack immunity, but 100% magic hit rate and loss of magical enhancements.
    Faith - Similar to Bravery, only it affects the potency of, and vulnerability to, magic in Final Fantasy Tactics, or magic power Final Fantasy XII and Final Fantasy XIII.
    Float - Target floats, becoming immune to earth damage and damage from damaging floors. In Final Fantasy XII it also prevents traps from triggering.
    Haste - Time taken to execute actions and time until next turn decreases.
    Invincible - Grants immunity to all physical and magical attacks but lasts for a very short period of time.
    Invisible - Attacks connect less frequently, or makes enemies less likely to detect a player by sight, wears off when attacked or attacks opponent.
    Null Magic - Makes afflicted unit immune to magical damage.
    Life 3/Auto-Life/Reraise - Automatic revival when Knocked Out.
    Protect - Increased physical Defense, or half physical damage.
    Reflect - Reflects most magic used against them at caster or to the opposing battle party.
    Runic - Allows the user to absorb some attacks and spells as MP equal to the ability's/spell's MP cost. The user must give up their turn, and if the user absorbs an attack/takes another turn, the status wears off.
    Regen - Restores HP over time.
    Shell - Increased Magic Resistance, or takes half magic damage. In Final Fantasy XII, It also decrease the chance of inflicting bad status.
     *
    Neutral Status Effects
    Berserk - Increased Attack and sometimes Speed, but attacks enemies uncontrollably.
    Control - Target is under the control of the user and is unable to make any actions of their own. This status can only be applied to monsters and never to the party.
    Hide - Target cannot be targeted by anything and is off-screen. Target cannot perform any actions until they return to the battlefield.
     
    Negative Status Ailments
    Blind/Darkness - Reduces Accuracy, causing the sufferer's physical attacks to miss most of the time. This was ineffective in Final Fantasy VI due to a bug.
    Charm - Victim attacks for the opposing team.
    HP Critical - Activates when a units' HP falls below a certain level (usually 25%), this status can trigger some positive status effects depending on the character's equipment.
    Condemned/Doom - KO'd after certain amount of time, can be "cured" by ending battle before time runs out.
    Confuse - Attacks both enemies and allies indiscriminately and uncontrollably.
    Curse - Effects vary depending on the game, but usually causes a drop in many stats and/or disallows the victim from performing Limit Breaks.
    Disease - Impairs the recuperation of HP and MP, in various ways.
    Disable - Unit cannot attack, but can still move.
    Eject - Target is removed from battle and is flagged as dead in most cases.
    Freeze - Immobilizes the target similar to Stop, however fire element attacks heal it and physical attacks will often kill the target instantly.
    Gradual Petrify/Slow Numb - Similar to Doom, victim turns to Stone after a certain amount of time.
    Immobilize - Unit cannot move, but can still attack. Called "Bind" in Final Fantasy XIV.
    KO - HP is zero and is unable to take turn. Some skills inflict Instant Death, which KO's a unit regardless of remaining HP.
    Oil - Unit takes extra damage from fire-based spells.
    Petrify/Stone - Encases in stone, unable to take turn or damaged by attacks. Also, if not cured by end of battle in some games, the afflicted character does not receive EXP/AP.
    Poison - Takes damage every turn, or over time.
    Reverse - Switches the effects of healing into damage and vice versa.
    Seizure/Sap - Takes a small amount of damage constantly.
    Silence - Unable to cast magic or sing.
    Size/Mini - Shrinks, Defense and/or attack strength greatly decreased.
    Sleep - Unable to take turn until woken up by attack or on their own.
    Slow - Time taken to execute actions and time until next turn is increased.
    Stop - Unable to move or attack until they re-enter time.
    Toad - Becomes a frog, attack strength is decreased and can only input the Attack or Frog command.
    Venom - A stronger or weaker variant of Poison, depending on the game.
    Zombie - Victim becomes Undead, taking damage from healing spells/items. Revivification magic and items KO afflicted units.
     */

    /* TODO: Possible additional statuses
     * List of game-specific status effects
     * 
Positive Status Enhancements
     * 
Aquaveil - In Final Fantasy XI, it decreases the likelihood of a spell being interrupted if the caster is hit.
Aura - In Final Fantasy VIII, the afflicted character is able to use Limit Breaks regardless of their current HP.
Bubble - In Final Fantasy XII, it doubles Max HP.
Charging/Focus - In Final Fantasy IV, dictates the amount of time before an attack used from Focus or Deadly is used. In the DS version, increases the next physical attack and is stackable up to 3 times.
Comradery - In Final Fantasy XIV, maximum HP and MP are increased by 5%, and physical and magic accuracy are enhanced. Granted when in a light party (4 to 7 members).
Costume - Changes the appearance of the player in Final Fantasy XI.
Dance - In Final Fantasy VI and Final Fantasy X-2, a character automatically uses a random ability from the current dance set every turn, and cannot be controlled. The status will not wear off unless another character Dances, the status is exchanged with Rippler, or the character is KO'ed. In Final Fantasy X-2, the effect of the Dance will remain as long as the user is dancing.
Decoy - In Final Fantasy XIV, this is a Archer ability that allows the target to avoid a single ranged or magic attack. A trait learned later makes it also avoid melee attacks.
Dedication - In Final Fantasy XI, it increases experience gained for a set period of time.
Deodorize - In Final Fantasy XI, this status prevents a single target within a party from being pursued by scent or detected by low HP status.
Dirge - In Final Fantasy XI, this is a song that grants a reduction of enmity to on targeted party member.
Interceptor Guard - In Final Fantasy VI, a status exclusive to Shadow. Interceptor randomly blocks physical attacks (even attacks from behind, which are normally unblockable) for the character, occasionally counterattacking for non-elemental damage with Takedown or Wild Fang.
Double - In Final Fantasy VIII, it enables units to cast any two magic spells in a single turn. This status effect, under the name Doublecast, is also present a free Special ability allowing to cast two Black Magic spells in a row.
Enspell - In Final Fantasy XI, grants additional damage of an elemental type determined by what type of spell it is (ie: Enfire grants additional fire damage).
False Image - In Final Fantasy V, a status that is granted only to clones of Wendigo and Pantera, making the user immune to physical attacks.
Flee - In Final Fantasy XI, flee is considered a status effect, increasing movement speed.
Jump - In Final Fantasy IV, it is a hidden status given when the Jump command is issued. The higher the Agility of the user, the longer this status lasts. The user will be unable to be targeted until they land, and all timers on statuses will halt.
Lucky Girl - In Final Fantasy VII, all hits are Critical Hits.
Nul— - In Final Fantasy X, NulBlaze, NulFrost, NulShock, and NulTide grants immunity to one Fire, Ice, Lightning, and Water attack respectively.
Pax - In Final Fantasy XI, it grants a reduction in enmity gained for a short period of time.
Performing - In Final Fantasy Tactics, the status is given when a unit is using the Bardsong command or the Dance command. The unit will continuously sing/dance the chosen song/dance endlessly until the player picks another ability which will end the current song/dance.
Phalanx - In Final Fantasy XI, grants a certain amount of damage resistance.
Potency - In Final Fantasy XI, this status increases the rate of critical hits.
Rage - In Final Fantasy VI, the status given through the Rage command of Gau. Character will act automatically each turn, with a 3/4 chance of using a physical and a 1/4 chance of using a special attack. Rage characters will also gain special properties of the chosen monster, which includes elemental defenses, resistances, and weaknesses, status resistances and immunities, and several other miscellaneous things. Can only be removed through Rippler spell or getting KO.
Regain - In Final Fantasy XI, this status increases TP by 3TP per tick for 3 minutes.
Reprisal - In Final Fantasy XI, this status increases the likelihood a Paladin will block with his shield and reflects 1/3rd of the damage taken from blocked hits back onto the attacker.
Singing - In Final Fantasy V, the status is given when using the Sing command, and renders the user unable to act until finished singing. While in this status, the party's appropriate stat will increase during the duration. This status is only given when using Sinewy Etude, Mana's Paean, Swift Song, or Hero's Rime.
Sirvente - In Final Fantasy XI, this status is granted by a bard song and decreases the rate of enmity loss functionally helping one party member maintain much greater hate.
Stoneskin - In Final Fantasy XI and Final Fantasy XIV, it grants a certain amount of protection against physical damage.
Sneak - In Final Fantasy XI, this status prevents a single target within a party from being detected by sound.
Synthesis Image Support - In Final Fantasy XI, this grants a bonus towards people performing item synthesis.
Strength in Numbers - In Final Fantasy XIV, maximum HP and MP are increased by 10%, and physical and magic accuracy are enhanced. Granted when in a full party (8 members).
Trance - In Final Fantasy VI, given through the Trance ability by Terra Branford. Adds a 100% bonus to physical and magical damage except defense-ignoring attacks, and halves magic damage taken except defense-ignoring attacks. Expires when the ATB gauge for Trance runs out or at the end of battle.
Triple - In Final Fantasy VIII, it enables units to cast any three magic spells in a single turn.
Well Fed - In Final Fantasy XIV, this status is set when a player eats a food item, and indicates he's under the effect of stats benefits and exp bonuses provided by the food.
     
Neutral Status Effects
All Lucky 7s - In Final Fantasy VII, it gives 64 consecutive hits for 7777 and takes off 7777 for every hit at the same HP thereafter. However, after winning a battle, any character with 7777 HP will end up with only 1 HP remaining in the menu screen.
Atheist - In Final Fantasy Tactics, also known as Innocence, decreases a character's Faith to 0, meaning that any spells they cast deal 0 damage or have a 0% hit rate, but they also will not receive any magic damage.
Chant - In Final Fantasy VI, this is the state Relm (or Gogo) enters when Controlling an enemy.
Fury - In Final Fantasy VII, the afflicted character's Limit Break gauge fills quicker but their physical attacks are more likely to miss.
Magitek - In Final Fantasy VI, this status is set when the party is riding Imperial Magitek Armor. The first command slot (Attack and Gau's Rage) is replaced with the Magitek command. All other commands except Magic, Dualcast, Items, and Mimic are disabled.
Sadness - Also in Final Fantasy VII, the afflicted character receives less physical damage, but their Limit gauge fills slower.
     
Negative Status Ailments
Addle - In Final Fantasy Tactics Advance, a character suffering from Addle cannot remember any ability mastered. A similar status effect in Final Fantasy XI and Final Fantasy XIV, Amnesia makes characters forget their job abilities.
Brink of Death - In Final Fantasy XIV, a character suffering from Brink of Death has 50% reduction in max HP, MP, attack, magic potency, defense and magic evasion for 3 minutes. Inflicted only by being revived by a non Conjurer / White Mage raise spell after being KO'd under the Weakness stat.
Chicken - In Final Fantasy Tactics, a character will turn into a chicken and only flee to a corner of the battlefield.
Exposed - In Final Fantasy XIV, target takes increased damage when hit by a specific direction (ex: Exposed Rear grants bonus damage to back attacks).
Gear Damage / Heavy Gear Damage - In Final Fantasy XIV, indicates one piece of equipment is damaged and is offering diminished stats.
Heavy - In Final Fantasy XIV, a character inflicted with heavy has it's movement speed reduced.
Heat - In Final Fantasy IX, a character inflicted with Heat will instantly KO if any action is taken. A similar effect is also given when Edgar uses his Air Anchor tool in Final Fantasy VI.
Imp - In Final Fantasy VI, a character will turn into an imp and have their offensive and defensive power drastically reduced, as well as unable to use any magic abilities other than Imp.
Imperil - Lowers elemental resistances in Final Fantasy XIII. In Final Fantasy XIV, Imperil reduces all character stats.
Imprisoned - In Final Fantasy VII, the victim is flagged as dead and is unable to fight until released.
Incapacitation - In Final Fantasy XIV, one or more of the target's body parts in broken. Changes monsters loot tables, stats and abilities.
Itchy - In Final Fantasy X-2, a character inflicted with Itchy is only capable of changing Dresspheres, and is unable to take any other action in battle. However, the status can be easily removed by sphere-changing into another Dressphere.
Lamed - In Final Fantasy XIV, lamed is a stat effect exclusive to mounts; mount movement speed is reduced.
Lure - In Final Fantasy XII, lure is a status effect that causes all enemies to target the character inflicted with the status.
Magnetize - In Final Fantasy IV, prevents the party from using metallic weapons by paralyzing them for the entire battle, and if all characters are in this status, the game is over.
Old - In Final Fantasy V, a character's hair will turn white, and their stats will drop turn after turn during battle.
Pacification - In Final Fantasy XIV, prevents the target from using weaponskills.
Pain - Disables the use of physical attacks in Final Fantasy XIII.
Pig - In Final Fantasy IV, a victim inflicted with Pig becomes a pig, and his or her offensive and defensive efficiency are greatly reduced. Additionally, characters normally able to use magic have their selection of spells greatly reduced.
Plague - In Final Fantasy XI, gradually decreases both MP and TP over time.
Terror - In Final Fantasy XI, temporarily prevents the target from acting and freezes their body.
TP Bleed - In Final Fantasy XIV, character's TP is constantly decreased.
Traitor - In Final Fantasy Tactics, also known as Invitation, makes character defect to the opponent's side.
Trouble - In Final Fantasy IX, when a character or enemy in Trouble status takes physical damage, half of that damage is also dealt to their allies.
Vampire - In Final Fantasy Tactics, also known as Blood Suck, makes character uncontrollable and only use Drain HP from other characters.
Virus - In Final Fantasy IX, a character inflicted with Virus does not receive Experience Points and Ability Points at the end of battle. This was also featured in Final Fantasy X-2 as the Pointless status ailment.
Vit 0 - In Final Fantasy VIII, a character inflicted with Vit 0 has no defense against physical attacks. It also appears to affect every enemy. The spell Meltdown, Quistis's Acid Limit Break and the GF Doomtrain are the only ways that inflict Vit 0. This status is also featured in Final Fantasy X, under the name Armor Break.
Weakened - In Final Fantasy XI, a character receives Weakened status after being revived. Their health and magic is reduced by 75% for five minutes. In Final Fantasy XIV, a weakened character loses 25% of their max HP and MP for 3 minutes.
Wound - In Final Fantasy XIII-2, it is hidden status effect which reduces character's maximum HP.
X-Zone - In Final Fantasy XII, the Demon Wall may cast Telega, causing one or more characters to be "cast into the void". They are no longer visible or controllable, and the character gets the status X-Zone. This effect can't be removed by any item or spell, and can only be removed by leaving the area.
     */
}