using System;
using UnityEngine;

public class ConvertTemperature : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Run temperature conversions using integer data types
        IntConversions(0);

        // Run temperature conversions using float data types
        FloatConversions(0);

        // Run temperature conversion using double data dypes
        DoubleConversions(0);
    }

    void IntConversions(int temp)
    {
        int originalTemp = temp;
        int calculatedCelcius;
        int calculatedFahrenheit;

        // Print original temperature in Fahrenheit
        Debug.Log("Original Fahrenheit Temperature: " + originalTemp);

        // Print calculated Celcius temperature
        calculatedCelcius = (originalTemp - 32) * 5 / 9;
        Debug.Log("Calculated Celcius Temperature: " + calculatedCelcius);

        // Print calculated Fahrenheit temperature
        calculatedFahrenheit = calculatedCelcius * 9 / 5 + 32;
        Debug.Log("Calculated Fahrenheit Temperature: " + calculatedFahrenheit);
    }
    void FloatConversions(float temp)
    {
        float originalTemp = temp;
        float calculatedCelcius;
        float calculatedFahrenheit;

        // Print original temperature in Fahrenheit
        Debug.Log("Original Fahrenheit Temperature: " + originalTemp);

        // Print calculated Celcius temperature
        calculatedCelcius = (originalTemp - 32) * 5 / 9;
        Debug.Log("Calculated Celcius Temperature: " + calculatedCelcius);

        // Print calculated Fahrenheit temperature
        calculatedFahrenheit = calculatedCelcius * 9 / 5 + 32;
        Debug.Log("Calculated Fahrenheit Temperature: " + calculatedFahrenheit);
    }

    void DoubleConversions(double temp)
    {
        double originalTemp = temp;
        double calculatedCelcius;
        double calculatedFahrenheit;

        // Print original temperature in Fahrenheit
        Debug.Log("Original Fahrenheit Temperature: " + originalTemp);

        // Print calculated Celcius temperature
        calculatedCelcius = (originalTemp - 32) * 5 / 9;
        Debug.Log("Calculated Celcius Temperature: " + calculatedCelcius);

        // Print calculated Fahrenheit temperature
        calculatedFahrenheit = calculatedCelcius * 9 / 5 + 32;
        Debug.Log("Calculated Fahrenheit Temperature: " + calculatedFahrenheit);
    }

}
