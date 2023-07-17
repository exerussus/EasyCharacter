using System;
using UnityEngine;

namespace EasyCharacter
{
    [Serializable]
    public class Attribute
    {
        [SerializeField] private float _value = 1;
        public int Value
        {
            get => Mathf.FloorToInt(_value);
            set
            {
                if (value > 0) _value = value;
            }
        }

        public Attribute(float value)
        {
            _value = value;
        }

        public static Attribute operator +(Attribute attribute1, Attribute attribute2)
        {
            return new Attribute(attribute1._value + attribute2._value);
        }

        public static Attribute operator *(Attribute attribute1, float multiply)
        {
            return new Attribute(attribute1._value * multiply);
        }
    }
}