using Ragnarok.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Models
{
    public class Detardeurus
    {
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int MaxSP { get; set; }
        public int CurrentSP { get; set; }
        public DateTime RespawnIn { get; set; }

        private static Detardeurus instance = new Detardeurus
        {
            MaxHP = 100,
            CurrentHP = 100,
            MaxSP = 50,
            CurrentSP = 50,
        };

        private Detardeurus()
        {
        }

        public static Detardeurus GetInstance(int damage)
        {
            if (instance == null || instance.CurrentHP <= 0)
            {
                instance = new Detardeurus();
            }

            instance.CurrentHP -= damage;

            return instance;
        }

        public static Detardeurus GetInstance(Detardeurus detardeurus, int damage)
        {
            if (detardeurus != null && detardeurus.CurrentHP > 0)
            {
                detardeurus.CurrentHP -= damage;
                return detardeurus;
            }

            instance.CurrentHP = instance.MaxHP - damage;
            
            return instance;
        }
    }
}
