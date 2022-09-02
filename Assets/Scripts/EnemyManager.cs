using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeB;

    // 経過時間
    private float time;
    float rand = 0;

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // 前フレームからの時間を加算していく
        time = time + Time.deltaTime;
        rand = Random.Range(3.0f, 5.0f);
        // 約1秒置きにランダムに生成されるようにする。
        if (time > rand)
        {

            Vector3 enemyPosition1 = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-0.1f, 1.1f), -0.1f, Camera.main.nearClipPlane));//画面下から生成
            Vector3 enemyPosition2 = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//画面左から生成
            Vector3 enemyPosition3 = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//画面右から生成
            Vector3 enemyPosition4 = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-0.1f, 1.1f), 1.1f, Camera.main.nearClipPlane));//画面上から生成
            enemyPosition1.z = 0;
            enemyPosition2.z = 0;
            enemyPosition3.z = 0;
            enemyPosition4.z = 0;
            int instanseRand = Random.Range(1, 5);
            if (instanseRand == 1)
            {
                Instantiate(createPrefab, enemyPosition1, Quaternion.identity);
            }
            else if (instanseRand == 2)
            {
                Instantiate(createPrefab, enemyPosition2, Quaternion.identity);
            }
            else if (instanseRand == 3)
            {
                Instantiate(createPrefab, enemyPosition3, Quaternion.identity);
            }
            else if (instanseRand == 4)
            {
                Instantiate(createPrefab, enemyPosition4, Quaternion.identity);
            }

            // 経過時間リセット
            time = 0f;
        }
    }
}