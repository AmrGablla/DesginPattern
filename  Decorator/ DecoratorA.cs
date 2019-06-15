public class DecoratorA : Icomponent
{
    Icomponent component;
    public DecoratorA(Icomponent c)
    {
        this.component = c;
    }

    public string Operation()
    {
        string s = component.Operation();
        s += " and listening to Classic FM ";
        return s;
    }
}