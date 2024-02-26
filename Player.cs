public class Player
{
    public string Name;
    public string CurrentLocation;
    public string CurrentWeapon;
    public int CurrentHitPoints;
    public int MaximumHitPoints;

    public Player(string name, string currentLocation, string currentWeapon, int currentHitPoints, int maximumHitPoints)
    {
        Name = name;
        CurrentLocation = currentLocation;
        CurrentWeapon = currentWeapon;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }

    public void Regenerate()
    {
        double regeneration = MaximumHitPoints * 1.2;
        CurrentHitPoints += Convert.ToInt32(regeneration);
    }

    public void MoveTo()
    {
        pass
    }
}