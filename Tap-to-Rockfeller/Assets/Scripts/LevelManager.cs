using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Image _fillingImage;
    [SerializeField] private Button _tapButton;
    [SerializeField] private TextMeshProUGUI _levelText;

    private int _countClick;
    private int _level;
    private int[] _rangeOfCoinsAmount = new int[5] { 10, 25, 50, 100, 200 };

    private void Start()
    {
        _tapButton.onClick.AddListener(OnClick);
        ShowInfo();
    }

    void OnClick()
    {
        _countClick++;
        CheckLevel();
        ShowInfo();

    }

    void ShowInfo()
    {
        if (_level == 0)
        {
            _fillingImage.fillAmount = _countClick * 1f / _rangeOfCoinsAmount[_level];
        }
        else
        {
            _fillingImage.fillAmount = (_countClick * 1f - _rangeOfCoinsAmount[_level - 1]) / (_rangeOfCoinsAmount[_level] - _rangeOfCoinsAmount[_level - 1]);
        }

        _levelText.text = (_level+1).ToString();
    }

    void CheckLevel()
    {
        if (_rangeOfCoinsAmount[_level] <= _countClick)
        {
            _level++;
        }
    }
}
