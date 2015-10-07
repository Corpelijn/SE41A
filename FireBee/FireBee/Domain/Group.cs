using System.Collections.Generic;

namespace FireBee.Domain
{
    public class Group
    {
        public static List<Group> Groups { get; set; }

        static Group()
        {
            Groups = new List<Group>();
        }

        public string Name { get; set; }
        public List<Member> Members { get; set; }

        public Group(string name)
        {
            Name = name;
            Members = new List<Member>();
        }
    }
}