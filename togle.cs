using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class togle : MonoBehaviour
{
    [SerializeField] Toggle _togle;
    [SerializeField] Text _togletext;
    void Start()
    {
        _togle.onValueChanged.AddListener(OnToggleValueChanged);

    }
    private void OnToggleValueChanged(bool ison)
    {
        if (ison)
            _togletext.text = "ON";
        else
            _togletext.text = "OFF";
    }
    



}
