using UnityEngine;

public class MoveYourPlayer : MonoBehaviour
{
 
                                  //This code is a "How to move your player in unity"

    //This float is to multiply the "Vector3" by "Time.deltaTime"
    float Whatever = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Create your float with the Inputs below
        float X = Input.GetAxis("Horizontal")
        float Z = Input.GetAxis("Vertical")
        
        //And Create your Vector3
        Vector3 Vector3name = new Vector3(X, 0, Z) * Whatever * Time.deltaTime;

        transform.Translate(Vector3name);
    }

}