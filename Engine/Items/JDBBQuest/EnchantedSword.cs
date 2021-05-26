using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.JDBBQuest
{
    class EnchantedSword: Sword
    {
        public EnchantedSword() : base("item9001")
        {
            StrMod = 50;
            GoldValue = 100;
            PublicName = "Enczantowany Miecz";
        }
    }
}
