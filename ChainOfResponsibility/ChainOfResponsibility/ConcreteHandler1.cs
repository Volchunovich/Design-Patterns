using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(String request)
        {
            if (request == "One")
            {
                Console.WriteLine(request);
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}