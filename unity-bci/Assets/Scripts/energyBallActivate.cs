using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class energyBallActivate : MonoBehaviour
{
    [SerializeField] GameObject energyBall;
    public Vector3 minEnergySize;
    public Vector3 maxEnergySize;
    [SerializeField]
    [Range(0f, 1f)] 
    float sizeToFocusPercent = 0f;

    public float focusValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        energyBall.transform.localScale = Vector3.Lerp(minEnergySize, maxEnergySize, sizeToFocusPercent);
    }
}
