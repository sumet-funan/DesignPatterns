using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public interface IDocument
    {
        int TotalPages();
        string ReadAllText(int pageIndex);
    }
}
