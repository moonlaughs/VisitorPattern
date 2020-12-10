using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
