using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    public bool mode1 = false;
    public bool mode2 = false;
    public bool mode3 = false;
    public bool mode4 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z)){
            mode1 = true;
            mode2 = false;
            mode3 = false;
            mode4 = false;
        }
        if (Input.GetKey(KeyCode.X))
        {
            mode1 = false;
            mode2 = true;
            mode3 = false;
            mode4 = false;
        }
        if (Input.GetKey(KeyCode.C))
        {
            mode1 = false;
            mode2 = false;
            mode3 = true;
            mode4 = false;
        }
        if (Input.GetKey(KeyCode.V))
        {
            mode1 = false;
            mode2 = false;
            mode3 = false;
            mode4 = true;
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            mode4 = false;
        }

    }
}
