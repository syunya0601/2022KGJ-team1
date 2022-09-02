using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab1;
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab2;
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab3;
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab4;

    // 経過時間
    private float LevelTime;
    private float time;
    float rand = 0;
    float MaxTime = 5.0f;
    float MinTime = 3.0f;

    private void Start()
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
        if (time > rand)
        {


            Vector3 enemyPosition2 = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//画面左から生成
            Vector3 enemyPosition3 = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//画面右から生成
            Vector3 enemyPosition4 = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-0.1f, 1.1f), 1.1f, Camera.main.nearClipPlane));//画面上から生成
            //enemyPosition1.z = 0;
            enemyPosition2.z = 0;
            enemyPosition3.z = 0;
            enemyPosition4.z = 0;
            int instanceTypeRand = Random.Range(1, 16);
            int instanceRand = Random.Range(1, 4);
            if (1 <= instanceTypeRand &&instanceTypeRand < 8)
            {
                //4方向からの生成

                if (instanceRand == 1)
                {
                    Instantiate(createPrefab1, enemyPosition2, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
                    Instantiate(createPrefab1, enemyPosition3, Quaternion.identity);
                }
                else if (instanceRand == 3)
                {
                    Instantiate(createPrefab1, enemyPosition4, Quaternion.identity);
                }
            }
            if (8 <= instanceTypeRand && instanceTypeRand < 12)
            {
                //4方向からの生成
                if (instanceRand == 1)
                {
                    Instantiate(createPrefab2, enemyPosition2, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
                    Instantiate(createPrefab2, enemyPosition3, Quaternion.identity);
                }
                else if (instanceRand == 3)
                {
                    Instantiate(createPrefab2, enemyPosition4, Quaternion.identity);
                }
            }
            if (12 <= instanceTypeRand && instanceTypeRand <= 14)
            {
                //4方向からの生成
                if (instanceRand == 1)
                {
                    Instantiate(createPrefab3, enemyPosition2, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
                    Instantiate(createPrefab3, enemyPosition3, Quaternion.identity);
                }
                else if (instanceRand == 3)
                {
                    Instantiate(createPrefab3, enemyPosition4, Quaternion.identity);
                }
            }
            if (14 < instanceTypeRand && instanceTypeRand <= 15)
            {
                //4方向からの生成
                if (instanceRand == 1)
                {
                    Instantiate(createPrefab4, enemyPosition2, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
                    Instantiate(createPrefab4, enemyPosition3, Quaternion.identity);
                }
                else if (instanceRand == 3)
                {
                    Instantiate(createPrefab4, enemyPosition4, Quaternion.identity);
                }
            }


            // 経過時間リセット
            time = 0f;
        }
    }
}