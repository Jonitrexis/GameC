using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class GuardianInitialStrategy : IGuardianStrategy
    {
        public bool Execute(GameSession ses, SecretaryEncounter secretary, bool Complete = false)
        {
            ses.SendText("Czego tu szukasz? Zmykaj mi stąd.");
            return false;
        }
    }
}
