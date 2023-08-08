using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shopping.Domain;

namespace Shopping.App.ViewModels;

public class RecipesPageViewModel : ObservableObject
{
    public ICommand AddRecipeCommand { get; }

    private ObservableCollection<Recipe> _recipes;
    
    public RecipesPageViewModel()
    {
        _recipes = new ObservableCollection<Recipe>();
        AddRecipeCommand = new RelayCommand(AddRecipe);
    }

    public ObservableCollection<Recipe> Recipes
    {
        get => _recipes;

        set => SetProperty(ref _recipes, value);
    }

    private void AddRecipe()
    {
        Recipe recipe = new Recipe( "New Recipe" );
        Recipes.Add(recipe);
    }
}