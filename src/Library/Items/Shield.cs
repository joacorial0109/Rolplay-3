using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    public class Shield : IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 14;
            }
        }
    }
}