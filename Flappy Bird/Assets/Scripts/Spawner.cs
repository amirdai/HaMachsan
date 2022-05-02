using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1f;
    float timer = 0f;
    public GameObject pipePrefab;
    Vector2 spread;
    public float hight = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>maxTime)
        {
            spread = new Vector2(transform.position.x, Random.Range(-hight, hight));
            GameObject newPipe = Instantiate(pipePrefab, spread, Quaternion.identity); 
            
            timer = 0f;
        }
        timer += Time.deltaTime;
    }
}
