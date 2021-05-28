using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Items.JDBBQuest;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class SecretaryInProgressFalseState : SecretaryState
    {
        public override void RunContent(GameSession ses, SecretaryEncounter myself, AntyPopeEncounter antyPope, PopeEncounter pope)
        {
            ses.SendText("\nSekretarz: Witaj wędrowcze, dzięki Ci za rozprawienie się z potworami." +
                " Miałbym dla Ciebie jeszcze jedno zlecenie. Potrzebuję by ktoś odpowiedzialny" +
                " przekazał ten oto FRAGMENT EDENU Papieżowi. Pod żadnym pozorem nie zanoś go AntyPapieżowi!");
            ses.AddThisItem(Index.ProduceSpecificItem("item9005"));
            antyPope.currentStrategy = new AntyPopeFalseStrategy();
            pope.currentStrategy = new PopeFalseStrategy();
            myself.ChangeState(new SecretaryCompleteState(), true);
        }
    }
}
