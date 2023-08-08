namespace Shopping.Domain;

public class Ingredient
{
    public int Id { get; private set; }
    
    public string Name { get; private set; }
    
    public string Icon { get; private set; }
    
    public List<IngredientCategory> Categories { get; private set; }
}

public class IngredientCategory
{
    public int Id { get; private set; }
    
    public string Name { get; private set; }
}