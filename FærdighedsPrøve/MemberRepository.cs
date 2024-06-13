using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsPrøve
{
    public class MemberRepository : IMemeberRepository
    {
        private List<Member> members { get; }

        public MemberRepository()
        {
            members = new List<Member>();
            members.Add(new Member() { Id = 1, Name = "Kevin", Address = "Zealand", BirthDate = DateTime.Now, Email = "Wawerukew@gmail.com", PhoneNumber = 31659339 });
            members.Add(new Member() { Id = 2, Name = "Weer", Address = "Zealand", BirthDate = DateTime.Now, Email = "Wawerukew@gmail.com", PhoneNumber = 31659339 });
            members.Add(new Member() { Id = 3, Name = "RTY", Address = "Zealand", BirthDate = DateTime.Now, Email = "Wawerukew@gmail.com", PhoneNumber = 31659339 });
            members.Add(new Member() { Id = 4, Name = "ZSRE", Address = "Zealand", BirthDate = DateTime.Now, Email = "Wawerukew@gmail.com", PhoneNumber = 31659339 });
        }

        public List<Member> GetAllMembers()
        {
            return members.ToList();
        }
        public StringBuilder PrintAllMembers()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Member m in GetAllMembers())
            {
                sb.Append($"\n{m.ToString()}");
            }
            return sb;
        }
        public StringBuilder PrintMember(int id)
        {
            StringBuilder sb = new StringBuilder();

            int foundMemberIndex = members.FindIndex(memberToFind => memberToFind.Id == id);
            sb.Append($"\n{members[foundMemberIndex].ToString()}");
            return sb;
        }

        public void AddMember(Member memberToBeAdded)
        {
            List<int> memberIds = new List<int>();
            foreach (Member existingMember in members)
            {
                memberIds.Add(existingMember.Id);
            }
            if (memberIds.Count != 0)
            {
                int start = memberIds.Max();
                memberToBeAdded.Id = start + 1;
            }
            else
            {
                memberToBeAdded.Id = 1;
            }
            members.Add(memberToBeAdded);
        }

        public Member GetMember(int id)
        {
            foreach (Member toBeEdittedMember in GetAllMembers())
            {
                if (toBeEdittedMember.Id == id)
                    return toBeEdittedMember;
            }

            return new Member();
        }

        public void UpdateMember(Member @mber)
        {
            if (@mber != null)
            {
                foreach (Member existingMember in GetAllMembers())
                {
                    if (existingMember.Id == @mber.Id)
                    {
                        existingMember.Id = mber.Id;
                        existingMember.Name = mber.Name;
                        existingMember.Address = mber.Address;
                        existingMember.BirthDate = mber.BirthDate;
                        existingMember.PhoneNumber = mber.PhoneNumber;
                        existingMember.Email = mber.Email;
                    }
                }
            }
        }

        public void Delete(int id)
        {
            if (members != null && members.Count > 0)
            {
                int foundMemberIndex = members.FindIndex(memberToFind => memberToFind.Id == id);
                members.RemoveAt(foundMemberIndex);
            }
        }
    }
}
