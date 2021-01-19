﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters.MonsterFactories
{
    [Serializable]
    class CerberusFactory : MonsterFactory
    {
        private int encounterNumber = 0;
        public override Monster Create()
        {
            if (encounterNumber == 0)
            {
                int rng = Index.RNG(1, 51);
                if (rng > 40)
                    encounterNumber++;
                return new Cerberus();
            }
            else return null;
        }
        public override System.Windows.Controls.Image Hint()
        {
            if (encounterNumber == 0) 
                return new Cerberus().GetImage();
            else 
                return null;
        }
    }
}