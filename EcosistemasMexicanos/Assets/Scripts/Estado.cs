using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado : MonoBehaviour
{
    public GameObject gameObject;

    public Estado(GameObject newGameObject) {
        gameObject = newGameObject;
    }

    public Vector4 GetPosition() {
        return gameObject.transform.position;
    }
}
