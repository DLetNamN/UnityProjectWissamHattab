using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgifter : MonoBehaviour
{

    public string firstSentence = "Write here before running the program3";

    public string secondSentence = "Write here before running the program3";

    public string thirdSentence = "Write here before running the program3";

    public float mathfunctionfloat;

    public float BaseOfTriangle;

    public string Prefix;

    public string Name;

    public string Suffix;

    public float Radius;

    public float Damage;

    public int Demons;

    public int DemonHealth = 890000;

    public float minDamage;

    public float maxDamage;

    private int Count = 1;

    public int countMulti;

    private int playerMaxLife = 100;

    public float playerResist = 0.0f;

    private int enemyDamage = 100;

    void Start()
    {
        Name1();
        MathFunction1();
        MathFunction2();
        sentence1();
        sentence2();
        sentence3();
        SphereFunction();
        DamageFunction();
        enemyEncounter();
    }

    //Uppgift 2
    void sentence1()
    {
        Debug.Log(string.Format("{0}", (firstSentence)));
    }

    void sentence2()
    {
        Debug.Log(string.Format("{0}", (secondSentence)));
    }

    void sentence3()
    {
        Debug.Log(string.Format("{0}", (thirdSentence)));
    }
    //End of Uppgift 2 //complete

    //Uppgift 3
    void MathFunction1()
    {
        Debug.Log(string.Format("Your number to the power of 2 = {0}. And your number's square root = {1}", Mathf.Pow(mathfunctionfloat, 2), Mathf.Sqrt(mathfunctionfloat)));
    }
    //End of Uppgift 3 //complete

    //Uppgift 4
    void MathFunction2()
    {
        Debug.Log(string.Format("The area of your triangle = {0}m²", BaseOfTriangle * 8 / 2));
    }
    //End of Uppgift 4 //complete

    //Uppgift 5

    //End of Uppgift 5

    //Uppgift 6
    void Name1()
    {
        Debug.Log(string.Format("{0} {1} {2}", Prefix, Name, Suffix));
    }
    //End of Uppgift 6 //complete

    //Uppgift 7
    void SphereFunction()
    {
        Debug.Log(string.Format("The volume of 2978 spheres with the radius of {0} = {1}", Radius, (4 * System.Math.PI * Mathf.Pow(Radius, 3) / 3) * 2978));
    }
    //End of Uppgift 7 //complete

    //Uppgift 8
    void DamageFunction()
    {
        if (minDamage > 1) Debug.Log(string.Format("You are fighting {0} Demons. Health left {1}." +
            " Maximum hits left to kill the Demon(s) {2}," +
            " and the minimun amoumt of hits are {3}," +
            " average amount of hits {4}.", Demons,
            (Demons * 890000) - minDamage,
            (Demons * 890000) / minDamage, (((Demons * 890000) + maxDamage) / 2),
            ((Demons * 890000) + minDamage) / 2));


        else if (Damage > 1) Debug.Log(string.Format("You are fighting {0} Demons. Health left {1}. Hits left to kill the Demon(s) {2}", Demons,
            (Demons * 890000) - Damage,
            (Demons * 890000) / Damage));

    }
    //End of Uppgift 7 //complete

    //Uppgift 9
    void Multi()
    {
        Debug.Log(Count = Count * 2);
    }
    //end of Uppgift 9 //complete

    //Uppgift 10
    void CountMulti()
    {
        Debug.Log(countMulti = (countMulti * 3)/2);
    }
    //end of Uppgift 10 //complete

    //Uppgift 11
    void enemyEncounter()
    {
        if (enemyDamage < 10)
            
        Debug.Log(string.Format("Health left: {0}", playerMaxLife - (enemyDamage * playerResist))); //unfinished
    }
    //end of Uppgift 11 //incomplete

    void Update()
    {
        
        Multi();
    }
}
