using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Results2
{
    class Program
    {
        static void Main(string[] args)
        {
            Results peter = new Results();
            Results smith = new Results();

            Console.Write("Peter's results\n");
            peter.physics = 90;
            peter.chemistry = 90;
            peter.mathematics = 90;
            peter.showResults();

            Console.Write("smith's results\n");
            smith.physics = 91;
            smith.chemistry = 90;
            smith.mathematics = 89;
            smith.showResults();
            Console.Read();
        }
    }
    class Results
    {
        private int phys, chem, math, numFailed;
        public int physics
        {
            set
            {
                if (value >= 0 && value <= 150)
                {
                    this.phys = value;
                }
                else
                {
                    this.phys = -1;
                    Console.Write("Invalid Physics Mark\n");
                }
            }
            get
            {
                return this.phys;
            }
        }
        public int mathematics
        {
            set
            {
                if (value >= 0 && value <= 150)
                {
                    this.math = value;
                }
                else
                {
                    this.math = -1;
                    Console.Write("Invalid Mathematics Mark\n");
                }
            }
            get
            {
                return this.math;
            }
        }
        public int chemistry
        {
            set
            {
                if (value >= 0 && value <= 150)
                {
                    this.chem = value;
                }
                else
                {
                    this.chem = -1;
                    Console.Write("Invalid Chemistry Mark\n");
                }
            }
            get
            {
                return this.chem;
            }
        }


        private void checkFailed()
        {
            numFailed = 0;
            if (phys < 90)
                numFailed++;
            if (chem < 90)
                numFailed++;
            if (math < 90)
                numFailed++;
        }

        public void showResults()
        {
            int total;
            float percentage;

            checkFailed();

            if (phys == -1 || chem == -1 || math == -1)
            {
                Console.Write("No results available\n");
            }
            else
            {
                switch (numFailed)
                {
                    case 0:
                        total = phys + chem + math;
                        percentage = (float)total * 100 / 450;
                        Console.Write("Total marks: {0}\n", total);
                        Console.Write("Percentage: {0}%\n", percentage);
                        break;
                    case 1:
                        Console.Write("Retake the exam\n");
                        break;
                    case 2:
                        Console.Write("Retake the course\n");
                        break;
                    case 3:
                        Console.Write("Go Home!\n");
                        break;
                }
            }
        }
    }
}