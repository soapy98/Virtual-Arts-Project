using System;
using UnityEngine;
using UnityEngine.UI;

public class ControlsMenu : Menu
{
    public GameObject ArrowKeys;
    public Button Rotate;
    public Button Move;
    public Button Lockin;
    public Button Group;
    public Button Scale;

    public Button ClearAll;
    public ArrowKeys Arrows;
    void Start()
    {
        Rotate.onClick.AddListener(delegate { SetControlType(ControlType.Rotate);});
        Move.onClick.AddListener(delegate { SetControlType(ControlType.Move);});
        Lockin.onClick.AddListener(delegate { SetControlType(ControlType.LockIn);});
        Group.onClick.AddListener(delegate { SetControlType(ControlType.Group);});
        Scale.onClick.AddListener(delegate { SetControlType(ControlType.Scale);});
    }

    void SetControlType(ControlType _controlType)
    {
        OpenCloseMenu(ArrowKeys);
        Arrows.ControlType = _controlType;
    }
    
}