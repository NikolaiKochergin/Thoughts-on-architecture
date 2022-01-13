using UnityEngine;

public class ArchitectureTest : MonoBehaviour
{
    public static Scene Scene;

    private void Start()
    {
        var sceneConfig = new SceneConfigExample();
        Scene = new Scene(sceneConfig);

        StartCoroutine(Scene.InitializeRoutine());
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
