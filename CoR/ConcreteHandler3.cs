using System;

class ConcreteHandler3 : Handler
{
    private bool someFlag;

    public ConcreteHandler3(bool flag) : base("ConcreteHandler3")
    {
        someFlag = flag;
    }

    public override void HandleRequest(int request)
    {
        if (request >= 20 && request < 30)
        {
            Console.WriteLine("{0} обробив запит {1}, флаг: {2}", handlerName, request, someFlag);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}
