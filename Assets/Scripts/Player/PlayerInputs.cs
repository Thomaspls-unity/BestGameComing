using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    public float xMove { get; private set; }

    private static PlayerInputs playerInputsInstance;

    public static PlayerInputs GetPlayerInputs()
    {
        return playerInputsInstance;
    }

    private void Awake()
    {
        if(playerInputsInstance != null && playerInputsInstance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            playerInputsInstance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
    }
}
