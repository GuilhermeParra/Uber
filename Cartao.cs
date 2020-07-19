using System;

namespace Uber
{
    public class Cartao 
    {
      private string numero ;
      private string titular;
      private string bandeira;
      private string cvv;
      public string formaPagamento;

      /// <summary>
      /// Cadastra o cartão do usuário
      /// </summary>
      /// <returns>O cadastro realizado</returns>
      public string cadastrar(){
          return "Cadastro feito com sucesso";
      }  
      /// <summary>
      /// Exclui o cartão do usuário
      /// </summary>
      public void excluir(){}

        
    }
}