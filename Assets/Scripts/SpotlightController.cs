using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightController : MonoBehaviour
{
    public SpriteRenderer spotlight;
    public Camera cam;

    public float minScale;
    public float maxScale;
    public AnimationCurve scaleCurve;
    public Gradient darknessColourCurve;
    public Gradient spotlightColourCurve;

    // Update is called once per frame
    void Update()
    {
        spotlight.transform.localScale = Vector2.one * Mathf.Lerp(minScale, maxScale, scaleCurve.Evaluate(AnxietyController.anxietyLevel01));
        cam.backgroundColor = darknessColourCurve.Evaluate(AnxietyController.anxietyLevel01);
        spotlight.color = spotlightColourCurve.Evaluate(AnxietyController.anxietyLevel01);
        //AnxietyController.ChangeAnxiety01(Time.deltaTime * 0.05f);
    }
}
