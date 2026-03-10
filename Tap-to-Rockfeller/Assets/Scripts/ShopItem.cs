using TMPro;
using UnityEngine;
using UnityEngine.UI;

enum ShopItemType
{
    ForClick,
    InSec
}

public class ShopItem : MonoBehaviour
{
    [SerializeField] private Button ShopItemButton;
    [SerializeField] private Image ShopItemImage;
    [SerializeField] private Image HideImage;
    [SerializeField] private TextMeshProUGUI ShopItemTMP;
    [SerializeField] private TextMeshProUGUI ShopItemPriceTMP;
    [SerializeField] private TextMeshProUGUI ShopItemTypeTMP;
    [SerializeField] private TextMeshProUGUI ShopItemCoinAmountTMP;

    [SerializeField] private Sprite ShopItemSprite;
    [SerializeField] private string ShopItemText;
    [SerializeField] private int ShopItemPrice;
    [SerializeField] private int ShopItemCoinAmount;
    [SerializeField] ShopItemType ShopItemType;

    private CoinCount _coinCount;

    private void Start()
    {
        ShopItemButton.onClick.AddListener(Buy);

        ShopItemImage.sprite = ShopItemSprite;
        ShopItemTMP.text = ShopItemText;
        ShopItemPriceTMP.text = ShopItemPrice.ToString();
        ShopItemCoinAmountTMP.text = ShopItemCoinAmount.ToString();

        if (ShopItemType == ShopItemType.ForClick)
        {
            ShopItemTypeTMP.text = "For Click";
        }
        else
        {
            ShopItemTypeTMP.text = "In Sec";
        }
        _coinCount = FindObjectOfType<CoinCount>();
    }

    void Buy()
    {
        if (_coinCount.EnoughMoney(ShopItemPrice))
        {
            _coinCount.ExtractCoins(ShopItemPrice);
            if(ShopItemType == ShopItemType.ForClick)
            {
                _coinCount.UpgradeClick(ShopItemCoinAmount);
            }
            else
            {
                _coinCount.UpgradeSec(ShopItemCoinAmount);
            }
        }        
    }

    private void Update()
    {
        HideImage.enabled = !(_coinCount.EnoughMoney(ShopItemPrice));
    }
}
