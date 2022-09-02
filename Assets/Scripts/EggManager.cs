using System;
using System.Collections;
using System.Collections.Generic;
using Saito;
using UnityEngine;

public class EggManager : MonoBehaviour
{
    [SerializeField] private Model _model;
    [SerializeField] private int _damegeAmount=10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Enemy1")
        {
            _model.UpdateCount(_damegeAmount);
        }
    }
}
