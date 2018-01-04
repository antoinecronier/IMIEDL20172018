using System;
using System.Collections.Generic;
using System.Text;

namespace IMIEDL20172018
{
    public class MoreAndLess
    {
        private int value;
        private int userSelect;
        private int limitCheck;
        private readonly int maxCheck = 5;
        private int min = 1;
        private int max = 100;

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public int UserSelect
        {
            get { return userSelect; }
            set { userSelect = value; }
        }

        public MoreAndLess()
        {
            Initialisation();
        }

        public MoreAndLess(int maxCheck)
        {
            this.maxCheck = maxCheck;
            Initialisation();
        }

        public MoreAndLess(int maxCheck, int min, int max)
        {
            this.maxCheck = maxCheck;
            this.min = min;
            this.max = max;
            Initialisation();
        }

        private void Initialisation()
        {
            Random rand = new Random();
            Value = rand.Next(min, max);
            limitCheck = maxCheck;

            Console.WriteLine("Start more and less\n\t- get " + maxCheck + " chances\n\t- Number between " + min + " & " + max);
        }

        public void Play()
        {
            bool loop = true;

            while (loop)
            {

                UserSelect = SelectValue();

                if (limitCheck > 0)
                {
                    limitCheck--;
                    if (Value.Equals(UserSelect))
                    {
                        OnFounded(new EventArgs());
                        Console.WriteLine("Found " + value + " in " + (maxCheck - limitCheck) + " rounds.");
                        loop = false;
                    }
                    else if (Value > UserSelect)
                    {
                        OnMore(new EventArgs());
                        Console.WriteLine("It's more (+)");
                    }
                    else if (Value < UserSelect)
                    {
                        OnLess(new EventArgs());
                        Console.WriteLine("It's less (-)");
                    }
                }
                else
                {
                    OnLoose(new EventArgs());
                    loop = false;
                    Console.WriteLine("You lose this");
                }
            }
        }

        public void PlayWPF(int value)
        {
            if (limitCheck > 0)
            {
                limitCheck--;
                if (Value.Equals(value))
                {
                    OnFounded(new EventArgs());
                    Console.WriteLine("Found " + value + " in " + (maxCheck - limitCheck) + " rounds.");
                }
                else if (Value > value)
                {
                    OnMore(new EventArgs());
                    Console.WriteLine("It's more (+)");
                }
                else if (Value < value)
                {
                    OnLess(new EventArgs());
                    Console.WriteLine("It's less (-)");
                }
            }
            else
            {
                OnLoose(new EventArgs());
                Console.WriteLine("You lose this");
            }
        }

        private int SelectValue()
        {
            Console.Write("Select your number : ");
            string value = Console.ReadLine();
            int result;

            if (!Int32.TryParse(value, out result))
            {
                Console.WriteLine("Error, retry :");
                SelectValue();
            }

            return result;
        }


        public event EventHandler More;

        protected virtual void OnMore(EventArgs e)
        {
            EventHandler handler = More;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler Less;

        protected virtual void OnLess(EventArgs e)
        {
            EventHandler handler = Less;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler Founded;

        protected virtual void OnFounded(EventArgs e)
        {
            EventHandler handler = Founded;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler Loose;

        protected virtual void OnLoose(EventArgs e)
        {
            EventHandler handler = Loose;
            if (handler != null)
            {
                handler(this, e);
            }
        }

    }
}
