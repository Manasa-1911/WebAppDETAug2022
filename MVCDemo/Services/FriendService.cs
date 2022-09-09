using Microsoft.AspNetCore.Components.Web.Virtualization;
using MVCDemo.Models;

namespace MVCDemo.Services
{
    public class FriendService
    {
        static List<Friend> Friends { get; }
        //public bool IsGlutenFree { get; internal set; }



        static int nextId = 3;
        static FriendService()
        {
            Friends = new List<Friend>
                {
                    new Friend { id = 1, FriendName = "Chandana", Place = "Bangalore" },
                    new Friend { id = 2, FriendName = "Ananya",  Place = "Ankola"  }
                };
        }

        public static List<Friend> GetAll() => Friends;

        public static Friend? Get(int id) => Friends.FirstOrDefault(p => p.id == id);

        public static void Add(Friend friend)
        {
            friend.id = nextId++;
            Friends.Add(friend);
        }

        public static void Delete(int id)
        {
            var friend = Get(id);
            if (friend is null)
                return;

            Friends.Remove(friend);
        }


        public static void Update(Friend friend)
        {
            var index = Friends.FindIndex(p => p.id == friend.id);
            if (index == -1)
                return;

            Friends[index] = friend;
        }
    }
}
