using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Hobby
    {
        public string ThingToDo { get; set; }
        public bool Crafty { get; set; }

        public string TheHobbyIsCrafty()
        {
            return Crafty
                ? $"My favorite hobby is {ThingToDo}. I am crafty!"
                : $"My favorite hobby is {ThingToDo}. I do not like crafts!";
        }
    }
}
