using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace Saito
{
  public class Model : MonoBehaviour
  {
    private IntReactiveProperty _current = new IntReactiveProperty();
    public IReactiveProperty<int> Current => _current;

    private int count = 0;
    
    public void UpdateCount(int value)
    {
      _current.Value = count+Mathf.Clamp(value, 0, 100);
      count = _current.Value;
      Debug.Log(count);
    }
  }
}