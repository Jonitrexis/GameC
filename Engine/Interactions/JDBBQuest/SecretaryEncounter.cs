using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class SecretaryEncounter : PlayerInteraction
    {
        private SecretaryState currentState;
        private AntyPopeEncounter antyPope;
        private PopeEncounter pope;
        public SecretaryEncounter(GameSession ses, AntyPopeEncounter _antyPope, PopeEncounter _pope) : base(ses)
        {
            parentSession = ses;
            Name = "interaction9004";
            this.antyPope = _antyPope;
            this.pope = _pope;
            currentState = new SecretaryInitialState();
        }
        protected override void RunContent()
        {
            currentState.RunContent(parentSession, this, antyPope, pope);
        }
        public void ChangeState(SecretaryState newState, bool isCompleted = false)
        {
            currentState = newState;
            if (isCompleted) Complete = true; // while changing state, we may also want to set this property
        }
    }
}
