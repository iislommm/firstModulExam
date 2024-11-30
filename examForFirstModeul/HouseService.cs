namespace examForFirstModeul;

public class HouseService
{
    private List<House> houses;
    public HouseService()
    {
        houses = new List<House>();
    }
    public House AddHouse(House newHouse)
    {
        newHouse.Id = new Guid();
        houses.Add(newHouse);
        return newHouse;
    }
    public House GetById (Guid id)
    {
        foreach (var house in houses)
        {
            if (house.Id == id)
            {
                return house;
            }
        }
        return null;
    }
    public List<House> Getall()
    {
        return houses;
    }
    public bool UpdateHouse (House house)
    {
        var houseDb = GetById(house.Id);
        if (houseDb is null)
        {
            return false;
        }
        var index = houses.IndexOf(houseDb);
        houses[index] = houseDb;
        return true;
    }
    public bool DeleteHouse (House house)
    {
        var houseDb = GetById(house.Id);
        if (houseDb is null)
        {
            return false;
        }
        var index = houses.Remove(houseDb);
        return true;
    }
}
