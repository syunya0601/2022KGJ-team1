using UniRx;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Saito
{
    public class SceneTransition : MonoBehaviour
    {
        public  string _scene;
        [SerializeField] private Button _button;


        private void Start()
       {
           _button.OnClickAsObservable()
                .Subscribe(_ =>
                {
                    if (SceneManager.GetActiveScene().name == "Result")
                    {
                        ScoreManager.Instance.Initialized();
                    }

                    SceneManager.LoadSceneAsync(_scene);
                })
                .AddTo(this);

        }
    }
}