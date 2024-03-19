using System;
using System.Collections.Generic;

namespace hmm.Models
{
    public partial class Taikhoan
    {
        public string Usn { get; set; } = null;
        public string Pass { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual Infor UsnNavigation { get; set; } = null!;
        
        
    }
}
