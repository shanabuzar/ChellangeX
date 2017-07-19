using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXo.Repositories.Repositories
{
    public class BaseDbContext
    {
        private ChallengeXEntities ex;
        public BaseDbContext(ChallengeXEntities ex)
        {
           this.ex = new ChallengeXEntities();

        }

    }
}
