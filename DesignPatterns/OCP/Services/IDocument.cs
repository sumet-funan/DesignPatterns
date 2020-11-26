using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Services
{
    public interface IDocument
    {
        int TotalPages();
        string ReadAllText(int pageIndex);
    }
}
