using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    public class Staff : IMagicalAttackItem, IMagicalDefenseItem
    {
        public int AttackValue
        {
            get
            {
                return 100 + Mana;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 100 + Mana;
            }
        }

        public int Mana
        {
            get
            {
                return 10;
            }
        }
    }
}