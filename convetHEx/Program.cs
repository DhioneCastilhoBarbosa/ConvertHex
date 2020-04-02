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
            int dec;
            int index = 0;
            string caratcter = string.Empty;
            string Hextest =
            "23;0D;03;14;03;1F;10;2C;2B;00;00;00;00;0D;" + // tipo 3
            "23;2D;01;14;03;1F;02;2E;12;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;01;2D;" + //tipo 1
            "23;2D;01;14;03;1F;02;2E;17;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;A0;3F;00;3C;1C;C6;1C;23;C2;44;00;00;00;02;2D;" +
            "23;19;02;14;03;1F;10;29;34;00;00;00;00;00;00;00;00;00;00;00;00;00;00;00;00;19;" + //tipo 2
            "23;2D;01;14;03;1F;02;2E;1C;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;03;2D;" +
            "23;2D;01;14;03;1F;02;2E;20;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;04;2D;23"; // final tem que acrecentar #

            // Console.WriteLine(Hextest);
            //  Console.WriteLine("completa");
            // Console.WriteLine();



            string Bruta0 = "53;54;41;52;54;" +
                            "23;2D;01;14;03;1F;02;2E;12;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                            "23;2D;01;14;03;1F;02;2E;17;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;A0;3F;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                            "23;2D;01;14;03;1F;02;2E;1C;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                            "23;2D;01;14;03;1F;02;2E;20;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                            "46;49;4E;41;4C;";



            string Bruta1 = "46;49;4E;41;4C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                            "23;2D;01;14;03;1F;02;2E;12;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                            "23;2D;01;14;03;1F;02;2E;17;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;A0;3F;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                            "23;2D;01;14;03;1F;02;2E;1C;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                            "23;2D;01;14;03;1F;02;2E;20;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;";

            string Bruta2 =
                          "23;2D;01;14;03;1F;02;2E;12;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;04;2D;" +
                           "46;49;4E;41;4C;" +
                          "23;2D;01;14;03;1F;02;2E;17;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;A0;3F;00;3C;1C;C6;1C;23;C2;44;00;00;00;01;2D;" +
                          "23;2D;01;14;03;1F;02;2E;1C;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;02;2D;" +
                          "23;2D;01;14;03;1F;02;2E;20;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;03;2D;";


            string Bruta3 = "41;4C;" + // "46;49;4E;41;4C;"
                         "23;2D;01;14;03;1F;02;2E;12;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                         "23;2D;01;14;03;1F;02;2E;17;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;A0;3F;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                         "23;2D;01;14;03;1F;02;2E;1C;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;" +
                         "23;2D;01;14;03;1F;02;2E;20;00;00;00;00;00;00;00;00;00;3C;1C;C6;00;3C;1C;C6;00;00;00;00;00;00;00;00;00;3C;1C;C6;1C;23;C2;44;00;00;00;00;2D;46;49;4E;";

            OrganizaString(Bruta3);

            void OrganizaString(string Bruta)
            {
                Console.WriteLine("entrei na função");

                if (Bruta.Contains("53;54;41;52;54;") && Bruta.Contains("46;49;4E;41;4C;"))
                {
                    Bruta = Bruta.Replace("53;54;41;52;54;", "");
                    Bruta = Bruta.Replace("46;49;4E;41;4C;", "/");

                    String[] Aux = Bruta.Split('/');

                    Bruta = Aux[0] + "23";

                    Console.WriteLine("Tem Start e Final");
                    Console.WriteLine(Bruta);
                    RXPronta = Bruta;
                }
                else if (Bruta.Contains("46;49;4E;41;4C;"))
                {
                    Console.WriteLine("Tem final apenas");


                    Bruta = Bruta.Replace("46;49;4E;41;4C;", "/");

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
                else if (Bruta.Contains("49;4E;41;4C"))
                {
                    Console.WriteLine("Tem apenas INAL ");

                    Bruta = Bruta.Replace("49;4E;41;4C", "/");


                    Console.WriteLine(Bruta);
                    Console.WriteLine();

                    String[] Aux = Bruta.Split('/');
                    Bruta = Aux[1] + "/" + Aux[0];

                    Bruta = Bruta.Replace("/", "49;4E;41;4C");

                    Bruta = Bruta.Remove(0, 1);
                    Console.WriteLine(Bruta);
                    Console.WriteLine();

                    OrganizaString(Bruta);

                }
                else if (Bruta.Contains("4E;41;4C"))
                {
                    Console.WriteLine("Tem apenas NAL ");


                    Bruta = Bruta.Replace("4E;41;4C", "/");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();

                    String[] Aux = Bruta.Split('/');

                    Bruta = Aux[1] + "/" + Aux[0];

                    Bruta = Bruta.Replace("/", "4E;41;4C");

                    Bruta = Bruta.Remove(0, 1);

                    Console.WriteLine(Bruta);

                    Console.WriteLine();

                    OrganizaString(Bruta);

                }
                else if (Bruta.Contains("46;49;4E"))
                {
                    Console.WriteLine("Tem apenas FIN ");


                    Bruta = Bruta.Replace("46;49;4E", "/");

                    Console.WriteLine(Bruta);

                    Console.WriteLine();

                    String[] Aux = Bruta.Split('/');

                    Bruta = Aux[1] + "/" + Aux[0];

                    Bruta = Bruta.Replace("/", "46;49;4E;");

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

                    // Inicial = Inicial + 2;
                    Final = Final + 1;


                    for (int x = Inicial; x < Final; x++)
                    {
                        linha += ArrayHex[x] + ";";

                    }

                    caratcter += linha;
                    RelatorioBruto1 = linha.Remove(0, 9);
                    RelatorioBruto1 = RelatorioBruto1.Substring(0, RelatorioBruto1.Length - 4);
                    // Console.WriteLine("Caracter = " + caratcter.Length);
                    //Console.WriteLine("String = " + Hextest.Length);


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
                    RelatorioBruto2 = RelatorioBruto2.Substring(0, RelatorioBruto2.Length - 4) + "\r\n";




                    //Console.WriteLine("Caracter = " + caratcter.Length);
                    // Console.WriteLine("String = " + Hextest.Length);


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



                void Relatorio3(int Inicial, int Final)
                {

                    // Inicial = Inicial + 2;
                    Final = Final + 1;


                    for (int x = Inicial; x < Final; x++)
                    {
                        linha += ArrayHex[x] + ";";

                    }

                    caratcter += linha;
                    RelatorioBruto3 += linha.Remove(0, 9);
                    RelatorioBruto3 = RelatorioBruto3.Substring(0, RelatorioBruto3.Length - 4) + "\r\n";
                    // Console.WriteLine("Caracter = " + caratcter.Length);
                    // Console.WriteLine("String = " + Hextest.Length);


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

                void RelatoriosBrtos()
                {

                    Console.WriteLine("Relatorio-1: ");
                    Console.WriteLine();
                    Console.WriteLine(RelatorioFinal1);



                    Console.WriteLine("Relatorio-2: ");
                    Console.WriteLine();
                    Console.WriteLine(RelatorioBruto2);


                    Console.WriteLine("Relatorio-3: ");
                    Console.WriteLine();
                    Console.WriteLine(RelatorioBruto3);
                    Console.WriteLine("Scan total");

                }

            }


            Console.ReadKey();



        }
    }



}
