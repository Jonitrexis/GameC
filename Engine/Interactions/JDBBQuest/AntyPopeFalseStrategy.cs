using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Items.JDBBQuest;


namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class AntyPopeFalseStrategy : IAntyPopeStrategy
    {
        public bool Execute(GameSession ses, KingEncounter king, bool complete)
        {
            if (complete || !ses.TestForItem("item9005"))
            {
                ses.SendText("*Zajęty budową papieżodestruktoinatora nie słyszy Cię przez huk narzędzi.*");
                return true;
            }
            else
            {
                ses.SendText("AntyPapież: Ave Satan, jestem AntyPapieżem. Z czym do mnie przychodzisz?");
                int choice = ses.GetListBoxChoice(new List<string>() { "Przynoszę ci FRAGMENT EDENU.", "Nie ważne." });
                switch (choice)
                {
                    case 0:
                        ses.SendText("AntyPapież: Nieźle przechytrzyłeś te ciamajdy królewskie. Dzięki za artefakt. Z jego pomocą przejmę władzę nad okręgiem 3 stanów." +
                            "Weź tą siłę, żebyś mógł dalej gnębić niedojdy z zamku.");
                        ses.RemoveThisItem(new EdenFragment());
                        ses.UpdateStat(2, 8);
                        king.ChangeState(new KingInitialState(), true);
                        return true;
                    case 1:
                        break;
                }
                return false;
            }
        }
    }
}
