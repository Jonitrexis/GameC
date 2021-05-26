using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    interface IAntyPopeStrategy
    {
        bool Execute(GameSession ses, KingEncounter king, bool complete);
    }
}
