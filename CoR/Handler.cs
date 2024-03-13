using System;

abstract class Handler
{
    protected Handler successor;
    protected string handlerName;

    public Handler(string name)
    {
        handlerName = name;
    }

    public void SetSuccessor(Handler successor)
    {
        this.successor = successor;
    }

    public abstract void HandleRequest(int request);
}
