using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace RSAproject
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCases;

            StringBuilder ress = new StringBuilder();
            BigInteger bigint = new BigInteger();
            TextReader origConsole = Console.In;
            int index = 0;
            string space;
            string n1;
            string n2;
            string n3;
            int ch = 0;

            Console.WriteLine(" Enter 2 for SUBTRACTION, 3 for SUMMATION, 4 for MULTIPLICATION,");
            Console.WriteLine(" 5 for DIVISION, 6 for MODofPOWER, 0 for ENCRYPTION, 1 for DECRYPTION :");
            char choice = (char)Console.ReadLine()[0];

            switch (choice)
            {

                case '2':

                    string[] subOutput = new string[20];
                    FileStream fs = new FileStream("SubtractTestCases_Output.txt", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    Console.SetIn(sr);
                    while (sr.Peek() != -1)
                    {
                        subOutput[index] = sr.ReadLine();
                        index++;
                        space = sr.ReadLine();
                    }
                    sr.Close();

                    FileStream fs1 = new FileStream("SubtractTestCases.txt", FileMode.Open);
                    StreamReader sr1 = new StreamReader(fs1);
                    Console.SetIn(sr1);
                    nCases = int.Parse(sr1.ReadLine());
                    Console.WriteLine(nCases);

                    for (int i = 0; i < nCases; i++)
                    {
                        space = sr1.ReadLine();
                        n1 = sr1.ReadLine();
                        n2 = sr1.ReadLine();

                        Console.WriteLine("Case " + (i + 1).ToString() + ":");
                        Console.WriteLine("The first number " + n1);
                        Console.WriteLine("The second number " + n2);

                        StringBuilder s11 = new StringBuilder(n1);
                        StringBuilder s22 = new StringBuilder(n2);

                        ress = bigint.SUB(s11, s22);
                        string r = ress.ToString();

                        if (subOutput[i] != r)
                        {
                            Console.WriteLine("Wrong Answer: case # " + (i + 1).ToString() + ": your answer = "
                                + r + ", correct answer = " + subOutput[i]);

                        }
                        else
                        {
                            Console.WriteLine("Succeed in case # " + (i + 1).ToString() + ": your answer = "
                            + r + ", correct answer = " + subOutput[i]);
                        }
                    }
                    sr1.Close();
                    break;

                case '3':

                    string[] sumOutput = new string[100];
                    FileStream fs2 = new FileStream("AddTestCases_Output.txt", FileMode.Open);
                    StreamReader sr2 = new StreamReader(fs2);
                    Console.SetIn(sr2);
                    while (sr2.Peek() != -1)
                    {
                        sumOutput[index] = sr2.ReadLine();
                        index++;
                        space = sr2.ReadLine();
                    }
                    sr2.Close();

                    FileStream fs3 = new FileStream("AddTestCases.txt", FileMode.Open);
                    StreamReader sr3 = new StreamReader(fs3);
                    Console.SetIn(sr3);
                    nCases = int.Parse(sr3.ReadLine());
                    Console.WriteLine(nCases);

                    for (int i = 0; i < nCases; i++)
                    {
                        space = sr3.ReadLine();
                        n1 = sr3.ReadLine();
                        n2 = sr3.ReadLine();

                        Console.WriteLine("Case " + (i + 1).ToString() + ":");
                        Console.WriteLine("The first number : " + n1);
                        Console.WriteLine("The second number : " + n2);

                        StringBuilder sbb1 = new StringBuilder(n1);
                        StringBuilder sbb2 = new StringBuilder(n2);

                        ress = bigint.SUM(sbb1, sbb2);
                        string rr = ress.ToString();

                        if (sumOutput[i] != rr)
                        {
                            Console.WriteLine("Wrong Answer : case # " + (i + 1).ToString() + ": your answer = "
                                + rr + ", correct answer = " + sumOutput[i]);

                        }
                        else
                        {
                            Console.WriteLine("Succeed in case # " + (i + 1).ToString() + ": your answer = "
                                + rr + ", correct answer = " + sumOutput[i]);
                        }
                    }
                    sr3.Close();
                    break;

                case '4':

                    string[] mulOutput = new string[10];
                    FileStream fs4 = new FileStream("MultiplyTestCases_Output.txt", FileMode.Open);
                    StreamReader sr4 = new StreamReader(fs4);
                    Console.SetIn(sr4);
                    while (sr4.Peek() != -1)
                    {
                        mulOutput[index] = sr4.ReadLine();
                        index++;
                        space = sr4.ReadLine();
                    }
                    sr4.Close();

                    FileStream fs5 = new FileStream("MultiplyTestCases.txt", FileMode.Open);
                    StreamReader sr5 = new StreamReader(fs5);
                    Console.SetIn(sr5);
                    nCases = int.Parse(sr5.ReadLine());
                    Console.WriteLine(nCases);

                    for (int i = 0; i < nCases; i++)
                    {
                        space = sr5.ReadLine();
                        n1 = sr5.ReadLine();
                        n2 = sr5.ReadLine();

                        Console.WriteLine("Case " + (i + 1).ToString() + ":");
                        Console.WriteLine("The first number : " + n1);
                        Console.WriteLine("The second number : " + n2);

                        StringBuilder sbbb1 = new StringBuilder(n1);
                        StringBuilder sbbb2 = new StringBuilder(n2);


                        ress = bigint.MUL(sbbb1, sbbb2);
                        string rrr = ress.ToString();
                        if (mulOutput[i] != rrr)
                        {
                            Console.WriteLine("Wrong Answer : case # " + (i + 1).ToString() + ": your answer = "
                                + rrr + ", correct answer = " + mulOutput[i]);

                        }
                        else
                        {
                            Console.WriteLine("Succeed in case # " + (i + 1).ToString() + ": your answer = "
                                + rrr + ", correct answer = " + mulOutput[i]);
                        }
                    }
                    sr5.Close();
                    break;

                case '5':

                    string s1 = "";
                    Console.WriteLine("The first number : " + s1);
                    s1 = Console.ReadLine();
                    string s2 = "";
                    Console.WriteLine("The second number : " + s2);
                    s2 = Console.ReadLine();

                    StringBuilder sb1 = new StringBuilder(s1);
                    StringBuilder sb2 = new StringBuilder(s2);

                    KeyValuePair<StringBuilder, StringBuilder> total = bigint.DIV_AUX(sb1, sb2);

                    Console.WriteLine("The result is : ");
                    string t = total.ToString();
                    Console.WriteLine(t);
                    break;

                case '6':

                    string w1 = "";
                    Console.WriteLine("The number : " + w1);
                    w1 = Console.ReadLine();
                    string w2 = "";
                    Console.WriteLine("The power : " + w2);
                    w2 = Console.ReadLine();
                    string w3 = "";
                    Console.WriteLine("The mod by number : " + w3);
                    w3 = Console.ReadLine();

                    StringBuilder sw1 = new StringBuilder(w1);
                    StringBuilder sw2 = new StringBuilder(w2);
                    StringBuilder sw3 = new StringBuilder(w3);

                    Stopwatch timer = new Stopwatch();
                    timer.Start();
                    ress = bigint.MOD_AUX(sw1, sw2, sw3);
                    timer.Stop();

                    Console.WriteLine("The result is : ");
                    string rrrr = ress.ToString();
                    Console.WriteLine(rrrr);

                    Console.WriteLine("Time in milliseconds : " + timer.Elapsed.TotalMilliseconds.ToString());
                    Console.ReadKey();

                    double ss = timer.Elapsed.TotalMilliseconds;
                    double RES = ss / 1000;
                    Console.WriteLine("Time in seconds : " + RES.ToString());

                    break;

                case '0':

                    StringBuilder res = new StringBuilder();
                    string[] sample = new string[100];
                    FileStream fs7 = new FileStream("SampleRSA.txt", FileMode.Open);
                    StreamReader sr7 = new StreamReader(fs7);
                    nCases = int.Parse(sr7.ReadLine());
                    string N, ED, MEM, C;
                     Stopwatch timer2 = new Stopwatch();
                    string[] sec = new string[100];
                    string[] time = new string[100];
                    string T = "";
                    string S = "";

                    for (int i = 0; i < nCases; i++)
                    {
                        N = sr7.ReadLine();
                        ED = sr7.ReadLine();
                        MEM = sr7.ReadLine();
                        C = sr7.ReadLine();
                        StringBuilder sn = new StringBuilder(N);
                        StringBuilder sed = new StringBuilder(ED);
                        StringBuilder smem = new StringBuilder(MEM);
                        res = bigint.ENCRYPTION(smem, sed, sn);
                        sample[i] = res.ToString();

                    }
                    sr7.Close();
                    FileStream fs8 = new FileStream("SampleRSA_output.txt", FileMode.OpenOrCreate);
                    StreamWriter sr8 = new StreamWriter(fs8);
                    for (int i = 0; i < nCases; i++)
                    {
                        sr8.WriteLine(sample[i]);
                    }

                    sr8.Close();
                    Console.WriteLine("complete cases y/n ?");
                    char x = Char.Parse(Console.ReadLine());
                    if (x == 'y')
                    {
                        FileStream fs9 = new FileStream("TestRSA.txt", FileMode.Open);
                        StreamReader sr9 = new StreamReader(fs9);
                        nCases = int.Parse(sr9.ReadLine());
                        for (int i = 0; i < nCases; i++)
                        {
                            N = sr9.ReadLine();
                            ED = sr9.ReadLine();
                            MEM = sr9.ReadLine();
                            C = sr9.ReadLine();

                            StringBuilder sn = new StringBuilder(N);
                            StringBuilder sed = new StringBuilder(ED);
                            StringBuilder smem = new StringBuilder(MEM);
                           
                            timer2.Start();
                            res = bigint.ENCRYPTION(smem,sed,sn);
                            timer2.Stop();
                            sample[i] = res.ToString();
                            T = timer2.Elapsed.TotalMilliseconds.ToString();
                            time[i] = T;
                            double Value =double.Parse(T);
                            double valuee = Value / 1000;
                            sec[i] =valuee.ToString();

                        }
                        sr9.Close();

                        FileStream fs10 = new FileStream("TestRSA_output.txt", FileMode.OpenOrCreate);
                        StreamWriter sr10 = new StreamWriter(fs10);
                        for (int i = 0; i < nCases; i++)
                        {
                            sr10.WriteLine(sample[i]);
                            sr10.WriteLine(time[i]);
                            sr10.WriteLine(sec[i]);
                        }
                        sr10.Close();

                    }
                    else
                        break;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
