using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace Saito
{
    public class Presenter : MonoBehaviour
    {
        [SerializeField] private Model _model;
        [SerializeField] private View _view;

        [SerializeField] private Slider _slider;
        [SerializeField] private Sprite _sprite;

        // Start is called before the first frame update
        void Start()
        {
            //model=>view
            _model.Current
                .Subscribe(x =>
                    {
                        if (x == 100) _view.ChangeSprite(_sprite);

                        _slider.value = x;
                        //_view.UpdateText(_slider.value.ToString());
                    },
                    ex => Debug.LogError("OnError!"),
                    () => Debug.Log("OnCompleted!")
                ).AddTo(this);

            //sliderの値が変動したら実体にも値を変更する
            _slider
                .OnValueChangedAsObservable()
                .Subscribe(x => _model.UpdateCount((int) x))
                .AddTo(this);


            var time = 0.0f;
            Observable.EveryUpdate()
                .Subscribe(value =>
                    {
                        time += Time.deltaTime;
                        _view.UpdateText(time.ToString("0.00"));
                    },
                    ex => Debug.LogError("OnError!"),
                    () => Debug.Log("OnCompleted!")
                ).AddTo(this);
        }
    }
}