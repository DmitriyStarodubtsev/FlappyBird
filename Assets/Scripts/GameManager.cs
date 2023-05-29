using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;
public LoseWindow LoseWindow;
   private void Start()
   {
     instance = this;
   }
    
    public void Lose()
    {
        LoseWindow.gameObject.SetActive(true);
        LoseWindow.PlayerLose();
        Time.timeScale = 0;
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        Time.timeScale = 1; 
    }
    public void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1;
    }
} 
