using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class energyBallActivate : MonoBehaviour
{
    [SerializeField] GameObject energyBall;
    public Vector3 minEnergySize;
    public Vector3 maxEnergySize;
    [SerializeField]
    [Range(0f, 1f)]
    float sizeToFocusPercent = 0f;

    //identify controller for input
    [SerializeField] ActionBasedController actionBasedController;
    private bool growthActive = false;

    // Start is called before the first frame update
    void Start()
    {
        //controller input for select action (grip button)
        actionBasedController.selectAction.action.performed += growEnergyBallSize;
    }

    //function that increases size of energy ball upon grip button press
    private void growEnergyBallSize(InputAction.CallbackContext obj)
    {
        growthActive = !growthActive;
    }

    // Update is called once per frame
    void Update()
    {
        energyBall.transform.localScale = Vector3.Lerp(minEnergySize, maxEnergySize, sizeToFocusPercent);

        //grow ball if button pressed
        if (growthActive == true)
        {
            sizeToFocusPercent += 0.001f;
        }
    }
}
