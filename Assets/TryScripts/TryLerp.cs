using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryLerp : MonoBehaviour
{
    private List<int> valuesOne = new List<int>() { 1, 2, 3 };

    private List<int> valuesTwo = new List<int>() { 5, 6, 7 };

    private Dictionary<int, int> interpolatedValues = null;

    private float t = 0.5f;

    private float MeanValue(float val1, float val2) => (val1 + val2) / 2;

    

    private void Update()
    {
        for(int i = 0; i < valuesOne.Count; ++i)
        {
            //var key = Vector3.Lerp(valuesOne[i], valuesTwo[i], t);
        }
    }
}
