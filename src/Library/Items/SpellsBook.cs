using System.Collections.Generic;
using RoleplayGame.Interfaces;

namespace RoleplayGame.Items
{
    public class SpellsBook : IMagicalAttackItem, IMagicalDefenseItem
    {
        public Spell[] Spells { get; set; }

        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value + Mana;
            }
        }

        public int Mana
        {
            get
            {
                int value = 0;
                foreach (Spell spell in Spells)
                {
                    value += spell.Mana;
                }
                return value;
            }
        }
    }
}