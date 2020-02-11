using System;
using System.Collections.Generic;

namespace Exercise_1___Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string>();
            var friend = "";
            do
            {
                Console.WriteLine("Please enter friends names:");
                friend = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(friend))
                {
                    friends.Add(friend);
                }
            } while (!String.IsNullOrWhiteSpace(friend));
            
            if (friends.Count == 1)
            {
                Console.WriteLine($"{friends[0]} likes your post");
            }
            else if (friends.Count == 2)
            {
                Console.WriteLine($"{friends[0]} and {friends[1]} like your post");
            }
            else if (friends.Count > 2)
            {
                Console.WriteLine($"{friends[0]}, {friends[1]} and {friends.Count - 2} like your post");
            }
        }
    }
}
