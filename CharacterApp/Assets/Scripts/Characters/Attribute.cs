using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Enums;

namespace Character
{

	public class AttributeValue
	{
		public readonly int baseValue;
		public readonly int minValue;
		public readonly int maxValue;

		public AttributeValue (int baseValue, int minValue, int maxValue)
		{
			this.baseValue = baseValue;
			this.minValue = minValue;
			this.maxValue = maxValue;
		}

		public AttributeValue (int baseValue)
		{
			this.baseValue = baseValue;
			this.minValue = 40;
			this.maxValue = 250;
		}

	}


	public class Attribute
	{
		public readonly Enums.Attributes.Attributes attribute;
		public readonly Enums.Races.Races baseRace;
		public readonly AttributeValue value;
		public readonly Dictionary<Enums.Races.Races, int> RacicalModifiers;

		public Attribute (Enums.Attributes.Attributes attr, int value, Enums.Races.Races race,
		                  Dictionary<Enums.Races.Races, int> racicalModifiers)
		{
			this.attribute = attr;
			this.baseRace = Enums.Races.Races.Any;
			this.value = new AttributeValue (value);			
			this.RacicalModifiers = new Dictionary<Enums.Races.Races, int> ();
			if (racicalModifiers != null)
				this.RacicalModifiers = racicalModifiers;
		}

		public Attribute (Enums.Attributes.Attributes attr, int value, Enums.Races.Races race)
		{
			this.attribute = attr;
			this.baseRace = Enums.Races.Races.Any;
			this.value = new AttributeValue (value);			
			this.RacicalModifiers = new Dictionary<Enums.Races.Races, int> ();
		}

		public Attribute (Enums.Attributes.Attributes attr, int value)
		{
			this.attribute = attr;
			this.baseRace = Enums.Races.Races.Any;
			this.value = new AttributeValue (value);
			this.RacicalModifiers = new Dictionary<Enums.Races.Races, int> ();
		}

		public Attribute (Enums.Attributes.Attributes attr, AttributeValue value)
		{
			this.attribute = attr;
			this.baseRace = Enums.Races.Races.Any;
			this.value = value;
			this.RacicalModifiers = new Dictionary<Enums.Races.Races, int> ();
		}

		public Attribute (Enums.Attributes.Attributes attr, AttributeValue value, 
		                  Enums.Races.Races race)
		{
			this.attribute = attr;
			this.baseRace = race;
			this.value = value;
			this.RacicalModifiers = new Dictionary<Enums.Races.Races, int> ();
		}

		public Attribute (Enums.Attributes.Attributes attr, AttributeValue value, 
		                  Enums.Races.Races race, 
		                  Dictionary<Enums.Races.Races, int> racicalModifiers)
		{
			this.attribute = attr;
			this.baseRace = race;
			this.value = value;
			this.RacicalModifiers = racicalModifiers;
		}

		public int currentValue ()
		{
			int raceOffset = 0;
			foreach (KeyValuePair<Enums.Races.Races, int> kvp in RacicalModifiers) {
				if (kvp.Key == this.baseRace) {
					raceOffset += kvp.Value;
				}					
			}
			return this.value.baseValue + raceOffset;
		}
			
	}



}