using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubredditLogic
{
    internal interface ISubredditLogic
    {
        public void Setup();

        public void Process();
    }
}
