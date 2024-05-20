
using RoleplayGame.Characters;
using RoleplayGame.Items;


namespace Program
{
    public static class Program
    {
        public static void Main()
        {
            // Héroes.
            Dwarf enano = new Dwarf("Gimli");
            Wizard mago = new Wizard("Sauron");
            Archer arquero = new Archer("Robin Hood");
            Knight caballero = new Knight("Merlín");

            
            // Equipando armas a los héroes.
            enano.AttackItem = new Axe();
            SpellsBook libro = new SpellsBook();
            libro.Spells = new Spell[] { new Spell(), new Spell(), new Spell() };
            mago.MagicalAttackItem = libro;
            arquero.Bow = new Bow();
            caballero.Sword = new Sword();

            // Equipando armaduras a los héroes.
            enano.DefenseItem = new Helmet();
            mago.MagicalDefenseItem = new Staff();
            arquero.DefenseItem = new Armor();
            caballero.DefenseItem = new Shield();

           

           
        }
    }
}
