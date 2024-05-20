using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    public class Sword : IAttackItem
    {
        public int AttackValue
        {
            get
            {
                return 20;
            }
        }
    }
}