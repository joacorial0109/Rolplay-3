namespace RoleplayGame.Interfaces
{
    /// <summary>
    /// Conjunto de operaciones que deben implementar los ítems defensivos no mágicos.
    /// </summary>
    public interface IDefenseItem : IItem
    {
        // Propiedades.
        int DefenseValue { get; }
    }
}