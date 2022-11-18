using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedPerceptron
{
    internal class Neuron
    {
        int Activation = 0;
        int Treshold = 5;
        int[] Weights;

        Neuron(int ConnectionsAmount, int _Treshold)
        {
            Weights = new int[ConnectionsAmount];
            Treshold = _Treshold;

            for (int i = 0; i < Weights.Length; i++)
            {
                Weights[i] = i;
            }
        }

        public int ActivationFunction(int Value)
        {
            Activation = Value > Treshold ? 1 : 0;
            return Activation;
        }

        public int WeightedSum(int[] Input)
        {
            int WeightedSum = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                WeightedSum += Input[i] * Weights[i];
            }
            return WeightedSum;
        }

        public void Train(int Value)
        {
            bool IsTrained = false;
            while(!IsTrained)
            {

                for (int i = 0; i < 10; i++)
                {
                    int Result = ActivationFunction(i);

                    if (Result == 1 && i != Value)
                    {
                        CorrectWeights(i, -1);
                        IsTrained = true;
                    }

                    if (Result == 0 && i == Value)
                    {
                        CorrectWeights(i, 1);
                        IsTrained = true;
                    }
                }
            }
        }
        public void CorrectWeights(int[] inputs, int editor)
        {
            for (int i = 0; i < Weights.Length; i++)
            {
                if (inputs[i] == 1)
                    Weights[i] = Weights[i] + editor;
            }
        }
    }
}
