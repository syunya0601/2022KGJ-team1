using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab1;//右移動
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab2;//左移動

    // 経過時間
    private float LevelTime;
    private float time;
    float rand = 0;
    float MaxTime = 10.0f;
    float MinTime = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelTime += Time.deltaTime;
        // 前フレームからの時間を加算していく
        time += Time.deltaTime;
        rand = Random.Range(MinTime, MaxTime);
        // 約1秒置きにランダムに生成されるようにする。
        //Debug.Log(LevelTime);
        if (LevelTime > 10)
        {
            MaxTime -= 0.1f;
            MinTime -= 0.1f;
            LevelTime = 0;
            //Debug.Log(MaxTime);
            //Debug.Log(MinTime);

        }
        //Debug.Log(time);
        if (time > rand)
        {
            Vector3 enemyPosition1 = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, Random.Range(0.5f, 1.1f), Camera.main.nearClipPlane));//画面左座標決め
            Vector3 enemyPosition2 = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, Random.Range(0.5f, 1.1f), Camera.main.nearClipPlane));//画面右座標決め

            enemyPosition1.z = 0;
            enemyPosition2.z = 0;

            int instanceRand = Random.Range(1, 3);//生成位置を決める

            if (instanceRand == 1)
            {
                Instantiate(createPrefab1, enemyPosition1, Quaternion.identity);
            }
            else if (instanceRand == 2)
            {
                Instantiate(createPrefab2, enemyPosition2, Quaternion.identity);
            }
            time = 0f;
        }
    }
}
