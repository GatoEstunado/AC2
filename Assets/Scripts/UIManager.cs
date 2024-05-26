using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Text txtScore;
    public SO_GameData GameData;


    private void Start()
    {
        txtScore.text = GameData.score.ToString();
    }

    public void ChangeScore(int score)
    {
        txtScore.text = GameData.score.ToString();
    }
}