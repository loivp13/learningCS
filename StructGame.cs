using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
        //CAN USE INTERFACE
    struct StructGame : ICloneable
    {
        // CAN ONLY HAVE CONSTRUCTOR TO DEFINE FIELDS
        public StructGame(string name, string developer, string rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }
        //NO INHERITENCE

        //similar to class
        public string name;
        public string developer;
        public string rating;
        public string releaseDate;

        

        //methods
        public void Display()
        {
            //runs code
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
