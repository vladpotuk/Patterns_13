using System;

class ConcreteHandler2 : Handler
{
    private string additionalField;

    public ConcreteHandler2(string additionalField) : base("ConcreteHandler2")
    {
        this.additionalField = additionalField;
    }

    public override void HandleRequest(int request)
    {
        if (request >= 10 && request < 20)
        {
            Console.WriteLine("{0} обробив запит {1}, додаткове поле: {2}", handlerName, request, additionalField);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}
