using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    

    public float speed;
    [SerializeField] Transform target;//���̍��W
    public int power=0;//�U����
    public bool transrate;
    public bool wallDestroy;//�L�̎�̍폜

    public AudioClip sound1;
    AudioSource audioSource1;
    // Start is called before the first frame update
    void Start()
    {
 
        target.transform.position = new Vector2(0.0f, 0.0f);
        audioSource1 = GetComponent<AudioSource>();
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
        
        if (collider.gameObject.tag == "wall")
        {
            if (wallDestroy == true)
            {
                audioSource1.PlayOneShot(sound1);
                MouseManager.DestroyCount1 += 1;
                Destroy(this.gameObject);
                
            }
        }
    }
}
