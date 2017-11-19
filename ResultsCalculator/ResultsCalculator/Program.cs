using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsCalculator {
    class Program {
        static void Main(string[] args)
        {
            Results Peter = new Results();
            Results Smith = new Results();
            Peter.setPhy(90);
            Peter.setChe(90);
            Peter.setMath(90);
            Peter.showResults();

            Smith.setPhy(89);
            Smith.setChe(0);
            Smith.setMath(32);            
            Smith.showResults();
            Console.Read();
        }
    }
    class Results {
        private int phy, che, math, numFailed;

        public void setPhy(int phy) {
            if (phy >= 0 && phy <= 150)
            {
                this.phy = phy;
            } else {
                this.phy = -1;
                Console.Write("Invalud Physics Mark\n");
            }
        }
        public void setChe(int che) {
            if (che >= 0 && che <= 150)
            {
                this.che = che;
            } else {
                this.che = -1;
                Console.Write("Invalud Chemistry Mark\n");
            }
        }
        public void setMath(int math) {
            if (math >= 0 && math <= 150)
            {
                this.math = math;
            } else {
                this.math = -1;
                Console.Write("Invalud Mathematics Mark\n");
            }
        }
        private void checkFailed()
        {
            numFailed = 0;
            if (phy < 90)
                numFailed++;
            if (che < 90)
                numFailed++;
            if (math < 90)
                numFailed++;
        }
        public void showResults() {
            int total;
            float percentage;

            checkFailed();

            if (phy == -1 || che == -1 || math == -1)
            {
                Console.Write("No results available\n");
            } else {
                switch (numFailed)
                {
                    case 0:
                        total = phy + che + math;
                        percentage = (float)total * 100 / 450;
                        Console.Write("Total marks: {0}\n", total);
                        Console.Write("Percentage: {0}%\n", percentage);
                        break;
                    case 1:
                        Console.Write("Retake the exam");
                        break;
                    case 2:
                        Console.Write("Retake the course");
                        break;
                    case 3:
                        Console.Write("Go Home!");
                        break;
                }                    
            }
        }
    }
}



