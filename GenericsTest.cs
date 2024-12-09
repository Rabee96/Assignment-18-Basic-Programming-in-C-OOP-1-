using UnityEngine;

namespace Assets.Script
{
    public class GenericsTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameContainer<string> gameContainer = new();
            gameContainer.SetItem("Healing Potion");
            Debug.Log($"The stored item is: {gameContainer.GetItem()}");
            GameUtils.DescribeItem(gameContainer.GetItem());
        }
    }
}
