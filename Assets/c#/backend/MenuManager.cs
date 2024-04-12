using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Text highscoreText;

    void Start()
    {
        // Загрузка рекорда из PlayerPrefs
        int highscore = PlayerPrefs.GetInt("HighScore", 0);
        // Отображение рекорда на экране
        highscoreText.text = "Highscore: " + highscore.ToString();
    }
}
