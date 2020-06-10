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

        public bool Login(string login, string senha){
            if(this.login == login && this.senha == senha){
             TokenLogin = "Guilherme";
             return true;
            } 
            return false;
        }
        public void Logout(){
            TokenLogin = "";
        }
        public string cadastro(){
            return "Tudo bem, vamos cadastrar";
        }

       
    }
}