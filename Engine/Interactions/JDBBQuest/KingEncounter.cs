using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class KingEncounter:PlayerInteraction
    {
        private KingState currentState;
        public KingEncounter(GameSession ses) : base(ses)
        {
            parentSession = ses;
            Name = "interaction9001";
            currentState = new KingInitialState();
        }
        protected override void RunContent()
        {
            currentState.RunContent(parentSession, this);
        }
        public void ChangeState(KingState newState, bool isCompleted = false)
        {
            currentState = newState;
            if (isCompleted) Complete = true; // while changing state, we may also want to set this property
        }
    }
}
