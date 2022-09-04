using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class HowToPlay : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    
    [SerializeField] private Button _openButton;
    [SerializeField] private Button _closedButton;
    
    void Start()
    {
        Observable.Merge(
            _openButton.OnClickAsObservable().Select(_ => true),
            _closedButton.OnClickAsObservable().Select(_ => false)
        ).Subscribe(flag => { _panel.SetActive(flag); }).AddTo(this);
    }
}
