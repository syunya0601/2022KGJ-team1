using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Saito
{
    public class ResultDrawmanager : MonoBehaviour
    {
        [SerializeField] private Text _score;
        [SerializeField] private Text _time;

        private ScoreManager _scoreManager = null;

        private void Awake()
        {
            //シングルトンなので重たくないはず,,,
            _scoreManager = FindObjectOfType<ScoreManager>();
        }

        private void Start()
        {
            _score.text = "スコア:"+_scoreManager.GetScore().ToString();
            _time.text = "タイム"+_scoreManager.GetTime().ToString();
        }
    }
}
