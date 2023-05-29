using System.Runtime.CompilerServices;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class LoseWindow : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreTXT;
    public Medal[] medals;
    public Image medalDisplay;
   public void PlayerLose(){
    int score = ScoreManager.Instance.score;
    scoreText.text = ScoreManager.Instance.score.ToString();
    int bestScore = PlayerPrefs.GetInt("BestScore");
    if(score > bestScore){bestScore = score;}
    for(int i = 0;i<medals.Length;i++)
    {
        if(medals[i].ScoreNeed<=score)
        {            
                medalDisplay.gameObject.SetActive(true);
                medalDisplay.sprite = medals[i].MedalsSprite;               
        }
    }

    bestScoreTXT.text = bestScore.ToString();
    PlayerPrefs.SetInt("BestScore", bestScore);

   }
}
