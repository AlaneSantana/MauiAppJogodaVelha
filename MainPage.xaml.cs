
namespace MauiAppJogodaVelha
{
    public partial class MainPage : ContentPage
    {

        // Controla a vez do jogador
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        //Esse método é chamado sempre que o jogador toca em um dos botões.
        private void Button_Clicked(object sender, EventArgs e)
        {
            //Identifica qual botão foi clicado
            Button btn = (Button)sender;

            // Desabilita o botão para que não possa ser clicado novamente
            btn.IsEnabled = false;

            // Coloca X ou O no botão
            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            // LINHAS
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") { Ganhar("X"); }
            if (btn13.Text == "X" && btn14.Text == "X" && btn15.Text == "X") { Ganhar("X"); }
            if (btn16.Text == "X" && btn17.Text == "X" && btn18.Text == "X") { Ganhar("X"); }

            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") { Ganhar("O"); }
            if (btn13.Text == "O" && btn14.Text == "O" && btn15.Text == "O") { Ganhar("O"); }
            if (btn16.Text == "O" && btn17.Text == "O" && btn18.Text == "O") { Ganhar("O"); }

            // COLUNAS
            if (btn10.Text == "X" && btn13.Text == "X" && btn16.Text == "X") { Ganhar("X"); }
            if (btn11.Text == "X" && btn14.Text == "X" && btn17.Text == "X") { Ganhar("X"); }
            if (btn12.Text == "X" && btn15.Text == "X" && btn18.Text == "X") { Ganhar("X"); }

            if (btn10.Text == "O" && btn13.Text == "O" && btn16.Text == "O") { Ganhar("O"); }
            if (btn11.Text == "O" && btn14.Text == "O" && btn17.Text == "O") { Ganhar("O"); }
            if (btn12.Text == "O" && btn15.Text == "O" && btn18.Text == "O") { Ganhar("O"); }

            // DIAGONAIS
            if (btn10.Text == "X" && btn14.Text == "X" && btn18.Text == "X") { Ganhar("X"); }
            if (btn12.Text == "X" && btn14.Text == "X" && btn16.Text == "X") { Ganhar("X"); }

            if (btn10.Text == "O" && btn14.Text == "O" && btn18.Text == "O") { Ganhar("O"); }
            if (btn12.Text == "O" && btn14.Text == "O" && btn16.Text == "O") { Ganhar("O"); }

            // MENSAGEM DE EMPATE 
            if (TodosPreenchidos())
            {
                DisplayAlert("Empate!", "Ninguém ganhou.", "OK");
                Zerar();
            }
        }
        // VERIFICA SE HOUVE VENCEDOR E MOSTRA ALERTA
        void Ganhar(string jogador)
        {
            DisplayAlert("Parabéns!", $"O {jogador} ganhou!", "OK");
            Zerar();
        }

        bool TodosPreenchidos()
        {
            return btn10.Text != "" && btn11.Text != "" && btn12.Text != "" &&
                   btn13.Text != "" && btn14.Text != "" && btn15.Text != "" &&
                   btn16.Text != "" && btn17.Text != "" && btn18.Text != "";
        }

        void Zerar()    // ZERA O JOGO PARA UMA NOVA PARTIDA
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn14.Text = "";
            btn15.Text = "";
            btn16.Text = "";
            btn17.Text = "";
            btn18.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn13.IsEnabled = true;
            btn14.IsEnabled = true;
            btn15.IsEnabled = true;
            btn16.IsEnabled = true;
            btn17.IsEnabled = true;
            btn18.IsEnabled = true;

            vez = "X"; // reinicia o jogador
    }

} // Fecha Classe 
} // Fecha Namespace
