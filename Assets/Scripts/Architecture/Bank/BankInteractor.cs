public class BankInteractor : Interactor
{
    private BankRepository _repository;

    public int Coins => _repository.Coins;

    public BankInteractor(BankRepository repository)
    {
        _repository = repository;
    }

    public bool IsEnougthCoin(int value)
    {
        return Coins >= value;
    }

    public void AddCoins(object sender, int value)
    {
        _repository.Coins += value;
        _repository.Save();
    }

    public void SpentCoins(object sender, int value)
    {
        _repository.Coins -= value;
        _repository.Save();
    }
}
