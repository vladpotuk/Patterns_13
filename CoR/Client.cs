using System;

class Client
{
    public void Run()
    {
        Handler handler1 = new ConcreteHandler1(0, 10, "ConcreteHandler1");
        Handler handler2 = new ConcreteHandler2("Додаткове поле ConcreteHandler2");
        Handler handler3 = new ConcreteHandler3(true);

        handler1.SetSuccessor(handler2);
        handler2.SetSuccessor(handler3);

        int[] requests = { 2, 5, 14, 22, 30 };

        foreach (int request in requests)
        {
            handler1.HandleRequest(request);
        }
    }
}
