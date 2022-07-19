using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private  GameObject[] AllMenus;

    public virtual GameObject[] Menus
    {
        get => AllMenus;
        set => AllMenus = value;
    }
    private string Name;
    public Button CloseMenus;
    
    public virtual string GetName
    {
        get => Name;
        set => Name = value;
    }

    void Start()
    {
        AllMenus = GameObject.FindGameObjectsWithTag("Menu");
        CloseMenus.onClick.AddListener(CloseAllMenus);
    }

    protected virtual void OpenCloseMenu(GameObject go)
    {
        go.SetActive(!go.activeSelf);
    }
    public virtual void CloseAllMenus()
    {
        foreach (var menu in AllMenus)
        {
            menu.SetActive(false);
        }
    }
}