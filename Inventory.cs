using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Script
{
    public class Inventory
    {
        List<string> items = new();
        public void AddItem(string item){
            items.Add(item);
        }

        public void ShowItems(){
                items.ForEach((item)=>{
                    Debug.Log($"This Inventory contains {item}");
                });
            }

        static public List<string> operator + (Inventory inventory1, Inventory inventory2){
            return inventory1.items.Concat(inventory2.items) as List<string>;
        }
    }  
}

