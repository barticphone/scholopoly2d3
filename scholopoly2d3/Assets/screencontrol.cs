using UnityEngine;
using UnityEngine.UI;

public class screencontrol: MonoBehaviour
{
    private static GameObject regelstext;
   
    // Start is called before the first frame update
    void Start()
    {
       regelstext = GameObject.Find("regelstext");
       regelstext.gameObject.SetActive(false);
        


    }

    // Update is called once per frame
    void Update()
    {
       
    }

} 