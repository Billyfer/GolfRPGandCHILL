using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Finish;
    [SerializeField] TMP_Text FinishText;
    [SerializeField] PlayerController player;
    [SerializeField] Hole hole;

    private void Start()
    {
        //Finish.SetActive(false);
    }

    private void Update()
    {
        if (hole.Entered && Finish.activeInHierarchy == false)
        {
            Finish.SetActive(true);
            FinishText.text = "Congratulations You Win! Shoot Count : " + player.ShootCount;
        }
    }

    public void BackToMainMenu()
    {
        SceneLoader.Load("MainMenu");
    }
    public void Replay()
    {
        SceneLoader.ReloadLevel();
    }
    public void PlayNext()
    {
        SceneLoader.LoadNextLevel();
    }
}