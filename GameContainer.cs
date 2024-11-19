using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets
{
   public class GameContainer<T>
    {
        public static readonly List<T> items = new();
        public void SetItem(T item){
            items.Add(item);
        }

        public void GetItem(int index){
            Debug.Log($"You chose item #{index} " + items[index]);
        }
        public void GetLastItem(){
            Debug.Log("The last item you've added was " + items[items.Count - 1]);
        }

        public void GetAllItems(){
            Debug.Log("Take a peak at you inventory 👀: " + string.Join(", ",items));
        }
}
 
}
