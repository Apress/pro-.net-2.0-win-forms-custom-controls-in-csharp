using System;
using System.Collections.Generic;
using System.Text;

namespace MultithreadingWorker
{
    public delegate void FindPrimesCompletedEventHandler(object sender, FindPrimesCompletedEventArgs e);

    public class EratosthenesTask : ThreadWrapperBase
    {
        public event FindPrimesCompletedEventHandler Completed;

        // Store the input and output information.
        private int fromNumber, toNumber;
        string primeList;

        public EratosthenesTask(int from, int to)
        {
            this.fromNumber = from;
            this.toNumber = to;
            SupportsProgress = true;
        }

        protected override void DoTask()
        {
            int[] list = new int[toNumber - fromNumber];
            int fromNumberCurrent = fromNumber;

            // Create an array containing all integers between the two specified numbers.
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = fromNumberCurrent;
                fromNumberCurrent += 1;
            }


            //find out the module for each item in list, divided by each d, where
            //d is < or == to sqrt(to)
            //if the remainder is 0, the nubmer is a composite, and thus
            //we mark its position with 0 in the marks array,
            //otherwise the number is a prime, and thus mark it with 1
            int maxDiv = (int)Math.Floor(Math.Sqrt(toNumber));

            int[] mark = new int[list.Length];


            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 2; j <= maxDiv; j++)
                {

                    if ((list[i] != j) && (list[i] % j == 0))
                    {
                        mark[i] = 1;
                    }

                }

                int iteration = list.Length / 100;
                if (i % iteration == 0)
                {
                    progress = i / iteration;

                }

            }

            //create new array that contains only the primes, and return that array
            int primes = 0;
            for (int i = 0; i < mark.Length; i++)
            {
                if (mark[i] == 0) primes += 1;

            }

            int[] ret = new int[primes];
            int curs = 0;
            for (int i = 0; i < mark.Length; i++)
            {
                if (mark[i] == 0)
                {
                    ret[curs] = list[i];
                    curs += 1;
                }
            }

            // Paste the list of primes together into one long string.
            StringBuilder sb = new StringBuilder();
            foreach (int prime in ret)
            {
                sb.Append(prime.ToString());
                sb.Append("  ");
            }
            // Store the result.
            primeList = sb.ToString();
        }

        protected override void OnCompleted()
        {
            // Signal that the operation is complete.
            if (Completed != null)
                Completed(this,
                new FindPrimesCompletedEventArgs(fromNumber, toNumber, primeList));
        }

        // Allow access to the result once the task is finished.
        public string GetResultOfLastTask()
        {
            if (Status == StatusState.Completed)
                return primeList;
            else
                return "";
        }
    }


    public class FindPrimesCompletedEventArgs : EventArgs
    {
        private string primeList;
        public string PrimeList
        {
            get { return primeList; }
            set { primeList = value; }
        }

        private int from;
        public int From
        {
            get { return from; }
            set { from = value; }
        }

        private int to;
        public int To
        {
            get { return to; }
            set { to = value; }
        }

        public FindPrimesCompletedEventArgs(int from, int to, string primeList)
        {
            From = from;
            To = to;
            PrimeList = primeList;
        }
    }
}
