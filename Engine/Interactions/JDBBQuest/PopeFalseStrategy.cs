using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Items.JDBBQuest;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class PopeFalseStrategy: IPopeStrategy
    {
        public bool Execute(GameSession ses, KingEncounter king, bool complete)
        {
            if (complete || !ses.TestForItem("item9005"))
            {
                ses.SendText("*Nie zauważa Cię pochłonięty modlitwą*");
                return true;
            }
            else
            {
                ses.SendText("Niech będzie pochwalony, jestem Papieżem. Z czym do mnie przychodzisz?");
                int choice = ses.GetListBoxChoice(new List<string>() { "Przynoszę ci FRAGMENT EDENU.", "Nie ważne." });
                switch (choice)
                {
                    case 0:
                        ses.SendText("“ ”Kłamstwo jest złym nawykiem człowieka i jest ono stale na ustach ludzi źle wychowanych. Lepszy złodziej niż ten," +
                            " co stale kłamstwem się posługuje, obydwaj zaś zgubę odziedziczą w spadku. Wzgarda zazwyczaj towarzyszy kłamcy, a hańba stale ciąży na nim.”" +
                            "Jestem Tobą zawiedziony, za twe czyny spotka Cię zguba!”");
                        ses.RemoveThisItem(new EdenFragment());
                        ses.FightRandomMonster();
                        ses.FightRandomMonster();
                        ses.FightRandomMonster();
                        ses.FightRandomMonster();
                        ses.FightRandomMonster();
                        king.ChangeState(new KingGivingRewardsFalseState());
                        return true;
                    case 1:
                        break;
                }
                return false;
            }
        }
    }
}
