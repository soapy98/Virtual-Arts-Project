using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class MainMenu : Menu
{
    public Button ShapesButton;
    public GameObject ShapesMenu;
    public Button ControlsButton;
    public GameObject ControlsMenu;

    public Button SoundsButton;
    public GameObject SoundButton;

    void Start()
    {
        ShapesButton.onClick.AddListener(delegate { OpenCloseMenu(ShapesMenu); });
        ControlsButton.onClick.AddListener(delegate { OpenCloseMenu(ControlsMenu); });
        SoundsButton.onClick.AddListener(delegate { OpenCloseMenu(SoundButton); });
    }
 
}