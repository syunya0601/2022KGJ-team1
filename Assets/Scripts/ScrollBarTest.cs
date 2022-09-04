using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBarTest : MonoBehaviour
{
    [SerializeField]
    private Image GreenGauge;
    [SerializeField]
    private Image RedGauge;

    private float maxLife = 1.0f;
    private float life = 0.5f;
    private float reducationValue = 0.2f;
    
    private Tween redGaugeTween;

    public void Get()
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
    }
}
