using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets
{
   public class Generic : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameUtils<string> inventory = new();
            
            inventory.SetItem("Health Potion");
            inventory.SetItem("Gold Armory");
            inventory.SetItem("Diamond Dagger");
            inventory.SetItem("Robin hood hat");

            inventory.GetItem(2);
            inventory.GetItem(0);
            inventory.GetLastItem();
            inventory.GetAllItems();

            GameUtils<string>.DescribeItem(3);

            Inventory potions = new();
            Inventory elixirs = new();

            potions.AddItem("Magic Potion");
            potions.AddItem("Strength Potion");

            elixirs.AddItem("Elixir");
            elixirs.AddItem("Dark Elixir");
            
            Inventory newInventory = potions + elixirs;
            newInventory.ShowItems();
        }
    }
}
