using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{   
    [Serializable]
    class AntyPopeTrueStrategy : IAntyPopeStrategy
    {
        public bool Execute(GameSession ses, KingEncounter king, bool complete)
        {
            ses.SendText("Ave Satan, jestem AntyPapieżem. Z czym do mnie przychodzisz?");
            int choice = ses.GetListBoxChoice(new List<string>() { "Przynoszę ci FRAGMENT EDENU.", "Nie ważne." });
            switch (choice)
            {
                case 0:
                    ses.SendText("Każdy kłamie, a Ty jeden ćwierćinteligent na całym świecie chcesz prawdę mówić," +
                        " głupcze co zaburzył równowagę 400 wymiarów. Skoro taki jesteś chojrak to zobaczymy jak sobie poradzisz z tym!!!");
                    ses.FightRandomMonster();
                    ses.FightRandomMonster();
                    ses.FightRandomMonster();
                    ses.FightRandomMonster();
                    ses.FightRandomMonster();
                    king.ChangeState(new KingInitialState(), true);
                    return true;
                case 1:
                    break;
            }
            return false;
        }
    }
}
