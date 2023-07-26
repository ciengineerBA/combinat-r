using System;
using System.Collections.Generic;

namespace combinatır
{
    class Program
    {
        static void Main(string[] args)
        {

            combinator3();
            Console.ReadKey();
            //combinator4();

        }

        public static string[] SabıtYuk = { "G", "Q" };
        public static string[] Isaretler = { "+", "-" };

        public static string[] Katsayı = { "1" };
        public static string[] Isaretler2 = { "+", "-" };
        public static string[] Katsayı2 = { "0.3" };


        public static string[] DepremYuk = { "SPECNX", "SPECPX" };


        public static string[] DepremYuk2 = { "SPECPY", "SPECNY"};
        public static List<string> combins = new List<string>();



        #region

        /// <summary>
        /// TDY2007 metodlaridir G,Q,SPECX,SPECY olmalıdır
        /// </summary>
        static void combinator1()

        {


            for (int i = 0; i < Isaretler.Length; i++)
            {
                for (int j  = 0; j < DepremYuk.Length; j++)
                {
                    for (int k = 0; k < Katsayı.Length; k++)
                    {
                        for (int m = 0; m < Katsayı2.Length; m++)
                        {
                            for (int l = 0; l < Isaretler2.Length; l++)
                            {
                                for (int n = 0; n < DepremYuk2.Length ;n++)
                                {
                                   combins.Add(Isaretler[i] + Katsayı[k] +DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + DepremYuk2[n]);
                                
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "TYPE" + " " + '"' + "Linear Add" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "DESIGN" + " " + '"' + "Concrete" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "DESIGN" + " " + '"' + "Wall" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + "G" + '"' + " " + "SF" + " " + "1");
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + "Q" + '"' + " " + "SF" + " " + "1");
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk[j] + '"' + " " + "SF" + " " + Isaretler[i] + Katsayı[k]);
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk2[n] + '"' + " " + "SF" + " " + Isaretler2[l] + Katsayı2[k]);


                                }

                            }
                        }

                    }
                    
                }
            }



   

            for (int i = 0; i < Isaretler.Length; i++)
            {
                for (int j = 0; j < DepremYuk.Length; j++)
                {
                    for (int k = 0; k < Katsayı.Length; k++)
                    {
                        for (int m = 0; m < Katsayı2.Length; m++)
                        {
                            for (int l = 0; l < Isaretler2.Length; l++)
                            {
                                for (int n = 0; n < DepremYuk2.Length; n++)
                                {
                                    combins.Add(Isaretler[i] + Katsayı[k] + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + DepremYuk[n]);

                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "TYPE" + " " + '"' + "Linear Add" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "DESIGN" + " " + '"' + "Concrete" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "DESIGN" + " " + '"' + "Wall" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + "G" + '"' + " " + "SF" + " " + "1");
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + "Q" + '"' + " " + "SF" + " " + "1");
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk2[j] + '"' + " " + "SF" + " " + Isaretler[i] + Katsayı[k]);
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk[n] + '"' + " " + "SF" + " " + Isaretler2[l] + Katsayı2[k]);


                                }

                            }
                        }

                    }

                }
            }


            //for (int i = 0; i < combins.Count; i++)
            //{
            //    for (int k = 0; k < combins.Count; k++)
            //    {
            //        if (combins[i] == combins[k])
            //        {
            //            if (k != i)
            //            {
            //                Console.WriteLine("Patladık" + combins[i]);
            //            }

            //        }
            //        else { Console.WriteLine("Oldu gibi"); }
            //    }
            //    //Console.WriteLine(combins[i]);
            //}
            //Console.WriteLine(combins.Count);

            //Console.ReadKey();
        }

        static void combinator2()

        {





            for (int i = 0; i < Isaretler.Length; i++)
            {
                for (int j = 0; j < DepremYuk.Length; j++)
                {
                    for (int k = 0; k < Katsayı.Length; k++)
                    {
                        for (int m = 0; m < Katsayı2.Length; m++)
                        {
                            for (int l = 0; l < Isaretler2.Length; l++)
                            {
                                for (int n = 0; n < DepremYuk2.Length; n++)
                                {
                                    combins.Add(Isaretler[i] + Katsayı[k] + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + DepremYuk2[n]);

                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "TYPE" + " " + '"' + "Linear Add" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' +"0.9" +  SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "DESIGN" + " " + '"' + "Concrete" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' +"0.9" +  SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "DESIGN" + " " + '"' + "Wall" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' +"0.9" +  SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + "G" + '"' + " " + "SF" + " " + "0.9");
                                    Console.WriteLine("COMBO" + " " + '"' +"0.9" +  SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk[j] + '"' + " " + "SF" + " " + Isaretler[i] + Katsayı[k]);
                                    Console.WriteLine("COMBO" + " " + '"' +"0.9" +  SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk2[n] + '"' + " " + "SF" + " " + Isaretler2[l] + Katsayı2[k]);


                                }

                            }
                        }

                    }

                }
            }





            for (int i = 0; i < Isaretler.Length; i++)
            {
                for (int j = 0; j < DepremYuk.Length; j++)
                {
                    for (int k = 0; k < Katsayı.Length; k++)
                    {
                        for (int m = 0; m < Katsayı2.Length; m++)
                        {
                            for (int l = 0; l < Isaretler2.Length; l++)
                            {
                                for (int n = 0; n < DepremYuk2.Length; n++)
                                {
                                    combins.Add(Isaretler[i] + Katsayı[k] + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + DepremYuk[n]);

                                    Console.WriteLine("COMBO" + " " + '"'+ "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "TYPE" + " " + '"' + "Linear Add" + '"');
                                    Console.WriteLine("COMBO" + " " + '"'+ "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "DESIGN" + " " + '"' + "Concrete" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"'+ "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "DESIGN" + " " + '"' + "Wall" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"'+ "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + "G" + '"' + " " + "SF" + " " + "0.9");
                                    Console.WriteLine("COMBO" + " " + '"'+ "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk2[j] + '"' + " " + "SF" + " " + Isaretler[i] + Katsayı[k]);
                                    Console.WriteLine("COMBO" + " " + '"'+ "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk[n] + '"' + " " + "SF" + " " + Isaretler2[l] + Katsayı2[k]);


                                }

                            }
                        }

                    }

                }
            }








            //for (int i = 0; i < Isaretler.Length; i++)
            //{
            //    for (int j = 0; j < DepremYuk.Length; j++)
            //    {
            //        for (int k = 0; k < Katsayı.Length; k++)
            //        {
            //            for (int m = 0; m < Katsayı2.Length; m++)
            //            {
            //                combins.Add(Isaretler[i] + Katsayı[k] +
            //                    DepremYuk[j] + Isaretler2[i] + Katsayı2[m] + DepremYuk2[j]);

            //                Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+"  + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[i] + Katsayı2[m] + "*" + DepremYuk2[j] + '"' + " " + "TYPE" + " " + '"' + "Linear Add" + '"');
            //                Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+"  + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[i] + Katsayı2[m] + "*" + DepremYuk2[j] + '"' + " " + "DESIGN" + " " + '"' + "Concrete" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
            //                Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+"  + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[i] + Katsayı2[m] + "*" + DepremYuk2[j] + '"' + " " + "DESIGN" + " " + '"' + "Wall" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
            //                Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+"  + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[i] + Katsayı2[m] + "*" + DepremYuk2[j] + '"' + " " + "LOADCASE" + " " + '"' + "G" + '"' + " " + "SF" + " " + "0.9");
            //                Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+"  + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[i] + Katsayı2[m] + "*" + DepremYuk2[j] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk[j] + '"' + " " + "SF" + " " + Isaretler[i] + Katsayı[k]);
            //                Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+"  + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[i] + Katsayı2[m] + "*" + DepremYuk2[j] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk2[j] + '"' + " " + "SF" + " " + Isaretler2[i] + Katsayı2[k]);
            //            }

            //        }

            //    }
            //}

            for (int i = 0; i < combins.Count; i++)
            {
                for (int k = 0; k < combins.Count; k++)
                {
                    if (combins[i] == combins[k])
                    {
                        if (k != i)
                        {
                            Console.WriteLine("Patladık" + combins[i]);
                        }

                    }
                    else { Console.WriteLine("Oldu gibi"); }
                }
                //Console.WriteLine(combins[i]);
            }
            Console.WriteLine(combins.Count);

            Console.ReadKey();
        }
        #endregion

        #region

        /// TBDY2018 e göre hesap yapar
        /// (2/3)SDS yi dahil eder
        /// Zemin yüklemesi ihmal edilmiştir.


        static void combinator3()

        {


            for (int i = 0; i < Isaretler.Length; i++)
            {
                for (int j = 0; j < DepremYuk.Length; j++)
                {
                    for (int k = 0; k < Katsayı.Length; k++)
                    {
                        for (int m = 0; m < Katsayı2.Length; m++)
                        {
                            for (int l = 0; l < Isaretler2.Length; l++)
                            {
                                for (int n = 0; n < DepremYuk2.Length; n++)
                                {
                                    combins.Add(Isaretler[i] + Katsayı[k] + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + DepremYuk2[n]);

                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "TYPE" + " " + '"' + "Linear Add" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "DESIGN" + " " + '"' + "Concrete" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "DESIGN" + " " + '"' + "Wall" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + "G" + '"' + " " + "SF" + " " + "1.1");
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + "Q" + '"' + " " + "SF" + " " + "1");
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk[j] + '"' + " " + "SF" + " " + Isaretler[i] + Katsayı[k]);
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk2[n] + '"' + " " + "SF" + " " + Isaretler2[l] + Katsayı2[k]);


                                }

                            }
                        }

                    }

                }
            }





            for (int i = 0; i < Isaretler.Length; i++)
            {
                for (int j = 0; j < DepremYuk.Length; j++)
                {
                    for (int k = 0; k < Katsayı.Length; k++)
                    {
                        for (int m = 0; m < Katsayı2.Length; m++)
                        {
                            for (int l = 0; l < Isaretler2.Length; l++)
                            {
                                for (int n = 0; n < DepremYuk2.Length; n++)
                                {
                                    combins.Add(Isaretler[i] + Katsayı[k] + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + DepremYuk[n]);

                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "TYPE" + " " + '"' + "Linear Add" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "DESIGN" + " " + '"' + "Concrete" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "DESIGN" + " " + '"' + "Wall" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + "G" + '"' + " " + "SF" + " " + "1.1");
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + "Q" + '"' + " " + "SF" + " " + "1");
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk2[j] + '"' + " " + "SF" + " " + Isaretler[i] + Katsayı[k]);
                                    Console.WriteLine("COMBO" + " " + '"' + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk[n] + '"' + " " + "SF" + " " + Isaretler2[l] + Katsayı2[k]);


                                }

                            }
                        }

                    }

                }
            }
        }

        static void combinator4()
        {
            for (int i = 0; i < Isaretler.Length; i++)
            {
                for (int j = 0; j < DepremYuk.Length; j++)
                {
                    for (int k = 0; k < Katsayı.Length; k++)
                    {
                        for (int m = 0; m < Katsayı2.Length; m++)
                        {
                            for (int l = 0; l < Isaretler2.Length; l++)
                            {
                                for (int n = 0; n < DepremYuk2.Length; n++)
                                {
                                    combins.Add(Isaretler[i] + Katsayı[k] + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + DepremYuk2[n]);

                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "TYPE" + " " + '"' + "Linear Add" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "DESIGN" + " " + '"' + "Concrete" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "DESIGN" + " " + '"' + "Wall" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + "G" + '"' + " " + "SF" + " " + "0.8");
                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk[j] + '"' + " " + "SF" + " " + Isaretler[i] + Katsayı[k]);
                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + Isaretler[i] + Katsayı[k] + "*" + DepremYuk[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk2[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk2[n] + '"' + " " + "SF" + " " + Isaretler2[l] + Katsayı2[k]);


                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < Isaretler.Length; i++)
            {
                for (int j = 0; j < DepremYuk.Length; j++)
                {
                    for (int k = 0; k < Katsayı.Length; k++)
                    {
                        for (int m = 0; m < Katsayı2.Length; m++)
                        {
                            for (int l = 0; l < Isaretler2.Length; l++)
                            {
                                for (int n = 0; n < DepremYuk2.Length; n++)
                                {
                                    combins.Add(Isaretler[i] + Katsayı[k] + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + DepremYuk[n]);

                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "TYPE" + " " + '"' + "Linear Add" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "DESIGN" + " " + '"' + "Concrete" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "DESIGN" + " " + '"' + "Wall" + " " + '"' + "COMBOTYPE" + '"' + " " + "Strength" + '"');
                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + "G" + '"' + " " + "SF" + " " + "0.8");
                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk2[j] + '"' + " " + "SF" + " " + Isaretler[i] + Katsayı[k]);
                                    Console.WriteLine("COMBO" + " " + '"' + "0.9" + SabıtYuk[0] + "+" + SabıtYuk[1] + Isaretler[i] + Katsayı[k] + "*" + DepremYuk2[j] + Isaretler2[l] + Katsayı2[m] + "*" + DepremYuk[n] + '"' + " " + "LOADCASE" + " " + '"' + DepremYuk[n] + '"' + " " + "SF" + " " + Isaretler2[l] + Katsayı2[k]);


                                }

                            }
                        }

                    }

                }
            }

            for (int i = 0; i < combins.Count; i++)
            {
                for (int k = 0; k < combins.Count; k++)
                {
                    if (combins[i] == combins[k])
                    {
                        if (k != i)
                        {
                            Console.WriteLine("Patladık" + combins[i]);
                        }

                    }
                    
                }
                //Console.WriteLine(combins[i]);
            }
            Console.WriteLine(combins.Count);

            Console.ReadKey();
        }




        #endregion



        




    }
}
