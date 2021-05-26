using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.JDBBQuest
{
    class EnchantedStaff: Staff
    {
        public EnchantedStaff() : base("item9002")
        {
            MgcMod = 50;
            GoldValue = 100;
            PublicName = "Zaklęta Różdżka";
            PublicTip = "Podczas wykonywania questa miej ten przedmiot wyekwipowany.";
        }

    }
}
