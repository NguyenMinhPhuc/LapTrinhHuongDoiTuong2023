using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_Interface
{
    internal interface IStorable
    {
        List<string> Read(ref string err, string path);
        void Write(string path, string contents);
        bool Status { get; set; }
    }
}
