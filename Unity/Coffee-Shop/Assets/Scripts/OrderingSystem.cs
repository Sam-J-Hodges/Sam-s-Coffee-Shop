using UnityEngine;

public class OrderingSystem : MonoBehaviour
{
    // Camel backing, capitalising the first letter of every word in the variable name 
    private float _costofcoffee = 4f;
    // this variable stores the cost of the coffee as a float
    // the variable name has an underscore infront of it, identifying it as a private variable
    public int coffeeAmountOrdered;
    // this variable is an interger for the amiunt of coffee ordered
    public float totalOrderCost;
    // this float will be used to calculate the total cost of the order
    public void AmountPlaced(int coffeeAmountOrdered)
    {
        totalOrderCost = coffeeAmountOrdered * _costofcoffee;
        Debug.Log("Total order cost: £" + totalOrderCost);
    }
    // void shows the start of the sub-routine "AmountPlaced" calculating the final cost of the order.
}