using UnityEngine;

public class ArchitectureTest : MonoBehaviour
{
    private BankRepository _bankRepository;
    private BankInteractor _bankInteractor;

    private void Start()
    {
        _bankRepository = new BankRepository();
        _bankRepository.Initialize();

        _bankInteractor = new BankInteractor(_bankRepository);
        _bankInteractor.Initialize();

        Debug.Log($"Bank initialized {_bankRepository.Coins}");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _bankInteractor.AddCoins(this, 5);
            Debug.Log($"Coins added (5), {_bankRepository.Coins}");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _bankInteractor.SpentCoins(this, 10);
            Debug.Log($"Coins spent (10), {_bankRepository.Coins}");
        }
    }
}
