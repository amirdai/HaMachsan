using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject canvas;
   
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        canvas.SetActive(true);

    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Movment>())
        {
            Time.timeScale = 0;
        }
    }
}
