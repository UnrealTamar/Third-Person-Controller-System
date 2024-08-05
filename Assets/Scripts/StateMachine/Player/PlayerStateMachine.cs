using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    [field:SerializeField] public InputReader InputReader{get; private set;}
    [field:SerializeField] public CharacterController Controller{get; private set;}
    [field:SerializeField] public Animator animator{get; private set;}
    [field:SerializeField] public float FreeLookMovementSpeed{get; private set;}
    [field:SerializeField] public float RotationDamping{get; private set;}

    public Transform MainCameraTransform{get; private set;}
    // Start is called before the first frame update
    void Start()
    {
        MainCameraTransform = Camera.main.transform;
        SwitchState(new PlayerFreeLookState(this));
    }

}
