using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab1;//石
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab2;//ボール
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab3;//鳥
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab4;//猫の手

    // 経過時間
    private float LevelTime;
    private float time;
    float rand = 0;
    float MaxTime = 5.0f;
    float MinTime = 3.0f;

    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioSource audioSource1;
    public AudioSource audioSource2;

    private void Start()
    {
        //audioSource1 = GetComponent<AudioSource>();
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
            MaxTime -= 0.2f;
            MinTime -= 0.2f;
            LevelTime = 0;
            //Debug.Log(MaxTime);
            //Debug.Log(MinTime);
            
        }
        if (time > rand)
        {


            Vector3 enemyPosition1 = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//画面左座標決め
            Vector3 enemyPosition2 = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//画面右座標決め
            Vector3 enemyPosition3 = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-0.1f, 1.1f), 1.1f, Camera.main.nearClipPlane));//画面上座標決め
            
            enemyPosition1.z = 0;
            enemyPosition2.z = 0;
            enemyPosition3.z = 0;
            int instanceTypeRand = Random.Range(1, 16);
            int instanceRand = Random.Range(1, 4);
            if (1 <= instanceTypeRand &&instanceTypeRand < 8)
            {
                //3方向からの生成

                if (instanceRand == 1)
                {
                    audioSource1.PlayOneShot(sound1);
                    Instantiate(createPrefab1, enemyPosition1, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
                    audioSource1.PlayOneShot(sound1);
                    Instantiate(createPrefab1, enemyPosition2, Quaternion.identity);
                }
                else if (instanceRand == 3)
                {
                    audioSource1.PlayOneShot(sound1);
                    Instantiate(createPrefab1, enemyPosition3, Quaternion.identity);
                }
            }
            if (8 <= instanceTypeRand && instanceTypeRand < 12)
            {
                //3方向からの生成
                if (instanceRand == 1)
                {
                    audioSource1.PlayOneShot(sound1);
                    Instantiate(createPrefab2, enemyPosition1, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
                    audioSource1.PlayOneShot(sound1);
                    Instantiate(createPrefab2, enemyPosition2, Quaternion.identity);
                }
                else if (instanceRand == 3)
                {
                    audioSource1.PlayOneShot(sound1);
                    Instantiate(createPrefab2, enemyPosition3, Quaternion.identity);
                }
            }
            if (12 <= instanceTypeRand && instanceTypeRand <= 14)
            {
                //3方向からの生成
                if (instanceRand == 1)
                {
                    audioSource2.PlayOneShot(sound2);
                    createPrefab3.GetComponent<SpriteRenderer>().flipX = true;
                    Instantiate(createPrefab3, enemyPosition1, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
                    audioSource2.PlayOneShot(sound2);
                    createPrefab3.GetComponent<SpriteRenderer>().flipX = false;
                    Instantiate(createPrefab3, enemyPosition2, Quaternion.identity);
                }
                else if (instanceRand == 3)
                {

                    if (enemyPosition3.x <= 0)
                    {
                        createPrefab3.GetComponent<SpriteRenderer>().flipX = true;
                    }
                    else if (enemyPosition3.x > 0)
                    {
                        createPrefab3.GetComponent<SpriteRenderer>().flipX = false;
                    }
                    audioSource2.PlayOneShot(sound2);
                    Instantiate(createPrefab3, enemyPosition3, Quaternion.identity);
                }
            }
            if (14 < instanceTypeRand && instanceTypeRand <= 15)
            {
                enemyPosition1 = Camera.main.ViewportToWorldPoint(new Vector3(-0.3f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//画面左座標決め
                enemyPosition2 = Camera.main.ViewportToWorldPoint(new Vector3(1.3f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//画面右座標決め
                enemyPosition3 = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-0.1f, 1.1f), 1.5f, Camera.main.nearClipPlane));//画面上座標決め

                enemyPosition1.z = 0;
                enemyPosition2.z = 0;
                enemyPosition3.z = 0;
                //3方向からの生成
                if (instanceRand == 1)
                {
                    audioSource2.PlayOneShot(sound3);
                    Instantiate(createPrefab4, enemyPosition1, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
                    audioSource2.PlayOneShot(sound3);
                    Instantiate(createPrefab4, enemyPosition2, Quaternion.identity);
                }
                else if (instanceRand == 3)
                {
                    audioSource2.PlayOneShot(sound3);
                    Instantiate(createPrefab4, enemyPosition3, Quaternion.identity);
                }
            }


            // 経過時間リセット
            time = 0f;
        }
    }
}