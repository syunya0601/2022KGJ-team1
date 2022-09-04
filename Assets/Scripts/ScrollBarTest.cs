using System;
using DG.Tweening;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBarTest : MonoBehaviour
{
    [SerializeField] private Button _button;
    
    [SerializeField]
    private Image GreenGauge;
    [SerializeField]
    private Image RedGauge;

    private float maxLife = 1.0f;
    private float life = 1.0f;

    private Tween redGaugeTween;


    private void Start()
    {
        _button.OnClickAsObservable()
            .Subscribe(_ => Get(0.1f))
            .AddTo(this);
    }

    public void Get(float reducationValue)
    {
        var valueFrom = life / maxLife;
        var valueTo = (life - reducationValue) / maxLife;
        
        GreenGauge.fillAmount = valueTo;
         
                if (redGaugeTween != null) {
                    redGaugeTween.Kill();
                }
         
                // 赤ゲージ減少
                redGaugeTween = DOTween.To(
                    () => valueFrom,
                    x => {
                        RedGauge.fillAmount = x;
                    },
                    valueTo,
                    1f
                );
                life = life - reducationValue;
    }
}
