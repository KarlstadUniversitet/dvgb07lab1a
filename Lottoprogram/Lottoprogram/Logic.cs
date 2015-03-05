using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottoprogram
{
    class Logic
    {
        private Random rnd = new Random();
        private int[] lottoRow { get; set; }
        private int lottoLow = 1;
        private int lottoHigh = 35;
        private int lottoDraws { get; set; }     // the number of draws lotto should use.
        public int[] numTimesRight { get; set; }   // How many times did the lotto give as many rights for the inputer.

        private bool[] successParseRow { get; set; }    // a bool list parse made från string lottoRow to int lottoRow. 
        private bool successParseDraw { get; set; }     // a bool for parse from string draws to int draws. 

        /********************************************/
        /*          CONSTRUCTORS                    */
        /********************************************/ 
        public Logic(String[] _lottoRow, String _lottoDraws)
        {
            // Constructor of the Logics which takes in the information from TextBoxes and parse it.
            this.lottoRow = new int[_lottoRow.Length];
            this.numTimesRight = new int[_lottoRow.Length];

            this.successParseRow = parseStringToInt(_lottoRow, this.lottoRow);
            this.successParseDraw = parseStringToInt(_lottoDraws, this.lottoDraws);
        }

        public Logic(int[] _lottoRow, int _lottoDraws)
        {
            // Constructor which takes an integer list of lottorow and an integer numbr of lottodraws. 
            this.lottoRow = new int[_lottoRow.Length];
            this.numTimesRight = new int[_lottoRow.Length];

            this.lottoRow = _lottoRow;
            this.lottoDraws = _lottoDraws;
        }

        /************************************************/
        /*          Public functions                     */
        /************************************************/
        public bool correctInput()
        {
            // return: false if anything is wrong with the user input. Otherwise true. 
            bool ret = true;

            foreach (bool success in successParseRow)
            {
                if (!success) { ret = false; }
            }
            if (!successParseDraw) { ret = false; }

            foreach (int number in lottoRow)
            {
                if (number > lottoHigh || number < lottoLow) ret = false;
            }

            return ret;
        }


        public void startLotto()
        {
            List<int> rndRow = new List<int>();
            int numRight = 0;

            for (int i = 0; i < this.lottoDraws; i++)
            {
                rndRow = generateRandomLottoRow(this.lottoRow.Length);
                for (int k = 0; k < rndRow.Count; k++)
                {
                    for (int m = 0; m < rndRow.Count; m++)
                    {
                        if (rndRow.ElementAt(m).Equals(this.lottoRow[k]))
                        {
                            numRight++;
                            rndRow.RemoveAt(m);
                        }
                    }
                }
                numTimesRight[numRight]++;
                numRight = 0;
            }
            int[] var = numTimesRight;
        }

        /************************************************************/
        /*      Private functions                                      */
        /**************************************************************/
        private bool[] parseStringToInt(String[] a, int[] b)
        {
            // Tries to parse the containment in the stringList to the intList.
            // return: A list of true and false which represent every parse attempt. 
            bool[] successList = new bool[a.Length];

            for ( int i = 0; i < a.Length; i++) {

                try 
                {
                    this.lottoRow[i] = int.Parse(a[i]);
                    successList[i] = true;
                } catch (Exception) 
                {
                    successList[i] = false;
                }
            }

            return successList;
        }
 
        private bool parseStringToInt(String a, int b)
        {
            // Tries to parse a string to an integer.
            // return: A variable true or false which says if the parse was successful. 
            bool success;

                try
                {
                    this.lottoDraws = int.Parse(a);
                    success = true;
                }
                catch (Exception)
                {
                    success = false;
                }
            

            return success;
        }

        private List<int> generateRandomLottoRow(int lottoLength)
        {
            /* generate a list with random numbers the given numbers lottoLow and lottoHigh as a frame. */
            List<int> randomLottoRow = new List<int>();
            for (int j = 0; j < lottoLength; j++)
            {
                randomLottoRow.Add(this.rnd.Next(lottoLow, lottoHigh));
            }
            return randomLottoRow;
        }

    }
}
