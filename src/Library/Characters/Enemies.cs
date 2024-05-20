namespace RoleplayGame.Characters
{
    /// <summary>
    /// Clase base de los héroes; hereda de la clase Character. Es una clase abstracta, por lo tanto, no se pueden crear instancias de ella.
    /// </summary>
    public abstract class  Enemies : Character
    {
        /// <summary>
        /// Puntos de victoria acumulados.
        /// </summary>
        protected int _acumulatedVP = 0;

        /// <summary>
        /// Obtiene un valor que representa los puntos de victoria del héroe.
        /// </summary>
        /// <value></value>
        public int AcumulatedVP { get { return _acumulatedVP; } }

        /// <summary>
        /// Método constructor que hereda la implementación de su clase base Character.
        /// </summary>
        /// <param name="name">Nombre del héroe.</param>
        public Hero(string name) : base(name) { }

        /// <summary>
        /// Obtiene los puntos de victoria del enemigo.
        /// </summary>
        /// <param name="VPofEnemy"></param>
        public void ObtainVP(int VPofEnemy)
        {
            _acumulatedVP += VPofEnemy;
        }
    }
}