using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    [SerializeField] Transform target;//���̍��W
    [SerializeField] int power;//�U����
    public bool transrate;
    public bool wallDestroy;//�L�̎�̍폜
    // Start is called before the first frame update
    void Start()
    {
 
        target.transform.position = new Vector2(0.0f, 0.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transrate == true)
        {
            // �Ώە��ւ̃x�N�g�����Z�o
            Vector2 toDirection = target.transform.position - transform.position;
            // �Ώە��։�]����
            transform.rotation = Quaternion.FromToRotation(Vector2.up, toDirection);
        }
    
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.name == "wall")
        {
            if (wallDestroy == true)
            {
                Destroy(this.gameObject);
                //Debug.Log("hit");
            }
        }
    }
}
