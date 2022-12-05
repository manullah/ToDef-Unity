using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

  public static bool GameIsOver;

  public GameObject gameOverUI;
  public GameObject completeLevelUI;
  public AudioSource audioSource;

  void Start()
  {
    GameIsOver = false;
  }

  // Update is called once per frame
  void Update()
  {
    if (GameIsOver)
      return;

    if (PlayerStats.Lives <= 0)
    {
      EndGame();
    }
  }

  void EndGame()
  {
    GameIsOver = true;
    gameOverUI.SetActive(true);
    audioSource.Stop();
  }

  public void WinLevel()
  {
    GameIsOver = true;
    completeLevelUI.SetActive(true);
    audioSource.Stop();
  }

}
