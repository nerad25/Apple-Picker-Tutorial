using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);


            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();

            Debug.Log("Apple Tag is: " + this.gameObject.tag);

            if (this.gameObject.tag == "Apple")
            {
                apScript.AppleDestroyed();
            }

            //GameObject Apple = GameObject.FindGameObjectWithTag("Apple");
            //GameObject badApple = GameObject.FindGameObjectWithTag("BadApple");

           // Debug.Log("Apple Tag is: " + Apple.gameObject.tag);
            //Debug.Log("BadApple Tag is: " + badApple.gameObject.tag);

            //if (Apple.gameObject.tag == "Apple")
            //{
                //apScript.AppleDestroyed();
               // Debug.Log("Destroying apple");
            //}
            //else {
             //   Debug.Log("Not destroying apple");
            //}
            //apScript.AppleDestroyed();
        }
    }
}
