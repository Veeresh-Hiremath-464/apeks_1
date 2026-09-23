using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Project
{
    internal class State
    {
        //Hasthtable
        public void StoreDetails()
        {
            //Hashtable stateTable = new Hashtable();

            // SortedList based on key names
            SortedList stateTable = new SortedList();

            stateTable.Add("KAR", "Karnataka");
            stateTable.Add("TN", "Tamilnadu");
            stateTable.Add("MAH", "Maharastra");
            foreach(DictionaryEntry items in stateTable)
            {
                Console.WriteLine("{0}\t {1}",items.Key,items.Value);
            }

            Console.WriteLine(stateTable.ContainsKey("KAR"));
            Console.WriteLine(stateTable.ContainsValue("Karnataka"));

            // remove
            stateTable.Remove("MAH");

            Console.WriteLine("================================");
            foreach (DictionaryEntry items in stateTable)
            {
                Console.WriteLine("{0}\t {1}", items.Key, items.Value);
            }

        }

        


    }
}
