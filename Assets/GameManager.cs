using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public birdBehaviour bird;
    public int score;
    public TMP_Text ScoreText;
    public TMP_Text EndText;
    private bool isGamePaused = false;

    // Start is called before the first frame update
    void Start()
    {
        if(EndText.enabled == true){
            EndText.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = $"{score}";
        if(bird.collide == true){
            Time.timeScale = 0f; 
            isGamePaused = true;
            EndText.enabled = true;
            Debug.Log("ok");
            if(Input.GetKey(KeyCode.Backspace)){
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
                Time.timeScale = 1f;

            }
        }
    }
}
