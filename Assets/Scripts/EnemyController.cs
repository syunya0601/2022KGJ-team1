using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    [SerializeField] Transform target;//卵の座標
    [SerializeField] int power;//攻撃力
    // Start is called before the first frame update
    void Start()
    {
 
        target.transform.position = new Vector2(0.0f, 0.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        // 対象物へのベクトルを算出
        Vector2 toDirection = target.transform.position - transform.position;
        // 対象物へ回転する
        transform.rotation = Quaternion.FromToRotation(Vector2.up, toDirection);
    
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed);
    }
}
