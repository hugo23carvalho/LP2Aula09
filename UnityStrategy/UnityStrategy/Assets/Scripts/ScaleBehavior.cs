using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehavior: MonoBehaviour
{
  public void animate() 
    {
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f) + Mathf.Abs(Mathf.Cos(Scale)) + Vector3.one;

        Scale += 0.01f;
    
    }
}
