using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshAtomInformation : MonoBehaviour
{
    public static int choice1;
    public static int choice2;
    public static int choice3;
    public static int choice4;
    public Transform OneMetalTwoAlkali;
    public Transform TwoAlkaliFourAlkali;
    public Transform CO2H2O;
    public Transform DoubleFourAlkali;
    public Transform AtomInformation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (choice1 == 1 && choice2 == -2)
        {
            Instantiate(OneMetalTwoAlkali, AtomInformation.position, AtomInformation.rotation);
            choice1 = 50;
            choice2 = 50;
        }
        if (choice1 == -4 && choice2 == -2)
        {
            Instantiate(TwoAlkaliFourAlkali, AtomInformation.position, AtomInformation.rotation);
            choice1 = 50;
            choice2 = 50;
        }
        if (choice1 == 10 && choice2 == 20)
        {
            Instantiate(CO2H2O, AtomInformation.position, AtomInformation.rotation);
            choice1 = 50;
            choice2 = 50;
        }
        if (choice1 == -4 && choice2 == -4)
        {
            Instantiate(DoubleFourAlkali, AtomInformation.position, AtomInformation.rotation);
            choice1 = 50;
            choice2 = 50;
            choice3 = -4;
            choice4 = -4;
        }
    }
}
