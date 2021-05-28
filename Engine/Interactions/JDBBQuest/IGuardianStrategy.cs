using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    interface IGuardianStrategy
    {
        bool Execute(GameSession ses, SecretaryEncounter secretary, bool Complete = false);
    }
}
