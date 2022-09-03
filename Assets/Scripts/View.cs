using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Saito
{
    public class View : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private Text _text;

        // Start is called before the first frame update
        public void UpdateText(string s)
        {
            _text.text = s;
        }

        public void ChangeSprite(Sprite sprite)
        {
            _image.sprite = sprite;
        }

    }
}