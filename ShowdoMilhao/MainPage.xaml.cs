﻿namespace ShowdoMilhao
{
    public partial class MainPage : ContentPage
    {
         Gerenciador gerenciador;
        
        public MainPage()
        {
            InitializeComponent();
            gerenciador = new Gerenciador(labelPergunta, buttonResposta1, buttonResposta2, buttonResposta3, buttonResposta4, buttonResposta5);
            gerenciador = Pergunta();
        }

        void OnButton1Clicked(object sender, EventArgs e)
        {
            gerenciador.VerificaCorreto(1);
        }

        private void OnButton2Clicked(object sender, EventArgs e)
        {
       
        }

        private void OnButton3Clicked(object sender, EventArgs e)
        {
         
        }

        private void OnButton4Clicked(object sender, EventArgs e)
        {
           
        }

        private void OnButton5Clicked(object sender, EventArgs e)
        {
        
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
}