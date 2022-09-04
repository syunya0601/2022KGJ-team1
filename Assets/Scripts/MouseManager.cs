using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Saito;

public class MouseManager : MonoBehaviour
{
    [SerializeField] private Model _model;
    private GameObject obj;
    ModeManager modemanager;
    GameObject clickedGameObject;

    public static int DestroyCount1 = 0;//score
    public static int DestroyCount2 = 0;//score

    [SerializeField]
    [Tooltip("発生させるエフェクト(パーティクル)")]
    private ParticleSystem particle;

    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

    audioSource = GetComponent<AudioSource>();

        obj = GameObject.Find("ModeManager");
        modemanager = obj.GetComponent<ModeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(DestroyCount1);
        //Debug.Log(DestroyCount2);
        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);


            if (hitSprite == true)
            {
                clickedGameObject = hitSprite.transform.gameObject;
                if (clickedGameObject.tag == "Enemy1" && modemanager.mode1==true)
                {
                    audioSource.PlayOneShot(sound1);

                    ParticleSystem newParticle = Instantiate(particle);
                    // パーティクルの発生場所をこのスクリプトをアタッチしているGameObjectの場所にする。
                    newParticle.transform.position = clickedGameObject.transform.position;
                    // パーティクルを発生させる。
                    newParticle.Play();

                    //Debug.Log(clickedGameObject);
                    Destroy(clickedGameObject);
                    DestroyCount2 += 1;
                    Destroy(newParticle.gameObject,1.0f);


                }
                clickedGameObject = hitSprite.transform.gameObject;
                if (clickedGameObject.tag == "Enemy2" && modemanager.mode2 == true)
                {
                    audioSource.PlayOneShot(sound1);

                    ParticleSystem newParticle = Instantiate(particle);
                    // パーティクルの発生場所をこのスクリプトをアタッチしているGameObjectの場所にする。
                    newParticle.transform.position = clickedGameObject.transform.position;
                    // パーティクルを発生させる。
                    newParticle.Play();

                    //Debug.Log(clickedGameObject);
                    Destroy(clickedGameObject);
                    DestroyCount2 += 1;
                    Destroy(newParticle.gameObject, 1.0f);

                }
                clickedGameObject = hitSprite.transform.gameObject;
                if (clickedGameObject.tag == "Enemy3" && modemanager.mode3 == true)
                {
                    audioSource.PlayOneShot(sound1);

                    ParticleSystem newParticle = Instantiate(particle);
                    // パーティクルの発生場所をこのスクリプトをアタッチしているGameObjectの場所にする。
                    newParticle.transform.position = clickedGameObject.transform.position;
                    // パーティクルを発生させる。
                    newParticle.Play();

                    //Debug.Log(clickedGameObject);
                    Destroy(clickedGameObject);
                    DestroyCount2 += 1;
                    Destroy(newParticle.gameObject, 1.0f);

                }
                clickedGameObject = hitSprite.transform.gameObject;
                if (clickedGameObject.tag == "Bomb")
                {
                    audioSource.PlayOneShot(sound2);

                    ParticleSystem newParticle = Instantiate(particle);
                    // パーティクルの発生場所をこのスクリプトをアタッチしているGameObjectの場所にする。
                    newParticle.transform.position = clickedGameObject.transform.position;
                    // パーティクルを発生させる。
                    newParticle.Play();

                    //Debug.Log(clickedGameObject);
                    Destroy(clickedGameObject);
                    _model.UpdateCount(50);
                    Destroy(newParticle.gameObject, 1.0f);

                }
                

            }
        }
    }
}
