using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    private int health;
    protected string name;

    public Data(int health, string name) 
    {
        this.health = health;
        this.name = name;
    }   

}
public class Stats : MonoBehaviour
{
    Data data = new Data(50, "Bear");

    public int attack = 30;

    void Start()
    {
        Debug.Log("attack 변수의 값 : " + attack);
    }
}
