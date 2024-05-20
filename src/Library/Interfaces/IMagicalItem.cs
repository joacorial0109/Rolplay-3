namespace RoleplayGame.Interfaces
{
    /// <summary>
    /// Conjunto de operaciones que deben implementar los ítems mágicos.
    /// </summary>
    public interface IMagicalItem
    {
        /// <summary>
        /// Obtiene el valor que indica el mana (puntaje extra en ataque y defensa para los ítems mágicos).
        /// </summary>
        /// <value>Bonificación.</value>
        int Mana { get; }
    }
}