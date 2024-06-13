using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace FærdighedsPrøve
{
    public interface IMemeberRepository
    {
        void AddMember(Member member);

        List<Member> GetAllMembers();

        StringBuilder PrintAllMembers();
        StringBuilder PrintMember(int id);

        Member GetMember(int id);

        void UpdateMember(Member member);

        void Delete(int id);
    }
}
