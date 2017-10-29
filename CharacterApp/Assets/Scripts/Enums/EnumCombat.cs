using System;

namespace Enums.Combat
{

	public enum DamageTypesPhysical
	{
		Slash,
		Pierce,
		Bludeon,
	}

	public enum DamageTypesMagicical
	{
		Heat,
		Cold,
		Earth,
		Air,
		Spirit,
		Body,
	}


	public enum CombatTypes
	{
		Unarmed,
		Melee,
		Ranged,
		Magicial
	}

	public enum Unarmed
	{
		Punch,
		Kick,
		Lock,
		Hold,
		Throw
	}

	public enum Situation
	{
		Attacker_On_Higher_Ground,
		Defender_Invisible,
		Defender_Mesmerized,
		Defender_Off_Balance,
		Defender_Paralyzed,
		Defender_Rooted,
		Defender_Sleeping,
		Defender_Slowed,
		Defender_Snared,
		Defender_Stunned,
		Defender_Suprized,

	}

	// roll 1d10 lower the numbers are better
	public enum Initiative
	{
		Defending,
		Hasted,
		Hindered,
		Mesmerized,
		Moving,
		On_Higher_Ground,
		Paralyzed,
		Resting,
		Rooted,
		Slippery_Footing,
		Slowed,
		Snared,
		Stunned,
		Wadding,
		Waiting,
		Weapon_Speed,
		Breath_Weapon,
		CastingSpeed,
		Attacker_Size_Tiny,
		Attacker_Size_Small,
		Attacker_Size_Medium,
		Attacker_Size_Huge,
		Attacker_Size_Gargantuan,
		Magic_Miscellaneous,
		Potion,
		Ring,
		Scroll,
	}



}

