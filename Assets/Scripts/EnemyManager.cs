using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("��������͈�A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("��������͈�B")]
    private Transform rangeB;

    // �o�ߎ���
    private float time;
    float rand = 0;

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // �O�t���[������̎��Ԃ����Z���Ă���
        time = time + Time.deltaTime;
        rand = Random.Range(3.0f, 5.0f);
        // ��1�b�u���Ƀ����_���ɐ��������悤�ɂ���B
        if (time > rand)
        {

            Vector3 enemyPosition1 = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-0.1f, 1.1f), -0.1f, Camera.main.nearClipPlane));//��ʉ����琶��
            Vector3 enemyPosition2 = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//��ʍ����琶��
            Vector3 enemyPosition3 = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, Random.Range(-0.1f, 1.1f), Camera.main.nearClipPlane));//��ʉE���琶��
            Vector3 enemyPosition4 = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(-0.1f, 1.1f), 1.1f, Camera.main.nearClipPlane));//��ʏォ�琶��
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

            // �o�ߎ��ԃ��Z�b�g
            time = 0f;
        }
    }
}