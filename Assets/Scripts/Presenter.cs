using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UniRx;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Saito
{
    public class Presenter : MonoBehaviour
    {
        [SerializeField] private Model _model;
        [SerializeField] private View _view;

        [SerializeField] private Slider _slider;
        [SerializeField] private Sprite _sprite1;
        [SerializeField] private Sprite _sprite2;
        [SerializeField] private Sprite _sprite3;
        [SerializeField] private Sprite _sprite4;
        [SerializeField] private Sprite _sprite5;

        [SerializeField] private SceneAsset scene;
        [SerializeField] private ScoreManager _scoreManager;

        // Start is called before the first frame update
        void Start()
        { 
            var time = 0.0f;
                     Observable.EveryUpdate()
                         .Subscribe(value =>
                             {
                                 Task.Delay(TimeSpan.FromSeconds(10f));
                                 time += Time.deltaTime;
                                 _view.UpdateText(time.ToString("0.00"));
                             },
                             ex => Debug.LogError("OnError!"),
                             () => Debug.Log("OnCompleted!")
                         ).AddTo(this);
                     
            //model=>view
            _model.Current
                .Subscribe(x =>
                    {
                        if (x == 0) { }
                        else if (x <= 20)
                        {
                            _view.ChangeSprite(_sprite2);
                        }
                        else if (x <= 40)
                        {
                            _view.ChangeSprite(_sprite3);
                        }
                        else if (x <= 60)
                        {
                            _view.ChangeSprite(_sprite4);
                        }
                        else if (x <= 80)
                        {
                            _view.ChangeSprite(_sprite5);
                        }
                        if(x >= 100)
                        {
                            Thread.Sleep(TimeSpan.FromSeconds(2f));
                            _view.ChangeSprite(_sprite1);
                            _scoreManager.SetScore((int)time);
                            _scoreManager.SetTime(time);
                             SceneManager.LoadScene(scene.name);
                        }

                        _slider.value = x;
                        _view.UpdateText(_slider.value.ToString());
                    },
                    ex => Debug.LogError("OnError!"),
                    () => Debug.Log("OnCompleted!")
                ).AddTo(this);

            
            /*
            //sliderの値が変動したら実体にも値を変更する
            _slider
                .OnValueChangedAsObservable()
                .Subscribe(x => _model.UpdateCount((int) x))
                .AddTo(this);
            */
        }
    }
}