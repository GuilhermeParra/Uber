namespace Uber
{
    public class Conta : Usuario
    {
        private string agencia;
        private string conta;

        public string cadastrar(){
            if(agencia != null && conta != null){
            return "Cadastro realizado com sucesso";
        }
        return "Não foi possível realizar o cadastro";
        }
        public void excluir(){
            
        }
    }
}