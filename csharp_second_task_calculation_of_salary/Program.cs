using System.Text;

namespace csharp_second_task_calculation_of_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa umumi emek haqqini daxil edin:");
            double payCheckSalary = (double)Math.Round(double.Parse(Console.ReadLine()));
            Console.WriteLine("Zehmet olmasa iscinin aile veziyyeti haqqinda melumat verin: (e:evli, s:subay, d:dul");
            char marriageStatus = char.Parse(Console.ReadLine());
            if (marriageStatus != 's' && marriageStatus != 'd')
            {

                Console.WriteLine("Zehmet olmasa iscinin elil olub-olmamasi haqda melumat veresiniz: B:beli, X:xeyr");
                char disableStatus = char.Parse(Console.ReadLine());
            }
          
               

                int additionSalaryForMarriedStatus = 50;
                int salaryForFirstChild = 30;
                int salaryForSecondChild = 25;
                int salaryOfThirdChild = 20;
                int salaryForAllChildren = 15;
                int totalSalaryOfChildren = 0;

            if (marriageStatus=='s')
            {
                additionSalaryForMarriedStatus = 0;
            }
                Console.WriteLine("Zehmet olmasa usaqlarin sayini daxil edin:");
                int countofchild = int.Parse(Console.ReadLine());
                Console.WriteLine("Gelir vergisi asagidaki kimi hesablanir:");
             

           
                if (marriageStatus != 's'  && countofchild==0)
                {
                    payCheckSalary += additionSalaryForMarriedStatus;
                }
                else if (marriageStatus != 's'&& countofchild == 1)
                {
                    totalSalaryOfChildren = salaryForFirstChild;

                    payCheckSalary += (additionSalaryForMarriedStatus + totalSalaryOfChildren);
                }
                else if (marriageStatus != 's'  && countofchild == 2)
                {
                    totalSalaryOfChildren += (salaryForFirstChild + salaryForSecondChild);
                    
                    payCheckSalary += (additionSalaryForMarriedStatus + totalSalaryOfChildren);
                }
                else if (marriageStatus != 's' && countofchild == 3)
                {
                    totalSalaryOfChildren = salaryForFirstChild + salaryForSecondChild + salaryOfThirdChild;
                    payCheckSalary += (additionSalaryForMarriedStatus + totalSalaryOfChildren);
                }

                else if (marriageStatus != 's' && countofchild > 3)
                {
                    totalSalaryOfChildren = (salaryForFirstChild + salaryForSecondChild + salaryOfThirdChild + salaryForAllChildren * (countofchild - 3));
                    payCheckSalary += (additionSalaryForMarriedStatus + totalSalaryOfChildren);
                }
                else if (marriageStatus == 's')
                {
                    Console.WriteLine("Subay oldugunuz ucun size aile muavineti dusmur");
                }
                double taxesIncome;
                int deegreOfTaxis;
                double totalTaxes;

            if (payCheckSalary <= 1000)
            {

                taxesIncome = payCheckSalary * 15 / 100;
                deegreOfTaxis = 1;
                totalTaxes=payCheckSalary+taxesIncome;

            }
            else if (payCheckSalary > 1000 && payCheckSalary <= 2000)
            {

                taxesIncome = payCheckSalary * 20 / 100;
                deegreOfTaxis = 2;
                totalTaxes= payCheckSalary + taxesIncome; 

            }

            else if (payCheckSalary > 2000 && payCheckSalary <= 3000)
            {

                taxesIncome = payCheckSalary * 25 / 100;
                deegreOfTaxis = 3;
                totalTaxes = payCheckSalary + taxesIncome;
            }

            else if (payCheckSalary > 3000)
            {

                taxesIncome = payCheckSalary *30 / 100;
                deegreOfTaxis = 4;
                totalTaxes = payCheckSalary + taxesIncome;

            }

            else
            {

                taxesIncome = payCheckSalary * 50 / 100;
                deegreOfTaxis = 5;
                totalTaxes = payCheckSalary + taxesIncome;


            }
                Console.WriteLine($"Iscinin aile muavineti------- {additionSalaryForMarriedStatus}");
                Console.WriteLine($"Iscinin usaq pulu------- {totalSalaryOfChildren}");
                Console.WriteLine($"Iscinin gelir vergi derecesi-------{deegreOfTaxis}");
                Console.WriteLine($"Iscinin gelir vergisi------- {taxesIncome}");
                Console.WriteLine($"Iscinin umumi emek haqqisi------- {totalTaxes}");
                Console.WriteLine($"Iscinin xalis emek haqqisi------- {payCheckSalary}");
            
           













        }
    }
}
