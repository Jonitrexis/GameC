using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    class KingInitialState : KingState
    {
        public override void RunContent(GameSession ses, KingEncounter myself)
        {
            ses.SendText("\n*strażnicy zagradzają Ci drogę do komnaty Króla*");
            int choice = ses.GetListBoxChoice(new List<string>() { "*Odejdź od króla*"});
            if (choice == 0)
            {
                ses.SendText("\n*Słyszysz zatrzaskujące się za Tobą drzwi*");
            }
        }
    }
}
