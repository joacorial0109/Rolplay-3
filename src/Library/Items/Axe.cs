using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    public class Axe : IAttackItem
    {
        public int AttackValue
        {
            get
            {
                return 25;
            }
        }
    }
}