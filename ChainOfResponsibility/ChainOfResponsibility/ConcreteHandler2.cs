using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(String request)
        {
            if (request == "Two")
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