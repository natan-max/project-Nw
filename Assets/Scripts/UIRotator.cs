using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRotator : MonoBehaviour
{
    public static void RotateSelf(RectTransform rect_transform)
    {
        Vector3 rotation = rect_transform.eulerAngles;
        rotation.z += 5f;
        rect_transform.eulerAngles = rotation;
    }
}
