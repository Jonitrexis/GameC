using System;
using Game.Engine.Monsters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class GuardianEnchatedItemStrategy : IGuardianStrategy
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
                ses.SendText("Nasze wspaniałe królestwo zostało dotknięte plagą pająków.Pół królestwa zawalone pająkami, najgorzej." +
                    "Średnio raz w miesiącu ktoś wdepnie w pajęczynę czy jaja i trzeba wysyłać eksterminatorów, bo to cholerstwo mnoży się straszliwie. Pozbądź się ich.");
                for (int i = killed; killed < 10; i++, killed++)
                {
                    int choice = ses.GetListBoxChoice(new List<string>() { "Wlacz.", "Skłam", "Odejdź." });
                    switch (choice)
                    {
                        case 0:
                            ses.FightThisMonster(new Spider());
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
