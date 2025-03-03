namespace Playground;

public class Dog
{
    private readonly string _name;
    private readonly string _breed;

    private int Weight { get; set; }
    
    public Dog(string name, string breed, int weight) {
        _name = name;
        _breed = breed;
        Weight = weight;
    }
       
    public Dog(string name, int weight, string breed = "mixed-breed") {
        _name = name;
        _breed = breed;
        Weight = weight;
    }

    public void SetWeight(int weight) => Weight = weight;

    private static string Size(int weight)
    {
        return weight switch
        {
            < 5 => "tiny",
            < 30 => "medium",
            _ => "large"
        };
    }
    
    public string Describe() => $"This dog is named {_name}, it's a {_breed}," +
                                $" and it weighs {Weight} kilograms, so it's a {Size(Weight)} dog.";
}