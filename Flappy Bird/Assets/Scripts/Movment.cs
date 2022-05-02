using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class Movment : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpHight = 5f;
    Vector2 velo = new Vector2();
    public int score = 0;
    public GameManager gameManager;
    public Text scoreText;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        int endscore = score;
        if (endscore > PlayerPrefs.GetInt("HighS"))
        {
            PlayerPrefs.SetInt("HighS", endscore);
        }
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighS").ToString();
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            velo = rb.velocity;
            velo.y = jumpHight;
            rb.velocity = velo;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameManager.GameOver();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        score++;
    }
}
