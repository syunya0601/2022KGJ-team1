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

    [SerializeField] GameObject wall1;
    [SerializeField] GameObject wall2;
    [SerializeField] GameObject wall3;

    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = Mode1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z)){
            mode1 = true;
            mode2 = false;
            mode3 = false;
            mode4 = false;
            
            MainSpriteRenderer.sprite = Mode1;
        }
        if (Input.GetKey(KeyCode.X))
        {
            mode1 = false;
            mode2 = true;
            mode3 = false;
            mode4 = false;
            MainSpriteRenderer.sprite = Mode2;
        }
        if (Input.GetKey(KeyCode.C))
        {
            mode1 = false;
            mode2 = false;
            mode3 = true;
            mode4 = false;
            MainSpriteRenderer.sprite = Mode3;
        }
        if (Input.GetKey(KeyCode.V))
        {
            mode1 = false;
            mode2 = false;
            mode3 = false;
            mode4 = true;
            MainSpriteRenderer.sprite = Mode4;

            wall1.gameObject.SetActive(true);
            wall2.gameObject.SetActive(true);
            wall3.gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            mode4 = false;
            wall1.gameObject.SetActive(false);
            wall2.gameObject.SetActive(false);
            wall3.gameObject.SetActive(false);
        }

    }
}
