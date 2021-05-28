using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class SecretaryCompleteState : SecretaryState
    {
        public override void RunContent(GameSession ses, SecretaryEncounter myself, AntyPopeEncounter antyPope, PopeEncounter pope)
        {
            ses.SendText("\n*Sekretarz podnosi wzrok znad dokumentów i nic nie mówiąc wraca do pracy.*");
        }
    }
}
