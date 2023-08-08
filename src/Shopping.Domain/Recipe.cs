namespace Shopping.Domain;

public class Recipe
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Icon { get; private set; }
    
    public List<Ingredient> Ingredients { get; private set; }

    public Recipe(string name)
    {
        SetName(name);
    }

    public void SetName(string name)
    {
        Name = name;
    }
}