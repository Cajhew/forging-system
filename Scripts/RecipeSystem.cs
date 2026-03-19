
using UdonSharp;
using UnityEngine;

public class RecipeSystem : UdonSharpBehaviour
{
    public string[] recipes;

    public string GetRecipe(int index)
    {
        if(index < 0 || index >= recipes.Length) return "";
        return recipes[index];
    }
}
