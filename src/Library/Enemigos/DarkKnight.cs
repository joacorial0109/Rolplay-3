using RoleplayGame.Interfaces;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// DarkKnight es un enemigo que puede atacar con una espada.
    /// </summary>
    public class DarkKnight : Enemy
    {
        /// <summary>
        /// Espada del personaje.
        /// </summary>
        public Sword Sword { get; set; }

        /// <summary>  
        /// Obtiene un valor que indica el ataque total del personaje a través de su arma y/o bonificación.
        /// </summary>
        /// <value>Ataque del personaje.</value>
        public Shield Shield { get; set; }

        /// <summary>
        /// Obtiene un valor que indica el ataque total del personaje a través de su arma y/o bonificación.
        /// </summary>
        /// <value>Ataque del arma.</value>
        public override int AttackValue
        {
            get
            {
                if (Sword == null) return 0 + 5;
                return Sword.AttackValue + 5;
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
                return 5;
            }
        }

        /// <summary>
        /// Método constructor de DarkKnight´s.
        /// </summary>
        /// <param name="name">Nombre de DarkKnight.</param>
        /// 
        public DarkKnight(string name) : base(name)
        {
            this.MaxHealth = 100;
            this.Health = _maxHealth;
            this._VP = 20;
        }
    }
}