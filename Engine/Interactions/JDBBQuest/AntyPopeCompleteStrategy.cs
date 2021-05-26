using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class AntyPopeCompleteStrategy : IAntyPopeStrategy
    {
        public bool Execute(GameSession ses, KingEncounter king, bool complete)
        {
            ses.SendText("*Zajęty budową papieżodestruktoinatora nie słyszy Cię przez huk narzędzi.*");
            return true;
        }
    }
}
