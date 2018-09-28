using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift : MonoBehaviour
{
    #region Sentences
    public string sentence1 = "jadå";
    public string sentence2 = "sådär";
    public string sentence3 = "hej";
    #endregion

    #region TriangleValue
    public int a = 3;
    public int basen = 2;
    #endregion

    #region CakeSliceValues
    public int angle = 180;
    public int Pieces = 4;
    #endregion

    #region Name
    public string _name = "Hampus";
    #endregion

    #region Sphere
    public int radius = 5;
    #endregion

    #region Demonvalue
    public int demonHealth = 890000;
    public int demonAmount = 1;
    #endregion

    #region DamageValues
    public float maxDamage = 100000;
    public float minDamage = 50000;
    #endregion

    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift6();
        Uppgift7();
        Uppgift8();
    }

    void Uppgift1()
    {
        Debug.Log(
            "uppgift 1:" + " " + ((963 * 421) - (175463 / 87f)));
    }

    void Uppgift2()
    {
        Debug.Log(
            string.Format(
                "uppgift 2: (sentence 1 = {0}) (sentence 2 = {1}) (sentence 3 = {2})",
            sentence1, sentence2, sentence3));
    }

    void Uppgift3()
    {
        Debug.Log(
            "uppgift 3a: användarens värde (a) i kvadrat" + "=" +
            (Mathf.Pow(a, 2)));

        Debug.Log(
            "uppgift 3b: roten ur användarens värde (a)" + "=" +
            (Mathf.Sqrt(a)));
    }

    void Uppgift4()
    {
        Debug.Log(
            "uppgift 4: En triangels area i m^2 om höjden är 8m och värdet av användarens bas (basen)" + "=" +
            (Mathf.Sqrt((basen * 8) / 2f)));
    }

    void Uppgift5()
    {
        Debug.Log(
            "uppgift 5: Bestäm vinkeln på bitarna i en tårta genom att ändra värdet på angle," + " " + "nuvarande antal bitar=" + 360 / angle);

        Debug.Log(
            "uppgift 5a: Bestäm antal bitar genom att ändra värdet pieces, nuvarande vinkel på bitarna=" + " " + (360 / Pieces));
    }

    void Uppgift6()
    {
        Debug.Log(
            "uppgift 6: Bless you, god" + " " + _name + " " + "our lord and savior");
    }

    void Uppgift7()
    {
        Debug.Log(
            "uppgift 7: Ange radien (radius) för att få ut volymen på ett klot, nuvarande volym=" + (4 * 3.14 * (Mathf.Pow(radius, 3)) / 3));
    }

    void Uppgift8()
    {
        Debug.Log(
            "uppgift 8a och 8b: Hur många slag det krävs för att döda antalet demoner (demonAmount) om skadan är det angivna skadan (damage), antal slag=" + " " + demonHealth * demonAmount / maxDamage);

        Debug.Log(
            "uppgift 8c: Hur många slag det krävs om du har en maximum damage (maxDamage) och en minimum damage (minDamage), antal slag=" + " " + demonHealth * demonAmount / Random.Range(maxDamage, minDamage));

        Debug.Log(
            "uppgift 8c fortsättning: snittvärdet för antal slag=" + " " + demonAmount * demonHealth / (maxDamage + minDamage / 2));
    }

    void Update()
    {

    }
}
