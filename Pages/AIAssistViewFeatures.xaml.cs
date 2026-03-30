using Pugon.Model;
using Pugon.ViewModel;
using Syncfusion.Maui.AIAssistView;
namespace Pugon.Pages;

public partial class AIAssistViewFeatures : ContentPage
{
    LlamaEngine llama = new LlamaEngine();
    public AIAssistViewFeatures()
	{
		InitializeComponent();
    }
    private async void sfAIAssistView_Request(object sender, Syncfusion.Maui.AIAssistView.RequestEventArgs e)
    {
        if (e.RequestItem != null)
        {
            await this.GetResult(e.RequestItem.Text);
        }
        else
        {
            System.Diagnostics.Debug.WriteLine("RequestItem is null");
        }
    }
    private async Task GetResult(string query)
    {
        var reply = await llama.AskAsync(query);

        AssistItem botMessage = new AssistItem()
        {
            Text = reply
        };

        viewModel.AssistItems.Add(botMessage);
    }
}