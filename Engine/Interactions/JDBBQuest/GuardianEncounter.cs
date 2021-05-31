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
        public IGuardianStrategy CurrentStrategy { get; set; }
        private SecretaryEncounter secretary;
        public GuardianEncounter(GameSession ses, SecretaryEncounter secretary): base(ses)
        {
            Name = "interaction9005";
            parentSession = ses;
            this.secretary = secretary;
            CurrentStrategy = new GuardianInitialStrategy();
        }
        protected override void RunContent()
        {
            Complete = CurrentStrategy.Execute(parentSession, secretary, Complete);
          
        }
    }
}
