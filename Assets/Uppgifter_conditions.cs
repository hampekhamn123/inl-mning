using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgifter_conditions : MonoBehaviour
{
    #region game 1
    public int userValue = 10;

    private int userPoints = 10;
    #endregion

    #region game 3
    private int dragonHealth;

    private int playerHealth = 100;

    private int dragonHitChance;

    private int playerDamage;

    private int dragonDamage;

    private int doubleHPDragonSpawnChance;

    private int playerMinDamage;

    private int playerMaxDamage;

    private int critChance;
    #endregion

    #region game 5
    private int startNumber = 50;

    private int newNumber;

    private int currentScore;

    private int highscore;


    #endregion

    void Start()
    {
        #region game 1
        print("press the arrows to change the value of uservalue! press the upparrow the see your current value");
        #endregion

        #region game 3
        playerMaxDamage = (Random.Range(10, 36));
        playerMinDamage = (Random.Range(0, 11));
        dragonHealth = Random.Range(100, 151);
        doubleHPDragonSpawnChance = (Random.Range(1, 11));

        if (doubleHPDragonSpawnChance == 1)
        {
            dragonHealth = (dragonHealth * 2);
            print(string.Format(
                "Unlucky the dragon spawned with double HP this turn!"));
        }

        print(string.Format(
            "Dragon health this round = {0}", dragonHealth));
        #endregion

        #region game 5
        print(
            "startvärdet är 50, tror du att nästa värde kommer vara mindre tryck H," +
            " tror du att det kommer vara större tryck Y");

        #endregion
    }

    void Update()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3_4();
        Uppgift5();
    }

    void Uppgift1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue = (userValue + 2);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue = (userValue / 2);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }
    }

    void Uppgift2()
    {
        if (userPoints > 0 && userPoints < 20)
        {

            if (Input.GetKeyDown(KeyCode.R))
            {
                userPoints = (userPoints + (Random.Range(1, 7)));
                userPoints = (userPoints - (Random.Range(1, 7)));
                print(string.Format(
                    "Du har nu {0} poäng", userPoints));


                if (userPoints >= 20)
                {
                    print("Grattis du vann! tryck på T för att spela igen!");
                }

                else if (userPoints <= 0)
                {
                    print("Du Förlorade! tryck på T för att spela igen!");
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            userPoints = 10;
            print("Du har nu 10 poäng");
        }

    }

    void Uppgift3_4()
    {
        if (dragonHealth > 0 && playerHealth > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerDamage = (Random.Range(playerMinDamage, playerMaxDamage));
                critChance = (Random.Range(1, 21));

                if (critChance == 1)
                {
                    dragonHealth = (dragonHealth - dragonHealth);
                    print("You got super lucky got a critical strike for all the dragons HP");
                }

                else
                {
                    print(string.Format(
                        "player hits the dragon for {0} damage", playerDamage));
                    dragonHealth = (dragonHealth - playerDamage);
                }
                dragonHitChance = Random.Range(1, 3);

                if (dragonHitChance == 1)
                {
                    dragonDamage = (Random.Range(10, 21));
                    playerHealth = (playerHealth - dragonDamage);
                    print(string.Format(
                        "The dragon spits fire on the player for {0} damage", dragonDamage));
                }

                else
                {
                    print("The dragon misses its fireball");
                }

                print(string.Format(
                    "The player now have {0} HP left and the dragon have {1} HP", playerHealth, dragonHealth));

                if (playerHealth <= 0)
                {
                    print("The player is dead, the dragon have won the battle! press P to play again!");
                }

                if (dragonHealth <= 0)
                {
                    print("The dragon is dead, The player have won the battle! press P to play again!");
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            dragonHealth = Random.Range(100, 151);
            doubleHPDragonSpawnChance = (Random.Range(1, 11));

            if (doubleHPDragonSpawnChance == 1)
            {
                dragonHealth = (dragonHealth * 2);
                print(string.Format(
                    "Unlucky the dragon spawned with double HP this turn!"));
            }

            playerMaxDamage = (Random.Range(10, 36));
            playerMinDamage = (Random.Range(0, 11));
            print(string.Format(
                "Dragon health this round = {0}", dragonHealth));

        }
    }

    void Uppgift5()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log(startNumber);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            newNumber = Random.Range(1, 101);

            if (newNumber > startNumber)
            {
                currentScore = (currentScore + 1);
                print(string.Format(
                    "Du hade rätt det ny nummret är {0}, gissa igen!", newNumber));
                startNumber = newNumber;
            }

            else
            {
                print(string.Format(
                    "Du hade fel och ditt poäng blev {0}, värdet börjar om på 50, gissa igen", currentScore));
                print(string.Format(
                    "nuvarande highscore är {0}", highscore));
                startNumber = 50;

                if (currentScore > highscore)
                {
                    highscore = currentScore;
                    print(string.Format(
                        "Grattis ditt nya highscore är {0}", highscore));
                }
                currentScore = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            newNumber = Random.Range(1, 101);

            if (newNumber < startNumber)
            {
                currentScore = (currentScore + 1);
                print(string.Format(
                    "Du hade rätt det ny nummret är {0}, gissa igen!", newNumber));
                startNumber = newNumber;
            }

            else
            {
                print(string.Format(
                    "Du hade fel och ditt poäng blev {0}, värdet börjar om på 50, gissa igen", currentScore));
                print(string.Format(
                    "nuvarande highscore är {0}", highscore));
                startNumber = 50;
                if (currentScore > highscore)
                {
                    highscore = currentScore;
                    print(string.Format(
                        "Grattis ditt nya highscore är {0},", highscore));
                }

                currentScore = 0;
            }
        }
    }
}
