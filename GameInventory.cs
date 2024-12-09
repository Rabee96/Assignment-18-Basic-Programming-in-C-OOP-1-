using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Script
{
    public class GameInventory : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Inventory potionsInventory = new();
            potionsInventory.AddItem("Healing Potion");
            potionsInventory.AddItem("Strength Potion");
            potionsInventory.ShowItems();
            Inventory elixirsInventory = new();
            elixirsInventory.AddItem("Dark Elixir");
            elixirsInventory.ShowItems();
        }
    } 
}

