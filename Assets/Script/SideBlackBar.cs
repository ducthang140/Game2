//using UnityEngine;

//[RequireComponent(typeof(Camera))]
//public class PortraitAspect : MonoBehaviour
//{
//    void Start()
//    {
//        Camera cam = GetComponent<Camera>();

//        float targetAspect = 9f / 16f;
//        float windowAspect = (float)Screen.width / Screen.height;
//        float scale = windowAspect / targetAspect;

//        if (scale > 1f)
//        {
//            // Screen is wider than target → add black bars on left/right
//            float width = targetAspect / windowAspect;
//            cam.rect = new Rect((1f - width) / 2f, 0, width, 1);
//        }
//        else
//        {
//            // Screen is taller than target → add black bars top/bottom
//            float height = windowAspect / targetAspect;
//            cam.rect = new Rect(0, (1f - height) / 2f, 1, height);
//        }
//    }
//}