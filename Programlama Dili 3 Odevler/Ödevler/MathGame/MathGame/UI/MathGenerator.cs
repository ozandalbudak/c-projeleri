using System;

namespace UI
{
    class MathGenerator
    {
        static Random random = new Random();
        /// <summary>
        /// Rastsal olarak matematiksel fonsiyon üretir.
        /// </summary>
        /// <returns></returns>
        public Equation Equation(int level)
        {
            Equation equation = new UI.Equation();

            int maxRange = 0;
            int minRange = 0;
            switch (level)
            {
                case 1:
                    maxRange = 10;
                    minRange = 1;
                    break;
                case 2:
                    maxRange = 100;
                    minRange = 10;
                    break;
                case 3:
                    maxRange = 1000;
                    minRange = 100;
                    break;
                case 4:
                    maxRange = 10000;
                    minRange = 1000;
                    break;
                case 5:
                    maxRange = 100000;
                    minRange = 10000;
                    break;
                default:
                    break;
            }
            equation.NumberOne = random.Next(minRange, maxRange);
            equation.NumberTwo = random.Next(minRange, maxRange);
            int a = random.Next(0, 4);
            string operant;
            switch (a)
            {
                case 0:
                    operant = "+";
                    break;
                case 1:
                    operant = "-";
                    break;

                case 2:
                    operant = "*";
                    break;
                case 3:
                    operant = "/";
                    switch (random.Next(1, 4))
                    {
                        case 1:
                            equation.NumberOne = equation.NumberTwo * 1;
                            break;
                        case 2:
                            equation.NumberOne = equation.NumberTwo * 2;
                            break;

                        case 3:
                            equation.NumberOne = equation.NumberTwo * 3;
                            break;

                        default:
                            equation.NumberOne = equation.NumberTwo * 4;
                            break;
                    }


                    break;
                default:
                    operant = "+";
                    break;
            }
            equation.Operant = operant;
            return equation;
        }

        /// <summary>
        /// İstenilen operatör doğrultusunda işlem yapar
        /// </summary>
        /// <param name="level">Seviye</param>
        /// <param name="operant">Operant</param>
        /// <returns></returns>
        public Equation Equation(int level, string operant)
        {
            Equation equation = new UI.Equation();
            int maxRange = 0;
            int minRange = 0;
            switch (level)
            {
                case 1:
                    maxRange = 10;
                    minRange = 1;
                    break;
                case 2:
                    maxRange = 100;
                    minRange = 10;
                    break;
                case 3:
                    maxRange = 1000;
                    minRange = 100;
                    break;
                case 4:
                    maxRange = 10000;
                    minRange = 1000;
                    break;
                case 5:
                    maxRange = 100000;
                    minRange = 10000;
                    break;
                default:
                    break;
            }
            equation.NumberOne = random.Next(minRange, maxRange);
            equation.NumberTwo = random.Next(minRange, maxRange);
            if (operant == "/")
            {
                switch (random.Next(1, 4))
                {
                    case 1:
                        equation.NumberOne = equation.NumberTwo * 1;
                        break;
                    case 2:
                        equation.NumberOne = equation.NumberTwo * 2;
                        break;

                    case 3:
                        equation.NumberOne = equation.NumberTwo * 3;
                        break;

                    default:
                        equation.NumberOne = equation.NumberTwo * 4;
                        break;
                }
            }
            equation.Operant = operant;
            return equation;
        }
    }
}
