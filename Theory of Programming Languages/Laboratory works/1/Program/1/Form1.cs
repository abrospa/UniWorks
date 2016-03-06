using System;
using System.Drawing;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        int[,] transTable = new int[30, 2];

        public Form1()
        {
            InitializeComponent();
            FillTransTable();
        }

        private void FillTransTable()
        {
            transTable[0, 0] = 1;
            transTable[0, 1] = 13;
            transTable[1, 0] = 2;
            transTable[1, 1] = 6;
            transTable[2, 0] = -1;
            transTable[2, 1] = 3;
            transTable[3, 0] = -1;
            transTable[3, 1] = 4;
            transTable[4, 0] = -1;
            transTable[4, 1] = 5;
            transTable[5, 0] = -1;
            transTable[5, 1] = 5;
            transTable[6, 0] = 7;
            transTable[6, 1] = 9;
            transTable[7, 0] = -1;
            transTable[7, 1] = 8;
            transTable[8, 0] = -1;
            transTable[8, 1] = 5;
            transTable[9, 0] = 10;
            transTable[9, 1] = 11;
            transTable[10, 0] = -1;
            transTable[10, 1] = 5;
            transTable[11, 0] = 12;
            transTable[11, 1] = 11;
            transTable[12, 0] = -1;
            transTable[12, 1] = 5;
            transTable[13, 0] = 14;
            transTable[13, 1] = 21;
            transTable[14, 0] = 15;
            transTable[14, 1] = 17;
            transTable[15, 0] = -1;
            transTable[15, 1] = 16;
            transTable[16, 0] = -1;
            transTable[16, 1] = 5;
            transTable[17, 0] = 18;
            transTable[17, 1] = 19;
            transTable[18, 0] = -1;
            transTable[18, 1] = 5;
            transTable[19, 0] = 20;
            transTable[19, 1] = 19;
            transTable[20, 0] = -1;
            transTable[20, 1] = 5;
            transTable[21, 0] = 22;
            transTable[21, 1] = 26;
            transTable[22, 0] = 23;
            transTable[22, 1] = 24;
            transTable[23, 0] = -1;
            transTable[23, 1] = 5;
            transTable[24, 0] = 25;
            transTable[24, 1] = 24;
            transTable[25, 0] = -1;
            transTable[25, 1] = 5;
            transTable[26, 0] = 27;
            transTable[26, 1] = 26;
            transTable[27, 0] = 28;
            transTable[27, 1] = 29;
            transTable[28, 0] = -1;
            transTable[28, 1] = 5;
            transTable[29, 0] = 28;
            transTable[29, 1] = 29;
        }

        private bool IsFinalState(int stateNumber)
        {
            bool value = false;
            switch (stateNumber)
            {
                case 5:
                    return true;
                case 12:
                    return true;
                case 20:
                    return true;
                case 28:
                    return true;
                default:
                    break;
            }
            return value;
        }

        private bool IsAccepted(string text)
        {
            int currentState = 0;
            bool finalState = false;

            foreach (char symbol in text)
            {
                if (symbol == 'a')
                    currentState = transTable[currentState, 0];
                else if (symbol == 'b')
                    currentState = transTable[currentState, 1];
                else return 
                    false;

                if (currentState == -1)
                    return false;
            }

            if (IsFinalState(currentState))
                return true;
            return false;
        }        

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string text = textBoxInput.Text;
            if (IsAccepted(text))
            {
                labelOutput.Location = new Point(186, 40);
                labelOutput.ForeColor = Color.Green;
                labelOutput.Text = "Строка принята.";
            }
            else
            {
                labelOutput.Location = new Point(171, 40);
                labelOutput.ForeColor = Color.Red;
                labelOutput.Text = "Строка отвергнута.";
            }
        }
    }
}
