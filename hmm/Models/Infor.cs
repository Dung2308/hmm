using System;
using System.Collections.Generic;

namespace hmm.Models
{
    public partial class Infor
    {
        public string Usn { get; set; } = null!;
        public string Hoten { get; set; } = null!;
        public int Tuoi { get; set; }
        public bool Gioitinh { get; set; }
        public DateTime Ngsinh { get; set; }
        public string Dc { get; set; } = null!;
        public string? School { get; set; }
        public string? Job { get; set; }

        public virtual Taikhoan? Taikhoan { get; set; }
    }
}
