using App1_ConsutarCEP.Servico.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Newtonsoft.Json;

namespace App1_ConsutarCEP.Servico
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(String CEP) 
        {
            String NovoEnderecoURL = String.Format(EnderecoURL, CEP);

            WebClient wc = new WebClient();
            String Conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if (end.cep == null) return null;

            return end;


        }



    }
}
