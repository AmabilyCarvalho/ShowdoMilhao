﻿namespace ShowdoMilhao;

    public partial class MainPage : ContentPage
    {
         Gerenciador gerenciador;
        
        public MainPage()
        {
            InitializeComponent();
            gerenciador = new Gerenciador( labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5, labelPontuacao, labelNivel);
            gerenciador.ProximaPergunta();
        }

        void OnButton1Clicked(object sender, EventArgs e)
        {
            gerenciador.VerificaCorreto(1);
        }

        void OnButton2Clicked(object sender, EventArgs e)
        {
            gerenciador.VerificaCorreto(2);
        }

        void OnButton3Clicked(object sender, EventArgs e)
        {
            gerenciador.VerificaCorreto(3);
        }

        void OnButton4Clicked(object sender, EventArgs e)
        {
            gerenciador.VerificaCorreto(4);
        }

        private void OnButton5Clicked(object sender, EventArgs e)
        {
            gerenciador.VerificaCorreto(5);
        }

       
        private void OnButton6Clicked(object sender, EventArgs e)
        {
            
        }

        private void OnButton7Clicked(object sender, EventArgs e)
        {
            
        }

        private void OnButton8Clicked(object sender, EventArgs e)
        {
            
        }
    }
