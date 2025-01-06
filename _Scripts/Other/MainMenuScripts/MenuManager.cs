using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class MenuManager : MonoBehaviour
{

    public static MenuManager instance;
    public MenuState menuState;

    private void Awake()
    {
        instance = this;
    }

    public static event Action<MenuState> OnMenuStateChanged;

    public void UpdateMenuState(MenuState newState)
    {
        menuState = newState;

        switch (menuState)
        {
            case MenuState.MainMenu:
                break;
            case MenuState.SelectSection:
                break;
            case MenuState.Options:
                break;
            case MenuState.Credits:
                break;
            case MenuState.Quit:
                break;
            case MenuState.DungeonLevel:
                break;
            case MenuState.GraveyardLevel:
                break;
            case MenuState.CastleLevel:
                break;
        }

        OnMenuStateChanged?.Invoke(newState);
    }

    public enum MenuState
    {
        MainMenu,
        SelectSection,
        Options,
        Credits,
        Quit,
        DungeonLevel,
        GraveyardLevel,
        CastleLevel
    }

}
