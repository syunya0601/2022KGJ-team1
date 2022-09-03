using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    public bool mode1 = false;
    public bool mode2 = false;
    public bool mode3 = false;
    public bool mode4 = false;

    SpriteRenderer MainSpriteRenderer;
    public Sprite Mode1;
    public Sprite Mode2;
    public Sprite Mode3;
    public Sprite Mode4;
    public Sprite none;

    [SerializeField] GameObject wall;


    Transform myTransform;
    Vector3 pos;

    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = Mode1;

        myTransform = this.transform;
        pos = myTransform.position;

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z)|| Input.GetKeyDown(KeyCode.Alpha1))
        {
            audioSource.PlayOneShot(sound1);
            mode1 = true;
            mode2 = false;
            mode3 = false;
            mode4 = false;
            
            MainSpriteRenderer.sprite = Mode1;
            pos.y = -3.8f;
        }
        if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            audioSource.PlayOneShot(sound1);
            mode1 = false;
            mode2 = true;
            mode3 = false;
            mode4 = false;
            MainSpriteRenderer.sprite = Mode2;
            pos.y = -3.8f;
        }
        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            audioSource.PlayOneShot(sound1);
            mode1 = false;
            mode2 = false;
            mode3 = true;
            mode4 = false;
            MainSpriteRenderer.sprite = Mode3;
            pos.y = -3.8f;
        }
        if (Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            audioSource.PlayOneShot(sound1);
            mode1 = false;
            mode2 = false;
            mode3 = false;
            mode4 = true;
            MainSpriteRenderer.sprite = Mode4;

            wall.gameObject.SetActive(true);

            pos.y = -2.8f;
        }
        if (Input.GetKeyUp(KeyCode.V) || Input.GetKeyUp(KeyCode.Alpha4))
        {
            mode4 = false;
            wall.gameObject.SetActive(false);
            pos.y = -2.8f;
            MainSpriteRenderer.sprite = none;

        }
        myTransform.position = pos;  // ç¿ïWÇê›íË
        
    }
}
