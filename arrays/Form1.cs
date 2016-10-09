using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] lottery_numbers;
            lottery_numbers = new int[1000];



            for (int i = 0; i != (lottery_numbers.Length); i++)
            {
                lottery_numbers[i] = i + 1;
                listBox1.Items.Add(lottery_numbers[i]);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aNumber = int.Parse(textBox1.Text);
            int[] arraySize;
            arraySize = new int[aNumber];

            for (int i = 0; i != (arraySize.Length); i++)
            {
                arraySize[i] = i + 1;
                listBox1.Items.Add(arraySize[i]);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] arrayTimes;
            arrayTimes = new int[10];

            int times = int.Parse(textBox1.Text);

            for (int i = 0; i != (arrayTimes.Length); i++)
            {
                arrayTimes[i] = (i + 1) * times;
                listBox1.Items.Add(times + " times " + (i + 1) + " = " + arrayTimes[i]);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int arrayRows = 5;
            int arrayCols = 3;

            int[,] arrayTimes;
            arrayTimes = new int[arrayRows, arrayCols];

            int mult = 0;

            for (int i = 0; i != arrayRows; i++)
            {
                mult = mult + 10;
                for (int j = 0; j != arrayCols; j++)
                {
                    arrayTimes[i, j] = mult;
                    mult = mult * 10;
                    listBox1.Items.Add(mult + " array pos = " + (i) + " val = " + arrayTimes[i, j]);

                }

                mult = mult / 1000;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int arrayRows = 5;
            int arrayCols = 3;

            int[,] arrayTimes;
            arrayTimes = new int[arrayRows, arrayCols];

            int mult = 0;

            for (int i = 0; i != arrayRows; i++)
            {
                mult = mult + 10;
                for (int j = 0; j != arrayCols; j++)
                {
                    arrayTimes[i, j] = mult;
                    mult = mult * 10;
                    listBox1.Items.Add("araypos = " + mult + " val = " + arrayTimes[i, j]);
                }
                mult = mult / 1000;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] arrayStrings;
            arrayStrings = new string[5];

            arrayStrings[0] = " this ";
            arrayStrings[1] = " is ";
            arrayStrings[2] = " a ";
            arrayStrings[3] = " string ";
            arrayStrings[4] = " array "; 

            foreach (string arrayElement in arrayStrings)
            {
                listBox1.Items.Add(arrayElement);
            }
        }
    }
}
