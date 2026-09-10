using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
    public int coffeesSold = 5;
    public float coffeePrice = 3.5f;

    void Start()
    {
        Debug.Log("Coffees sold: " + coffeesSold);  
    }
    void AddCoffee()
    {
        coffeesSold =+ 1; 
    }

    void Tart()
    {
        Debug.Log("Hello World");
        Debug.Log("I have ordered" + coffeesSold + " coffees");
        coffeesSold++;
        Debug.Log("Oops I accidentaly" + coffeesSold + " coffees");

        coffeesSold = coffeesSold * 5;
        Debug.Log(coffeesSold);
    }
}
