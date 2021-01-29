using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Name;
using ArrayList;

namespace CS_131_Projects
{
    public class Program
    {

        static void Main()
        {
            string response = "";        
            while (response!= "5")
            {

                List<User> userList = new List<User>();
                List<Comment> commentList = new List<Comment>();

                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Create a Comment");
                Console.WriteLine("3. Print List of Users);
                Console.WriteLine("4. Print List of Comments");
                Console.WriteLine("5. Exit");

                Console.WriteLine("");
                Console.WriteLine("Please select an option: ");
                Console.ReadLine();

                response = Console.ReadLine();

                switch(response)
                {
                    case "1":
                        User user = new User();
                        user.UserName = "Luis";
                        user.UserId = 7;
                        userList.Add(user);
                        Console.WriteLine("You have created a user");
                        break;

                    case "2":
                        Comment hisComment = new Comment();
                        hisComment.CommentId = 5;
                        hisComment.TheBestComment = "The best is yet to Come!";
                        commentList.Add(hisComment);
                        Console.WriteLine("You have created a comment");
                        break;

                    case "3":
                        Console.WriteLine("This is the list you wanted: ");
                        foreach(var insideUser in userList)
                        {
                            Console.WriteLine(insideUser.UserId);
                            Console.WriteLine(insideUser.UserName);
                        }
                        break;

                    case "4":
                        Console.WriteLine("This is the list you wanted: ");
                        foreach (var insideComment in commentList)
                        {
                            Console.WriteLine(insideComment.CommentId);
                            Console.WriteLine(insideComment.TheBestComment);
                        }
                        break;
                }

               
            }

        }
    }
}


