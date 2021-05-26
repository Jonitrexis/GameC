using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    abstract class KingState
    {
        public abstract void RunContent(GameSession ses, KingEncounter myself);
    }
}
