using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Items.JDBBQuest;
using Game.Engine.Interactions.JDBBQuest;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class KingAdvisorInitialState : KingAdvisorState
    {
        public override void RunContent(GameSession ses, KingAdvisorEncounter myself, GuardianEncounter guardian)
        {
            if (ses.CheckStat(7) < 5)
            {
                ses.SendText("\nPoziom twojego wytrenowania jest niewystarczający do wykonania mojego zadania. Pozdro poćwicz do 5 poziomu.");
            }
            else
            {
                if (ses.TestForItemClass(RequiredItem.Staff))
                {
                    ses.SendText("\nWitaj potężny magu doszły mnie wieści, że moi wojownicy potrzebują pomocy." +
                        " Udaj się do dowódcy królewskiej straży, który przekaże ci szczegóły." +
                        " Aby ułatawić ci twoje zadanie, mogę zaoferować tą zaklętą różdżkę");
                    int choice = ses.GetListBoxChoice(new List<string>() { "*Weź różdżkę od Doradcy Króla.*", "*odmów*"});
                    switch(choice)
                    {
                        case 0:
                            ses.AddThisItem(new EnchantedStaff());
                            guardian.currentStrategy = new GuardianEnchatedItemStrategy();
                            break;
                        case 1:
                            guardian.currentStrategy = new GuardianBasicItemStrategy();
                            break;
                    }
                    myself.ChangeState(new KingAdvisordCompleteState(), true);
                }
                else
                {
                    ses.SendText("\nWitaj potężny wojowniku doszły mnie wieści, że moi wojownicy potrzebują pomocy." +
                        " Udaj się do dowódcy królewskiej straży, który przekaże ci szczegóły." +
                        " Aby ułatawić ci twoje zadanie, mogę zaoferować ten zaklęty miecz");
                    int choice = ses.GetListBoxChoice(new List<string>() { "*Weź miecz od Doradcy Króla.*", "*odmów*" });
                    switch (choice)
                    {
                        case 0:
                            ses.AddThisItem(new EnchantedSword());
                            guardian.currentStrategy = new GuardianEnchatedItemStrategy();
                            break;
                        case 1:
                            guardian.currentStrategy = new GuardianBasicItemStrategy();
                            break;
                    }
                    myself.ChangeState(new KingAdvisordCompleteState(), true);
                }
            }  
        }
    }
}
