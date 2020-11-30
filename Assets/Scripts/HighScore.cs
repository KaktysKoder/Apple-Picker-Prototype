using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static int Score = 1000;

    private void Awake()
    {
        // Если значение HighScore уже существует в PlayerPrefs, прочитать его
        if (PlayerPrefs.HasKey("HighScore"))
        {
            Score = PlayerPrefs.GetInt("HighScore");
        }

        // Сохранить высшее достижение HighScore в хранилище
        PlayerPrefs.SetInt("HighScore", Score);
    }

    private void Update()
    {
        Text getText = this.GetComponent<Text>();

        getText.text = $"High Score: {Score}";

        // Обновить HighScore в PlayerPrefs, если необходимо
        if (Score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", Score);
        }
    }
}