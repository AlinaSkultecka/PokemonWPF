using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokemonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PokemonCardModel _rhyhorn;
        private PokemonCardModel _charmander;
        private PokemonCardModel _squirtle;
        public MainWindow()
        {
            InitializeComponent();

            _rhyhorn = new PokemonCardModel
            {
                Name = "Rhyhorn",
                HP = "HP 100 ✊",
                SubInfo = "NO. 0111  Spike Pokemon  HT:3'3'  WT:253.5 lbs.",
                Attacks =
                {
                    new PokemonAttack
                    {
                        Icon = "✊⭐",
                        Name = "Push Down",
                        Damage = "20",
                        Description = "Switch out your opponent's Active Pokemon to the Bench. (Your opponent choose the new Active Pokemon.)."
                    },
                    new PokemonAttack
                    {
                        Icon = "✊✊⭐",
                        Name = "Boulder Crush",
                        Damage = "70",
                        Description = "Massive attack."
                    }
                },
                Weakness = "weakness 🍀 x 2",
                Resistance = "resistance",
                Retreat = "retreat ⭐⭐⭐",
                IllusAuthor = "Illus. GOSSSAN 111/165",
                BottomInfo = "It can remember only one thing at a time. Once it starts rushing, it forgets why it started.",
                Rarity = "Common",
            };

            _squirtle = new PokemonCardModel
            {
                Name = "Squirtle",
                HP = "HP 70 💧",
                SubInfo = "NO. 007  Tiny Turtle Pokemon  HT:1'8'  WT:19.8 lbs.",
                Attacks =
                {
                    new PokemonAttack
                    {
                        Icon = "💧⭐",
                        Name = "Bubble",
                        Damage = "10",
                        Description = "Flip a coin. If heads, your opponent's Active Pokemon is now Paralyzed."
                    },
                    new PokemonAttack
                    {
                        Icon = "💧💧⭐",
                        Name = "Water Gun",
                        Damage = "30",
                        Description = "You may do 10 more damage. (You don't apply Weakness and Resistance for this damage.)"
                    }
                },
                Weakness = "weakness ⚡ x 2",
                Resistance= "resistance",
                Retreat = "retreat ⭐",
                IllusAuthor = "Illus. MIKI TANAKA 63/165",
                BottomInfo = "After birth, its back swells and hardens into a shell. It powerfully sprays foam from its mouth.",
                Rarity = "Common",
            };

            _charmander = new PokemonCardModel
            {
                Name = "Charmander",
                HP = "HP 80 🔥",
                SubInfo = "NO. 004  Lizard Pokemon  HT:2'0'  WT:18.7 lbs.",
                Attacks =
                {
                    new PokemonAttack
                    {
                        Icon = "🔥⭐",
                        Name = "Scratch",
                        Damage = "10",
                        Description = "aaa aaa"
                    },
                    new PokemonAttack
                    {
                        Icon = "🔥🔥⭐",
                        Name = "Flamethrower",
                        Damage = "50",
                        Description = "Discard an Energy from this Pokemon."
                    }
                },
                Weakness = "weakness 💧 x 2",
                Resistance= "resistance",
                Retreat = "retreat ⭐",
                IllusAuthor = "Illus. MIKI TANAKA 46/165",
                BottomInfo = "It has a preference for hot things. When it rains, steam is said to spout from the tip of its tail.",
                Rarity = "Common",
            };
            SetUpWindow(_rhyhorn);
        }
        
        public void OpenSelectionWindowClick (Object sender, RoutedEventArgs e)
        {
            var picker = new SelectionWindow(_rhyhorn, _charmander, _squirtle) { Owner = this };
            if (picker.ShowDialog() == true)
            {
                SetUpWindow(picker.SelectedPokemon);

            }
        }
        //SetUpWindow(pokemonCardModel);

        private void SetUpWindow(PokemonCardModel pokemon)
        {
            NameTextBlock.Text = pokemon.Name;
            HPTextBlock.Text = pokemon.HP;
            SubInfoTextBlock.Text = pokemon.SubInfo;

            Attack1IconTextBlock.Text = pokemon.Attacks[0].Icon;
            Attack1NameTextBlock.Text = pokemon.Attacks[0].Name;
            Attack1DamageTextBlock.Text = pokemon.Attacks[0].Damage;
            Attack1DescriptionTextBlock.Text = pokemon.Attacks[0].Description;

            Attack2IconTextBlock.Text = pokemon.Attacks[1].Icon;
            Attack2NameTextBlock.Text = pokemon.Attacks[1].Name;
            Attack2DamageTextBlock.Text = pokemon.Attacks[1].Damage;
            Attack2DescriptionTextBlock.Text = pokemon.Attacks[1].Description;

            BottomTextBlock.Text = pokemon.BottomInfo;
            IllusAuthorTextBlock.Text = pokemon.IllusAuthor;

            WeaknessTextBlock.Text = pokemon.Weakness;
            ResistanceTextBlock.Text = pokemon.Resistance;
            RetreatTextBlock.Text = pokemon.Retreat;
        }

    }
}