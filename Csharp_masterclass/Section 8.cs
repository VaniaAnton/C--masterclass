using System;
using System.Collections.Generic;

namespace Section.Eight
{
	public  class Debugging 
	{

        public static void MainDebug()
        {
            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelika" };
            //var friends = new List<string>();
            var partyFriends = GetPartyFriends(friends, 10);

            foreach (var name in friends)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-------------");
            foreach (var name in partyFriends)
            {
                Console.WriteLine(name);
            }
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException("list", "List is empty");
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Cannot be greater then elem in the list or lower zero");
            
            var buffer = new List<string>(list);
            var partyFriends = new List<string>();
            while (partyFriends.Count < count)
            {
                string currentFriend = GetPartyFriend(buffer);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend);
                
            }
            return partyFriends;
        }

        /// <summary>
        /// this is the logic to figure out who is a partyFriend
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
	}
}

