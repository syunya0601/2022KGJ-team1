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

        private void OnTriggerEnter(Collider other)
        {
            _model.UpdateCount(_damegeAmount);
            Debug.Log(other.name+"と衝突しました。");
        }
    }
}