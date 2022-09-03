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
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("ModeManager");
        modemanager = obj.GetComponent<ModeManager>();
    }

    // Update is called once per frame
    void Update()
    {
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
                    //Debug.Log(clickedGameObject);
                    Destroy(clickedGameObject);
                }
                clickedGameObject = hitSprite.transform.gameObject;
                if (clickedGameObject.tag == "Enemy2" && modemanager.mode2 == true)
                {
                    //Debug.Log(clickedGameObject);
                    Destroy(clickedGameObject);
                }
                clickedGameObject = hitSprite.transform.gameObject;
                if (clickedGameObject.tag == "Enemy3" && modemanager.mode3 == true)
                {
                    //Debug.Log(clickedGameObject);
                    Destroy(clickedGameObject);
                }
                clickedGameObject = hitSprite.transform.gameObject;
                if (clickedGameObject.tag == "Bomb")
                {
                    //Debug.Log(clickedGameObject);
                    Destroy(clickedGameObject);
                    _model.UpdateCount(50);
                }

            }
        }
    }
}
