using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convetHEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = string.Empty;
            string RelatorioBruto1 = string.Empty;
            string RelatorioBruto2 = string.Empty;
            string RelatorioBruto3 = string.Empty;
            string RelatorioParcial1 = string.Empty;
            string RelatorioParcial2 = string.Empty;
            string RelatorioParcial3 = string.Empty;

            string RelatorioFinal1 = string.Empty;
            string RelatorioFinal2 = string.Empty;
            string RelatorioFinal3 = string.Empty;


            string RXPronta = string.Empty;


            int decValue;
            int index = 0;
            string caratcter = string.Empty;
            


            string Bruta5 = "54;"+
                            "23;2D;01;14;04;06;0E;17;2B;00;00;00;00;00;00;00;00;70;A2;D1;41;79;AF;80;42;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                            "23;19;02;14;04;06;0E;17;31;00;00;00;00;00;00;A0;BF;00;00;00;00;00;00;00;00;19;" +
                            "23;0D;03;14;04;06;0E;17;36;00;00;00;00;0D;" +
                            "45;52;4D;49;4E;41;4E;44;4F;";



            OrganizaString(Bruta5);

           

            void OrganizaString(string Bruta)
            {
                Console.WriteLine("entrei na função");

                if (Bruta.Contains("53;54;41;52;54;") && Bruta.Contains("54;45;52;4D;49;4E;41;4E;44;4F;"))
                {
                    Bruta = Bruta.Replace("53;54;41;52;54;", "");
                    Bruta = Bruta.Replace("54;45;52;4D;49;4E;41;4E;44;4F;", "/");

                    String[] Aux = Bruta.Split('/');

                    Bruta = Aux[0] + "23";

                    Console.WriteLine("Tem Start e Final");
                    Console.WriteLine(Bruta);
                    RXPronta = Bruta;
                }
                else if (Bruta.Contains("54;45;52;4D;49;4E;41;4E;44;4F;"))
                {
                    Console.WriteLine("Tem final apenas");


                    Bruta = Bruta.Replace("54;45;52;4D;49;4E;41;4E;44;4F;", "/");

                    String[] Aux = Bruta.Split('/');
                    Bruta = Aux[1] + Aux[0] + "23";

                    Console.WriteLine(Bruta);
                    Console.WriteLine();

                    String[] ArrayHex = Bruta.Split(';');

                    int index1 = Array.IndexOf(ArrayHex, "23");

                    Console.WriteLine(index1);
                    Console.WriteLine(ArrayHex[index1 + 1]);


                    decValue = int.Parse(ArrayHex[index1 + 1], System.Globalization.NumberStyles.HexNumber);
                    Console.WriteLine(decValue);
                    Console.WriteLine(ArrayHex[decValue]);
                    Console.WriteLine(ArrayHex[decValue + 1]);


                    if (ArrayHex[index1 + 1] == ArrayHex[decValue])
                    {
                        Console.WriteLine("E valida");


                        Console.WriteLine(Bruta);
                        Console.WriteLine();


                        RXPronta = Bruta;
                    }
                    else
                    {
                        Console.WriteLine("Tem Lixo");
                        ArrayHex[index1] = "/";
                        string aux = "";
                        for (int i = 0; i < ArrayHex.Length - 1; i++)
                        {
                            aux += ArrayHex[i] + ";";
                        }

                        //Console.WriteLine(aux);


                        String[] Aux1 = aux.Split('/');
                        aux = Aux1[1] + "23";


                        Console.WriteLine(aux);

                        ArrayHex = aux.Split(';');

                        index1 = Array.IndexOf(ArrayHex, "23");
                        Console.WriteLine(index1);
                        Console.WriteLine(ArrayHex[index1]);
                        ArrayHex[index1 - 1] = "/";

                        aux = "";
                        for (int i = 0; i < ArrayHex.Length - 1; i++)
                        {
                            aux += ArrayHex[i] + ";";
                        }

                        // Console.WriteLine(aux);


                        Aux1 = aux.Split('/');
                        aux = Aux1[1] + "23";
                        aux = aux.Remove(0, 1);
                        Console.WriteLine(aux);
                        Console.WriteLine();


                        RXPronta = aux;
                    }

                }
                else if (Bruta.Contains("54;45;52;4D;49;4E;41;4E;44") && Bruta.Substring(Bruta.Length-3)=="4F;")
                {
                    Console.WriteLine("Tem apenas TERMINAND ");

                    Bruta = Bruta.Substring(0, Bruta.Length - 3);
                    Bruta = Bruta.Replace("54;45;52;4D;49;4E;41;4E;44", "/");


                    Console.WriteLine(Bruta);
                    Console.WriteLine();

                    String[] Aux = Bruta.Split('/');
                    Bruta = Aux[1] + "/" + Aux[0];

                    Bruta = Bruta.Replace("/", "54;45;52;4D;49;4E;41;4E;44;4F;");

                    Bruta = Bruta.Remove(0, 1);
                    Console.WriteLine(Bruta);
                    Console.WriteLine();

                    OrganizaString(Bruta);

                }
                else if (Bruta.Contains("54;45;52;4D;49;4E;41;4E") && Bruta.Substring(Bruta.Length - 6) =="44;4F;")
                 {
                     Console.WriteLine("Tem apenas TERMINAN ");

                     Bruta = Bruta.Substring(0, Bruta.Length - 6);
                     Bruta = Bruta.Replace("54;45;52;4D;49;4E;41;4E", "/");

                     Console.WriteLine(Bruta);

                     Console.WriteLine();

                     String[] Aux = Bruta.Split('/');

                     Bruta = Aux[1] + "/" + Aux[0];

                     Bruta = Bruta.Replace("/", "54;45;52;4D;49;4E;41;4E;44;4F;");

                     Bruta = Bruta.Remove(0, 1);

                     Console.WriteLine(Bruta);

                     Console.WriteLine();

                     OrganizaString(Bruta);

                 }
                else if (Bruta.Contains("54;45;52;4D;49;4E;41") && Bruta.Substring(Bruta.Length - 9) == "4E;44;4F;") 
                {
                    Console.WriteLine("Tem apenas TERMINA ");

                    Bruta = Bruta.Substring(0, Bruta.Length - 9);
                    Bruta = Bruta.Replace("54;45;52;4D;49;4E;41", "/");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();

                    String[] Aux = Bruta.Split('/');

                    Bruta = Aux[1] + "/" + Aux[0];

                    Bruta = Bruta.Replace("/", "54;45;52;4D;49;4E;41;4E;44;4F;");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();
                    Bruta = Bruta.Remove(0, 1);
                    OrganizaString(Bruta);

                }
                 else if (Bruta.Contains("54;45;52;4D;49;4E") && Bruta.Substring(Bruta.Length - 12) == "41;4E;44;4F;")
                {
                    Console.WriteLine("Tem apenas TERMIN");

                    Bruta = Bruta.Substring(0, Bruta.Length - 12);

                    Bruta = Bruta.Replace("54;45;52;4D;49;4E", "/");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();

                    String[] Aux = Bruta.Split('/');

                    Bruta = Aux[1] + "/" + Aux[0];

                    Bruta = Bruta.Replace("/", "54;45;52;4D;49;4E;41;4E;44;4F;");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();
                    Bruta = Bruta.Remove(0, 1);
                    OrganizaString(Bruta);

                }
                else if (Bruta.Contains("54;45;52;4D;49") && Bruta.Substring(Bruta.Length - 15) == "4E;41;4E;44;4F;")
                {
                    Console.WriteLine("Tem apenas TERMI");

                    Bruta = Bruta.Substring(0, Bruta.Length - 15);

                    Bruta = Bruta.Replace("54;45;52;4D;49", "/");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();

                    String[] Aux = Bruta.Split('/');

                    Bruta = Aux[1] + "/" + Aux[0];

                    Bruta = Bruta.Replace("/", "54;45;52;4D;49;4E;41;4E;44;4F;");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();
                    Bruta = Bruta.Remove(0, 1);
                    OrganizaString(Bruta);

                }
                else if (Bruta.Contains("54;45;52;4D") && Bruta.Substring(Bruta.Length - 18) == "49;4E;41;4E;44;4F;")
                {
                    Console.WriteLine("Tem apenas TERM");

                    Bruta = Bruta.Substring(0, Bruta.Length - 18);

                    Bruta = Bruta.Replace("54;45;52;4D", "/");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();

                    String[] Aux = Bruta.Split('/');

                    Bruta = Aux[1] + "/" + Aux[0];

                    Bruta = Bruta.Replace("/", "54;45;52;4D;49;4E;41;4E;44;4F;");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();
                    Bruta = Bruta.Remove(0, 1);
                    OrganizaString(Bruta);

                }
                else if (Bruta.Contains("54;45;52") && Bruta.Substring(Bruta.Length - 21) == "4D;49;4E;41;4E;44;4F;")
                {
                    Console.WriteLine("Tem apenas TER");

                    Bruta = Bruta.Substring(0, Bruta.Length - 21);

                    Bruta = Bruta.Replace("54;45;52", "/");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();

                    String[] Aux = Bruta.Split('/');

                    Bruta = Aux[1] + "/" + Aux[0];

                    Bruta = Bruta.Replace("/", "54;45;52;4D;49;4E;41;4E;44;4F;");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();
                    Bruta = Bruta.Remove(0, 1);
                    OrganizaString(Bruta);

                }
                else if (Bruta.Contains("54;45") && Bruta.Substring(Bruta.Length - 24) == "52;4D;49;4E;41;4E;44;4F;")
                {
                    Console.WriteLine("Tem apenas TE");

                    Bruta = Bruta.Remove(0,6);

                    Bruta = Bruta.Replace("52;4D;49;4E;41;4E;44;4F", "/");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();

                    String[] Aux = Bruta.Split('/');

                    Bruta = Aux[1] + "/" + Aux[0];

                    Bruta = Bruta.Replace("/", "54;45;52;4D;49;4E;41;4E;44;4F;");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();
                    Bruta = Bruta.Remove(0, 1);
                    OrganizaString(Bruta);

                }
                else if (Bruta.Contains("54") && Bruta.Substring(Bruta.Length - 27) == "45;52;4D;49;4E;41;4E;44;4F;")
                {
                    Console.WriteLine("Tem apenas T");

                    Bruta = Bruta.Remove(0, 3);

                    Bruta = Bruta.Replace("45;52;4D;49;4E;41;4E;44;4F", "/");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();

                    String[] Aux = Bruta.Split('/');

                    Bruta = Aux[1] + "/" + Aux[0];

                    Bruta = Bruta.Replace("/", "54;45;52;4D;49;4E;41;4E;44;4F;");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();
                    Bruta = Bruta.Remove(0, 1);
                    OrganizaString(Bruta);

                }

            }

            //Hextest = Hextest.Replace("53;54;41;52;54;", "Start ");
            //Hextest = Hextest.Replace("46; 49; 4E; 41; 4C", "Fim");


            //String[] ArrayHex = Hextest.Split(';');
            //Console.WriteLine(Hextest.Length.ToString());



            scan(index, RXPronta);



            void scan(int Index, string Text)
            {

                String[] ArrayHex = Text.Trim().Split(';');



                string aux = ArrayHex[Index];

                // Console.WriteLine(Index);



                if (aux == "23")
                {


                    decValue = int.Parse(ArrayHex[Index + 1], System.Globalization.NumberStyles.HexNumber);
                    //Console.WriteLine("Valor HEX:  " + ArrayHex[Index + 1]);
                    //Console.WriteLine();
                    //Console.WriteLine("Valor Decimal:  " + decValue);
                    // Console.WriteLine();

                    //Console.WriteLine(ArrayHex[Index +1]);
                    // Console.WriteLine(Convert.ToByte(decValue));

                    //Console.WriteLine(ArrayHex[Index + decValue]);

                    if (ArrayHex[Index] == "23" && ArrayHex[Index + decValue] == ArrayHex[Index + 1] && ArrayHex[Index + 2] == "01")
                    {

                        // Console.WriteLine("Sim:" + ArrayHex[decValue + 2]);
                        // Console.WriteLine();
                        Relatorio1(Index, decValue + Index);


                    }
                    else
                    {

                        //Console.WriteLine("Nao e Relatorio-1:" + ArrayHex[Index]);
                    }

                    if (ArrayHex[Index] == "23" && ArrayHex[Index + decValue] == ArrayHex[Index + 1] && ArrayHex[Index + 2] == "02")
                    {

                        // Console.WriteLine("Sim:" + ArrayHex[decValue + 2]);
                        // Console.WriteLine();
                        Relatorio2(Index, decValue + Index);


                    }
                    else
                    {

                        //  Console.WriteLine("Nao e Relatorio-2" + ArrayHex[Index]);
                    }


                    if (ArrayHex[Index] == "23" && ArrayHex[Index + decValue] == ArrayHex[Index + 1] && ArrayHex[Index + 2] == "03")
                    {

                        // Console.WriteLine("Sim:" + ArrayHex[decValue + 2]);
                        // Console.WriteLine();
                        Relatorio3(Index, decValue + Index);


                    }
                    else
                    {

                        // Console.WriteLine("Nao e Relatorio-3" + ArrayHex[Index]);
                    }


                }
                else
                {
                    Console.WriteLine("AUX nao e igual a 23");
                    Console.WriteLine(ArrayHex[Index]);
                }




                //Console.WriteLine(Hextest);
                // Console.WriteLine("Removido");

                void Relatorio1(int Inicial, int Final)
                {

                    
                    Final = Final + 1;


                    for (int x = Inicial; x < Final; x++)
                    {
                        linha += ArrayHex[x] + ";";

                    }

                    caratcter += linha;
                    RelatorioBruto1 = linha.Remove(0, 9);
                    RelatorioBruto1 = RelatorioBruto1.Substring(0, RelatorioBruto1.Length - 4);
                    


                    String[] DadosConvert = RelatorioBruto1.Split(';');

                    string dataConvert = string.Empty;
                    for (int i = 0; i < 3; i++)
                    {
                        // Console.WriteLine(DadosConvert[i]);
                        int Data = int.Parse(DadosConvert[i], System.Globalization.NumberStyles.HexNumber);

                        dataConvert += Data.ToString("00") + "-";
                    }
                    dataConvert = dataConvert.Substring(0, dataConvert.Length - 1);
                    //Console.WriteLine(dataConvert);



                    string HoraConvert = string.Empty;
                    for (int i = 3; i < 6; i++)
                    {
                        // Console.WriteLine(DadosConvert[i]);
                        int Hora = int.Parse(DadosConvert[i], System.Globalization.NumberStyles.HexNumber);

                        HoraConvert += Hora.ToString("00") + ":";
                    }
                    HoraConvert = HoraConvert.Substring(0, HoraConvert.Length - 1);
                    //Console.WriteLine(HoraConvert);

                    RelatorioParcial1 = dataConvert +";"+ HoraConvert+";";

                    string Dados = string.Empty;

                    for (int i = 0; i < DadosConvert.Length; i++)
                    {
                        Dados += DadosConvert[i]+";" ;

                    }
                    Dados = Dados.Remove(0, 18);

                   // Console.WriteLine(Dados);

                   // Console.WriteLine(Dados.Length);


                    string DadosSeparados = string.Empty;

                    for (int i = 0; i < Dados.Length; i = i + 12)
                    {
                        DadosSeparados = Dados.Substring(i, 12);
                       // Console.WriteLine("Dados Separados= "+DadosSeparados);

                        string hexOrdenado = string.Empty;
                        string hexString = DadosSeparados;

                        String[] bytes = hexString.Split(';');

                        for (int x = 3; x >= 0; x--)
                        {

                            hexOrdenado += bytes[x];
                        }

                        uint num = uint.Parse(hexOrdenado, System.Globalization.NumberStyles.AllowHexSpecifier);
                        byte[] floatVals = BitConverter.GetBytes(num);
                        float f = BitConverter.ToSingle(floatVals, 0);

                        RelatorioParcial1 += f+";";

                        

                        //Console.WriteLine("float Convertido = {0}", f);
                    }

                    RelatorioFinal1 += RelatorioParcial1 + "\r\n";
                   //Console.WriteLine(RelatorioBrutoFinal1);




                    if (caratcter.Length == RXPronta.Length - 2)
                    {
                        //Console.WriteLine("Linha = " + linha);
                        linha = "";

                        RelatoriosBrtos();
                    }
                    else
                    {

                        // Console.WriteLine("Linha = " + linha);
                        linha = "";
                        scan(Final, RXPronta);
                    }




                }


                void Relatorio2(int Inicial, int Final)
                {

                    // Inicial = Inicial + 2;
                    Final = Final + 1;


                    for (int x = Inicial; x < Final; x++)
                    {
                        linha += ArrayHex[x] + ";";

                    }

                    caratcter += linha;
                    RelatorioBruto2 += linha.Remove(0, 9);
                    RelatorioBruto2 = RelatorioBruto2.Substring(0, RelatorioBruto2.Length - 4);




                    String[] DadosConvert = RelatorioBruto2.Split(';');

                    string dataConvert = string.Empty;
                    for (int i = 0; i < 3; i++)
                    {
                       
                        int Data = int.Parse(DadosConvert[i], System.Globalization.NumberStyles.HexNumber);

                        dataConvert += Data.ToString("00") + "-";
                    }
                    dataConvert = dataConvert.Substring(0, dataConvert.Length - 1);
                    



                    string HoraConvert = string.Empty;
                    for (int i = 3; i < 6; i++)
                    {
                        
                        int Hora = int.Parse(DadosConvert[i], System.Globalization.NumberStyles.HexNumber);

                        HoraConvert += Hora.ToString("00") + ":";
                    }
                    HoraConvert = HoraConvert.Substring(0, HoraConvert.Length - 1);
                    

                    RelatorioParcial2 = dataConvert + ";" + HoraConvert + ";";

                    string Dados = string.Empty;

                    for (int i = 0; i < DadosConvert.Length; i++)
                    {
                        Dados += DadosConvert[i] + ";";

                    }
                    Dados = Dados.Remove(0, 18);

                    ;


                    string DadosSeparados = string.Empty;

                    for (int i = 0; i < Dados.Length; i = i + 12)
                    {
                        DadosSeparados = Dados.Substring(i, 12);
                       

                        string hexOrdenado = string.Empty;
                        string hexString = DadosSeparados;

                        String[] bytes = hexString.Split(';');

                        for (int x = 3; x >= 0; x--)
                        {

                            hexOrdenado += bytes[x];
                        }

                        uint num = uint.Parse(hexOrdenado, System.Globalization.NumberStyles.AllowHexSpecifier);
                        byte[] floatVals = BitConverter.GetBytes(num);
                        float f = BitConverter.ToSingle(floatVals, 0);

                        RelatorioParcial2 += f + ";";



                        
                    }

                    RelatorioFinal2 += RelatorioParcial2 + "\r\n";
                    


                    if (caratcter.Length == RXPronta.Length - 2)
                    {
                        
                        linha = "";


                        RelatoriosBrtos();
                    }
                    else
                    {

                        
                        linha = "";
                        scan(Final, RXPronta);
                    }




                }



                void Relatorio3(int Inicial, int Final)
                {

                   
                    Final = Final + 1;


                    for (int x = Inicial; x < Final; x++)
                    {
                        linha += ArrayHex[x] + ";";

                    }

                    caratcter += linha;
                    RelatorioBruto3 += linha.Remove(0, 9);
                    RelatorioBruto3 = RelatorioBruto3.Substring(0, RelatorioBruto3.Length - 4);

                    String[] DadosConvert = RelatorioBruto3.Split(';');

                    string dataConvert = string.Empty;
                    for (int i = 0; i < 3; i++)
                    {
                       
                        int Data = int.Parse(DadosConvert[i], System.Globalization.NumberStyles.HexNumber);

                        dataConvert += Data.ToString("00") + "-";
                    }
                    dataConvert = dataConvert.Substring(0, dataConvert.Length - 1);
                    



                    string HoraConvert = string.Empty;
                    for (int i = 3; i < 6; i++)
                    {
                        
                        int Hora = int.Parse(DadosConvert[i], System.Globalization.NumberStyles.HexNumber);

                        HoraConvert += Hora.ToString("00") + ":";
                    }
                    HoraConvert = HoraConvert.Substring(0, HoraConvert.Length - 1);
                  

                    RelatorioParcial3 = dataConvert + ";" + HoraConvert + ";";

                    string Dados = string.Empty;

                    for (int i = 0; i < DadosConvert.Length; i++)
                    {
                        Dados += DadosConvert[i] + ";";

                    }
                    Dados = Dados.Remove(0, 18);

                    


                    string DadosSeparados = string.Empty;

                    for (int i = 0; i < Dados.Length; i = i + 12)
                    {
                        DadosSeparados = Dados.Substring(i, 12);
                        

                        string hexOrdenado = string.Empty;
                        string hexString = DadosSeparados;

                        String[] bytes = hexString.Split(';');

                        for (int x = 3; x >= 0; x--)
                        {

                            hexOrdenado += bytes[x];
                        }

                        uint num = uint.Parse(hexOrdenado, System.Globalization.NumberStyles.AllowHexSpecifier);
                        byte[] floatVals = BitConverter.GetBytes(num);
                        float f = BitConverter.ToSingle(floatVals, 0);

                        RelatorioParcial3 += f + ";";
   
                    }

                    RelatorioFinal3 += RelatorioParcial3 + "\r\n";
                    
                    if (caratcter.Length == RXPronta.Length - 2)
                    {
                        
                        linha = "";

                        RelatoriosBrtos();
                    }
                    else
                    {

                        
                        linha = "";
                        scan(Final, RXPronta);
                    }




                }

                void RelatoriosBrtos()
                {

                    Console.WriteLine("Relatorio-1: ");
                    Console.WriteLine();
                    Console.WriteLine(RelatorioFinal1);



                    Console.WriteLine("Relatorio-2: ");
                    Console.WriteLine();
                    Console.WriteLine(RelatorioFinal2);


                    Console.WriteLine("Relatorio-3: ");
                    Console.WriteLine();
                    Console.WriteLine(RelatorioFinal3);
                    Console.WriteLine("Scan total");

                }

            }


            Console.ReadKey();



        }
    }



}
