﻿using System;
using System.Collections.Generic;
using System.Linq;
using LitJson;

namespace PokeAPI
{
    public struct AbilityEffectChange
    {
        [JsonPropertyName("effect_entries")]
        public VerboseEffect[] Effects
        {
            get;
            internal set;
        }

        [JsonPropertyName("version_group")]
        public NamedApiResource<VersionGroup> VersionGroup
        {
            get;
            internal set;
        }
    }
    public struct AbilityPokemon
    {
        [JsonPropertyName("is_hidden")]
        public bool IsHidden
        {
            get;
            internal set;
        }
        public int Slot
        {
            get;
            internal set;
        }

        public NamedApiResource<Pokemon> Pokemon
        {
            get;
            internal set;
        }
    }

    public struct PokemonSpeciesVariety
    {
        [JsonPropertyName("is_default")]
        public bool IsDefault
        {
            get;
            internal set;
        }

        public NamedApiResource<Pokemon> Pokemon
        {
            get;
            internal set;
        }
    }

    public struct PokemonSpeciesGender
    {
        internal class GenderConverter : IJsonConverter
        {
            public bool Deserialize(JsonData j, out object value)
            {
                if (j.JsonType != JsonType.Int)
                {
                    value = null;
                    return false;
                }

                var i = (int)j;

                value = i == -1 ? null : (float?)i / 0.128f;

                return true;
            }
        }

        /// <summary>
        /// The chance of this <see cref="Pokemon" /> being female; or null for genderless.
        /// </summary>
        [JsonPropertyName("rate"), JsonConverter(typeof(GenderConverter))]
        public float? FamaleToMaleRate
        {
            get;
            internal set;
        }

        [JsonPropertyName("pokemon_species")]
        public NamedApiResource<PokemonSpecies> Species
        {
            get;
            internal set;
        }
    }
    public struct PokemonSpeciesFlavorText
    {
        [JsonPropertyName("flavor_text")]
        public string FlavorText
        {
            get;
            internal set;
        }

        public NamedApiResource<Language> Language
        {
            get;
            internal set;
        }
        public NamedApiResource<GameVersion> Version
        {
            get;
            internal set;
        }
    }

    public struct GrowthRateExperienceLevel
    {
        public int Level
        {
            get;
            internal set;
        }
        public int Experience
        {
            get;
            internal set;
        }
    }

    public struct NatureStatChange
    {
        public int Change
        {
            get;
            internal set;
        }

        public NamedApiResource<PokeathlonStat> Stat
        {
            get;
            internal set;
        }
    }
    public struct MoveBattleStylePreference
    {
        [JsonPropertyName("low_hp_preference")]
        public float LowHPPreference
        {
            get;
            internal set;
        }
        [JsonPropertyName("high_hp_preference")]
        public float HighHPPrefernece
        {
            get;
            internal set;
        }

        [JsonPropertyName("move_battle_style")]
        public NamedApiResource<MoveBattleStyle> BattleStyle
        {
            get;
            internal set;
        }
    }

    public struct NaturePokeathlonStatAffect
    {
        [JsonPropertyName("max_change")]
        public int MaxChange
        {
            get;
            internal set;
        }

        public NamedApiResource<Nature> Nature
        {
            get;
            internal set;
        }
    }
    public struct NaturePokeathlonStatAffectSets
    {
        public NaturePokeathlonStatAffect[] Increase
        {
            get;
            internal set;
        }
        public NaturePokeathlonStatAffect[] Decrease
        {
            get;
            internal set;
        }
    }

    public struct PokemonAbility
    {
        [JsonPropertyName("is_hidden")]
        public bool IsHidden
        {
            get;
            internal set;
        }
        public int Slot
        {
            get;
            internal set;
        }

        public NamedApiResource<Ability> Ability
        {
            get;
            internal set;
        }
    }

    public struct PokemonTypeMap
    {
        public int Slot
        {
            get;
            internal set;
        }

        public NamedApiResource<PokemonType> Type
        {
            get;
            internal set;
        }
    }

    public struct LocationAreaEncounter
    {
        [JsonPropertyName("location_area")]
        public ApiResource<LocationArea> LocationArea
        {
            get;
            internal set;
        }

        [JsonPropertyName("version_details")]
        public VersionEncounterDetail[] VersionDetails
        {
            get;
            internal set;
        }
    }

    public struct AwesomeName
    {
        [JsonPropertyName("awesome_name")]
        public string Text
        {
            get;
            internal set;
        }

        public NamedApiResource<Language>[] Language
        {
            get;
            internal set;
        }
    }

    public struct Genus
    {
        [JsonPropertyName("genus")]
        public string Name
        {
            get;
            internal set;
        }

        public NamedApiResource<Language> Language
        {
            get;
            internal set;
        }
    }
    public struct PokemonSpeciesDexEntry
    {
        [JsonPropertyName("entry_number")]
        public int EntryNumber
        {
            get;
            internal set;
        }

        public NamedApiResource<Pokedex> Pokedex
        {
            get;
            internal set;
        }
    }
    public class PalParkEncounterArea
    {
        [JsonPropertyName("base_score")]
        public int BaseScore
        {
            get;
            internal set;
        }
        public int Rate
        {
            get;
            internal set;
        }

        public NamedApiResource<PalParkArea> Area
        {
            get;
            internal set;
        }
    }

    public struct StatAffect<T>
        where T : NamedApiObject
    {
        [JsonPropertyName("max_change")]
        public int MaxChange
        {
            get;
            internal set;
        }

        [JsonPropertyName("move"), JsonPropertyName("nature")]
        public NamedApiResource<T> Resource
        {
            get;
            internal set;
        }
    }
    public struct StatAffectSets<T>
        where T : NamedApiObject
    {
        public StatAffect<T>[] Increase
        {
            get;
            internal set;
        }
        public StatAffect<T>[] Decrease
        {
            get;
            internal set;
        }
    }

    public struct TypePokemon
    {
        public int Slot
        {
            get;
            internal set;
        }

        public NamedApiResource<Pokemon> Pokemon
        {
            get;
            internal set;
        }
    }
    public struct TypeRelations
    {
        [JsonPropertyName("no_damage_to")]
        public NamedApiResource<PokemonType> NoDamageTo
        {
            get;
            internal set;
        }
        [JsonPropertyName("half_damage_to")]
        public NamedApiResource<PokemonType> HalfDamageTo
        {
            get;
            internal set;
        }
        [JsonPropertyName("double_damage_to")]
        public NamedApiResource<PokemonType> DoubleDamageTo
        {
            get;
            internal set;
        }

        [JsonPropertyName("no_damage_from")]
        public NamedApiResource<PokemonType> NoDamageFrom
        {
            get;
            internal set;
        }
        [JsonPropertyName("half_damage_from")]
        public NamedApiResource<PokemonType> HalfDamageFrom
        {
            get;
            internal set;
        }
        [JsonPropertyName("double_damage_from")]
        public NamedApiResource<PokemonType> DoubleDamageFrom
        {
            get;
            internal set;
        }
    }
}
