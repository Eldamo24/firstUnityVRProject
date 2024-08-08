using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleScript : MonoBehaviour
{
    private Vector3 minScale = Vector3.one;
    private Vector3 maxScale = new Vector3(1.5f, 1.5f, 1.5f);
    private float speedScale = 2f;

    // Update is called once per frame
    void Update()
    {
        float scale = (Mathf.Sin(Time.time * speedScale) + 1.0f) / 2.0f;
        transform.localScale = Vector3.Lerp(minScale, maxScale, scale);
    }

}
