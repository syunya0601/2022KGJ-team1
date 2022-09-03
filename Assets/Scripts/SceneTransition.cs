using System.Threading;
using Cysharp.Threading.Tasks;
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
                .Subscribe(_ =>
                {
                    var token = this.gameObject.GetCancellationTokenOnDestroy();
                    LoadScene(token).Forget();
                })
                .AddTo(this);
       }

       private async UniTask LoadScene(CancellationToken token)
       {
           await SceneManager.LoadSceneAsync(_scene.name).WithCancellation(token).AsAsyncUnitUniTask();
       }
    }
}