using UnityEngine;

public class Vector3Code : MonoBehaviour
{
                                              //This code is just a "How to use Vector3 in Unity"

    //this float is just to multiply in "Time.deltaTime"
    float Whatever = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //You'll give a name to your Vector3
        Vector3 vector3name = new Vector3(0, 0, 0) * Whatever * Time.deltaTime;
        //----------- Put that "new Vector3" and your float in (0, 0, 0)
        //Multiply by your main float, and by Time.deltaTime

        transform.Translate(vector3name);
        //And Put the Vector3 in transform.Translate(yourfloat);
    }

}