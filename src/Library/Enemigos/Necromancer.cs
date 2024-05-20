using RoleplayGame.Interfaces;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{

    public class Necromancer : Enemy
{   
    /// <summary>
        /// Esqueletos del personaje.
        /// </summary>
    public Skeletons skeletons { get; set; }

        /// <summary>  
        /// Obtiene un valor que indica el ataque total del personaje a través de su arma(esqueletos) y/o bonificación.
        /// </summary>
        /// <value>Ataque del personaje.</value>
        public override int AttackValue
        {
            get
            {
                if (skeletons == null) return 0 + 15;
                return skeletons.AttackValue + 15;
            }
        }
        /// <summary>
        /// Obtiene un valor que indica la defensa total del personaje a través de su ítem defensivo y/o bonificación.
        /// </summary>
        /// <value>Defensa del personaje.</value>

        public override int DefenseValue
        {
            get
            {
                if (skeletons == null) return 0 + 25;
                return skeletons.DefenseValue + 25;
            }
            
        }

    

        public Necromancer (string name) : base(name)
        {
            this.MaxHealth = 100;
            this.Health = _maxHealth;
            this._VP = 5;
        }
    }
}