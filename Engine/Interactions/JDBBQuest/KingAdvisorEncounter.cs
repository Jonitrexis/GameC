using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class KingAdvisorEncounter : PlayerInteraction
    {
        private KingAdvisorState currentState;
        private GuardianEncounter guardian;
        public KingAdvisorEncounter(GameSession ses, GuardianEncounter _guardian) : base(ses)
        {
            parentSession = ses;
            Name = "interaction9006";
            this.guardian = _guardian;
            currentState = new KingAdvisorInitialState();
        }
        protected override void RunContent()
        {
            currentState.RunContent(parentSession, this, guardian);
        }
        public void ChangeState(KingAdvisorState newState, bool isCompleted = false)
        {
            currentState = newState;
            if (isCompleted) Complete = true; // while changing state, we may also want to set this property
        }
    }
}
