using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    interface IChatRoomMediator
    {
        void SendMessage(User user, String message);
    }

    class ChatRoom : IChatRoomMediator
    {
        public void SendMessage(User user, string message)
        {
            Console.WriteLine(user.userName + ": " + message);
        }
    }

    class User
    {
        protected IChatRoomMediator chatRoom;
        public String userName;

    public User(IChatRoomMediator chatRoom, String userName)
        {
            this.userName = userName;
            this.chatRoom = chatRoom;
        }

        public void Send(String message)
        {
            chatRoom.SendMessage(this, message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChatRoom chatRoom = new ChatRoom();
            User userA = new User(chatRoom, "A");
            User userB = new User(chatRoom, "B");

            userA.Send("Hello!");
            userB.Send("Hi!");
            Console.ReadLine();
        }
    }
}
