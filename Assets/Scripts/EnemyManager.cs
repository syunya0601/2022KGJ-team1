using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab1;//��
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab2;//�{�[��
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab3;//��
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab4;//�L�̎�

    // �o�ߎ���
    private float LevelTime;
    private float time;
    float rand = 0;
    float MaxTime = 5.0f;
    float MinTime = 3.0f;

    Vector2 lscale;

    private void Start()
    {
        lscale = createPrefab3.transform.localScale;
    }
    // Update is called once per frame
    void Update()
    {
        LevelTime += Time.deltaTime;
        // �O�t���[������̎��Ԃ����Z���Ă���
        time += Time.deltaTime;
        rand = Random.Range(MinTime, MaxTime);
        // ��1�b�u���Ƀ����_���ɐ��������悤�ɂ���B
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


            Vector3 enemyPosition1 = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//��ʍ����W����
            Vector3 enemyPosition2 = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//��ʉE���W����
            Vector3 enemyPosition3 = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-0.1f, 1.1f), 1.1f, Camera.main.nearClipPlane));//��ʏ���W����
            
            enemyPosition1.z = 0;
            enemyPosition2.z = 0;
            enemyPosition3.z = 0;
            int instanceTypeRand = Random.Range(1, 16);
            int instanceRand = Random.Range(1, 4);
            /*if (1 <= instanceTypeRand &&instanceTypeRand < 8)
            {
                //3��������̐���

                if (instanceRand == 1)
                {
                    Instantiate(createPrefab1, enemyPosition1, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
                    Instantiate(createPrefab1, enemyPosition2, Quaternion.identity);
                }
                else if (instanceRand == 3)
                {
                    Instantiate(createPrefab1, enemyPosition3, Quaternion.identity);
                }
            }
            if (8 <= instanceTypeRand && instanceTypeRand < 12)
            {
                //3��������̐���
                if (instanceRand == 1)
                {
                    Instantiate(createPrefab2, enemyPosition1, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
                    Instantiate(createPrefab2, enemyPosition2, Quaternion.identity);
                }
                else if (instanceRand == 3)
                {
                    Instantiate(createPrefab2, enemyPosition3, Quaternion.identity);
                }
            }
            if (12 <= instanceTypeRand && instanceTypeRand <= 14)
            {
                //3��������̐���
                if (instanceRand == 1)
                {
                    createPrefab3.GetComponent<SpriteRenderer>().flipX = true;
                    Instantiate(createPrefab3, enemyPosition1, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
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
                    Instantiate(createPrefab3, enemyPosition3, Quaternion.identity);
                }
            }*/
            if (1 < instanceTypeRand && instanceTypeRand <= 15)
            {
                //3��������̐���
                if (instanceRand == 1)
                {
                    Instantiate(createPrefab4, enemyPosition1, Quaternion.identity);
                }
                else if (instanceRand == 2)
                {
                    Instantiate(createPrefab4, enemyPosition2, Quaternion.identity);
                }
                else if (instanceRand == 3)
                {
                    Instantiate(createPrefab4, enemyPosition3, Quaternion.identity);
                }
            }


            // �o�ߎ��ԃ��Z�b�g
            time = 0f;
        }
    }
}