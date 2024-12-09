using UnityEngine;

namespace Assets.Script
{
    public class GameUtils
    {
        static public void DescribeItem<T>(T item){
            Debug.Log($"This item is a {item}.");
        }
    }  
}

