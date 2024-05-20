using System;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Clase base de los personajes. Es una clase abstracta, por lo tanto, no se pueden crear instancias de ella.
    /// </summary>
    public abstract class Character
    {
        /// <summary>
        /// Nombre del personaje.
        /// </summary>
        protected string _name;

        /// <summary>
        /// Vida del personaje.
        /// </summary>
        protected int _health;

        /// <summary>
        /// Capacidad máxima de la vida de un personaje.
        /// </summary>
        protected int _maxHealth = 0;

        /// <summary>
        /// Modifica el valor de la capacidad máxima de la vida de un personaje.
        /// Sólo se modifica una vez en el método constructor de cada clase específica de personaje.
        /// </summary>
        /// <value>Capacidad máxima de la vida de un personaje.</value>
        protected int MaxHealth
        {
            set { if (_maxHealth == 0) _maxHealth = value; }
        }

        /// <summary>
        /// Obtiene el nombre del personaje.
        /// </summary>
        /// <value>Nombre del personaje.</value>
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {

                    Console.WriteLine("Invalid name of character.");
                }
                else
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Obtiene un valor que indica el ataque total del personaje a través de su arma.
        /// </summary>
        /// <value>Ataque del arma.</value>
        public abstract int AttackValue { get; }

        /// <summary>
        /// Obtiene un valor que indica la defensa total del personaje a través de su ítems defensivos.
        /// </summary>
        /// <value>Defensa de las armaduras.</value>
        public abstract int DefenseValue { get; }

        /// <summary>
        /// Obtiene un valor que indica la vida del personaje.
        /// </summary>
        /// <value>Vida del personaje.</value>
        public int Health
        {
            get
            {
                return this._health;
            }
            protected set
            {
                this._health = value < 0 ? 0 : value;
            }
        }

        /// <summary>
        /// Implementación común en el método constructor de todos los personajes, tanto enemigos como héroes.
        /// </summary>
        /// <param name="name">Nombre del personaje.</param>
        public Character(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Modifica el valor de vida del personaje según el ataque que recibe.
        /// </summary>
        /// <param name="power">Ataque de otro personaje.</param>
        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        /// <summary>
        /// Cura al personaje.
        /// </summary>
        public void Cure()
        {
            this.Health = this._maxHealth;
        }
    }
}