using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    [SerializeField] Transform target;//���̍��W
    [SerializeField] int power;//�U����
    // Start is called before the first frame update
    void Start()
    {
 
        target.transform.position = new Vector2(0.0f, 0.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        // �Ώە��ւ̃x�N�g�����Z�o
        Vector2 toDirection = target.transform.position - transform.position;
        // �Ώە��։�]����
        transform.rotation = Quaternion.FromToRotation(Vector2.up, toDirection);
    
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed);
    }
}
