using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDestroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        gameObject.SetActive(false);
    }
}
