using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Variables
    private int score = 0;
    public Text scoreLabel;
    #endregion

    public void AddScore()
    {
        score++;
        scoreLabel.text = score.ToString();
    }
}
