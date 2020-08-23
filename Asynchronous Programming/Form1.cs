using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syed_Rumail_Exercise03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Event when factorial button is clicked
        private async void fact_button_Click(object sender, EventArgs e)
        {
            try
            {
                // shifts the control to asynchronous method Run
                await Run();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private async Task Run()
        {
            BigInteger factorial = 0;
            await Task.Run(async () => {
                factorial = await Factorial(Convert.ToInt64(factorial_input.Text));
            });
            if (factorial != 0)
            {                
                MessageBox.Show("The factorial is " +factorial.ToString());
            }

        }

        // Calculates the factorial
        private async Task<BigInteger> Factorial(long num)
        {
            BigInteger factorial = 1;
            for (long i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        // Method using Lambda to find wether the number is even or odd using Function
        private static bool IsEven(int number) => number % 2 == 0;
        Func<int, bool> evenOdd = IsEven;

        private void Even_Odd_Btn_Click(object sender, EventArgs e)
        {
            string temp = "Even";
            string flag = "Odd";

            if(evenOdd(Int32.Parse(Even_OddTB.Text))==true)
            {
                MessageBox.Show(" The number is  " + temp);
            }
            else
            {
                MessageBox.Show(" The number is  " + flag);
            }

        }

        
        List<int> intList = new List<int>();
        List<double> doubleList = new List<double>();
        List<char> charList = new List<char>();

        // The Value Generator Button even to display the list in the ListBox
        private void ValGenBtn_Click(object sender, EventArgs e)
        {
            // initiating a random variable
            var rand = new Random();
           
           // checking radio button and adding values to the appropriate List 
           // and displaying it in the ListBox
            if (IntRB.Checked==true)
            {
                for (int i = 0; i < 10; i++)
                {
                    intList.Add(rand.Next(10,99));

                }
                Values.DataSource = intList;
            }
            else if (DoubleRB.Checked == true)
            {
                for (double i = 0; i < 10; i++)
                {
                    doubleList.Add(rand.Next(10, 99));

                }
                Values.DataSource = doubleList;
            }
            else if (CharRB.Checked == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    charList.Add((char)rand.Next('a', 'z'));
                }             
                Values.DataSource = charList;
            }
        }
        // Generic Method to Search the List
        public static void Search<T>(List<T> dataArray, T searchKey) where T : IComparable<T> // implements IComparable
        {
            var flag = 1; // flag will track the location and will be returned

            for (int i = 0; i < dataArray.Count; i++)
            {
                if (dataArray[i].CompareTo(searchKey) == 0) // CompareTo Compares each element in array with the search Key
                {
                    flag = i; // flag set to the location of the searchKey
                    break; // exits the if block
                }

                else flag = -1; // -1 is returned if the search key is not found               
            }

            if (flag == -1)
            {
                // Message Box to Display the Output
                MessageBox.Show($"'{searchKey}' Not Found in List");
               
            }
            else
            {
                // Message Box to Display the Output
                MessageBox.Show($"'{searchKey}' is at {flag}th position");
                 
            }
        }

        // Event for the Search button Click
        private void SearchValBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // checking radio button and Searching the appropriate List 
                // and displaying it in the Message Box
                if (IntRB.Checked == true)
                {
                    var sch = Int32.Parse(searchTB.Text);
                    Search(intList, sch);
                }
                else if (DoubleRB.Checked == true)
                {
                    var sch = Double.Parse(searchTB.Text);
                    Search(doubleList, sch);
                }
                else if (CharRB.Checked == true)
                {
                    var sch = Char.Parse(searchTB.Text);
                    Search(charList, sch);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Generic Method to display the List between two indexes
        public static List<T> Display<T>(List<T> dataArray, int lowIndex , int highIndex) where T : IComparable<T> 
        {           
            List<T> flag = new List<T>();
            for(int i = lowIndex;i<highIndex;i++)
            {
                flag.Add(dataArray.ElementAt(i));

            }
            // returns a list with the required values
            return flag;
        }

        //Event for the Display Button Click
        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // checking radio button and Searching the appropriate List 
                // and displaying it in the Output List Box
                if (IntRB.Checked == true)
                {
                    OutputLB.DataSource = Display(intList, Int32.Parse(LowIndTB.Text), Int32.Parse(HighIndTB.Text));
                }
                else if (DoubleRB.Checked == true)
                {
                    OutputLB.DataSource = Display(doubleList, Int32.Parse(LowIndTB.Text), Int32.Parse(HighIndTB.Text));
                }
                else if (CharRB.Checked == true)
                {
                    OutputLB.DataSource = Display(charList, Int32.Parse(LowIndTB.Text), Int32.Parse(HighIndTB.Text));
                }

            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message +"Please enter the indexes in range 0 to 10");
            }
            catch(Exception check)
            {
                MessageBox.Show(check.Message);
            }
        }
    }
}
