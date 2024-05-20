using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    public class Bow : IAttackItem
    {
        public int AttackValue
        {
            get
            {
                return 15;
            }
        }
    }
}