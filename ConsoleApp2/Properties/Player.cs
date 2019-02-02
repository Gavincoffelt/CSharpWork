using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Properties
{
    class Player
    {
        private string name;
        public int kills;
        public int deaths;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
        public int Score
        {
            get
            {
                return kills - deaths;
            }
        }
         

    }

}
