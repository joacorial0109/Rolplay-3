using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    public class Knife : IAttackItem
    {
        public int AttackValue
        {
            get
            {
                return 10;
            }
        }
    }
}