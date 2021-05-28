using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Interactions.JDBBQuest
{
    [Serializable]
    class AntyPopeEncounter : PlayerInteraction
    {
        public IAntyPopeStrategy currentStrategy { get; set; }
        private KingEncounter king { get; set; }

        public AntyPopeEncounter(GameSession ses, KingEncounter king) : base(ses)
        {
            Name = "interaction9003";
            currentStrategy = new AntyPopeInitialStrategy();
            this.king = king;

        }
        protected override void RunContent()
        {
            Complete = currentStrategy.Execute(parentSession, king, Complete);
        }

    }
}
