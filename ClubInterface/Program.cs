using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace club
{

    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
        public string DisplayMemberInfo();
    }

    class Club
    {
        public class Member : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
            public int YearJoined { get; set; }
            public string Email { get; set; }

            public Member()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
                Title = "";
                YearJoined = 0;
                Email = "";


            }
            public Member(int id, string firstName, string lastName, string title, int yearjoined, string email)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Title = title;
                YearJoined = yearjoined;
                Email = email;
            }
            public string Fullname()
            {
                Console.WriteLine();
                return "Name: "+ FirstName + " " + LastName;
               
            }
            public string DisplayMemberInfo()
            {
                
                return "Id: " + Id + "\nYear Joined: " + YearJoined + "\nEmail: " + Email;

            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Member RJ = new Member(1, "RJ", "Scarbrough", "Member", 1997, "RJ'sEmail@YourWebsite.com");
                Console.WriteLine(RJ.Fullname());
                Console.WriteLine(RJ.DisplayMemberInfo());
            }
        }
    }
}

