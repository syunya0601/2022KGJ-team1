using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab1;//�E�ړ�
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject createPrefab2;//���ړ�

    // �o�ߎ���
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
        //Debug.Log(time);
        if (time > rand)
        {
            Vector3 enemyPosition1 = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, Random.Range(0.5f, 1.1f), Camera.main.nearClipPlane));//��ʍ����W����
            Vector3 enemyPosition2 = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, Random.Range(0.5f, 1.1f), Camera.main.nearClipPlane));//��ʉE���W����

            enemyPosition1.z = 0;
            enemyPosition2.z = 0;

            int instanceRand = Random.Range(1, 3);//�����ʒu�����߂�

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
