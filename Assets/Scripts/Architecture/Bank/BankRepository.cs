using UnityEngine;

public class BankRepository : Repository
{
    private const string Key = "BANK_KEY";

    public int Coins { get; set; }

    public override void Initialize()
    {
        Coins = PlayerPrefs.GetInt(Key, 0);
    }

    public override void Save()
    {
        PlayerPrefs.SetInt(Key, Coins);
    }
}
