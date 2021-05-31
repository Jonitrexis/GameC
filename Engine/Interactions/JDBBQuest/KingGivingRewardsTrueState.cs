using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Items.JDBBQuest;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class KingGivingRewardsTrueState : KingState
    {
        public override void RunContent(GameSession ses, KingEncounter myself)
        {
            bool isEnchantedSword = ses.TestForItem("item9001");
            bool isEnchantedStaff = ses.TestForItem("item9002");
            if(isEnchantedStaff)
            {
                ses.SendText("Król: Twoja pomoc dla naszego królestwa była nieoceniona. Pozwól, że podziękuję Ci poprzez ulepszenie Twojej broni.");
                ses.RemoveThisItem(new EnchantedStaff());
                ses.AddThisItem(Index.ProduceSpecificItem("item9004"));
            }
            if (isEnchantedSword)
            {
                ses.SendText("Król: Twoja pomoc dla naszego królestwa była nieoceniona. Pozwól, że podziękuję Ci poprzez ulepszenie Twojej broni.");
                ses.RemoveThisItem(new EnchantedSword());
                ses.AddThisItem(Index.ProduceSpecificItem("item9003"));
            }
            else
            {
                ses.SendText("Król: Twoja pomoc dla naszego królestwa była nieoceniona. W ramach podziękowania nakładam na Ciebie królewskie błogosławieństwo.");
                for(int i=0; i<7; i++)
                {
                    ses.UpdateStat(i, 5);
                }
            }
            myself.ChangeState(new KingInitialState(), true);
        }
    }
}
