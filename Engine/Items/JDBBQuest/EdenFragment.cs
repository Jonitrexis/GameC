using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.JDBBQuest
{
    class EdenFragment:JDBBQuestItem
    {
        public EdenFragment() : base("item9005")
        {
            PublicName = "Fragment Edenu";
            GoldValue = 0;
            StrMod = 0;
            PublicTip = "Podczas wykonywania questa miej ten przedmiot wyekwipowany.";
        }
    }
}
