using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    public class  Skeletons : IAttackItem, IDefenseItem // se usan como ojbeto ya que son controlados por el nigromanser como su objeto
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