using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class GuardianCompleteStrategy : IGuardianStrategy
    {
        public bool Execute(GameSession ses, SecretaryEncounter secretary, bool Complete = false)
        {
            ses.SendText("Byłeś już u sekretarza? Nie mam dla Ciebie więcej zadań.");
            return true;
        }
    }
}
