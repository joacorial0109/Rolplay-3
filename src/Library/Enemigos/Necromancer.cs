using RoleplayGame.Interfaces;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{

    public class Necromancer : Enemy
{
    public Skeletons skeletons { get; set; }

        /// <summary>  
        /// Obtiene un valor que indica el ataque total del personaje a través de su arma y/o bonificación.
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

        public override int DefenseValue
        {
            get
            {
                return 25;
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