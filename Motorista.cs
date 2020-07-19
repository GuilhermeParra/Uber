using System;

namespace Uber
{
    public class Motorista : Usuario
    {
        
        private string carro;
        private string placa;

        /// <summary>
        /// Permite que o motorista aceite o passageiro
        /// </summary>
        /// <returns>Viagem aceita</returns>
        public string aceitarPassageiro(){
            return "Viagem aceita para o passageiro" + nome;
        }
    }
}