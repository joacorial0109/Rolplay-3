using RoleplayGame.Interfaces;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Los magos tienen poquísima salud, pero pueden usar ítems mágicos muy poderosos. Los magos se hacen más poderosos con el
    /// mana de sus objeos.
    /// </summary>
    public class Wizard : Hero
    {
        /// <summary>
        /// Arma mágica.
        /// </summary>
        public IMagicalAttackItem MagicalAttackItem { get; set; }

        /// <summary>
        /// Armadura mágica.
        /// </summary>
        public IMagicalDefenseItem MagicalDefenseItem { get; set; }

        /// <summary>
        /// Obtiene un valor que indica el ataque total del personaje a través de su arma.
        /// </summary>
        /// <value>Ataque del arma mágica.</value>
        public override int AttackValue
        {
            get
            {
                if (MagicalAttackItem == null) return 0;
                return MagicalAttackItem.AttackValue + MagicalAttackItem.Mana;
            }
        }

        /// <summary>
        /// Obtiene un valor que indica la defensa total del personaje a través de sus ítems defensivos.
        /// </summary>
        /// <value>Defensa de los ítems mágicos.</value>
        public override int DefenseValue
        {
            get
            {
                if (MagicalDefenseItem == null) return 0;
                return MagicalDefenseItem.DefenseValue + MagicalDefenseItem.Mana;
            }
        }

        /// <summary>
        /// Método constructor de magos.
        /// </summary>
        /// <param name="name">Nombre del mago.</param>
        public Wizard(string name) : base(name)
        {
            this.MaxHealth = 15;
            this.Health = _maxHealth;
        }
    }
}