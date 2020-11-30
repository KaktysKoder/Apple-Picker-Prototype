using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("Set in Inspector")]
    public Text ScoreGetText;

    private void Start()
    {
        //GameObject scoreGameobject = GameObject.Find("ScoreCounter");
        GameObject scoreGameobject = GameObject.FindWithTag("Score");

        ScoreGetText = scoreGameobject.GetComponent<Text>();

        ScoreGetText.text = "0";
    }

    private void Update()
    {
        // Перемещение корзин мышью. 
        Vector3 mousePosition2D = Input.mousePosition;

        mousePosition2D.z = -Camera.main.transform.position.z;

        Vector3 mousePosition3D = Camera.main.ScreenToWorldPoint(mousePosition2D);

        Vector3 thisPosition = this.transform.position;

        thisPosition.x = mousePosition3D.x;

        this.transform.position = thisPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Отыскать яблоко попавшее в эту корзину.
        GameObject collidedWith = collision.gameObject;

        //if (collidedWith.GetComponent(typeof(Apple)).Equals(collidedWith.GetComponent<Apple>()))
        //    Destroy(collidedWith);

        if (collidedWith.CompareTag("Apple"))
        {
            Destroy(collidedWith);
        }

        int score = int.Parse(ScoreGetText.text);

        score += 100;

        ScoreGetText.text = score.ToString();

        // Запомнить высшее достижение
        if (score > HighScore.Score)
        {
            HighScore.Score = score;
        }
    }
}