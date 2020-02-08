using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speedPlayer = 6f;
    Vector3 moviment;
    Animator anim;
    Rigidbody rbPlayer;
    int pisoMask;
    float camLongitude = 100f;
    
    void Awake()
    {
        anim = GetComponent<Animator>();
        rbPlayer = GetComponent<Rigidbody>();
        pisoMask = LayerMask.GetMask("Piso");
    }

    void Star()
    {

    }

    void Update()
    {

    }
}
