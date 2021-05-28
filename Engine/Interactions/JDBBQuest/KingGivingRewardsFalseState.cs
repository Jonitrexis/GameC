using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Items.JDBBQuest;
using Game.Engine.Items;


namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class KingGivingRewardsFalseState : KingState
    {
        public override void RunContent(GameSession ses, KingEncounter myself)
        {
            bool isEnchantedSword = ses.TestForItem("item9001");
            bool isEnchantedStaff = ses.TestForItem("item9002");
            if (isEnchantedStaff)
            {
                ses.SendText("Król: Ty wywłoko nie kochana przez matkę! Król w swojej hojności łaskawie pozwala Ci na wykonanie misji,"+
                    " a Ty bandyto nie myty swoimi plugawymi ustami kłamstwa obrzydliwe mi tu przedstawiasz? Myślałeś poczwaro, że "+
                    "mój iloraz inteligencji tak samo jak Twój zamyka się w jednocyfrowej liczbie? Obyś sczezł pomiocie diabelski! Niech"+
                    " się rozstąpi pod Tobą ziemia! Niech Cię pochłoną bramy piekielne, a diabły będą zabawiać się torturami Twojego"+
                    " nędznego ciała. Niech Ci się nawet nie roi w Twoim mysim móżdżku, że nagrodę dostaniesz! W Twoich brudnych łapskach"+
                    " nie powinien znajdować się tak dobry przedmiot. Dla takich jak Ty to są zafajdane sztachetki, których nikt by nawet kijem przez szmatę nie dotknął. A kysz! A kysz! Zgiń przepadnij!");
                ses.RemoveThisItem(new EnchantedStaff());
                ses.AddThisItem(Index.ProduceSpecificItem("item9004"));
            }
            if (isEnchantedSword)
            {
                ses.SendText("Król: Ty wywłoko nie kochana przez matkę! Król w swojej hojności łaskawie pozwala Ci na wykonanie misji," +
                    " a Ty bandyto nie myty swoimi plugawymi ustami kłamstwa obrzydliwe mi tu przedstawiasz? Myślałeś poczwaro, że " +
                    "mój iloraz inteligencji tak samo jak Twój zamyka się w jednocyfrowej liczbie? Obyś sczezł pomiocie diabelski! Niech" +
                    " się rozstąpi pod Tobą ziemia! Niech Cię pochłoną bramy piekielne, a diabły będą zabawiać się torturami Twojego" +
                    " nędznego ciała. Niech Ci się nawet nie roi w Twoim mysim móżdżku, że nagrodę dostaniesz! W Twoich brudnych łapskach" +
                    " nie powinien znajdować się tak dobry przedmiot. Dla takich jak Ty to są zafajdane sztachetki, których nikt by nawet kijem przez szmatę nie dotknął. A kysz! A kysz! Zgiń przepadnij!");
                ses.RemoveThisItem(new EnchantedSword());
                ses.AddThisItem(Index.ProduceSpecificItem("item9003"));
            }
            else
            {
                ses.SendText("Król: Ty wywłoko nie kochana przez matkę! Król w swojej hojności łaskawie pozwala Ci na wykonanie misji," + 
                    "a Ty bandyto nie myty swoimi plugawymi ustami kłamstwa obrzydliwe mi tu przedstawiasz? Myślałeś poczwaro, że " +
                    "mój iloraz inteligencji tak samo jak Twój zamyka się w jednocyfrowej liczbie? Obyś sczezł pomiocie diabelski! Niech"+
                    " się rozstąpi pod Tobą ziemia! Niech Cię pochłoną bramy piekielne, a diabły będą zabawiać się torturami Twojego"+
                    " nędznego ciała. Niech Ci się nawet nie roi w Twoim mysim móżdżku, że nagrodę dostaniesz! A kysz! A kysz! Zgiń przepadnij!");
            }
            myself.ChangeState(new KingInitialState(), true);
        }
    }
}

