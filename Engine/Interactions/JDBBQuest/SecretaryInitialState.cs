using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class SecretaryInitialState : SecretaryState
    {
        public override void RunContent(GameSession ses, SecretaryEncounter myself, AntyPopeEncounter antyPope, PopeEncounter pope)
        {
            ses.SendText("\n*Sekretarz ręką wskazuje Ci wyjście i wraca do papierów.*");
        }
    }
}
