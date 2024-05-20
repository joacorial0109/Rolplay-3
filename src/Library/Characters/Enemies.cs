namespace RoleplayGame.Characters
{
    /// <summary>
    /// Clase base de los enemigos; hereda de la clase Character. Es una clase abstracta, por lo tanto, no se pueden crear instancias de ella.
    /// Los enemigos tienen bonificaciones en ataque y defensa.
    /// </summary>
    public abstract class Enemy : Character
    {
        /// <summary>
        /// Puntos de victoria del enemigo.
        /// </summary>
        protected int _VP;

        /// <summary>
        /// Método constructor que hereda la implementación de su clase base Character.
        /// </summary>
        /// <param name="name">Nombre del enemigo.</param>
        public Enemy(string name) : base(name) { }

        /// <summary>
        /// Pierde y retorna sus puntos de victoria.
        /// </summary>
        /// <returns>Si la vida es cero, pierde y retorna sus puntos de victoria, sino retorna cero.</returns>
        public int GiveVP()
        {
            if (this.Health == 0)
            {
                int VPtoReturn = _VP;
                _VP = 0;
                return VPtoReturn;
            }
            else
            {
                return 0;
            }
        }
    }
}