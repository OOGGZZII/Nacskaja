using System;
using System.Collections.Generic;
using System.Linq;
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

        public void fillFoods()
        {

        }




        public bool HasIngreedientsForOne(string name)
        {

        }
    }
}
