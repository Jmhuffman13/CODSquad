using CODSquadConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CODSquadConsole
{
    public interface IGamerRepository
    {
        public IEnumerable<Gamer> GetGamers();

    }
}
