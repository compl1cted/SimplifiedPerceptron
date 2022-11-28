using System.Diagnostics;

namespace SimplifiedPerceptron
{
    public partial class Form1 : Form
    {
        private const int MatrixColumns = 3;
        private const int MatrixRows = 5;
        private readonly Button[,] ButtonMatrix = new Button[MatrixColumns, MatrixRows];
        private readonly Neuron Neuron = new(15, 50);
        public Form1()
        {
            InitializeComponent();
            GenerateButtonMatrix();
            CurrentNumber.Text = "Number is not entered!";
        }

        private void TestButtonClick(object sender, EventArgs e)
        {
            bool Result = Neuron.ActivationFunction(GetMatrixValues()) == true;
            DialogResult dialogResult = MessageBox.Show("Is Answer Correct?", Result.ToString(), MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                int Editor = Result == false ? 1 : -1;
                Neuron.CorrectWeights(GetMatrixValues(), Editor);
            }
        }

        private void TrainButtonClick(object sender, EventArgs e)
        {
            if (NumberInput.Text == null)
            {
                OutputLabel.Text = "Input can't be empty!";
                return;
            }
            CurrentNumber.Text = NumberInput.Text;
            Neuron.Train(GetMatrixValues());
        }

        private void MatrixButtonClick(object? sender, EventArgs e)
        {
            Button? Button = sender as Button;
            if (Button == null) return;
            Button.BackColor = Button.BackColor == Color.White ? Color.Black : Color.White;
        }

        private int[] GetMatrixValues()
        {
            int Counter = 0;
            int[] MatrixValues = new int[MatrixColumns * MatrixRows];
            for (int i = 0; i < MatrixColumns; i++)
            {
                for (int j = 0; j < MatrixRows; j++)
                {
                    MatrixValues[Counter] = ButtonMatrix[i, j].BackColor == Color.Black ? 1 : 0;
                    Counter++;
                }
            }
            return MatrixValues;
        }

        private void GenerateButtonMatrix()
        {
            for (int y = 0; y < MatrixColumns; y++)
            {
                for (int x = 0; x < MatrixRows; x++)
                {
                    ButtonMatrix[y, x] = new()
                    {
                        Size = new Size(50, 50),
                        Location = new Point(y * 50 + 350, x * 50 + 120),
                    };
                    ButtonMatrix[y, x].Click += MatrixButtonClick;
                    Controls.Add(ButtonMatrix[y,x]);
                }
            }
        }
    }
}