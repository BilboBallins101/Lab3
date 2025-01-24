using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    [SerializeField] private double price; //price the customer pays
    [SerializeField] private double numCopies; //number of copies the customer bought
    [SerializeField] private double profit; //what the bookstore makes before costs
    [SerializeField] private double costs; // what the bookstore pays to process the order

    void Start()
    {

        profit = price * numCopies; //profit would simply be price times how many copies were sold
        Debug.Log("The profit before costs is " + profit);

        costs = ((price*.6)*numCopies) + 3 + (.75*(numCopies-1)); //multiplying the price by .6 gets us what the bookstore pays for the book at 40% off.
        Debug.Log("Costs the bookstore pays to process the purchase is " + costs);
        
    }
}
