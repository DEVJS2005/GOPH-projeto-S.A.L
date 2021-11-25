using System;
using System.IO;
using System.Collections.Generic;

namespace Lista_automatica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis do cabeçalho:
            string nomeFun;
            string Comando;
            string Cocomand;
            string auxiliarList;
            string aliadaFun;
            bool sair = false;
            // Variaveis do horario de ciclo:
            int opc;
            int opc1;
            int opcn;
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // Lista de aliadas:
            List<String> aliadaVi = new List<string>();
            string aliadaAux;
            


            Console.WriteLine("==========================");
            Console.WriteLine("    BEM VINDO AO S.A.L     ");
            Console.WriteLine("==========================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lista de presença automatica-GOPH");
            Console.WriteLine();
            Console.WriteLine("Selecione o turno:");
            Console.WriteLine("\n1-Manhã\n2-Tarde\n3-noite");
            opc1 =Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Infome o nome do comandante:");
            Comando = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe o nome do Co.comandante:");
            Cocomand = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe o nome do auxiliar de lista:");
            auxiliarList = Console.ReadLine();
            Console.WriteLine();
            string data = DateTime.Now.ToString("dd-MM-yyyy");


            StreamWriter lista = new StreamWriter(desktop+"\\Lista_Automatica.txt");    

            Console.Clear();
            switch (opc1)
            {
                case 1:
                    lista.WriteLine("Data:"+ data);
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
                     opc = Convert.ToInt16(Console.ReadLine());
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
                    opcn = Convert.ToInt16(Console.ReadLine());
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

                    lista.WriteLine("Data:" + data);
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
                    Console.WriteLine("");
                    Console.WriteLine("Cabeçalho salvo!");
                    break;
            }
            Console.WriteLine("=========================================================================");
            Console.WriteLine("    Quando terminar de preencher digite fim para ir a proxima etapa.     ");
            Console.WriteLine("=========================================================================");
            lista.WriteLine("Funcionários presentes no CÓDIGO 01: (Registrados no Sistema):");

            do
            {
                Console.Write("Nick:");
                nomeFun = Console.ReadLine();
                if (nomeFun != "fim")
                {
                    Console.WriteLine();
                    Console.Write("Aliadas visitadas:");
                    aliadaFun = Console.ReadLine();
                    if(aliadaFun == "")
                    {
                        Console.WriteLine("*Você informou o campo vazio! informe novamente*");
                        aliadaFun = Console.ReadLine();
                    }
                    lista.WriteLine("Nick:" + nomeFun);
                    lista.WriteLine("Aliadas:" + aliadaFun);
                    lista.WriteLine("-");
                    lista.WriteLine("-");
                }
                else { sair = true; }
                
            } while (sair == false);
            
            Console.WriteLine("===============================================================================");
            Console.WriteLine("       Informa o nome das aliadas um por um,após digite fim para continuar!    ");
            Console.WriteLine("===============================================================================");

            int i = 0;

            Console.WriteLine("Informe:");
            do
            {
                i++;
                Console.Write("{0}ª:",i);
                aliadaAux =  Console.ReadLine();
                if (aliadaAux != "fim")
                {
                    aliadaVi.Add(aliadaAux);
                }
            } while (aliadaAux != "fim");
            if (aliadaVi.Count < 9)
            {
                while (aliadaVi.Count < 9)
                {
                    aliadaVi.Add("");
                }
            }


            lista.WriteLine("Aliadas visitadas:");
            switch (opc1)
            {
                case 1:
                    lista.WriteLine( "{0}:10:30 ás 10:40", aliadaVi[0]);
                    lista.WriteLine( "{0}:10:40 ás 10:50", aliadaVi[1]);
                    lista.WriteLine("{0}:10:50 ás 11:00", aliadaVi[2]);
                    lista.WriteLine("{0}:11:00 ás 11:10", aliadaVi[3]);
                    lista.WriteLine("{0}:11:10 ás 11:20", aliadaVi[4]);
                    lista.WriteLine("{0}:11:20 ás 11:30", aliadaVi[5]);
                    lista.WriteLine("{0}:11:30 ás 11:40", aliadaVi[6]);
                    lista.WriteLine("{0}:11:40 ás 11:50", aliadaVi[7]);
                    lista.WriteLine("{0}:11:50 ás 12:00", aliadaVi[8]);

                    
                    break;
                case 2:
                    Console.WriteLine("Confirme o numero do ciclo da tarde(1/2):");
                    opc = Convert.ToInt16(Console.ReadLine());
                    if (opc == 1)
                    {
                        lista.WriteLine("{0}:14:00 ás 14:10", aliadaVi[0]);
                        lista.WriteLine("{0}:14:10 ás 14:20", aliadaVi[1]);
                        lista.WriteLine("{0}:14:20 ás 14:30",aliadaVi[2]);
                        lista.WriteLine("{0}:14:30 ás 14:40", aliadaVi[3]);
                        lista.WriteLine("{0}:14:40 ás 14:50", aliadaVi[4]);
                        lista.WriteLine("{0}:14:50 ás 15:00", aliadaVi[5]);
                       
                    }
                    else if(opc == 2)
                    {
                        lista.WriteLine("{0}:15:30 ás 15:40", aliadaVi[0]);
                        lista.WriteLine("{0}:15:40 ás 15:50", aliadaVi[1]);
                        lista.WriteLine("{0}:15:50 ás 16:00", aliadaVi[2]);
                        lista.WriteLine("{0}:16:00 ás 16:10", aliadaVi[3]);
                        lista.WriteLine("{0}:16:10 ás 16:20", aliadaVi[4]);
                        lista.WriteLine("{0}:16:20 ás 16:30", aliadaVi[5]);
                    
                    }
                      break;
                case 3:
                    Console.WriteLine("Confirme o numero do ciclo da noite(01/02/03):");
                    opcn = Convert.ToInt16(Console.ReadLine());
                    switch (opcn)
                    {
                        case 1:
                            lista.WriteLine("{0}:17:30 ás 17:40", aliadaVi[0]);
                            lista.WriteLine("{0}:17:40 ás 17:50", aliadaVi[1]);
                            lista.WriteLine("{0}:17:50 ás 18:00", aliadaVi[2]);
                            lista.WriteLine("{0}:18:00 ás 18:10", aliadaVi[3]);
                            lista.WriteLine("{0}:18:10 ás 18:20", aliadaVi[4]);
                            lista.WriteLine("{0}:18:20 ás 18:30", aliadaVi[5]);
                            lista.WriteLine("{0}:18:30 ás 18:40", aliadaVi[6]);
                            lista.WriteLine("{0}:18:40 ás 18:50", aliadaVi[7]);
                            lista.WriteLine("{0}:18:50 ás 19:00", aliadaVi[8]);
                            break;

                        case 2:
                            lista.WriteLine("{0}:19:30 ás 19:40", aliadaVi[0]);
                            lista.WriteLine("{0}:19:40 ás 19:50", aliadaVi[1]);
                            lista.WriteLine("{0}:19:50 ás 20:00", aliadaVi[2]);
                            lista.WriteLine("{0}:20:00 ás 20:10", aliadaVi[3]);
                            lista.WriteLine("{0}:20:10 ás 20:20", aliadaVi[4]);
                            lista.WriteLine("{0}:20:20 ás 20:30", aliadaVi[5]);
                            lista.WriteLine("{0}:20:30 ás 20:40", aliadaVi[6]);
                            lista.WriteLine("{0}:20:40 ás 20:50", aliadaVi[7]);
                            lista.WriteLine("{0}:20:50 ás 21:00", aliadaVi[8]);
                            break;

                        case 3:
                            lista.WriteLine("{0}:21:30 ás 21:40", aliadaVi[0]);
                            lista.WriteLine("{0}:21:40 ás 21:50", aliadaVi[1]);
                            lista.WriteLine("{0}:21:50 ás 22:00", aliadaVi[2]);
                            lista.WriteLine("{0}:22:00 ás 22:10", aliadaVi[3]);
                            lista.WriteLine("{0}:22:10 ás 22:20", aliadaVi[4]);
                            lista.WriteLine("{0}:22:20 ás 22:30", aliadaVi[5]);
                            lista.WriteLine("{0}:22:30 ás 22:40 ", aliadaVi[6]);
                            lista.WriteLine("{0}:22:40 ás 22:50 ", aliadaVi[7]);
                            lista.WriteLine("{0}:22:50 ás 23:00 ", aliadaVi[8]);
                            break;
                    }
                    
                    break;
            }
            lista.WriteLine();
            lista.WriteLine();
            lista.WriteLine();
            lista.WriteLine("Lista Gerada pelo Sistema Automático de Lista(S.A.L).");
            lista.WriteLine("By:JS/Deadpool533");
            lista.WriteLine();
            lista.WriteLine("Atenciosamente "+ Comando);

            Console.WriteLine("Lista Salva no caminho desejado!" + desktop);
            lista.Close();

            Console.WriteLine("Aperte Enter para fechar.");
            Console.ReadKey();
        }
    }
    
}
