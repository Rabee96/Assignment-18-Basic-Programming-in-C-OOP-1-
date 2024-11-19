using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets
{
    public class Inventory
    {
        private readonly List<string> items = new();
        
        public void AddItem(string item){
            items.Add(item);
        }

        public void ShowItems(){
            Debug.Log(string.Join(", ", items));
        }

        public static Inventory operator +(Inventory firstInventory,Inventory secondInventory){
            firstInventory.items.AddRange(secondInventory.items);
            return firstInventory;
        }
    } 
}

