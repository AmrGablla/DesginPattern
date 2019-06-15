public class DecoratorB : Icomponent
{
    Icomponent component;
    public string AddedState = "Past the coffe shop"; // What should this called?
    public DecoratorB(Icomponent c) => this.component = c;
    public string Operation()
    {
        string s = component.Operation();
        s += "to school ";
        return s;
    }
    public string AddedBehavior()
    {
        return "and I bought a cappuccino ";
    }
}