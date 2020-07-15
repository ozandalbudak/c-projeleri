using System;
using System.Collections.Generic;

namespace UI
{
    class Equation
    {
        #region Properties


        #region GUID
        //Sınıfın id değeri,aynı bellek alanlarını referans göstermelerini engeller
        private Guid id;
        public Guid Id
        {
            get
            {
                return id;
            }
        }
        #endregion

        #region NumberOne
        private int numberOne;
        public int NumberOne
        {
            get { return numberOne; }
            set
            {
                if (numberOne != value)
                {
                    numberOne = value;
                }
            }
        }
        #endregion NumberOne
        #region NumberTwo
        private int numberTwo;
        public int NumberTwo
        {
            get { return numberTwo; }
            set
            {
                if (numberTwo != value)
                {
                    numberTwo = value;
                }
            }
        }
        #endregion numberTwo
        #region Operant
        private string operant;
        public string Operant
        {
            get { return operant; }
            set
            {
                if (operant != value)
                {
                    operant = value;
                }
            }
        }




        #endregion Operant
        #endregion

        #region Methods
        public Equation()
        {
            this.id = Guid.NewGuid();
        }

        /// <summary>
        /// Verilen propertyleri string fonksiyon olarak verir
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.NumberOne.ToString() + this.Operant + this.NumberTwo.ToString();
        }
        /// <summary>
        /// Matematiksel hesaplama sonucunu verir
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {
            return Evaluate(this.ToString());
        }
        /// <summary>
        /// String ifadeyi parçalar ve matematiksel ifade eder
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private double Evaluate(String input)
        {
            String expr = "(" + input + ")";
            Stack<String> ops = new Stack<String>();
            Stack<Double> vals = new Stack<Double>();

            for (int i = 0; i < expr.Length; i++)
            {
                String s = expr.Substring(i, 1);
                if (s.Equals("(")) { }
                else if (s.Equals("+")) ops.Push(s);
                else if (s.Equals("-")) ops.Push(s);
                else if (s.Equals("*")) ops.Push(s);
                else if (s.Equals("/")) ops.Push(s);
                else if (s.Equals(")"))
                {
                    int count = ops.Count;
                    while (count > 0)
                    {
                        String op = ops.Pop();
                        double v = vals.Pop();
                        if (op.Equals("+")) v = vals.Pop() + v;
                        else if (op.Equals("-")) v = vals.Pop() - v;
                        else if (op.Equals("*")) v = vals.Pop() * v;
                        else if (op.Equals("/")) v = vals.Pop() / v;
                        vals.Push(v);
                        count--;
                    }
                }
                else vals.Push(Double.Parse(s));
            }
            return vals.Pop();
        }
        #endregion


    }
}
