using ConsoleApp3.Entities;
using ConsoleApp3.Enumerations;


namespace ConsoleApp3.DamageSystem
{
    public class DamageCalculator
    {
        private long Damage;
        public long DamageInflicted(Habilidades hability, Pokemons usedPokemon, Pokemons enemyPokemon)
        {

            Damage = 0;

            if (ValidadeCounter(usedPokemon.Type, enemyPokemon.Type))
                Damage += (hability.Damage * 20 / 100);

            if (ValidateDisadvantages(usedPokemon.Type, enemyPokemon.Type))
                Damage -= (hability.Damage * 20 / 100);

            if (usedPokemon.Level >= (enemyPokemon.Level + 3))
                Damage += (hability.Damage * 10 / 100);

            if (usedPokemon.Level >= (enemyPokemon.Level + 10))
                Damage += (hability.Damage * 50 / 100);

            return Damage;

        }
        public bool ValidateDisadvantages(PokemonType usedPokemon, PokemonType enemyPokemon)
        {
            if (enemyPokemon == PokemonType.Fire && usedPokemon == PokemonType.Plant)
                return true;
            if (enemyPokemon == PokemonType.Water && (usedPokemon == PokemonType.Rock || usedPokemon == PokemonType.Fire))
                return true;
            if (enemyPokemon == PokemonType.Plant && (usedPokemon == PokemonType.Rock || usedPokemon == PokemonType.Water))
                return true;
            if (enemyPokemon == PokemonType.Rock && usedPokemon == PokemonType.Fire)
                return true;

            return false;
        }
        public bool ValidadeCounter(PokemonType usedPokemon, PokemonType enemyPokemon)
        {
            if (usedPokemon == PokemonType.Fire && enemyPokemon == PokemonType.Plant)
                return true;
            if (usedPokemon == PokemonType.Water && (enemyPokemon == PokemonType.Rock || enemyPokemon == PokemonType.Fire))
                return true;
            if (usedPokemon == PokemonType.Plant && (enemyPokemon == PokemonType.Rock || enemyPokemon == PokemonType.Water))
                return true;
            if (usedPokemon == PokemonType.Rock && enemyPokemon == PokemonType.Fire)
                return true;

            return false;
        }
    }
}
