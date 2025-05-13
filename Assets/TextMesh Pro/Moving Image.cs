using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingImage : MonoBehaviour
{
    public RectTransform imageTransform;
    public float moveDistance = 50f;

    public void MoveUp()
    {
        if (imageTransform != null)
        {
            
            Vector3 currentPosition = imageTransform.localPosition;
            currentPosition.y += moveDistance;
            imageTransform.localPosition = currentPosition;
        }
    }

}
