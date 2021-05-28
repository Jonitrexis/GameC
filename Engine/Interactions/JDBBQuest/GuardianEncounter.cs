using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class GuardianEncounter : PlayerInteraction
    {
        public IGuardianStrategy currentStrategy { get; set; }
        private SecretaryEncounter secretary;
        public GuardianEncounter(GameSession ses, SecretaryEncounter secretary): base(ses)
        {
            Name = "interaction9005";
            parentSession = ses;
            this.secretary = secretary;
            currentStrategy = new GuardianInitialStrategy();
        }
        protected override void RunContent()
        {
            Complete = currentStrategy.Execute(parentSession, secretary, Complete);
        }
    }
}
