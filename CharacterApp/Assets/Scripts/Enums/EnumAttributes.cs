using System;
using System.Xml.Schema;

namespace Enums.Attributes
{
	public enum Attributes
	{
		Strength,
		Dexterity,
		Constitution,
		Intelligence,
		Wisdom,
		Charisma,
		BaseMovement
	}

	public enum Encumerance
	{
		Unencumbered,
		Light,
		Moderate,
		Heavy,
		Severe
	}

	public enum Stealth
	{
		PickPockets,
		OpenLocks,
		FindTraps,
		RemoveTraps,
		MoveSlightly,
		Hide,
		DetectNoise,
		ClimbWalls,
		ReadLanguages
	}

	public enum ModiferStength
	{
		Hit_Probability,
		DamageAdjustment,
		WeightAllowance,
		Press,
		OpenDoors,
		Bend_Bars,
		Lift_Gates
	}

	public enum ModifierConstitution
	{
		HitPoints,
		Shock,
		ResurrectionSurvival,
		PosionSave,
		Regeneration
	}

	public enum ModifierIntelligence
	{
		LanguageCount,
		SpellLevel,
		ChanceLearnSpell,
		MaxSpells,
		Immunity,
	}

	public enum ModifierDexterity
	{
		ReactionAdjustment,
		RangedAttackAdjustment,
		DefenceAdjustment,
	}

	public enum ModifierWisom
	{
		MagicalDefenceAdjustment,
		BonusSpells,
		ChanceOfFailure,
		Immunity,
	}

	public enum ModifierCharisma
	{
		MaximunHenchmen,
		LoyalityBase,
		ReactionAdjustment
	}


}

