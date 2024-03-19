using hmm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmm
{
    internal class qltk : Taikhoan
    {
       public List<Taikhoan> danhsachtaikhoan {  get; set; } = new List<Taikhoan>();
       public void themtaikhoan(string usn,string pass,string email)
        {
            Taikhoan taikhoan = new Taikhoan { Usn = usn, Pass = pass,Email = email };
            danhsachtaikhoan.Add(taikhoan);
        }
    }
}
