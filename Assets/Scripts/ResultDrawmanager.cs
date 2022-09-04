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
        [SerializeField] private Text _Hightcore;
        [SerializeField] private Text _time;

        private ScoreManager _scoreManager = null;

        private void Awake()
        {
            //シングルトンなので重たくないはず,,,
            _scoreManager = FindObjectOfType<ScoreManager>();
        }

        private void Start()
        {
            if (_scoreManager.GetHightScore()==_scoreManager.GetHightScore())
            {
                _Hightcore.text = "ハイスコア："+_scoreManager.GetHightScore();
            }
            else
            {
                _Hightcore.gameObject.SetActive(false);
            }

            _score.text = "スコア:"+_scoreManager.GetScore().ToString();
            _time.text = "タイム："+_scoreManager.GetTime().ToString();
        }
    }
}
