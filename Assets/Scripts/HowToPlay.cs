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
    
    [SerializeField] private Button _leftButton;
    [SerializeField] private Button _rightButton;
    
    void Start()
    {
        _openButton.OnClickAsObservable()
            .Subscribe(_ =>
            {
                _panel.SetActive(true);
            })
            .AddTo(this);

        _closedButton.OnClickAsObservable()
            .Subscribe(_ =>
            {
                _panel.SetActive(false);
            })
            .AddTo(this);

        /*
        Observable.Merge(
            _leftButton.Select(_ => +),
            _rightButton.Select(_ =>)
        ).Subscribe(_ =>
            {
                
            })
            .AddTo(this);
            */
    }
}
