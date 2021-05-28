using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.JDBBQuest
{
    [Serializable]
    abstract class JDBBQuestItem : Item
    {
        public JDBBQuestItem(string name) : base(name)
        {   
        }
    }
}
