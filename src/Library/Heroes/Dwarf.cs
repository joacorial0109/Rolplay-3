using RoleplayGame.Interfaces;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Los enanos son expertos en armas y armaduras; pueden equiparse cualquier arma o armadura no mágica.
    /// </summary>
    public class Dwarf : Hero
    {
        /// <summary>
        /// Arma del personaje.
        /// </summary>
        /// <value>Cualquier objeto ofensivo no mágico.</value>
        public IAttackItem AttackItem { get; set; }

        /// <summary>
        /// Armadura del personaje.
        /// </summary>
        /// <value>Cualquier objeto defensivo no mágico.</value>
        public IDefenseItem DefenseItem { get; set; }

        /// <summary>
        /// Obtiene un valor que indica el ataque total del personaje a través de su arma.
        /// </summary>
        /// <value>Ataque del arma.</value>
        public override int AttackValue
        {
            get
            {
                if (AttackItem == null) return 0;
                return AttackItem.AttackValue;
            }
        }

        /// <summary>
        /// Obtiene un valor que indica la defensa total del personaje a través de su ítems defensivos.
        /// </summary>
        /// <value>Defensa de la armadura.</value>
        public override int DefenseValue
        {
            get
            {
                if (DefenseItem == null) return 0;
                return DefenseItem.DefenseValue;
            }
        }

        /// <summary>
        /// Método constructor de enanos.
        /// </summary>
        /// <param name="name">Nombre del enano.</param>
        public Dwarf(string name) : base(name)
        {
            this.MaxHealth = 300;
            this.Health = _maxHealth;
        }
    }
}