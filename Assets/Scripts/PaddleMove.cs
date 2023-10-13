
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{

    private float _direction;
    public float moveSpeed; // can be changed on unity bc public
    public float minX, maxX;
    public void OnMove(InputValue value) 
    {
        _direction = value.Get<float>(); // get sirection value from input of A and D key (-1 or 1)
    }
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() 
    {
        float newX = transform.position.x + (_direction * moveSpeed * Time.deltaTime); // move object
        float clampedX = Mathf.Clamp(newX, minX, maxX); //sets the clamped value
        transform.position = new Vector3(clampedX, 0, 0);
    }
}
