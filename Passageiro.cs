using System;

namespace Uber
{
    public class Passageiro : Usuario
    {
      public string SolicitarMotorista(){
          return "Procurando motorista";
      }

      public string proximidade(){
          return "O motorista está próximo da sua localidade";
      }
      public string finalizada(){
          return "Corrida finalizada";
      }
      public bool Pagar(string statusCorrida){
          if(statusCorrida == "Finalizada"){
              return true;
          }
          return false;
      }

        
    }
}