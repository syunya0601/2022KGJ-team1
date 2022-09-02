using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Model : MonoBehaviour
{
  private IntReactiveProperty _current = new IntReactiveProperty();
  public IReactiveProperty<int> Current => _current;

  public void UpdateCount(int value)
  {
    _current.Value = Mathf.Clamp(value, 0, 100);
  }
}
