using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState state;
    private void Awake()
    {
        Instance = this;
    }

    public static event Action<GameState> OnStateChanged;

    public void UpdateGamestate(GameState newState)
    {
        state = newState;

        switch (state)
        {
            case GameState.MainMenu:
                break;
            case GameState.Game:
                break;
            case GameState.Lose:
                break;
            case GameState.Victory:
                break;
        }

        OnStateChanged?.Invoke(newState);
    }

    public enum GameState
    {
        MainMenu,
        Game,
        Lose,
        Victory
    }
}