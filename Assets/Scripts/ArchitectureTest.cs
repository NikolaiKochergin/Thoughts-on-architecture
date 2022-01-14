using UnityEngine;

public class ArchitectureTest : MonoBehaviour
{
    public static SceneManagerBase SceneManager;

    private void Start()
    {
        SceneManager = new SceneManagerExample();
        SceneManager.InitScenesMap();
        SceneManager.LoadCurrentSceneAsync();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Bank.AddCoins(this, 5);
            Debug.Log($"Coins added (5), {Bank.Coins}");    
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Bank.SpendCoins(this, 10);
            Debug.Log($"Coins spent (10), {Bank.Coins}");
        }
    }
}
