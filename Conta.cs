namespace Uber
{
    public class Conta : Usuario
    {
        private string agencia;
        private string conta;

        /// <summary>
        /// Cadastra a conta do usuário do aplicativo
        /// </summary>
        /// <returns>O cadastro realizado, caso as exigências sejam atendidas, cao o contrário, retornará que o cadastro nao foi realizado</returns>
        public string cadastrar(){
            if(agencia != null && conta != null){
            return "Cadastro realizado com sucesso";
        }
        return "Não foi possível realizar o cadastro";
        }

        /// <summary>
        /// Exclui a conta do usuário
        /// </summary>
        public void excluir(){
            
        }
    }
}