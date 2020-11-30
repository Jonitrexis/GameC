﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Monsters
{
    [Serializable]
    class RatEvolved : Monster
    {
        // evolved rat - this time also with venom
        public RatEvolved()
        {
            Health = 60;
            Strength = 15;
            Armor = 0;
            Precision = 50;
            MagicPower = 0;
            Stamina = 70;
            XPValue = 40;
            Name = "monster0002";
            BattleGreetings = "Now I'm back... with venom!"; // this rat actually has something to say
        }
        public override List<StatPackage> BattleMove()
        {
            if (Stamina > 0)
            {
                Stamina -= 10;
                return new List<StatPackage>()
                { 
                    // the same bite move as in Rat, but also with 15 poison damage
                    new StatPackage(DmgType.Cut, 5 + Strength, "Rat uses Bite! ("+ (5 + Strength) +" cut damage)"),
                    new StatPackage(DmgType.Poison, 15, "Venom burns in your veins (15 poison damage)")
                };
            }
            else
            {
                return new List<StatPackage>() { new StatPackage(DmgType.Other, 0, "Rat has no energy to attack anymore!") };
            }
        }
    }
}
