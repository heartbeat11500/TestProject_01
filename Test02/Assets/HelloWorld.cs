using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [ContextMenu("Test")]
    public void ShowMe()
    {
        Debug.Log("Test");
        Debug.Log("ClickMe");
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Test");
        Debug.Log("dwdaad");
        Debug.Log("asdasd");

    }
}
