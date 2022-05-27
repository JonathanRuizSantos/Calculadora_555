using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;

namespace CalculadoraR1R2C1_555C1C2C3
{
    internal class Calc555Timer
    {
        double x, y, r;
        double frec;
        double C1;
        double T;
        double T1;
        double T2;
        double R2;
        double R1;
        double T2menor;
        double T2mayor;
        double R1menor;
        double R1mayor;
        double T1menor;
        double T1mayor;
        double R2normalizada;
        double R2menor;
        double R2mayor;
        double Difmenor;
        double Difmayor;
        double Toleranciamenor;
        double Toleranciamayor;
        double T1porcentage;
        double T2porcentage;


        public string C1T1YT2(double x,double y,ref double r, ref double r2)
        {
            frec = x;
            T = 1 / frec;
            r = T1 = (T * 30) / 100;
            r2 = T2 = (T * 70) / 100;

            return ("T1 y T2 para un 555 Caso 1 ");
            
        }
        public string C2T1YT2(double x, double y, ref double r, ref double r2)
        {
            frec = x;
            T = 1 / frec;
            r = T1 = (T * 40) / 100;
            r2 = T2 = (T * 60) / 100;

            return ("T1 y T2 para un 555 Caso 2 ");

        }
        public string C3T1YT2(double x, double y,double h,double i, ref double r, ref double r2)
        {
            frec = x;
            T1porcentage = h;
            T2porcentage = i;
            T = 1 / frec;
            r = T1 = (T * T1porcentage) / 100;
            r2 = T2 = (T * T2porcentage) / 100;

            return ("T1 y T2 para un 555 Caso 3 ");

        }
        public string C1R2(double x, double y, ref double r)
        {
            frec = x;
            C1 = y;
            T = 1 / frec;
            T1 = (T * 30) / 100;
            T2 = (T * 70) / 100;
            r = R2 = T2 / (0.693 * C1);
            return ("Valor de R2 sin normalizar // Caso 1 ");

        }
        public string C2R2(double x, double y, ref double r)
        {
            frec = x;
            C1 = y;
            T = 1 / frec;
            T1 = (T * 40) / 100;
            T2 = (T * 60) / 100;
            r = R2 = T2 / (0.693 * C1);
            return ("Valor de R2 sin normalizar // Caso 2 ");

        }
        public string C3R2(double x, double y, ref double r)
        {
            frec = x;
            C1 = y;
            T = 1 / frec;
            T1 = (T * T1porcentage) / 100;
            T2 = (T * T2porcentage) / 100;
            r = R2 = T2 / (0.693 * C1);
            return ("Valor de R2 sin normalizar // Caso 3 ");

        }
        public string C1R2NyR1(double c, double y, double z, double a, double b, ref double r, ref double r2, ref double r3)
        {
            R2menor = b;
            R2mayor = c;
            C1 = y;
            T1 = z;
            T2 = a;
            T2menor = 0.693 * R2menor * C1;
            T2mayor = 0.693 * R2mayor * C1;
            Difmenor = T2 - T2menor;
            Difmayor = T2 - T2mayor;
            r = Toleranciamenor = (Difmenor * 100) / T2;
            r2 = Toleranciamayor = (Difmayor * 100) / T2;

            if (Toleranciamenor < 0)
            {
                Toleranciamenor = Toleranciamenor * -1;

                if (Toleranciamayor < 0)
                {
                    Toleranciamayor = Toleranciamayor * -1;

                    if (Toleranciamenor < Toleranciamayor)
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 1 // se usa R2menor porque sutolerancia es menor");
                    }
                    else
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 1 // se usa R2mayor porque sutolerancia es menor");
                    }
                    

                }
                else
                {
                    if (Toleranciamenor < Toleranciamayor)
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 1 // se usa R2menor porque sutolerancia es menor");
                    }
                    else
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 1 // se usa R2mayor porque sutolerancia es menor");
                    }
                    
                }
            }
            else if (Toleranciamayor < 0)
            {
                Toleranciamayor = Toleranciamayor * -1;

                if (Toleranciamenor < Toleranciamayor)
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 1 // se usa R2menor porque sutolerancia es menor");
                }
                else
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 1 // se usa R2mayor porque sutolerancia es menor");
                }
                

            }
            else
            {
                if (Toleranciamenor < Toleranciamayor)
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 1 // se usa R2menor porque sutolerancia es menor");
                }
                else
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 1 // se usa R2mayor porque sutolerancia es menor");
                }
                
            }
        }
        public string C2R2NyR1(double c, double y, double z, double a, double b, ref double r, ref double r2, ref double r3)
        {
            R2menor = b;
            R2mayor = c;
            C1 = y;
            T1 = z;
            T2 = a;
            T2menor = 0.693 * R2menor * C1;
            T2mayor = 0.693 * R2mayor * C1;
            Difmenor = T2 - T2menor;
            Difmayor = T2 - T2mayor;
            r = Toleranciamenor = (Difmenor * 100) / T2;
            r2 = Toleranciamayor = (Difmayor * 100) / T2;

            if (Toleranciamenor < 0)
            {
                Toleranciamenor = Toleranciamenor * -1;

                if (Toleranciamayor < 0)
                {
                    Toleranciamayor = Toleranciamayor * -1;

                    if (Toleranciamenor < Toleranciamayor)
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 2 // se usa R2menor porque sutolerancia es menor");
                    }
                    else
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 2 // se usa R2mayor porque sutolerancia es menor");
                    }


                }
                else
                {
                    if (Toleranciamenor < Toleranciamayor)
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 2 // se usa R2menor porque sutolerancia es menor");
                    }
                    else
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 2 // se usa R2mayor porque sutolerancia es menor");
                    }

                }
            }
            else if (Toleranciamayor < 0)
            {
                Toleranciamayor = Toleranciamayor * -1;

                if (Toleranciamenor < Toleranciamayor)
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 2 // se usa R2menor porque sutolerancia es menor");
                }
                else
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 2 // se usa R2mayor porque sutolerancia es menor");
                }


            }
            else
            {
                if (Toleranciamenor < Toleranciamayor)
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 2 // se usa R2menor porque sutolerancia es menor");
                }
                else
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 2 // se usa R2mayor porque sutolerancia es menor");
                }

            }
        }
        public string C3R2NyR1(double c, double y, double z, double a, double b, ref double r, ref double r2, ref double r3)
        {
            R2menor = b;
            R2mayor = c;
            C1 = y;
            T1 = z;
            T2 = a;
            T2menor = 0.693 * R2menor * C1;
            T2mayor = 0.693 * R2mayor * C1;
            Difmenor = T2 - T2menor;
            Difmayor = T2 - T2mayor;
            r = Toleranciamenor = (Difmenor * 100) / T2;
            r2 = Toleranciamayor = (Difmayor * 100) / T2;

            if (Toleranciamenor < 0)
            {
                Toleranciamenor = Toleranciamenor * -1;

                if (Toleranciamayor < 0)
                {
                    Toleranciamayor = Toleranciamayor * -1;

                    if (Toleranciamenor < Toleranciamayor)
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 3 // se usa R2menor porque sutolerancia es menor");
                    }
                    else
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 3 // se usa R2mayor porque sutolerancia es menor");
                    }


                }
                else
                {
                    if (Toleranciamenor < Toleranciamayor)
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 3 // se usa R2menor porque sutolerancia es menor");
                    }
                    else
                    {
                        r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                        return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 3 // se usa R2mayor porque sutolerancia es menor");
                    }

                }
            }
            else if (Toleranciamayor < 0)
            {
                Toleranciamayor = Toleranciamayor * -1;

                if (Toleranciamenor < Toleranciamayor)
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 3 // se usa R2menor porque sutolerancia es menor");
                }
                else
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 3 // se usa R2mayor porque sutolerancia es menor");
                }


            }
            else
            {
                if (Toleranciamenor < Toleranciamayor)
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2menor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 3 // se usa R2menor porque sutolerancia es menor");
                }
                else
                {
                    r3 = R1 = (T1 / (0.693 * C1)) - R2mayor;
                    return ("Tol-R2menor, Tol-R2mayor, R1 para " +
                            "un 555 Caso 3 // se usa R2mayor porque sutolerancia es menor");
                }

            }
        }
        public string C1R1N(double d, double y, double z, double a, double f, double g, ref double r, ref double r2, ref double r3)
        {
            R1menor = f;
            R1mayor = g;
            C1 = y;
            T1 = z;
            T2 = a;
            R2normalizada = d;
            T1menor = 0.693 * (R1menor + R2normalizada) * C1;
            T1mayor = 0.693 * (R1mayor + R2normalizada) * C1;
            Difmenor = T1 - T1menor;
            Difmayor = T1 - T1mayor;
            r = Toleranciamenor = (Difmenor * 100) / T1;
            r2 = Toleranciamayor = (Difmayor * 100) / T1;

            if (Toleranciamenor < 0)
            {
                Toleranciamenor = Toleranciamenor * -1;

                if (Toleranciamayor < 0)
                {
                    Toleranciamayor = Toleranciamayor * -1;

                    if (Toleranciamenor < Toleranciamayor)
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");
                        

                    }
                    else
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                    }


                }
                else
                {
                    if (Toleranciamenor < Toleranciamayor)
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");
                    }
                    else
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                    }

                }
            }
            else if (Toleranciamayor < 0)
            {
                Toleranciamayor = Toleranciamayor * -1;

                if (Toleranciamenor < Toleranciamayor)
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");
                }
                else
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                }


            }
            else
            {
                if (Toleranciamenor < Toleranciamayor)
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");
                }
                else
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                }

            }
        }
        public string C2R1N(double d, double y, double z, double a, double f, double g, ref double r, ref double r2, ref double r3)
        {
            R1menor = f;
            R1mayor = g;
            C1 = y;
            T1 = z;
            T2 = a;
            R2normalizada = d;
            T1menor = 0.693 * (R1menor + R2normalizada) * C1;
            T1mayor = 0.693 * (R1mayor + R2normalizada) * C1;
            Difmenor = T1 - T1menor;
            Difmayor = T1 - T1mayor;
            r = Toleranciamenor = (Difmenor * 100) / T1;
            r2 = Toleranciamayor = (Difmayor * 100) / T1;

            if (Toleranciamenor < 0)
            {
                Toleranciamenor = Toleranciamenor * -1;

                if (Toleranciamayor < 0)
                {
                    Toleranciamayor = Toleranciamayor * -1;

                    if (Toleranciamenor < Toleranciamayor)
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");


                    }
                    else
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                    }


                }
                else
                {
                    if (Toleranciamenor < Toleranciamayor)
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");
                    }
                    else
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                    }

                }
            }
            else if (Toleranciamayor < 0)
            {
                Toleranciamayor = Toleranciamayor * -1;

                if (Toleranciamenor < Toleranciamayor)
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");
                }
                else
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                }


            }
            else
            {
                if (Toleranciamenor < Toleranciamayor)
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");
                }
                else
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                }

            }
        }
        public string C3R1N(double d, double y, double z, double a, double f, double g, ref double r, ref double r2, ref double r3)
        {
            R1menor = f;
            R1mayor = g;
            C1 = y;
            T1 = z;
            T2 = a;
            R2normalizada = d;
            T1menor = 0.693 * (R1menor + R2normalizada) * C1;
            T1mayor = 0.693 * (R1mayor + R2normalizada) * C1;
            Difmenor = T1 - T1menor;
            Difmayor = T1 - T1mayor;
            r = Toleranciamenor = (Difmenor * 100) / T1;
            r2 = Toleranciamayor = (Difmayor * 100) / T1;

            if (Toleranciamenor < 0)
            {
                Toleranciamenor = Toleranciamenor * -1;

                if (Toleranciamayor < 0)
                {
                    Toleranciamayor = Toleranciamayor * -1;

                    if (Toleranciamenor < Toleranciamayor)
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");


                    }
                    else
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                    }


                }
                else
                {
                    if (Toleranciamenor < Toleranciamayor)
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");
                    }
                    else
                    {
                        return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                    }

                }
            }
            else if (Toleranciamayor < 0)
            {
                Toleranciamayor = Toleranciamayor * -1;

                if (Toleranciamenor < Toleranciamayor)
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");
                }
                else
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                }


            }
            else
            {
                if (Toleranciamenor < Toleranciamayor)
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 menor porque su tolerancia es menor");
                }
                else
                {
                    return ("Tol.R1menor y Tol.R1mayor // Se usa R1 mayor porque su tolerancia es menor");
                }

            }
        }

    }
    
}
