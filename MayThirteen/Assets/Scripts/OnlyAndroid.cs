using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnlyAndroid : MonoBehaviour
{
    public Sprite IOS_Sprite;
    // Use this for initialization
    void Awake()
    {
#if !UNITY_ANDROID
        //gameObject.SetActive (false);
        var rectTransform = GetComponent<RectTransform>();
        rectTransform.offsetMin = new Vector2(20f, 20f);
        rectTransform.offsetMax = new Vector2(-20f, -20f);
        var image = GetComponent<Image>();
        image.sprite = IOS_Sprite;
        
#endif

    }
}
