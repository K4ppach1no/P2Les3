using P2Les3.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace P2Les3
{
    public partial class MainPage : TabbedPage
    {
        public ObservableCollection<Hero> heroCollection { get; private set; } = new ObservableCollection<Hero>();
        public ObservableCollection<Villain> villainCollection { get; private set; } = new ObservableCollection<Villain>();
        public ObservableCollection<Minion> minionCollection { get; private set; } = new ObservableCollection<Minion>();

        private Hero selectedHero = null;

        private Villain selectedVillain = null;

        private Minion selectedMinion = null;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

            Minion Bob = new Minion("Bob");
            minionCollection.Add(Bob);

            Villain Gru = new Villain("Gru");
            villainCollection.Add(Gru);

            heroCollection.Add(new Hero("Jason Todd", Gru, Bob));
        }

        private void HeroSelected(object sender, SelectedItemChangedEventArgs e)
        {
            selectedHero = (Hero)e.SelectedItem;
            if (selectedHero != null)
                DisplayAlert("Hero Info", $"Naam: {selectedHero.GetName()}\nArchnemesis: {selectedHero.GetArchnemesis()}\n Sidekick: {selectedHero.GetSidekick()}", "OK");
        }

        private void AddHeroClicked(object sender, EventArgs e)
        {
            heroCollection.Add(new Hero(heroName.Text, (Villain)pickArchnemesis.SelectedItem, (Minion)pickSidekick.SelectedItem));
        }

        private void VillainSelected(object sender, SelectedItemChangedEventArgs e)
        {
            selectedVillain = (Villain)e.SelectedItem;
            if (selectedVillain != null)
                DisplayAlert("Villain Info", $"Naam: {selectedVillain.GetName()}", "OK");
        }

        private void AddVillainClicked(object sender, EventArgs e)
        {
            villainCollection.Add(new Villain(villainNaam.Text, (Minion)pickMinion.SelectedItem));
        }

        private void AddMinionClicked(object sender, EventArgs e)
        {
            minionCollection.Add(new Minion(minionName.Text));

            minionName.Text = string.Empty;
        }

        private void MinionSelected(object sender, SelectedItemChangedEventArgs e)
        {
            selectedMinion = (Minion)e.SelectedItem;
            if (selectedMinion != null)
                DisplayAlert("Minion Info", selectedMinion.GetName(), "OK");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
