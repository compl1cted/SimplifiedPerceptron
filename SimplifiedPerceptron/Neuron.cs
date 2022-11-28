namespace SimplifiedPerceptron
{
    internal class Neuron
    {
        private readonly int Treshold;
        public readonly int[] Weights;

        public Neuron(int _ConnectionsAmount, int _Treshold)
        {
            Weights = new int[_ConnectionsAmount];
            Treshold = _Treshold;
            for (int i = 0; i < Weights.Length; i++)
                Weights[i] = 0;
        }

        public bool ActivationFunction(int[] Value)
        {
            return WeightedSum(Value) > Treshold;
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

        public void Train(int[] Input)
        {
            while(true)
            {
                if (ActivationFunction(Input) == false)
                    CorrectWeights(Input, 1);
                else break;
            }
        }
        public void CorrectWeights(int[] inputs, int editor)
        {
            for (int i = 0; i < Weights.Length; i++)
                if (inputs[i] == 1) Weights[i] += editor;
        }
    }
}