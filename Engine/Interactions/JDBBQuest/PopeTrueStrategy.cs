using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Items.JDBBQuest;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class PopeTrueStrategy : IPopeStrategy
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
                        ses.SendText("Potomku Adama i Ewy wdzięczny jestem Ci za Twe dobre dary. Ten artefakt pomoże mi nieść dobrą nowinę na świat." +
                            "Niech Ci Pan błogosławi, a i ja Ci pobłogosławię. Weź te kilka sztuk złota i udaj się do Króla, który przekaże Ci resztę Twojej nagrody.");
                        ses.RemoveThisItem(new EdenFragment());
                        ses.UpdateStat(8, 5);
                        king.ChangeState(new KingGivingRewardsTrueState());
                        return true;
                    case 1:
                        break;
                }
                return false;
            }
        }
    }
}
