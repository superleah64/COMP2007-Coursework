using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool GameIsPlaying = true;

    public void pauseGame()
    {
        if (GameIsPaused)
        {
            Time.timeScale = 1f;
            GameIsPaused = false;
            GameIsPlaying = true;
        }

        else
        {
            Time.timeScale = 0f;
            GameIsPaused = true;
            GameIsPlaying = false;
        }
    }

    public void resumeGame()
    {
        if (GameIsPlaying)
        {
            Time.timeScale = 0f;
            GameIsPaused = true;
            GameIsPlaying = false;
        }

        else
        {
            Time.timeScale = 1f;
            GameIsPaused = false;
            GameIsPlaying = true;
        }
    }
}