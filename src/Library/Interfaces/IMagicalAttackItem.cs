namespace RoleplayGame.Interfaces
{
    /// <summary>
    /// Conjunto de operaciones que deben implementar los ítems ofensivos mágicos.
    /// </summary>
    public interface IMagicalAttackItem : IMagicalItem
    {
        /// <summary>
        /// Obtiene el valor que indica el ataque del ítem.
        /// </summary>
        /// <value>Ataque del ítem.</value>
        int AttackValue { get; }
    }
}