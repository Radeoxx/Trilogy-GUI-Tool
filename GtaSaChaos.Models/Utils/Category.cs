// Copyright (c) 2019 Lordmau5
using GtaChaos.Models.Effects.@abstract;
using System.Collections.Generic;

namespace GtaChaos.Models.Utils
{
    public sealed class Category
    {
        public readonly string Name;
        public readonly string Prefix;
        public readonly List<AbstractEffect> Effects;

        public static readonly List<Category> Categories = new List<Category>();

        private Category(string name, string prefix)
        {
            Name = name;
            Prefix = prefix;
            Effects = new List<AbstractEffect>();

            if (!Categories.Contains(this))
            {
                Categories.Add(this);
            }
        }

        public string AddEffectToCategory(AbstractEffect effect)
        {
            Effects.Add(effect);
            return Prefix + Effects.Count;
        }

        public int GetEffectCount()
        {
            return Effects.Count;
        }

        public void ClearEffects()
        {
            Effects.Clear();
        }

        public static readonly Category WeaponsAndHealth = new Category("Armas Y Salud", "HE");
        public static readonly Category WantedLevel = new Category("\"Se busca\" (Policía)", "WA");
        public static readonly Category Weather = new Category("Clima", "WE");
        public static readonly Category Spawning = new Category("Spawning", "SP");
        public static readonly Category Time = new Category("Tiempo", "TI");
        public static readonly Category VehiclesTraffic = new Category("Vehículos Y Tráfico", "VE");
        public static readonly Category PedsAndCo = new Category("Personas (NPCs)", "PE");
        public static readonly Category PlayerModifications = new Category("Modificaciones Al Jugador", "MO");
        public static readonly Category Stats = new Category("Estadísticas", "ST");
        public static readonly Category CustomEffects = new Category("Efectos Personalizados", "CE");
        public static readonly Category Teleportation = new Category("Teletransporte", "TP");
    }
}
