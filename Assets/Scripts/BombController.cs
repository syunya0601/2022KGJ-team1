using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    private float speed;
    public int direction=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(0.05f, 0.01f);
        Vector2 position = transform.position;
        if (direction == 1)
        {
            position.x -= speed;
        }else if (direction == 2)
        {
            position.x += speed;
        }
        

        transform.position = position;
    }

}
