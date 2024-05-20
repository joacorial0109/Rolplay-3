using RoleplayGame.Interfaces;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Los arqueros tienen mucha vida, pero se ven limitados a sólo usar un arco.
    /// </summary>
    public class Archer : Hero
    {
        /// <summary>
        /// Arco del personaje.
        /// </summary>
        public Bow Bow { get; set; }

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
                if (Bow == null) return 0;
                return Bow.AttackValue;
            }
        }

        /// <summary>
        /// Obtiene un valor que indica la defensa total del personaje a través de su ítem defensivo.
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
        /// Método constructor de arqueros.
        /// </summary>
        /// <param name="name">Nombre del arquero.</param>
        public Archer(string name) : base(name)
        {
            this.MaxHealth = 500;
            this.Health = _maxHealth;
        }
    }
}