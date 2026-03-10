using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TapScript : MonoBehaviour
{
    [SerializeField] private Animator _tappedAnimation;
    [SerializeField] private Button _tapButton;

    private void Start()
    {        
            _tapButton.onClick.AddListener(StartAnimation);        
    }
    public void StartAnimation()
    {
        _tappedAnimation.SetTrigger("Click");
    }
    
}
