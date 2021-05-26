using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.JDBBQuest
{
    [Serializable]
    class EnchantedStaff2: Staff
    {
        
        public EnchantedStaff2(): base("item9004")
        {
            MgcMod = 100;
            GoldValue = 200;
            PublicName = "Zaklęta Różdżka+";
            PublicTip = "Podczas wykonywania questa miej ten przedmiot wyekwipowany.";
        }
    }
}
