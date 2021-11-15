using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energyBallActivate : MonoBehaviour
{
    [SerializeField] GameObject energyBall;
    [Range(1.0f, 2.0f)] public float size = 1f;

    public float scale(float focusMin, float focusMax, float energyMin, float energyMax, float focusValue)
    {
        float focusRange = (focusMax - focusMin);
        float energyRange = (energyMax - energyMin);
        float NewValue = (((focusValue - focusMin) * energyRange) / focusRange) + energyMin;

        return (NewValue);
    }

    // Start is called before the first frame update
    void Start()
    {
        Mathf.Lerp
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bellyPos = breathHand.transform.position;
        Debug.Log(bellyPos.ToString("f5"));

        float scaled = scale(exhalePos, inhalePos, 1F, 2F, orbScale);

        energyBall.transform.localScale = new Vector3(scaled, scaled, scaled);
        print(scaled);
    }
}
