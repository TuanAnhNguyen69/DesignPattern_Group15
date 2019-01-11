using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    interface IChatRoomMediator
    {
        void SendMessage(Participant user, String message);
    }

    class ChatRoom : IChatRoomMediator
    {
        public void SendMessage(Participant user, string message)
        {
            Console.WriteLine(user.name + ": " + message);
        }
    }

    class Participant
    {
       public String name;
    }

    class User : Participant
    {
        protected IChatRoomMediator chatRoom;

        public User(IChatRoomMediator chatRoom, String userName)
        {
            this.name = userName;
            this.chatRoom = chatRoom;
        }

        public void Send(String message)
        {
            chatRoom.SendMessage(this, message);
        }
    }

    class Bot : Participant
    {
        protected IChatRoomMediator chatRoom;

        public Bot(IChatRoomMediator chatRoom, String botName)
        {
            this.name = botName;
            this.chatRoom = chatRoom;
        }

        public void Send(String message)
        {
            chatRoom.SendMessage(this, message + "Auto repplied!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChatRoom chatRoom = new ChatRoom();
            User userA = new User(chatRoom, "A");
            Bot bot = new Bot(chatRoom, "B");

            userA.Send("Hello!");
            bot.Send("Hi!");
            Console.ReadLine();
        }
    }
}
