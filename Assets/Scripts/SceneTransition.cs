using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Saito
{
    public class SceneTransition : MonoBehaviour
    {
        [SerializeField] private SceneAsset _scene;
        [SerializeField] private Button _button;

        private void Start()
        {
            _button.OnClickAsObservable()
                .Subscribe(_ => SceneManager.LoadScene(_scene.name, LoadSceneMode.Single))
                .AddTo(this);
        }
    }
}