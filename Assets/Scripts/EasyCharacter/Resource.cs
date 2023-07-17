using System;
using UnityEngine;

namespace EasyCharacter
{
    [Serializable]
    public class Resource
    {
        [SerializeField] private float _currentValue;
        [SerializeField] private float _maxValue;
    
        public float CurrentValue
        {
            get => _currentValue;
            set
            {
                if (value < 0) _currentValue = 0;
                else if (value > _maxValue) _currentValue = _maxValue;
                else _currentValue = value;
            
            }
        }

        public float MaxValue
        {
            get => _maxValue;
            set
            {
                if (value > 0)
                {
                    _maxValue = value;
                    _currentValue = _maxValue;
                }
            }
        }

        public bool IsEmpty => _currentValue == 0;

        public Resource(float maxValue)
        {
            _maxValue = maxValue;
            _currentValue = maxValue;
        }
    }
}