using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class PopeInitialStrategy: IPopeStrategy
    {
        public bool Execute(GameSession ses, KingEncounter king, bool Complete = false)
        {
            ses.SendText("Papież: Nie wiem.");
            return false;
        }
    }
}
