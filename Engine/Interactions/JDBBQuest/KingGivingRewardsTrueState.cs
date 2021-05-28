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
                ses.SendText("Twoja pomoc dla naszego królestwa była nieoceniona. Pozwól, że w imieniu swoim i Króla podziękuję Ci poprzez ulepszenie Twojej broni.");
                ses.RemoveThisItem(new EnchantedStaff());
                ses.AddThisItem(new EnchantedStaff2());
            }
            if (isEnchantedSword)
            {
                ses.SendText("Twoja pomoc dla naszego królestwa była nieoceniona. Pozwól, że w imieniu swoim i Króla podziękuję Ci poprzez ulepszenie Twojej broni.");
                ses.RemoveThisItem(new EnchantedSword());
                ses.AddThisItem(new EnchantedSword2());
            }
            else
            {
                ses.SendText("Twoja pomoc dla naszego królestwa była nieoceniona. W ramach podziękowania nakładam na Ciebie królewskie błogosławieństwo.");
                for(int i=0; i<7; i++)
                {
                    ses.UpdateStat(i, 5);
                }
            }
            myself.ChangeState(new KingInitialState(), true);
        }
    }
}
