using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP_3
{
    internal class Task4
    {
        // Возможно какаято итеративная структура, которая выполняет рекурсивно действия, которые вызывают разные абстрактные модули.
        // List<GameAction>
    }

    public class GameAction
    {
        List<GameAction> actions;
        public void currentAction() 
        {
            // some action
            foreach (var item in actions)
            {
                item.currentAction();
            }
        }
    }
}
