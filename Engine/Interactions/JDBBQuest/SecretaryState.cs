using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    abstract class SecretaryState
    {
       public abstract void RunContent(GameSession ses, SecretaryEncounter myself, AntyPopeEncounter antyPope, PopeEncounter pope);
       
    }
}
