using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    string HeroName = "Abdullah;
    int HeroPower = 20;
    string villainName = "Unity";
    int villainPower = 25;
    float playerSpeed = 4.4f;
    float playerSpeed2 = 0f;


    void setSpeed(float newSpeed)
    {
    playerSpeed = newSpeed;
    }

// Start is called before the first frame update
void Start()
{
    if (HeroPower > villainPower)
    {
        print(HeroPower);
    }
    else if (HeroPower == villainPower)
    {
        print(HeroPower + "=" + villainPower);
    }
    else
    {
        print(villainPower);
    }

    print("old playerSpeed " + playerSpeed);
    setSpeed(2.5f);
    print("new playerSpeed " + playerSpeed);
    CompareSpeed();
}
void CompareSpeed()
{
    if (playerSpeed > playerSpeed2)
    {
        print(playerSpeed);
    }
    else if (playerSpeed == playerSpeed2)
    {
        print(playerSpeed);
        print(playerSpeed2);
    }
    else
    {
        print(playerSpeed2);
    }

}
}
        


    
