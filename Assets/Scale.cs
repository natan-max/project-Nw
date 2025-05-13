using UnityEngine;
using UnityEngine.UI;

public class ImageToggleScaler : MonoBehaviour
{
    public RectTransform imageTransform; // Сюди перетягни Image
    private int scaleState = 0; // 0 = норм, 1 = збільшена, 2 = зменшена

    private Vector3 normalScale;
    private Vector3 maxScale;
    private Vector3 minScale;

    void Start()
    {
        if (imageTransform == null)
            imageTransform = GetComponent<RectTransform>();

        normalScale = imageTransform.localScale;
        maxScale = normalScale * 1.3f;
        minScale = normalScale * 0.8f;
    }

    public void OnClickScale()
    {
        scaleState = (scaleState + 1) % 3;

        switch (scaleState)
        {
            case 0:
                imageTransform.localScale = normalScale;
                break;
            case 1:
                imageTransform.localScale = maxScale;
                break;
            case 2:
                imageTransform.localScale = minScale;
                break;
        }
    }
}