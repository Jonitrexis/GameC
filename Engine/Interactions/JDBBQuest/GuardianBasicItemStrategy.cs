using System;
using Game.Engine.Monsters
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class GuardianBasicItemStrategy: IGuardianStrategy
    {
        private int killed = 0;
        public bool Execute(GameSession ses, SecretaryEncounter secretary, bool Complete = false)
        {
            if (ses.CheckStat(7) < 8)
            {
                ses.SendText("Poziom twojego wytrenowania jest niewystarczający do wykonania mojego zadania. Pozdro poćwicz do 8 poziomu.");
                return false;
            }
            else
            {
                ses.SendText("Nasze królestwo męczy epidemia szczurów. Co raz któryś kogoś ugryzie i już kolejna czarna plaga się zaczyna, a" +
                    "bestyje zajadliwe są i wszystkich szczurołapów zeżarły. Pokonanie ich przyniesie Ci wieczną cześć i chwałę. Powodzenia!");
                for (int i = killed; i <= 7; i++, killed++)
                {
                    int choice = ses.GetListBoxChoice(new List<string>() { "Wlacz.", "Skłam", "Odejdź." });
                    switch (choice)
                    {
                        case 0:
                            ses.FightThisMonster(new Rat());
                            break;

                        case 1:
                            ses.SendText("Gratuluję pokonania wszystkich potworów. Udaj się do Sekretarza, a on poinstruuje Cię dalej.");
                            secretary.ChangeState(new SecretaryInProgressFalseState());
                            return true;
                        case 2:
                            return false;
                    }
                }
                ses.SendText("Gratuluję pokonania wszystkich potworów. Udaj się do Sekretarza, a on poinstruuje Cię dalej.");
                secretary.ChangeState(new SecretaryInProgressTrueState());
                return true;
            }
        }
    }
}
