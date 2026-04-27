using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScreen : MonoBehaviour
{
    [SerializeField] private GameObject RotateScreenImage;

    void Update()
    {
        if (Screen.width < Screen.height)
        {
            RotateScreenImage.SetActive(true);
        }
        else
        {
            RotateScreenImage.SetActive(false);
        }
    }
}
