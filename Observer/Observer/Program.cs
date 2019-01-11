using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Observer
{
    interface ChatComponent // Observable
    {
        void AddUser(ChatParticipant user);
        void RemoveUser(ChatParticipant user);
        void NotifyMessage(String message);
    }

    class ChatRoom : ChatComponent // ConcreteObservable
    {
        ArrayList users = new ArrayList();

        public void AddUser(ChatParticipant user)
        {
            users.Add(user);
        }

        public void NotifyMessage(String message)
        {
            foreach(User user in users)
            {
                user.ReceiveMessage(message);
            }
        }

        public void RemoveUser(ChatParticipant user)
        {
            users.Remove(user);
        }
    }

    interface ChatParticipant
    {
        void ReceiveMessage(String message);
    }

    class User : ChatParticipant
    {
        String name;

        public User(String name)
        {
            this.name = name;
        }

        public void ReceiveMessage(String message)
        {
                Console.WriteLine(name + ": " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChatRoom chatRoom = new ChatRoom();
            User userA = new User("A");
            User userB = new User("B");
            chatRoom.AddUser(userA);
            Console.WriteLine("Add User A");
            Console.WriteLine("Notify");
            chatRoom.NotifyMessage("Hello");
            Console.WriteLine("Add User B");
            chatRoom.AddUser(userB);
            Console.WriteLine("Notify");
            chatRoom.NotifyMessage("Hi there");
            Console.ReadLine();
        }
    }
}
