
using UnityEngine;

namespace EasyCharacter
{
    [CreateAssetMenu(menuName = "Character/Class", fileName = "CharacterClass")]
    public class CharacterClass : ScriptableObject
    {
        [SerializeField] private Attributes _startedAttributes;
        [SerializeField] private Attributes _attributesPerLevel;
        public Attributes StartedAttributes => _startedAttributes;
        public Attributes AttributesPerLevel => _attributesPerLevel;
    }
}
