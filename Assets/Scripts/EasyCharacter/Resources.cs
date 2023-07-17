using System;

namespace EasyCharacter
{
    [Serializable]
    public class Resources
    {
        public Resource Health;
        public Resource Stamina;
        public Resource Mana;

        public Resources(float health, float stamina, float mana)
        {
            Health = new Resource(health);
            Stamina = new Resource(stamina);
            Mana = new Resource(mana);
        }
    }
}
