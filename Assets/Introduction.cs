using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{

    public int testInt = 10;

    public float testFloat = 5f;

    public double testDouble;

    public bool testBool;

    public char testChar;

    public string testString = "HEnloreeeee";

    void Start()
    {
        MathFunction1();
        TestFunction();
        print(testInt);
        print("Wissam Hattab");
        print("LBS Kreativa Gymnasiet");
        print("SU18a");
        print("Spelutveckling");

    }  

    void MathFunction1() //Math thing
    {
        Debug.Log(string.Format("Answer to (963 * 421) - (175463 / 87) = {0}", (963f * 421f) - (175463f / 87f)));
    }

    void TestFunction()
    {
        Debug.Log("this is weird, henloooooooooo");
    }

    void Update()
    {

    }
}