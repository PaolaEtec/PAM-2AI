namespace Exemplo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string name = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                Btn.Text = $"Clicked {count} time";
            else
                Btn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(Btn.Text);
        }

        private void OnGreetClicked(object sender, EventArgs e)
        {
            name = NameEntry.Text;
            GreetLabel.Text = $"Hello, {name}!";
        }
    }
    // comentário

}
