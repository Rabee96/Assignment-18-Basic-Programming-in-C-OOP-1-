
using UnityEngine;

namespace Assets
{
   public class GameUtils<T>: GameContainer<T>
    {
        public static void DescribeItem(int index){
            Debug.Log("This item is a " + items[index]);
        }
    } 
}

