using System;
using UnityEngine;

namespace EasyCharacter
{
    [Serializable]
    public class Attributes 
    {
        [SerializeField] private Attribute strength;
        [SerializeField] private Attribute agility;
        [SerializeField] private Attribute constitution;
        [SerializeField] private Attribute intellect;
        [SerializeField] private Attribute wisdom;
        [SerializeField] private Attribute charisma;

        public Attribute Strength => strength;
        public Attribute Agility => agility;
        public Attribute Constitution => constitution;
        public Attribute Intellect => intellect;
        public Attribute Wisdom => wisdom;
        public Attribute Charisma => charisma;
        
        public Attributes(float strength, float agility, float constitution, float intellect, float wisdom, float charisma)
        {
            this.strength = new Attribute(strength);
            this.agility = new Attribute(agility);
            this.constitution = new Attribute(constitution);
            this.intellect = new Attribute(intellect);
            this.wisdom = new Attribute(wisdom);
            this.charisma = new Attribute(charisma);
        }
        public static Attributes operator +(Attributes attributes1, Attributes attributes2)
        {
            Attribute newStrength = new Attribute(attributes1.strength.Value + attributes2.strength.Value);
            Attribute newAgility = new Attribute(attributes1.agility.Value + attributes2.agility.Value);
            Attribute newConstitution = new Attribute(attributes1.constitution.Value + attributes2.constitution.Value);
            Attribute newIntellect = new Attribute(attributes1.intellect.Value + attributes2.intellect.Value);
            Attribute newWisdom = new Attribute(attributes1.wisdom.Value + attributes2.wisdom.Value);
            Attribute newCharisma = new Attribute(attributes1.charisma.Value + attributes2.charisma.Value);

            return new Attributes(newStrength.Value, newAgility.Value, newConstitution.Value, newIntellect.Value, newWisdom.Value, newCharisma.Value);
        }
        public static Attributes operator *(Attributes a, float multiply)
        {
            Attribute newStrength = new Attribute(a.strength.Value * multiply);
            Attribute newAgility = new Attribute(a.agility.Value * multiply);
            Attribute newConstitution = new Attribute(a.constitution.Value * multiply);
            Attribute newIntellect = new Attribute(a.intellect.Value * multiply);
            Attribute newWisdom = new Attribute(a.wisdom.Value * multiply);
            Attribute newCharisma = new Attribute(a.charisma.Value * multiply);

            return new Attributes(newStrength.Value, newAgility.Value, newConstitution.Value, newIntellect.Value, newWisdom.Value, newCharisma.Value);
        }
    }
}
