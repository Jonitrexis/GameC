using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class KingAdvisorInProgressState : KingAdvisorState
    {
        public override void RunContent(GameSession ses, KingAdvisorEncounter myself, GuardianEncounter guardian)
        {
            ses.SendText("\nPowiedziałem ci już wszystko co wiedziałem. Powodzenia w twojej wędrówce.");
        }
    }
}
