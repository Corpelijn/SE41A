using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace FireBee.Domain
{
    public class Member
    {
        public static List<Member> Members { get; set; }

        static Member()
        {
            Members = new List<Member>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Image Image { get; set; }
        public Group Group { get; set; }

        public Member(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Member(string firstName, string lastName, Image image)
        {
            FirstName = firstName;
            LastName = lastName;
            Image = image;
        }
    }
}