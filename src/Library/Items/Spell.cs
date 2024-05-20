using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    /// <summary>
    /// Los hechizos nuevos son más poderosos que sus antecesores.
    /// </summary>
    public class Spell : IMagicalAttackItem, IMagicalDefenseItem
    {
        private readonly int _attackValue = 1;
        private readonly int _defenseValue = 1;
        private readonly int _mana = 1;

        public int AttackValue
        {
            get { return _attackValue; }
        }

        public int DefenseValue
        {
            get { return _defenseValue; }
        }

        public int Mana
        {
            get { return _mana; }
        }

        public Spell()
        {
            this._attackValue = _attackValue + 1;
            this._defenseValue = _defenseValue + 1;
            this._mana = _mana + 1;
        }
    }
}