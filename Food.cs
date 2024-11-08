using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Etterem
{
    internal class Food
    {
        private string name;
        private string description;
        private bool haveIngreedientsForOne;

        private Food(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.haveIngreedientsForOne = HasIngreedientsForOne(name);
        }




        //private Dictionary<ingredientName, select(ingreedient, ingredientName)> usedUpCurrentSelection = new Dictionary<ingredientName, select(ingreedient, ingredientName)>;
        private Dictionary<string, int> usedUpCurrentSelection = new Dictionary<string, int>();
        public bool HasIngreedientsForOne(string name)
        {
            int i = 0;
            List<string> ingredients = SelectReceipt(name, "names");
            List<int> ingredientAmounts = SelectReceipt(name, "ammounts");
            foreach (string item in ingredients)
            {
                if (usedUpCurrentSelection.ContainsKey(item))
                {
                    if (!(ingredientAmounts[i] > usedUpCurrentSelection[item])) return false;
                }
                else { 
                    if /
                }
                i++;
            }
         
        }

        
    }
}
