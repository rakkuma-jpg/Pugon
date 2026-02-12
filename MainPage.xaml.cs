using PugonPrototype.Views;

namespace PugonPrototype
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            ContentArea.Content = new HomeView();
            HomeTab.BackgroundColor = Colors.LightGreen;
        }
        private void ResetTabColors() 
        {
            HomeTab.BackgroundColor = Colors.Transparent; 
            RecipesTab.BackgroundColor = Colors.Transparent; 
            ChatbotTab.BackgroundColor = Colors.Transparent; 
            FavoritesTab.BackgroundColor = Colors.Transparent; 
            AccountTab.BackgroundColor = Colors.Transparent; 
        }
        private void OnCounterClicked(object? sender, EventArgs e)
        {
           
        }
        private void Notification_Clicked(object sender, EventArgs e)
        {
            // TODO: Add your notification click handling logic here
        }
        private void Settings_Clicked(object sender, EventArgs e)
        {
            // TODO: Add your notification click handling logic here
        }
        private void Home_Clicked(object sender, EventArgs e)
        {
            // TODO: Add your Home tab click handling logic here
            ResetTabColors();
            HomeTab.BackgroundColor = Colors.LightGreen;
            ContentArea.Content = new HomeView();
        }
        private void Recipes_Clicked(object sender, EventArgs e)
        {
            // TODO: Add your Recipe tab click handling logic here
            ResetTabColors();
            RecipesTab.BackgroundColor = Colors.LightGreen;
            ContentArea.Content = new RecipesView();
        }
        private void Chatbot_Clicked(object sender, EventArgs e)
        {
            // TODO: Add your AI Chatbot tab click handling logic here
            ResetTabColors();
            ChatbotTab.BackgroundColor = Colors.LightGreen;
            ContentArea.Content = new ChatbotView();
        }
        private void Favorites_Clicked(object sender, EventArgs e)
        {
            // TODO: Add your Favorites tab click handling logic here
            ResetTabColors();
            FavoritesTab.BackgroundColor = Colors.LightGreen;
            ContentArea.Content = new FavoritesView();
        }
        private void Account_Clicked(object sender, EventArgs e)
        {
            // TODO: Add your Favorites tab click handling logic here
            ResetTabColors();
            AccountTab.BackgroundColor = Colors.LightGreen;
            ContentArea.Content = new AccountView();
        }
    }
}
