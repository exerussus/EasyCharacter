using System;
using UnityEngine;

namespace EasyCharacter
{
    [Serializable]
    public class Parameter
    {
        [SerializeField] private float _value;

        public float Value
        {
            get => _value;
            set
            {
                if (value < 0) _value = 0;
                else _value = value;
            }
        }

        public Parameter(float value)
        {
            _value = value;
        }
        public static Parameter operator +(Parameter parameter1, Parameter parameter2)
        {
            return new Parameter(parameter1._value + parameter2._value);
        }

        public static Parameter operator *(Parameter parameter1, float multiply)
        {
            return new Parameter(parameter1._value * multiply);
        }
    }
    
}