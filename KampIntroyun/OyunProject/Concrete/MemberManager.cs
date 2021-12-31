using OyunProject.Abstract;
using OyunProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProject.Concrete
{
   public class MemberManager:MemberBaseManager
    {
        private IMemberCheckService memberCheckService;

        public MemberManager(IMemberCheckService memberCheckService)
        {
            this.memberCheckService = memberCheckService;
        }
        public override void Register(Member member)
        {
            if (memberCheckService.CheckIfRealPerson(member))
            {
            base.Register(member);

            }
            else
            {
                throw new Exception ("Bu bi bitki veya robot yada vıdı vıdı");
            }
        }
    }
}
