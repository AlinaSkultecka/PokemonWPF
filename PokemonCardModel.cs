using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PokemonWPF
{
    public class PokemonCardModel
    {
        public string Name { get; set; }
        public string HP { get; set; }
        public ElementType ElementType { get; set; }
        public string ImagePath { get; set; }
        public String SubInfo { get; set; }
        public string Weakness { get; set; }
        public string Resistance { get; set; }
        public string Retreat { get; set; }
        public string IllusAuthor { get; set; }
        public List<PokemonAttack> Attacks { get; set; } = new();
        public string BottomInfo { get; set; }
        public string BackgroundColor { get; set; }
        public string MainColor { get; set; }

    }

    public enum ElementType
    {
        Fire,
        Spike,
        Water,
        Grass,
        Electric,
        Psychic,
        Fighting,
        Dark,
        Fairy,
        Dragon,
        Colorless
    }
}
