public class Abstraction
{
    Bridge bridge;

    public Abstraction(Bridge implentaion)
    {
        this.bridge = implentaion;
    }
    public string Operation()
    {
        return "Abstraction" + " <<< BRIDGE >>>> " + bridge.OperationImp();
    }
}