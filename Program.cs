
using projeto_poo_incrementado.Models;

Console.WriteLine("Seja bem vindo ao sistema de smartphones! \n" +
                        "Digite a opcao desejada de acordo com o MENU abaixo:");

bool exibirMenu = true;

while (exibirMenu){

    Console.WriteLine("Qual smartphone voce deseja configurar:");
    Console.WriteLine("1 - Nokia");
    Console.WriteLine("2 - iPhone");
    Console.WriteLine("3 - Encerrar");

    switch (Console.ReadLine())
    {

        case "1":
                
                Console.WriteLine("Digite o numero");
                string num = Console.ReadLine();
                Console.WriteLine("Digite o modelo");
                string mod = Console.ReadLine();
                Console.WriteLine("Digite o IMEI");
                string IM = Console.ReadLine();
                Console.WriteLine("Digite a memoria");
                int mem = Convert.ToInt32(Console.ReadLine());
                
                Smartphone nokia1 = new Nokia(numero: num, modelo: mod, IMEI2: IM, memoria: mem);
            
                Console.WriteLine($"Seu smartphone: Nokia, numero: {num}, modelo: {mod}, IMEI: {IM}, memoria: {mem}");

                    
                    Console.WriteLine("Digite 0 para ligar o telefone:");
                    
                    int x = Convert.ToInt32(Console.ReadLine());
                   

                          
                                    if(x == 0)
                                    {
                                        nokia1.Ligar();
                                        
                                        bool w = true;
                                        while(w)
                                        {
                                        
                                        Console.WriteLine("Escolha o que voce deseja fazer:");
                                        Console.WriteLine("Digite 1 - Fazer ligacao");
                                        Console.WriteLine("Digite 2 - Instalar aplicativo");
                                        Console.WriteLine("Digite 3 - Encerrar");

                                        int y = Convert.ToInt32(Console.ReadLine());

                                            if (y == 1){
                                                nokia1.fazerLigacao();
                                            }
                                            else if(y == 2){
                                                Console.WriteLine("Digite o nome do aplicativo");
                                                string app = Console.ReadLine();
                                                nokia1.InstalarAplicativo(app);
                                            }
                                            else if(y == 3){
                                                Console.WriteLine("Retornando ao menu principal...");
                                                w = false;
                                            }
                                            else{
                                                Console.WriteLine("Opcao invalida");
                                            }
                                        }
                                
                                    }

                                    else 
                                    {
                                    Console.WriteLine("Seu smartphone permanece desligado");
                                    }
                    
                            
            break;

        case "2":

            Console.WriteLine("Digite o numero");
                string num1 = Console.ReadLine();
                Console.WriteLine("Digite o modelo");
                string mod1 = Console.ReadLine();
                Console.WriteLine("Digite o IMEI");
                string IM1 = Console.ReadLine();
                Console.WriteLine("Digite a memoria");
                int mem1 = Convert.ToInt32(Console.ReadLine());
                
                Smartphone iphone1 = new Iphone(numero: num1, modelo: mod1, IMEI2: IM1, memoria: mem1);
            
                Console.WriteLine($"Seu smartphone: Nokia, numero: {num1}, modelo: {mod1}, IMEI: {IM1}, memoria: {mem1}");

                    
                    Console.WriteLine("Digite 0 para ligar o telefone:");
                    
                    int z = Convert.ToInt32(Console.ReadLine());
                   

                          
                                    if(z == 0)
                                    {
                                        iphone1.Ligar();
                                        
                                        bool w = true;
                                        while(w)
                                        {
                                        
                                        Console.WriteLine("Escolha o que voce deseja fazer:");
                                        Console.WriteLine("Digite 1 - Fazer ligacao");
                                        Console.WriteLine("Digite 2 - Instalar aplicativo");
                                        Console.WriteLine("Digite 3 - Encerrar");

                                        int y = Convert.ToInt32(Console.ReadLine());

                                            if (y == 1){
                                                iphone1.fazerLigacao();
                                            }
                                            else if(y == 2){
                                                Console.WriteLine("Digite o nome do aplicativo");
                                                string app = Console.ReadLine();
                                                iphone1.InstalarAplicativo(app);
                                            }
                                            else if(y == 3){
                                                Console.WriteLine("Retornando ao menu principal...");
                                                w = false;
                                            }
                                            else{
                                                Console.WriteLine("Opcao invalida");
                                            }
                                        }
                                
                                    }

                                    else 
                                    {
                                    Console.WriteLine("Seu smartphone permanece desligado");
                                    }
            
            break;

        case "3":
            Console.WriteLine("Programa encerrado!");
            exibirMenu = false;
            break;            

        default:
            Console.WriteLine("Opção inválida");
            break;
    }



}