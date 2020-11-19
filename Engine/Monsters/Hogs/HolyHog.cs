﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    [Serializable]
    class HolyHog : Monster
    {
        public HolyHog(int holyHogLevel)
        {
            Health = 80 + 15 * holyHogLevel;
            Strength = 10 + holyHogLevel;
            Armor = 5;
            Precision = 30;
            MagicPower = 1 + holyHogLevel;
            Stamina = 1000;
            XPValue = 60 + 4 * holyHogLevel;
            Name = "monster1422";
            BattleGreetings = "Choir of Oinks!";
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 10;
                return new List<StatPackage>()
                {
                    new StatPackage(DmgType.Cut, 8 + Strength, "Holy Hog Charges! (" + (8 + Strength) + " cut damage)"),
                    new StatPackage(DmgType.Fire, 1 * MagicPower, ""),
                    new StatPackage(DmgType.Earth, 1 * MagicPower, ""),
                    new StatPackage(DmgType.Air, 1 * MagicPower, ""),
                    new StatPackage(DmgType.Water, 1 * MagicPower, "It calls all of the elements for help! (" + (4 * MagicPower) + " elemental damage)")
                };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage(DmgType.Other, 0, "Impossible! Holy Hog is out of Stamina!") };
            }
        }
    }
}
