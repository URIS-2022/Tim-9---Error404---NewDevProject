using System;
namespace AuctionService.Repository
{
	public interface IKupacRepository
	{
		//Check if user exist
		public bool checkIfUserExist(string username, string passwprd);
	}
}

