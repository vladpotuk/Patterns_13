using System;

class ConcreteHandler1 : Handler
{
    private int minRange;
    private int maxRange;

    public ConcreteHandler1(int min, int max, string name) : base(name)
    {
        minRange = min;
        maxRange = max;
    }

    public override void HandleRequest(int request)
    {
        if (request >= minRange && request < maxRange)
        {
            Console.WriteLine("{0} обробив запит {1}", handlerName, request);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}
