namespace RoleplayGame.Interfaces
{
    /// <summary>
    /// Conjunto de operaciones que deben implementar los ítems ofensivos no mágicos.
    /// </summary>
    public interface IAttackItem : IItem
    {
        /// <summary>
        /// Obtiene el valor que indica el ataque del ítem.
        /// </summary>
        /// <value>Ataque del ítem.</value>
        int AttackValue { get; }
    }
}