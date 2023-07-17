using System;
using UnityEngine;

namespace EasyCharacter
{
    [Serializable]
    public class Parameters
    {
    
        [SerializeField] private Parameter _health;
        [SerializeField] private Parameter _stamina;
        [SerializeField] private Parameter _mana;

        public float Health => _health.Value;
        public float Stamina => _stamina.Value;
        public float Mana => _mana.Value;

        public Parameters(float health, float stamina, float mana)
        {
            _health = new Parameter(health);
            _stamina = new Parameter(stamina);
            _mana = new Parameter(mana);
        }
    }
}

