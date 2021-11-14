using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIMC
{
    class Person
    {
        public double weight;
        public double height;

        public double bmi()
        {
            return weight / (height * height);
        }

        public string situationBmi(double bmi)
        {
            if (bmi < 18.5)
            {
                return "underweight";
            }

            else if (bmi < 25)
            {
                return "normal weight";
            }

            else if (bmi < 30)
            {
                return "overweight";
            }

            else if (bmi < 35)
            {
                return "Class I Obesity";
            }
            
            else if (bmi < 40)
            {
                return "Class II Obesity";
            }

            else
            {
                return "Class III obesity";
            }
        }

        public void message()
        {
            Console.WriteLine($"Your weight is {weight} and your height is {height}");
            double knowBmi = bmi();
            Console.WriteLine($"O seu BMI é {knowBmi}");
            string situacaoImc = situationBmi(knowBmi);
            Console.WriteLine($"{situacaoImc}");

        }
    }
}
