using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePage : MonoBehaviour
{
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject Options;
    [SerializeField] GameObject Credits;
    [SerializeField] GameObject SelectSection;
    [SerializeField] GameObject DungeonLevel;
    [SerializeField] GameObject GraveyardLevel;
    [SerializeField] GameObject CastleLevel;



    void Awake()
    {
        MenuManager.OnMenuStateChanged += MenuManager_OnMenuStateChanged;
    }
    void OnDestroy()
    {
        MenuManager.OnMenuStateChanged -= MenuManager_OnMenuStateChanged;
    }

    private void MenuManager_OnMenuStateChanged(MenuManager.MenuState obj)
    {
        switch (obj)
        {
            case MenuManager.MenuState.MainMenu:
                HandleMainMenu();
                break;
            case MenuManager.MenuState.SelectSection:
                HandleSelectSection();
                break;
            case MenuManager.MenuState.Options:
                HandleOptions();
                break;
            case MenuManager.MenuState.Credits:
                HandleCredits();
                break;
            case MenuManager.MenuState.Quit:
                HandleQuit();
                break;
            case MenuManager.MenuState.DungeonLevel:
                HandleDungeonLevel();
                break;
            case MenuManager.MenuState.GraveyardLevel:
                HandleGraveyardLevel();
                break;
            case MenuManager.MenuState.CastleLevel:
                HandleCastleLevel();
                break;
        }


    }

    private void HandleMainMenu()
    {
        MainMenu.gameObject.SetActive(true);
        Options.gameObject.SetActive(false);
        Credits.gameObject.SetActive(false);
        SelectSection.gameObject.SetActive(false);
        DungeonLevel.gameObject.SetActive(false);
        GraveyardLevel.gameObject.SetActive(false);
        CastleLevel.gameObject.SetActive(false);
    }

    private void HandleSelectSection()
    {
        MainMenu.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        Credits.gameObject.SetActive(false);
        SelectSection.gameObject.SetActive(true);
        DungeonLevel.gameObject.SetActive(false);
        GraveyardLevel.gameObject.SetActive(false);
        CastleLevel.gameObject.SetActive(false);
    }

    private void HandleDungeonLevel()
    {
        MainMenu.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        Credits.gameObject.SetActive(false);
        SelectSection.gameObject.SetActive(false);
        DungeonLevel.gameObject.SetActive(true);
        GraveyardLevel.gameObject.SetActive(false);
        CastleLevel.gameObject.SetActive(false);
    }
    private void HandleGraveyardLevel()
    {
        MainMenu.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        Credits.gameObject.SetActive(false);
        SelectSection.gameObject.SetActive(false);
        DungeonLevel.gameObject.SetActive(false);
        GraveyardLevel.gameObject.SetActive(true);
        CastleLevel.gameObject.SetActive(false);
    }
    private void HandleCastleLevel()
    {
        MainMenu.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        Credits.gameObject.SetActive(false);
        SelectSection.gameObject.SetActive(false);
        DungeonLevel.gameObject.SetActive(false);
        GraveyardLevel.gameObject.SetActive(false);
        CastleLevel.gameObject.SetActive(true);
    }
    private void HandleCredits()
    {
        MainMenu.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        Credits.gameObject.SetActive(true);
        SelectSection.gameObject.SetActive(false);
        DungeonLevel.gameObject.SetActive(false);
        GraveyardLevel.gameObject.SetActive(false);
        CastleLevel.gameObject.SetActive(false);
    }
    private void HandleOptions()
    {
        MainMenu.gameObject.SetActive(false);
        Options.gameObject.SetActive(true);
        Credits.gameObject.SetActive(false);
        SelectSection.gameObject.SetActive(false);
        DungeonLevel.gameObject.SetActive(false);
        GraveyardLevel.gameObject.SetActive(false);
        CastleLevel.gameObject.SetActive(false);
    }
    private void HandleQuit()
    {
        Application.Quit();
    }
}