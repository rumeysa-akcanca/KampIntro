using OyunProject.Abstract;
using OyunProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProject.Adapter
{
    public class MemberCheckManager : IMemberCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {
            return true;
        }
    }
}
