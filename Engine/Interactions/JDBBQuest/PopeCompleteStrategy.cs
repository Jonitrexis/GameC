using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class PopeCompleteStrategy: IPopeStrategy
    {
        public bool Execute(GameSession ses, KingEncounter king, bool Complete = false)
        {
            ses.SendText("*Nie zauważa Cię pochłonięty modlitwą*");
            return true;
        }
    }
}
