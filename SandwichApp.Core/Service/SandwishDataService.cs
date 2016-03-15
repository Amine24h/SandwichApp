using Amine24hSandwich.Core.Model;
using Amine24hSandwich.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amine24hSandwich.Core.Service
{
    class SandwishDataService
    {
        private static SandwichRepository sandwichRepository = new SandwichRepository();

        public List<Sandwich> GetAllSandwiches()
        {
            return sandwichRepository.GetAllSandwiches();
        }

        public List<SandwichGroup> GetGroupedSandwiches()
        {
            return sandwichRepository.GetGroupedSandwiches();
        }

        public List<Sandwich> GetSandwichesForGroup(int SandwishGroupId)
        {
            return sandwichRepository.GetSandwichesForGroup(SandwishGroupId);
        }

        public List<Sandwich> GetFavoriteSandwiches()
        {
            return sandwichRepository.GetFavoriteSandwiches();
        }

        public Sandwich GetSandwishById(int SandwishId)
        {
            return sandwichRepository.GetSandwichById(SandwishId);
        }
    }
}
