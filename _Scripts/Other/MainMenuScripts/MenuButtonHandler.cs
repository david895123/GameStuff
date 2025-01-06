using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonHandler : MonoBehaviour
{
    MenuManager menuManager;

    private void Start()
    {
        menuManager = GetComponent<MenuManager>();
        menuManager.UpdateMenuState(MenuManager.MenuState.MainMenu);
    }
    public void StartButton()
    {
        menuManager.UpdateMenuState(MenuManager.MenuState.SelectSection);
    }

    public void QuitButton()
    {
        menuManager.UpdateMenuState(MenuManager.MenuState.Quit);
    }

    public void OptionsButton()
    {
        menuManager.UpdateMenuState(MenuManager.MenuState.Options);
    }

    public void CreditsButton()
    {
        menuManager.UpdateMenuState(MenuManager.MenuState.Credits);
    }

    public void BackToMenuButton()
    {
        menuManager.UpdateMenuState(MenuManager.MenuState.MainMenu);
    }

    public void DungeonButton()
    {
        menuManager.UpdateMenuState(MenuManager.MenuState.DungeonLevel);
    }

    public void GraveyardButton()
    {
        menuManager.UpdateMenuState(MenuManager.MenuState.GraveyardLevel);
    }

    public void CastleButton()
    {
        menuManager.UpdateMenuState(MenuManager.MenuState.CastleLevel);
    }

    public void BackToSelectSection()
    {
        menuManager.UpdateMenuState(MenuManager.MenuState.SelectSection);
    }
}
