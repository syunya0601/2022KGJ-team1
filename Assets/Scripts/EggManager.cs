using System;
using System.Collections;
using System.Collections.Generic;
using Saito;
using UnityEngine;

namespace Saito
{
    public class EggManager : MonoBehaviour
    {
        [SerializeField] private Model _model;
        [SerializeField] private int _damegeAmount = 10;
        //[SerializeField] private EnemyController _enemeyController;
        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("hit");
            if (other.gameObject.tag =="Enemy1") {
                _model.UpdateCount(10);
            }
            if (other.gameObject.tag == "Enemy2")
            {
                _model.UpdateCount(20);
            }
            if (other.gameObject.tag == "Enemy3")
            {
                _model.UpdateCount(30);
            }
            if (other.gameObject.tag == "Enemy4")
            {
                _model.UpdateCount(100);
            }
            Destroy(other.gameObject);
            
        }
    }
}