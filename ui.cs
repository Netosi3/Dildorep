using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{

    [SerializeField] private GameObject _buttons;
    [SerializeField] private GameObject _setting;
    [SerializeField] private GameObject _hint;

    [SerializeField] private Text _hintText;


    private void Start()
    {
        ShowPanel(_buttons);
        _hint.SetActive(false);
    }

    public void ShowPanel(GameObject panelToShow)
    {
        _buttons.SetActive(false);
        _setting.SetActive(false);

        panelToShow.SetActive(true);
    }
    public void ShowHint(string message)
    {
        _hintText.text = message;
        _hint.SetActive(true);
    }

    public void ShowButtons() => ShowPanel(_buttons);

    public void ShowSetting() => ShowPanel(_setting);

    public void CloseApp() => Application.Quit();

    public void HideHint() => _hint.SetActive(false);


}
