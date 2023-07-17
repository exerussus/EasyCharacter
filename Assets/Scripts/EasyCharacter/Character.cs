using System;
using UnityEngine;

namespace EasyCharacter
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private int _level = 1;
        [SerializeField] private Attributes _attributes;
        [SerializeField] private CharacterClass _characterClass;
        [SerializeField] private Parameters _parameters;
        [SerializeField] private Resources _resources;

        public int Level => _level;
        public Attributes Attributes => _attributes;
        public Parameters Parameters => _parameters;
        public Resources Resources => _resources;


        public Action OnDead;
        public Action OnTakeDamage;
        public Action OnHeal;
        public Action OnLevelUp;
        public Action OnManaChange;
        public Action OnStaminaChange;
    
    
        private void Start()
        {
            if (_level <= 0) _level = 1;
            RecalculateCharactersFields();
            _resources = new Resources(_parameters.Health, _parameters.Stamina, _parameters.Mana);
        }

        private void SetAttributes()
        {
            _attributes = _characterClass.StartedAttributes + _characterClass.AttributesPerLevel * (_level - 1);
        }
    
        private void SetParameters()
        {
            var health = _attributes.Constitution * 2;
            var stamina = _attributes.Agility * 2 + _attributes.Constitution;
            var mana = _attributes.Wisdom * 3 + _attributes.Intellect * 2;
            _parameters = new Parameters(health.Value, stamina.Value, mana.Value);
        }

        private void RecalculateCharactersFields()
        {
            SetAttributes();
            SetParameters();
        }

        public void TakeDamage(float value)
        {
            if (value <= 0) return;
            _resources.Health.CurrentValue -= value;
            OnTakeDamage?.Invoke();
        }

        public void Heal(float value)
        {
            if (value <= 0) return;
            _resources.Health.CurrentValue += value;
            OnHeal?.Invoke();
        }
    
        public void LevelUp()
        {
            _level += 1;
            RecalculateCharactersFields();
            OnLevelUp?.Invoke();
        }

        public void RestoreStamina(float value)
        {
            if (value <= 0) return;
            _resources.Stamina.CurrentValue += value;
            OnStaminaChange?.Invoke();
        }

        public void DrainStamina(float value)
        {
            if (value <= 0) return;
            _resources.Stamina.CurrentValue -= value;
            OnStaminaChange?.Invoke();
        }

        public void RestoreMana(float value)
        {
            if (value <= 0) return;
            _resources.Mana.CurrentValue += value;
            OnManaChange?.Invoke();
        }

        public void DrainMana(float value)
        {
            if (value <= 0) return;
            _resources.Mana.CurrentValue -= value;
            OnManaChange?.Invoke();
        }
    }
}
