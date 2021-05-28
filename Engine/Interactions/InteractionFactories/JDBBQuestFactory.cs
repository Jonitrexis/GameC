using System;
using System.Collections.Generic;
using System.Linq;
using Game.Engine.Interactions.JDBBQuest;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.InteractionFactories
{
    class JDBBQuestFactory : InteractionFactory
    {
        private int i = 0;
        public List<Interaction> CreateInteractionsGroup(GameSession parentSession)
        {
            if (i == 0)
            {
                i++;
                KingEncounter king = new KingEncounter(parentSession);
                PopeEncounter pope = new PopeEncounter(parentSession, king);
                AntyPopeEncounter antyPope = new AntyPopeEncounter(parentSession, king);
                SecretaryEncounter secretary = new SecretaryEncounter(parentSession, antyPope, pope);
                GuardianEncounter guardian = new GuardianEncounter(parentSession, secretary);
                KingAdvisorEncounter kingAdvisor = new KingAdvisorEncounter(parentSession, guardian);
                return new List<Interaction> { king, pope, antyPope, secretary, guardian, kingAdvisor };
            }
            else return new List<Interaction>();
            
        }
    }
}
