using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

public int NumberOfPrimes()
        {
            int a, b, j, flag;

            int count = 0;

            a = Convert.ToInt32(Console.ReadLine());
            

            b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {

                if(i == 1 || i == 0)
                {

                    continue;

                }

                flag = 1;

                for (j = 2; j <= (i/2); j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if(flag == 1)
                {
                    count++;
                }

            }

            return count;

        }
