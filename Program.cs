using System;

namespace Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro guilherme = new Passageiro();

            System.Console.WriteLine("Digite seu login");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine();

            guilherme.Login(login, senha);
 
            if(guilherme.TokenLogin != "" && guilherme.TokenLogin != null){
                System.Console.WriteLine("Login Autorizado!");
                System.Console.WriteLine(guilherme.TokenLogin);

                System.Console.WriteLine("Deseja se cadastrar como motorista ou passageiro?");
                string cadastro = Console.ReadLine();

                if(cadastro == "passageiro" || cadastro == "Passageiro"){
                   
                   
                   Console.WriteLine("Digite o número do seu cartão");
                   string numero = Console.ReadLine();

                    Console.WriteLine("Digite o nome do titular do cartão");
                    string titular = Console.ReadLine();

                     Console.WriteLine("Digite a bandeira do seu cartão");
                     string bandeira = Console.ReadLine();

                     Console.WriteLine("Digite o cvv do seu cartão");
                     string cvv = Console.ReadLine();

                     System.Console.WriteLine("Cadastro realizado!");

                    

                    System.Console.WriteLine("Deseja solicitar uma corrida?");
                    string solicitar = Console.ReadLine();

                    if(solicitar == "sim" || solicitar == "Sim"){
                        System.Console.WriteLine("Insira o local de partida e o seu destino");
                        string localInicio = Console.ReadLine();
                        string localChegada = Console.ReadLine();

                        System.Console.WriteLine("Digite a forma de pagamento. Opções: dinheiro ou cartão");
                        string formaPagamento = Console.ReadLine();

                        guilherme.SolicitarMotorista();

                        guilherme.proximidade();

                        guilherme.finalizada();

                    }else{
                        System.Console.WriteLine("Tudo bem, fechando aplicativo");
                    }

                    
                }
                else if(cadastro == "motorista" || cadastro == "Motorista"){
                    Motorista motor = new Motorista();
                    
                    System.Console.WriteLine("Insira sua agência e conta");
                    string agencia = Console.ReadLine();
                    string conta = Console.ReadLine();

                    System.Console.WriteLine("Digite o modelo e a placa de seu veículo");
                    string carro =  Console.ReadLine();
                    string placa = Console.ReadLine();

                    System.Console.WriteLine("Cadastro concluído");

                    System.Console.WriteLine("Há uma corrida disponível em:");

                    string localInicio = "Local de busca: Rua Limoeiro";
                    string localChegada = "Destino: Rua Barão de Limeira";

                    motor.aceitarPassageiro();

                    System.Console.WriteLine("Você chegou em " + localInicio);
                    System.Console.WriteLine("Dirija-se até " + localChegada);

                    System.Console.WriteLine("Corrida finalzada!");

                    


                }
            }else{
                System.Console.WriteLine("Não é possível utilizar o app!");
            }
        }
    }
}
