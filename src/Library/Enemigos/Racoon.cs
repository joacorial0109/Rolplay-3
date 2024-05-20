using RoleplayGame.Interfaces;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Racoon es un enemigo que puede atacar con una espada.
    /// </summary>
    public class Racoon : Enemy
    {
        /// <summary>
        /// Espada del personaje.
        /// </summary>
        public Bow Bow { get; set; }

        /// <summary>  
        /// Obtiene un valor que indica el ataque total del personaje a través de su arma y/o bonificación.
        /// </summary>
        /// <value>Ataque del personaje.</value>
        public override int AttackValue
        {
            get
            {
                if (Bow == null) return 0 + 5;
                return Bow.AttackValue + 5;
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
        public Racoon(string name) : base(name)
        {
            this.MaxHealth = 145;
            this.Health = _maxHealth;
            this._VP = 15;
        }
    }
}