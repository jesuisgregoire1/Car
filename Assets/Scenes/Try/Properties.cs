
public class Properties 
{
    private int _health;
    private int _donut;

    public int GetHealth { get; set; }
    public int Donut { get; set; }

    public Properties(int health, int donut)
    {
        Donut = donut;
        GetHealth = health;
    }

    public void DoThing(Accessors a)
    {
      
    }
}
