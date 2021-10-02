using System;
using System.IO;
using System.Collections.Generic;

namespace Lista_automatica
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFun;
            string Comando;
            string Cocomand;
            string auxiliarList;
            string aliadaFun;
            bool sair = false;
            string nameAld;
            List<string> aliadasV = new List<string>();

            Console.WriteLine("==========================");
            Console.WriteLine("    BEM VINDO AO S.A.L     ");
            Console.WriteLine("==========================");


            Console.WriteLine("informe o caminho da pasta:");
            Console.WriteLine("Troque 1 barra por 2:");
            string caminho = Console.ReadLine();

            Console.WriteLine("Lista de presença automatica-GOPH");
            Console.WriteLine();
            Console.WriteLine("Selecione o turno:");
            Console.WriteLine("\n1-Manhã\n2-Tarde\n3-noite");
            int opc1 =Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Infome o nome do comandante:");
            Comando = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe o nome do Co.comandante:");
            Cocomand = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe o nome do auxiliar de lista:");
            auxiliarList = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe a data:");
            DateTime data = Convert.ToDateTime(Console.ReadLine());


            StreamWriter lista = new StreamWriter(caminho);
            switch (opc1)
            {
                case 1:
                    lista.WriteLine("data:"+ data);
                    lista.WriteLine("Turno:Manhã");
                    lista.WriteLine("Ciclo:01");
                    lista.WriteLine("Código:01");
                    lista.WriteLine("Hora de inicio:10:30");
                    lista.WriteLine("Hora de fim:12:00");
                    lista.WriteLine("Comandante do código:"+ Comando);
                    lista.WriteLine("Co.comandante do código:" + Cocomand);
                    lista.WriteLine("Auxiliar da lista:" + auxiliarList);
                    Console.WriteLine("Cabeçalho salvo!");
                    break;
                case 2:
                    Console.WriteLine("Qual o numero do ciclo da tarde(1/2):");
                    int opc = Convert.ToInt16(Console.ReadLine());
                    int ciclo = 0;
                    if (opc == 1)
                    {
                        ciclo = 1;
                    }else if (opc == 2)
                    {
                        ciclo = 2;
                    }
                    else { Console.WriteLine("Digite apenas 1 ou 2"); }
                    lista.WriteLine("data:" + data);
                    lista.WriteLine("Turno:tarde");
                    lista.WriteLine("Ciclo:"+ ciclo);
                    lista.WriteLine("Código: 01");
                    if(opc == 1)
                    {
                        lista.WriteLine("Hora de inicio:14:00");
                        lista.WriteLine("Hora de fim:15:00");
                    }else if(opc == 2)
                    {
                        lista.WriteLine("Hora de inicio:15:30");
                        lista.WriteLine("Hora de fim:16:30");
                    }
                    lista.WriteLine("Comandante do código:" + Comando);
                    lista.WriteLine("Co.comandante do código:" + Cocomand);
                    lista.WriteLine("Auxiliar da lista:" + auxiliarList);
                    Console.WriteLine("Cabeçalho salvo!");
                    break;
                case 3:
                    Console.WriteLine("Qual o numero do ciclo da noite(1/2/3):");
                    int opcn = Convert.ToInt16(Console.ReadLine());
                    int ciclon = 0;

                    switch (opcn)
                    {
                        case 1:
                            ciclon = 1;
                            
                            break;
                        case 2:

                            ciclon = 2;
                            break;
                        case 3:
                            ciclon = 3;
                            break;
                    }

                    lista.WriteLine("data:" + data);
                    lista.WriteLine("Turno:tarde");
                    lista.WriteLine("Ciclo:" + ciclon);
                    lista.WriteLine("Código: 01");
                    if (opcn == 1) 
                    {
                        lista.WriteLine("Hora de inicio:17:30");
                        lista.WriteLine("Hora de fim:19:00");
                    }else if (opcn == 2)
                    {
                        lista.WriteLine("Hora de inicio:19:30");
                        lista.WriteLine("Hora de fim:21:00");
                    }else if(opcn == 3)
                    {
                        lista.WriteLine("Hora de inicio:21:30");
                        lista.WriteLine("Hora de fim:23:00");
                    }
                    lista.WriteLine("Comandante do código:" + Comando);
                    lista.WriteLine("Co.comandante do código:" + Cocomand);
                    lista.WriteLine("Auxiliar da lista:" + auxiliarList);
                    Console.WriteLine("Cabeçalho salvo!");
                    break;
            }
            Console.WriteLine(" Quando terminar de preencher digite fim para ir a proxima etapa.");

            do
            {
                Console.WriteLine("Nick:");
                nomeFun = Console.ReadLine();
                if (nomeFun != "fim")
                {
                    Console.WriteLine();
                    Console.WriteLine("Aliadas visitadas:");
                    aliadaFun = Console.ReadLine();
                    lista.WriteLine("Nick:" + nomeFun);
                    lista.WriteLine("Aliadas:" + aliadaFun);
                    lista.WriteLine("-");
                    lista.WriteLine("-");
                }
                else { sair = true; }
                
            } while (sair == false);
            lista.WriteLine("Aliadas visitadas:");
            switch (opc1)
            {
                case 1:
                    lista.WriteLine(":10:30 ás 10:40");
                    lista.WriteLine(":10:40 ás 10:50");
                    lista.WriteLine(":10:50 ás 11:00");
                    lista.WriteLine(":11:00 ás 11:10");
                    lista.WriteLine(":11:10 ás 11:20");
                    lista.WriteLine(":11:20 ás 11:30");
                    lista.WriteLine(":11:30 ás 11:40");
                    lista.WriteLine(":11:40 ás 11:50");
                    lista.WriteLine(":11:50 ás 12:00");
                    break;
                case 2:
                    Console.WriteLine("Qual o numero do ciclo da tarde(1/2):");
                    int opc = Convert.ToInt16(Console.ReadLine());
                    if (opc == 1)
                    {
                        lista.WriteLine(":14:00 ás 14:10");
                        lista.WriteLine(":14:10 ás 14:20");
                        lista.WriteLine(":14:20 ás 14:30");
                        lista.WriteLine(":14:30 ás 14:40");
                        lista.WriteLine(":14:40 ás 14:50");
                        lista.WriteLine(":14:50 ás 15:00");
                    }else if(opc == 2)
                    {
                        lista.WriteLine(":15:30 ás 15:40");
                        lista.WriteLine(":15:40 ás 15:50");
                        lista.WriteLine(":15:50 ás 16:00");
                        lista.WriteLine(":16:00 ás 16:10");
                        lista.WriteLine(":16:10 ás 16:20");
                        lista.WriteLine(":16:20 ás 16:30");
                    }
                      break;
                case 3:
                    Console.WriteLine("Qual o numero do ciclo da noite(1/2/3):");
                    int opcn = Convert.ToInt16(Console.ReadLine());
                    switch (opcn)
                    {
                        case 1:
                            lista.WriteLine(":17:30 ás 17:40");
                            lista.WriteLine(":17:40 ás 17:50");
                            lista.WriteLine(":17:50 ás 18:00");
                            lista.WriteLine(":18:00 ás 18:10");
                            lista.WriteLine(":18:10 ás 18:20");
                            lista.WriteLine(":18:20 ás 18:30");
                            lista.WriteLine(":18:30 ás 18:40");
                            lista.WriteLine(":18:40 ás 18:50");
                            lista.WriteLine(":18:50 ás 19:00");
                            break;
                        case 2:
                            lista.WriteLine(":19:30 ás 19:40");
                            lista.WriteLine(":19:40 ás 19:50");
                            lista.WriteLine(":19:50 ás 20:00");
                            lista.WriteLine(":20:00 ás 20:10");
                            lista.WriteLine(":20:10 ás 20:20");
                            lista.WriteLine(":20:20 ás 20:30");
                            lista.WriteLine(":20:30 ás 20:40");
                            lista.WriteLine(":20:40 ás 20:50");
                            lista.WriteLine(":20:50 ás 21:00");
                            break;
                        case 3:
                            lista.WriteLine(":21:30 ás 21:40");
                            lista.WriteLine(":21:40 ás 21:50");
                            lista.WriteLine(":21:50 ás 22:00");
                            lista.WriteLine(":22:00 ás 22:10");
                            lista.WriteLine(":22:10 ás 22:20");
                            lista.WriteLine(":22:20 ás 22:30");
                            lista.WriteLine(":22:30 ás 22:40 ");
                            lista.WriteLine(":22:40 ás 22:50 ");
                            lista.WriteLine(":22:50 ás 23:00 ");
                            break;
                    }
                    
                    break;
            }
            lista.WriteLine();
            lista.WriteLine();
            lista.WriteLine();
            lista.WriteLine("Lista Gerada pelo Sistema Automatico de Lista(S.A.L). BY:JS/Deadpool533");

            Console.WriteLine("Lista Salva no caminho desejado!" + caminho);
            lista.Close();
        }
    }
}
