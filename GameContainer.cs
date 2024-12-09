using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script{
    public class GameContainer<T>
    {
        private T item;
        public void SetItem(T selectedItem){
            item = selectedItem;
       }

       public T GetItem(){
            return item;
       }
    }
}

