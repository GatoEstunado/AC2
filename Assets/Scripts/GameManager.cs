using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    #region Singleton
    public static GameManager Instance;
    public SO_GameData GameData;

    public UIManager Hud;
    public int score = 0;


    public bool scareEnemies = false;

    public void Pontos(int value)
    {
        GameData.score += value;
        Hud.ChangeScore(value);
    }

    public void Damage(int value)
    {
        GameData.lifes -= value;
        GameData.OnLifeChange();
    }

    public void LoadScene(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void Heal(int value)
    {
        GameData.lifes += value;
    }

    public void StartScaringEnemies(float time)
    {
        StartCoroutine(ScaringEnemiesCoroutine(time));
    }

    private IEnumerator ScaringEnemiesCoroutine(float time)
    {
        scareEnemies = true;
        yield return new WaitForSeconds(time);
        scareEnemies = false;
        yield return null;
    }

    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion
}
