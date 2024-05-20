using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    public class Helmet : IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 18;
            }
        }
    }
}