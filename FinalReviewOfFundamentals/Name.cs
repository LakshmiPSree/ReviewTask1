using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReviewOfFundamentals
{
    internal class Name
    {
        public Name()
        {
            AplabeticOrderWithoutUsingInbuitFunction();
        }
        List<String> name = new List<String>()
        {
            "Tanvi","Aparna", "Saloni", "Viji","Ambruta"
        };
        public void AplabeticOrderWithoutUsingInbuitFunction()
        {
            for (int i = 0; i < name.Count; i++)
            {
                for (int j = i + 1; j < name.Count; j++)
                {
                    if (name[i].CompareTo(name[j]) > 0)
                    {
                        string temp = name[i];
                        name[i] = name[j];
                        name[j] = temp;
                    }
                }
            }
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}
