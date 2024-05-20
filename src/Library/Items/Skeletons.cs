using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    public class  Skeletons : IAttackItem, IDefenseItem
    {
        public int AttackValue
        {
            get
            {
                return 150 ;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 100;
            }
        }

    }
}