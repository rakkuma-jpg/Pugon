using Pugon.ViewModel;
using Pugon.Model;
using Pugon.View;

namespace Pugon.Pages;

[QueryProperty(nameof(Difficulty), "difficulty")]
public partial class BreadsPage : ContentPage
{
    public BreadsPage()
    {
        InitializeComponent();
    }
    public string Difficulty
    {
        set
        {
            BindingContext = new BreadsViewModel(value);
        }
    }
    //public BreadDetailModel? SelectedBread { get; set; } = null;

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (sender is Syncfusion.Maui.Core.SfEffectsView effectsView && effectsView.BindingContext is BreadDetailModel bread)
        {
            PastryPopup.BindingContext = bread;
            this.PastryPopup.Show();
        }

    }

}