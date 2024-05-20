using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    public class Armor : IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 25;
            }
        }
    }
}