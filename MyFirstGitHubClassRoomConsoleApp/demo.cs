using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class demo
    {
        private int _great_property;

        public int GreatProperty
        {
            get { return _great_property; }
            set { _great_property = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public demo(int great, string name)
        {
            GreatProperty = great;
            Name = name;
        }


    }
}
