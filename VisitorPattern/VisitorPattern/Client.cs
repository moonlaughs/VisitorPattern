using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Client
    {
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach(var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
