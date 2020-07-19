using System;

namespace Uber
{
    public class Passageiro : Usuario
    {
        /// <summary>
        /// Solicita um motorista para a viagem
        /// </summary>
        /// <returns>Procurando motorista</returns>
        public string SolicitarMotorista(){
          return "Procurando motorista";
      }

        /// <summary>
        /// Indica quando um motorista está próximo de você
        /// </summary>
        /// <returns>O motorista está próximo de sua localidade</returns>
        public string proximidade(){
          return "O motorista está próximo da sua localidade";
      }
        /// <summary>
        /// Finaliza a corrida
        /// </summary>
        /// <returns>Corrida finalizada</returns>
        public string finalizada(){
          return "Corrida finalizada";
      }
        /// <summary>
        /// Mostra se o passageiro pagou a corrida
        /// </summary>
        /// <param name="statusCorrida"></param>
        /// <returns>Finalizada, caso o passageiro pague</returns>
        public bool Pagar(string statusCorrida){
            if(statusCorrida == "Finalizada"){
              return true;
          }
            return false;
        }

        
    }
}