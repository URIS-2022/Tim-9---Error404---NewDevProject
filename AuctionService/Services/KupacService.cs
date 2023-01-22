using System;
using AuctionService.Repository;

namespace AuctionService.Services
{
	public class KupacService : IKupacRepository
	{
		public KupacService() 
		{
		}

        public bool checkIfUserExist(string username, string passwprd)
        {
            throw new NotImplementedException();
        }
    }
}

