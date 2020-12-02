using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Models
{
    public class Hero : Character
    {
        private string heroSecret { get; set; }

        public new Hero Clone()
        {
            return new Hero
            {
                Class = Class,
                Hat = new Hat
                {
                    Name = Hat.Name
                },
                HP = HP,
                Level = Level,
                SP = SP,
            };
        }
    }
}
