namespace RoleplayGame.Interfaces
{
    /// <summary>
    /// Conjunto de operaciones que deben implementar los ítems defensivos mágicos.
    /// </summary>
    public interface IMagicalDefenseItem : IMagicalItem
    {
        /// <summary>
        /// Obtiene el valor que indica la defensa del ítem.
        /// </summary>
        /// <value>Defensa del ítem.</value>
        int DefenseValue { get; }
    }
}