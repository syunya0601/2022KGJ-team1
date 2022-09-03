using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    [SerializeField] Transform target;//—‘‚ÌÀ•W
    [SerializeField] int power;//UŒ‚—Í
    public bool transrate;
    public bool wallDestroy;//”L‚Ìè‚Ìíœ
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
            // ‘ÎÛ•¨‚Ö‚ÌƒxƒNƒgƒ‹‚ğZo
            Vector2 toDirection = target.transform.position - transform.position;
            // ‘ÎÛ•¨‚Ö‰ñ“]‚·‚é
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
