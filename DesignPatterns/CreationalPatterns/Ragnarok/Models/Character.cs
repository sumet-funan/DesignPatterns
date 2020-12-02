using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Models
{
    public class Character
    {
        public int Level { get; set; }
        public string Class { get; set; }
        public int SP { get; set; }
        public int HP { get; set; }
        public Hat Hat { get; set; }
        private int privateData { get; set; }

        public Character Clone()
        {
            return new Character
            {
                Level = Level,
                Class = Class,
                HP = HP,
                SP = SP,
                Hat = new Hat
                {
                    Name = Hat.Name
                },
                privateData = privateData
            };
        }
    }
}
