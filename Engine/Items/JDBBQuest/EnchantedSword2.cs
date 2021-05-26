using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.JDBBQuest
{
    [Serializable]
    class EnchantedSword2: Sword
    {
        
        public EnchantedSword2() : base("item9003")
        {
            StrMod = 100;
            GoldValue = 200;
            PublicName = "Zaklęty Miecz+";
            PublicTip = "Podczas wykonywania questa miej ten przedmiot wyekwipowany.";
        }
    }
}
