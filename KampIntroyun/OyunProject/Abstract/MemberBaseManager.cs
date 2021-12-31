using OyunProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProject.Abstract
{
    public abstract class MemberBaseManager : IMemberService
    {
        public void Delete(Member member)
        {
            Console.WriteLine($"{member.FirstName+" "+member.LastName} adli üye silindi.");
        }

        public virtual void Register(Member member)
        {
            Console.WriteLine($"{member.FirstName + " " + member.LastName} adli üye kaydedildi.");
        }

        public void Update(Member member)
        {
            Console.WriteLine($"{member.FirstName + " " + member.LastName} adli üye güncellendi.");
        }
    }
}
