
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

            // Enemigos
            Necromancer necromancer = new Necromancer("Vingilot");
            Racoon racoon = new Racoon("Xenomorfo");
            DarkKnight darkKnight = new DarkKnight("Tomayapo");
            Chucky chucky = new Chucky("Chucky");

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

            // Equipando armas a los enemigos.
            necromancer.skeletons = new Skeletons();
            racoon.Bow = new Bow();
            darkKnight.Sword = new Sword();
            chucky.Knife = new Knife();

            // Equipando armaduras a los enemigos.
            necromancer.skeletons = new Skeletons();
            darkKnight.Shield = new Shield();

            // Preparación del encuentro.
            Encounter encuentro = new Encounter();

            encuentro.AddCharacter(enano);
            encuentro.AddCharacter(mago);
            encuentro.AddCharacter(arquero);
            encuentro.AddCharacter(caballero);

            encuentro.AddCharacter(necromancer);
            encuentro.AddCharacter(racoon);
            encuentro.AddCharacter(darkKnight);
            encuentro.AddCharacter(chucky);

            // Batalla.
            encuentro.DoEncounter();
        }
    }
}