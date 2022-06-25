using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spineCube : MonoBehaviour
{
    public float degree;
    public Transform tf;

    // делаем крутящиеся препятсвие
    void Update()
    {
        tf.Rotate(0, degree, 0);
    }
}
