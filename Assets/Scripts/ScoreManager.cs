using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Saito
{
    public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
    {
        #region Singleton

        private void Awake()
        {
            if (this != Instance)
            {
                Debug.LogError("インスタンスが既に存在しています。インスタンスを一つにするためこのインスタンスを破棄します");
                Destroy(this.gameObject);
                return;
            }

            DontDestroyOnLoad(this.gameObject);
        }

        #endregion

        private int _score = 0;
        public int Score => _score;

        private float _time = 0.0f;
        public float Time => _time;

        public void SetScore(int score)
        {
            Instance._score = score;
        }

        public int GetScore()
        {
            return Instance.Score;
        }

        public void SetTime(float time)
        {
            Instance._time = time;
        }

        public float GetTime()
        {
            return Instance.Time;
        }
    }
}
