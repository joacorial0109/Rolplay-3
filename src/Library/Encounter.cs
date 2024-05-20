using System;
using System.Collections.Generic;
using RoleplayGame.Characters;

namespace RoleplayGame.Utils
{
    /// <summary>
    /// Los encuentros son instancias donde dos o más personajes se encuentran para batallar (encuentros de combate entre héroes y enemigos).
    /// </summary>
    public class Encounter
    {
        /// <summary>
        /// En un encuentro debe haber siempre personajes Hero (al menos uno).
        /// </summary>
        /// <value>Héroe.</value>
        private List<Hero> _heroes = new List<Hero> { };

        /// <summary>
        /// En un encuentro debe haber siempre personajes Enemy (al menos uno).
        /// </summary>
        /// <value>Enemigo.</value>
        private List<Enemy> _enemies = new List<Enemy> { };

        /// <summary>
        /// Añade un héroe a la lista de héroes en el encuentro.
        /// </summary>
        /// <param name="hero">Héroe.</param>
        public void AddCharacter(Hero hero)
        {
            if (!_heroes.Contains(hero))
            {
                _heroes.Add(hero);
            }
            else
            {
                Console.WriteLine($"The hero '{hero.Name}' is already inside of the list.");
            }
        }

        /// <summary>
        /// Añade un enemigo a la lista de enemigos en el encuentro.
        /// </summary>
        /// <param name="enemy">Enemigo.</param>
        public void AddCharacter(Enemy enemy)
        {
            if (!_enemies.Contains(enemy))
            {
                _enemies.Add(enemy);
            }
            else
            {
                Console.WriteLine($"The enemy '{enemy.Name}' is already inside of the list.");
            }
        }

        /// <summary>
        /// Remueve un héroe de la lista de héroes en el encuentro.
        /// </summary>
        /// <param name="hero">Héroe.</param>
        public void RemoveCharacter(Hero hero)
        {
            if (_heroes.Contains(hero))
            {
                _heroes.Remove(hero);
            }
            else
            {
                Console.WriteLine($"The hero '{hero.Name}' is not inside of the list.");
            }
        }

        /// <summary>
        /// Remueve un enemigo a la lista de enemigos en el encuentro.
        /// </summary>
        /// <param name="enemy">Enemigo.</param>
        public void RemoveCharacter(Enemy enemy)
        {
            if (_enemies.Contains(enemy))
            {
                _enemies.Remove(enemy);
            }
            else
            {
                Console.WriteLine($"The enemy '{enemy.Name}' is not inside of the list.");
            }
        }

        /// <summary>
        /// Retorna un valor que indica si el encuentro puede empezar o no.
        /// </summary>
        /// <returns>true si el encuentro puede empezar, false si el encuentro no puede empezar.</returns>
        private bool CanStartEncounter()
        {
            if (_heroes.Count >= 1 && _enemies.Count >= 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna un valor que indica quién ganó el encuentro.
        /// </summary>
        /// <returns>"Enemies" si ganaron los enemigos, "Heroes" si ganaron los héroes, "Nobody" si no ganó nadie por ahora.</returns>
        private string WhoWon()
        {
            if (_heroes.Count < 1)
            {
                return "Enemies";
            }
            else if (_enemies.Count < 1)
            {
                return "Heroes";
            }
            else
            {
                return "Nobody";
            }
        }

        /// <summary>
        /// Simula un encuentro entre héroes y enemigos.
        /// </summary>
        public void DoEncounter()
        {
            if (CanStartEncounter() == true)
            {
                Console.WriteLine("An encounter has started!!!\n");

                while (_heroes.Count > 0 && _enemies.Count > 0)
                {

                    TurnOfEnemies();

                    if (WhoWon() == "Nobody")
                    {
                        TurnOfHeroes();
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine($"Winners: {WhoWon()}");
            }
            else
            {
                Console.WriteLine("The encounter can't to start. Insufficient quantity of enemies or heroes.");
            }
        }

        /// <summary>
        /// Simula el turno de los enemigos.
        /// </summary>
        private void TurnOfEnemies()
        {
            int indexHeroes = 0;
            for (int indexEnemies = 0; indexEnemies < _enemies.Count; indexEnemies++)
            {
                if (indexHeroes >= _heroes.Count)
                {
                    indexHeroes = 0;
                }

                Hero heroToAttack = _heroes[indexHeroes];

                // El enemigo ataca al héroe que le corresponde.
                heroToAttack.ReceiveAttack(_enemies[indexEnemies].AttackValue);

                // Mensaje de aviso en consola.
                Console.WriteLine($"{_enemies[indexEnemies].Name} attacks {heroToAttack.Name} with ⚔️ {_enemies[indexEnemies].AttackValue}");
                Console.WriteLine($"{heroToAttack.Name} has ❤️ {heroToAttack.Health}\n");

                // Se elimina a un héroe de la lista si su vida es 0 después del ataque.
                if (heroToAttack.Health == 0)
                {
                    Console.WriteLine($"{heroToAttack.Name} 💔 was defeated\n");
                    RemoveCharacter(heroToAttack);
                }

                // Se rompe el bucle si los enemigos ganaron para evitar pasos inncessarios.
                if (WhoWon() == "Enemies") break;

                indexHeroes++;
            }
        }

        /// <summary>
        /// Simula el turno de los héroes, si al menos un héroe sobrevivió después del turno de los enemigos.
        /// </summary>
        private void TurnOfHeroes()
        {
            int indexEnemies = 0;
            int VP = 0;

            for (int indexHeroes = 0; indexHeroes < _heroes.Count; indexHeroes++)
            {
                indexEnemies = 0;
                // Cada héroe ataca a cada enemigo una vez.
                while (indexEnemies < _enemies.Count)
                {
                    Enemy enemyToAttack = _enemies[indexEnemies];

                    // El héroe ataca a un enemigo.
                    enemyToAttack.ReceiveAttack(_heroes[indexHeroes].AttackValue);

                    // Mensaje de aviso en consola.
                    Console.WriteLine($"{_heroes[indexHeroes].Name} attacks {enemyToAttack.Name} with ⚔️ {_heroes[indexHeroes].AttackValue}");
                    Console.WriteLine($"{enemyToAttack.Name} has ❤️ {enemyToAttack.Health}\n");

                    // Se elimina a un enemigo de la lista si su vida es 0 después del ataque.
                    if (enemyToAttack.Health == 0)
                    {
                        // Puntos de victoria del enemigo.
                        VP = enemyToAttack.GiveVP();

                        // El héroe obtiene los puntos de victoria del héroe que asesinó.
                        _heroes[indexHeroes].ObtainVP(VP);

                        // Si el héroe obtiene más de 5 puntos de victoria, entonces se cura.
                        if (VP >= 5)
                        {
                            _heroes[indexHeroes].Cure();
                            Console.WriteLine($"{_heroes[indexHeroes].Name} was cured ❤️❤️❤️\n");
                        }

                        Console.WriteLine($"{enemyToAttack.Name} 💔 was defeated\n");
                        RemoveCharacter(enemyToAttack);
                    }
                    else
                    {
                        indexEnemies++;
                    }

                    // Se rompe el bucle si los héroes ganaron para evitar pasos inncessarios.
                    if (WhoWon() == "Heroes") break;
                }
            }
        }
    }
}