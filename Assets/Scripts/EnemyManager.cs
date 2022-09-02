using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab1;
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab2;
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab3;
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab4;

    // �o�ߎ���
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


            Vector3 enemyPosition2 = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//��ʍ����琶��
            Vector3 enemyPosition3 = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//��ʉE���琶��
            Vector3 enemyPosition4 = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-0.1f, 1.1f), 1.1f, Camera.main.nearClipPlane));//��ʏォ�琶��
            //enemyPosition1.z = 0;
            enemyPosition2.z = 0;
            enemyPosition3.z = 0;
            enemyPosition4.z = 0;
            int instanceTypeRand = Random.Range(1, 16);
            int instanceRand = Random.Range(1, 4);
            if (1 <= instanceTypeRand &&instanceTypeRand < 8)
            {
                //4��������̐���

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
                //4��������̐���
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
                //4��������̐���
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
                //4��������̐���
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


            // �o�ߎ��ԃ��Z�b�g
            time = 0f;
        }
    }
}