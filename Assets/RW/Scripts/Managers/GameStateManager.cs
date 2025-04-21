using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;

    [HideInInspector]
    public int sheepSaved;

    [HideInInspector]
    public int sheepDropped;

    public int sheepDroppedBeforeGameOver;
    public int sheepSavedBeforeGameWin;
    public SheepSpawner sheepSpawner;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title");
        }
    }

    public void SavedSheep()
    {
        sheepSaved++;
        UIManager.Instance.UpdateSheepSaved();

        if (sheepSaved == sheepSavedBeforeGameWin)
        {
            GameWin();
        }
    }

    private void GameOver()
    {
        sheepSpawner.canSpawn = false;
        sheepSpawner.DestroyAllSheep();
        SoundManager.Instance.audioSource.Stop();
        SoundManager.Instance.PlayGameOverClip();
        UIManager.Instance.ShowGameOverWindow();
    }

    private void GameWin()
    {
        sheepSpawner.canSpawn = false;
        sheepSpawner.DestroyAllSheep();
        SoundManager.Instance.audioSource.Stop();
        SoundManager.Instance.PlayGameWinClip();
        UIManager.Instance.ShowGameWinWindow();
    }

    public void DroppedSheep()
    {
        sheepDropped++;
        UIManager.Instance.UpdateSheepDropped();

        if (sheepDropped == sheepDroppedBeforeGameOver)
        {
            GameOver();
        }
    }
}
