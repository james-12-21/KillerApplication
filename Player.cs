using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class Player
    {
        int id = 0;
        string name = "name";
        private bool isAlive;

        public Player(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int PlayerId
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsAlive
        { 
            get { return isAlive; } 
            set { isAlive = value; }
        }
        
    }
}

