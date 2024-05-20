using RoleplayGame.Interfaces;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Los caballeros sólo pueden atacar con una espada, pero pueden usar un escudo y cualquier armadura no mágica.
    /// </summary>
    public class Knight : Hero
    {
        /// <summary>
        /// Espada del personaje.
        /// </summary>
        public Sword Sword { get; set; }

        /// <summary>
        /// Escudo del personaje.
        /// </summary>
        public Shield Shield { get; set; }

        /// <summary>
        /// Armadura del personaje.
        /// </summary>
        /// <value>Cualquier objeto defensivo no mágico.</value>
        public IDefenseItem DefenseItem { get; set; }

        /// <summary>
        /// Obtiene un valor que indica el ataque total del personaje a través de su arma.
        /// </summary>
        /// <value>Ataque de la espada.</value>
        public override int AttackValue
        {
            get
            {
                if (Sword == null) return 0;
                return Sword.AttackValue;
            }
        }

        /// <summary>
        /// Obtiene un valor que indica la defensa total del personaje a través de sus ítems defensivos.
        /// </summary>
        /// <value>Defensa de las armaduras.</value>
        public override int DefenseValue
        {
            get
            {
                if (DefenseItem == null && Shield == null)
                {
                    return 0;
                }
                else if (DefenseItem == null)
                {
                    return Shield.DefenseValue;
                }
                else if (Shield == null)
                {
                    return DefenseItem.DefenseValue;
                }
                return DefenseItem.DefenseValue + Shield.DefenseValue;
            }
        }

        /// <summary>
        /// Método constructor de caballeros.
        /// </summary>
        /// <param name="name">Nombre del caballero.</param>
        public Knight(string name) : base(name)
        {
            this.MaxHealth = 250;
            this.Health = _maxHealth;
        }
    }
}