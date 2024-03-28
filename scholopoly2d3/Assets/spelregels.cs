using UnityEngine;
using UnityEngine.UI;

public class spelregels1 : MonoBehaviour
{
    public static GameObject regelstext;

    public void open()
    {
        regelstext = GameObject.Find("regelstext");
        regelstext.gameObject.SetActive(true);
    }
}