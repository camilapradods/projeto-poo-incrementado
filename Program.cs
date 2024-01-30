
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
            
            var nokia1 = new Nokia(numero: num, modelo: mod, IMEI2: IM, memoria: mem);
        
            Console.WriteLine($"Seu smartphone: Nokia, numero: {num}, modelo: {mod}, IMEI: {IM}, memoria: {mem} \n");
            

            Console.WriteLine("Digite 'Ligar' para iniciar o telefone:");
            
            var ligarNokia = Console.ReadLine().ToUpper();
    
            if(ligarNokia.Equals("LIGAR"))
            {
                nokia1.Ligar();
                
                bool funcionando = true;
                while(funcionando)
                {
                
                Console.WriteLine("Escolha o que voce deseja fazer:");
                Console.WriteLine("Digite 'ligacao' para fazer um ligacao");
                Console.WriteLine("Digite 'instalar' para instalar um aplicativo");
                Console.WriteLine("Digite 'desligar' para desligar o smartphone");

                var funcionalidades = Console.ReadLine().ToUpper();

                    if (funcionalidades.Equals("LIGACAO")){
                        nokia1.fazerLigacao();
                    }
                    else if(funcionalidades.Equals("INSTALAR")){
                        Console.WriteLine("Digite o nome do aplicativo");
                        string app = Console.ReadLine();
                        nokia1.InstalarAplicativo(app);
                    }
                    else if(funcionalidades.Equals("DESLIGAR")){
                        Console.WriteLine("Desligando seu smartphone... \n");
                        funcionando = false;
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
                
            var iphone1 = new Iphone(numero: num1, modelo: mod1, IMEI2: IM1, memoria: mem1);
            
            Console.WriteLine($"Seu smartphone: Iphone, numero: {num1}, modelo: {mod1}, IMEI: {IM1}, memoria: {mem1}");

                    
            Console.WriteLine("Digite 'Ligar' para iniciar o telefone:");;
                    
            var ligarIphone = Console.ReadLine().ToUpper();
    
            if(ligarIphone.Equals("LIGAR"))
            {
                iphone1.Ligar();
                
                bool funcionando = true;
                while(funcionando)
                {
                                        
                Console.WriteLine("Escolha o que voce deseja fazer:");
                Console.WriteLine("Digite 'ligacao' para fazer um ligacao");
                Console.WriteLine("Digite 'instalar' para instalar um aplicativo");
                Console.WriteLine("Digite 'desligar' para desligar o smartphone");


                var funcionalidades = Console.ReadLine().ToUpper();

                    if (funcionalidades.Equals("LIGACAO")){
                        iphone1.fazerLigacao();
                    }
                    else if(funcionalidades.Equals("INSTALAR")){
                        Console.WriteLine("Digite o nome do aplicativo");
                        string app = Console.ReadLine();
                        iphone1.InstalarAplicativo(app);
                    }
                    else if(funcionalidades.Equals("DESLIGAR")){
                        Console.WriteLine("Desligando seu smartphone... \n");
                        funcionando = false;
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
            Console.WriteLine("Programa encerrado! \n");
            exibirMenu = false;
            break;            

        default:
            Console.WriteLine("Opção inválida \n");
            break;
    }
}
