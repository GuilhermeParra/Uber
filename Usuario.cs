namespace Uber
{
    public class Usuario 
    {   
        public string nome;
        public int idade;
        public string Foto {get; set;}
        private string login = "parra.gui@hotmail.com";
        private string senha = "fvg54fd65";
        public string LocalizacaoAtual {get; set;}
        public string TokenLogin {get; set;}
        public string TipoAcesso { get; set; }

        /// <summary>
        /// Faz o login do usuário
        /// </summary>
        /// <param name="login">Guarda o login</param>
        /// <param name="senha">Guarda a senha do usuário</param>
        /// <returns>Verdadeiro caso atinja os requisitos</returns>
        public bool Login(string login, string senha){
            if(this.login == login && this.senha == senha){
             TokenLogin = "Guilherme";
             return true;
            } 
            return false;
        }
        /// <summary>
        /// Faz o logout do usuário
        /// </summary>
        public void Logout(){
            TokenLogin = "";
        }
        /// <summary>
        /// Faz o cadastro do usuário
        /// </summary>
        /// <returns>Vamos cadastrar</returns>
        public string cadastro(){
            return "Tudo bem, vamos cadastrar";
        }

       
    }
}