using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class KingAdvisordCompleteState : KingAdvisorState
    {
        public override void RunContent(GameSession ses, KingAdvisorEncounter myself, GuardianEncounter guardian)
        {
            ses.SendText("\nDoradca Króla: Nie mam dla Ciebie więcej zadań. Powodzenia w Twoich kolejnych wędrówkach.");
        }
    }
}
