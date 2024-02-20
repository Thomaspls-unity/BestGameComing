using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        MovePlayer(xMove);
    }

    private void MovePlayer(float xMove)
    {
        transform.position += playerSpeed * Time.deltaTime * new Vector3(xMove, 0, 0);

        Mathf.Clamp(transform.position.x, -1.0f, 1.0f);
    }
}
