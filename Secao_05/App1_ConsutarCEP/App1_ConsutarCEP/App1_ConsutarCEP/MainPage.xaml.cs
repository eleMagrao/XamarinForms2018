using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1_ConsutarCEP.Servico.Modelo;
using App1_ConsutarCEP.Servico;

namespace App1_ConsutarCEP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            string cep = CEP.Text.Trim();

            if(IsvalidCEP(cep))
            {
                try
                {                    
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço: {2} de {3} {0},{1} ", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else 
                    {
                        DisplayAlert("ERRO", "O endereço não foi encontrado para o CEP informado " + cep, "OK");
                    }

                    
                } catch (Exception e) 
                {
                    DisplayAlert("ERRO CRITICO", e.Message, "OK");
                }
            }
            
        }

        private bool IsvalidCEP(string cep) 
        {
            bool valido = true;


            if (cep.Length != 8) 
            {
                DisplayAlert("ERRO", "CEP Inválido! O CEP deve conter 8 caracteres", "OK");
                valido = false;
            }
            
            int NovoCEP = 0;
            if (!int.TryParse(cep, out NovoCEP)) 
            {
                DisplayAlert("ERRO", "CEP Inválido! O CEP deve ser composto apenas por números", "OK");
                valido = false;
            }
             
            
            

            return valido;
        }
    }
}
