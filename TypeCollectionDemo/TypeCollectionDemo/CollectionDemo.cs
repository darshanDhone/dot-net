using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TypeCollectionDemo
{
    class CollectionDemo
    {
        static void Main(string[] args)
        {
            #region
            int[] numberArray = new int[3];
            numberArray[0] = 454;
            numberArray[1] = 4452;
            numberArray[2] = 21;

            for(int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
            #endregion

            #region System.Collections classes

            ArrayList countryList = new ArrayList();
            countryList.Add("India");
            countryList.Add("USA");
            countryList.Add("China");
            countryList.Insert(1, "UK");

            //object initializer
            Person person = new Person() { FirstName = "Darshan", LastName = "Dhone" };
            Console.WriteLine(person.FirstName + " " + person.LastName);
            countryList.Add(person);

            Console.WriteLine(((Person)countryList[4]).FirstName);

            for (int i = 0; i < countryList.Count; i++)
            {
                Console.WriteLine(countryList[i]);
            }
            #endregion


        }
    }
}
