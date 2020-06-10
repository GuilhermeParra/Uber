using System;

namespace Uber
{
    public class Motorista : Usuario
    {
        
        private string carro;
        private string placa;
        public string aceitarPassageiro(){
            return "Viagem aceita para o passageiro" + nome;
        }
    }
}