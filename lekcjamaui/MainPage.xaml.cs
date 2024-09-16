namespace lekcjamaui
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private bool szukanie_malpy(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == '@')return true;
            }
            return false;
        }

        private void zatwierdz(System.Object sender, System.EventArgs e)
        {
            if (mail.Text.Length > 0)
            {
                if (szukanie_malpy(mail.Text))
                {
                    if (password.Text == password2.Text)
                    {
                        odpowiedz.Text = "Witaj " + mail.Text;
                    }
                    else
                    {
                        odpowiedz.Text = "Hasła się różnią";
                    }
                }
                else
                {
                    odpowiedz.Text = "Nieprawidłowy adres e-mail";
                }
            }
        }
    }

}
