using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinCountText;
    [SerializeField] private Button _tapButton;
    [SerializeField] private TextMeshProUGUI _coinsAmountForClickText;
    [SerializeField] private TextMeshProUGUI _coinsAmountInSecText;

    public int countCoinsInSec;
    public int addedForClickCoins = 1;

    private int _coins;
    private float _allTime;

    void Start()
    {
        _tapButton.onClick.AddListener(AddCoinsClick);
        ShowInfo();
        ShowInfoUpgrade();
    }

    private void Update()
    {
        _allTime += Time.deltaTime;
        if (_allTime >= 1f)
        {
            AddCoinsInSec();
            _allTime = 0f;
        }
    }

    void AddCoinsClick()
    {
        _coins += addedForClickCoins;
        ShowInfo();
    }

    void AddCoinsInSec()
    {
        _coins += countCoinsInSec;
        ShowInfo();
    }

    void ShowInfo()
    {
        _coinCountText.text = _coins.ToString();
    }

    public void UpgradeSec(int value)
    {
        countCoinsInSec += value;
        ShowInfoUpgrade();
    }



    public void UpgradeClick(int value)
    {
        addedForClickCoins += value;
        ShowInfoUpgrade();
    }


    void ShowInfoUpgrade()
    {
        _coinsAmountForClickText.text = $"+ {addedForClickCoins} coins for click";
        _coinsAmountInSecText.text = $"+ {countCoinsInSec} coins in sec";
    }

    public bool EnoughMoney(int price)
    {
        if (_coins >= price)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ExtractCoins(int price)
    {
        _coins -= price;
        ShowInfo();
    }


}
