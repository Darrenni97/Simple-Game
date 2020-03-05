﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
  [SerializeField]
  private int level;
  [SerializeField]
  private bool lastLevel;
  private int nextLevel;
  // Start is called before the first frame update
  void Start()
  {
    nextLevel = level += 1;
  }

  // Update is called once per frame
  public void LoadNextLevel()
  {
    if (!lastLevel)
    {
      string sceneName = "Level-" + nextLevel;
      SceneManager.LoadScene(sceneName);
    }
    else
    {
      //go to main menu
      SceneManager.LoadScene("Level-1")
    }
  }

  public void ReloadCurrentLevel()
  {
    SceneManager.LoadScene("Level-" + level)
  }
}
