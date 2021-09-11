using System;

namespace neuron
{
    class Neuron
    {
        private float weight = 0f;
        private float smooth = 0.00001f;
        public bool learnt = false;

        public void Learn(float source, float expectedResult)
        {
            float actualResult = source / weight;
            if (actualResult >= expectedResult - 0.00001f && actualResult <= expectedResult + 0.00001f)
            {
                Console.WriteLine("Learning is over!");
                learnt = true;
            }
            else
            {
                weight += smooth;
            }
        }

        public void Calculate(float source)
        {
            float result = source / weight;
            Console.WriteLine(result);
        }
    }
    class Execute
    {
        static void Main(string[] args)
        {
            float km = 1f;
            float miles = 0.621371f;

            Neuron neuron = new Neuron();

            for (int i = 0; neuron.learnt != true; i++)
            {
                neuron.Learn(km, miles);
                if (i % 1000 == 0)
                {
                    Console.WriteLine($"Iteration: {i}");
                    neuron.Calculate(km);
                    Console.WriteLine("@@@@@@@@@@");
                }
            }

            neuron.Calculate(km);
            neuron.Calculate(3f);
            neuron.Calculate(5.5f);
        }
    }
}
