using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class PopeEncounter : PlayerInteraction
    {
        public IPopeStrategy currentStrategy {get; set;}
        public KingEncounter king { get; set; }

        public PopeEncounter(GameSession ses, KingEncounter king) : base(ses)
        {
            Name = "interaction9002";
            currentStrategy = new PopeInitialStrategy();
            this.king = king;

        }
        protected override void RunContent()
        {
            Complete = currentStrategy.Execute(parentSession, king, Complete);
        }
    }
}
