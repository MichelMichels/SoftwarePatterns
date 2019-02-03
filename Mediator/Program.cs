using Mediator.Implementation;
using Mediator.Interfaces;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {            
            IChatRoom chatroom = new ChatRoom();

            IChatClient alice = new ChatClient("Alice");
            IChatClient bob = new ChatClient("Bob");

            chatroom.Register(alice);
            chatroom.Register(bob);

            alice.Send("Bob", Message.Create("Hey Bob, how are you!"));
            bob.Send("Alice", Message.Create("Could be better."));
            bob.Send("Alice", Message.Create("I'm a little under the weather."));
            alice.Send("Bob", Message.Create("Get well soon! Much love, Alice x"));

            Console.WriteLine();
            Console.WriteLine("Registered users:");

            foreach (var user in chatroom.RegisteredUsers)
                Console.WriteLine(user);

            Console.ReadKey();
        }
    }
}
