using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{

    float delay;
    bool isFlickering = false;
    Light thisLight;
    public float minValue = 0.01f;
    public float maxValue = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        thisLight = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFlickering)
        {
            StartCoroutine(FlickerLight());
        }
    }

    IEnumerator FlickerLight()
    {
        isFlickering = true;
        thisLight.enabled = false;
        delay = Random.Range(minValue, maxValue);
        yield return new WaitForSeconds(delay);

        thisLight.enabled = true;
        delay = Random.Range(minValue, maxValue);
        yield return new WaitForSeconds(delay);
        isFlickering = false;
    }
}
