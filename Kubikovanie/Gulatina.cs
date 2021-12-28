using System;

namespace ForestaSK.Kubikovanie
{
    public static class Gulatina
    {
        private static double HrubkaKory(Drevina drevina, int priemer)
        {
            var hornaHranica = HornaHranica(drevina);
            if (priemer <= hornaHranica)
            {
                return HrubkaKoryX(drevina, priemer);
            }
            else
            {
                // nad hornou hranicou orig. kubikovacich tabuliek vytvorim linearnu funkciu z hrubky kory pre priemer 10cm a [hornaHranica]cm 
                var hk10 = HrubkaKoryX(drevina, 10);
                var hkHh = HrubkaKoryX(drevina, hornaHranica);

                var a = (hkHh - hk10) / (hornaHranica - 10);
                var b = hkHh - a * hornaHranica;

                // a z nej vypocitam hrubky kory pre dany priemer
                return a * priemer + b;
            }
        }

        private static int HornaHranica(Drevina drevina)
        {
            int hornaHranica = default;

            switch (drevina)
            {
                case Drevina.BK:
                    hornaHranica = 130;
                    break;
                case Drevina.BO:
                    hornaHranica = 60;
                    break;
                case Drevina.BP:
                    hornaHranica = 100;
                    break;
                case Drevina.DB:
                    hornaHranica = 130;
                    break;
                case Drevina.JD:
                    hornaHranica = 130;
                    break;
                case Drevina.SC:
                    hornaHranica = 100;
                    break;
                case Drevina.SM:
                    hornaHranica = 130;
                    break;
                case Drevina.TK:
                    hornaHranica = 130;
                    break;
            }

            return hornaHranica;
        }


        private static double HrubkaKoryX(Drevina drevina, int priemer)
        {
            double hrubkaKory = default;

            switch (drevina)
            {
                case Drevina.BK:
                    hrubkaKory = BK(priemer);
                    break;
                case Drevina.BO:
                    hrubkaKory = BO(priemer);
                    break;
                case Drevina.BP:
                    hrubkaKory = BP(priemer);
                    break;
                case Drevina.DB:
                    hrubkaKory = DB(priemer);
                    break;
                case Drevina.JD:
                    hrubkaKory = JD(priemer);
                    break;
                case Drevina.SC:
                    hrubkaKory = SC(priemer);
                    break;
                case Drevina.SM:
                    hrubkaKory = SM(priemer);
                    break;
                case Drevina.TK:
                    hrubkaKory = TK(priemer);
                    break;
            }

            return hrubkaKory;
        }

        public static double Objem(Drevina drevina, decimal dlzka, int priemer)
        {
            if (priemer < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(priemer), "Priemer musí väčší ako 0");
            }
            double hrubkaKory = HrubkaKory(drevina, priemer);
            return Math.PI * Math.Pow(priemer - hrubkaKory, 2) / 4 * Convert.ToDouble(dlzka) / 10000;
        }

        static double BK(int priemer)
        {
            return 1.19461964238995E-11 * Math.Pow(priemer, 6) - 5.05397678443814E-09 * Math.Pow(priemer, 5) + 7.79245900812964E-07 * Math.Pow(priemer, 4) - 0.0000513269850701548 * Math.Pow(priemer, 3) + 0.00118592490866831 * Math.Pow(priemer, 2) + 0.0239937532546719 * priemer + 0.210777395515834;
        }

        static double BO(int priemer)
        {
            return 9.27178571495223E-10 * Math.Pow(priemer, 6) - 1.50798471619529E-07 * Math.Pow(priemer, 5) + 8.32050198873446E-06 * Math.Pow(priemer, 4) - 0.000167028326067964 * Math.Pow(priemer, 3) + 0.00104262346735595 * Math.Pow(priemer, 2) + 0.0214817576174937 * priemer + 0.202494479817688;
        }

        static double BP(int priemer)
        {
            return 5.85036123041673E-11 * Math.Pow(priemer, 6) - 1.93011802183257E-08 * Math.Pow(priemer, 5) + 2.37255515328494E-06 * Math.Pow(priemer, 4) - 0.000130900925448429 * Math.Pow(priemer, 3) + 0.00318264190389073 * Math.Pow(priemer, 2) + 0.0422912207895934 * priemer + 0.902261672581517;
        }

        static double DB(int priemer)
        {
            return 4.18512704799441E-12 * Math.Pow(priemer, 6) - 1.33655103434424E-09 * Math.Pow(priemer, 5) + 1.0949526957349E-07 * Math.Pow(priemer, 4) + 2.57829850092151E-06 * Math.Pow(priemer, 3) - 0.000590819628200734 * Math.Pow(priemer, 2) + 0.07432465524289 * priemer + 1.0578431753147;
        }

        static double JD(int priemer)
        {
            return 1.58102440172983E-09 * Math.Pow(priemer, 4) - 1.83551588452124E-06 * Math.Pow(priemer, 3) + 0.000212910426383939 * Math.Pow(priemer, 2) + 0.0410112234102087 * priemer + 0.0517094290546538;
        }

        static double SC(int priemer)
        {
            return -2.05743772340513E-11 * Math.Pow(priemer, 6) + 7.03868552071746E-09 * Math.Pow(priemer, 5) - 9.37434211256694E-07 * Math.Pow(priemer, 4) + 0.0000595492971910971 * Math.Pow(priemer, 3) - 0.0013527786738905 * Math.Pow(priemer, 2) + 0.0985307898899919 * priemer + 0.379685329131462;
        }
        
        static double SM(int priemer)
        {
            return 2.43636149503342E-11 * Math.Pow(priemer, 6) - 9.76333250205831E-09 * Math.Pow(priemer, 5) + 1.43178308180392E-06 * Math.Pow(priemer, 4) - 0.0000935604731431283 * Math.Pow(priemer, 3) + 0.00268965152582723 * Math.Pow(priemer, 2) + 0.000485249067423865 * priemer + 0.39242984365228;
        }

        static double TK(int priemer)
        {
            return 5.33393933244535E-11 * Math.Pow(priemer, 6) - 2.00793461467216E-08 * Math.Pow(priemer, 5) + 2.72667327691489E-06 * Math.Pow(priemer, 4) - 0.000157970776211158 * Math.Pow(priemer, 3) + 0.00363928456312124 * Math.Pow(priemer, 2) + 0.0327958959624084 * priemer + 0.446159898907354;
        }         

        public enum Drevina
        {
            BK,
            BO,
            BP,
            DB,
            JD,
            SC,
            SM,
            TK
        }
    }
}
