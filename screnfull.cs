using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screnfull : MonoBehaviour
{
    [SerializeField] private Dropdown _scren;
    

    private void Start()
    {
        _scren.ClearOptions();
        List<string> options = new List<string>
        {
            "1280 x 720",
            "1366 x 768",
            "1600 x 900",
            "1920 x 1080",
        };
        _scren.AddOptions(options);
        _scren.onValueChanged.AddListener(SetResolution);
        SetResolution(_scren.value);
    }

    private void SetResolution(int index)
    {
        switch (index)
        {
            case 0:
                Screen.SetResolution(1280, 720, Screen.fullScreen);
                break;

            case 1:
                Screen.SetResolution(1366, 768, Screen.fullScreen);
                break;
            case 2:
                Screen.SetResolution(1600, 900, Screen.fullScreen);
                break;
            case 3:
                Screen.SetResolution(1920, 1080, Screen.fullScreen);
                break;

        }

    }

}  

