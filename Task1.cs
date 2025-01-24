using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{

    public int modules; //variables for the amount of work in a class
    public int quizzes;
    public int reading;
    public int assignments;
    public int timesTaught;

    private float modulesScore; //variables for determining percentages of difficulty
    private float quizzesScore;
    private float readingScore;
    private float assignmentsScore;
    private float timesTaughtScore;

    public string className; //string for putting name of the course
    
    [SerializeField] private float classDifficulty; //class difficulty score variable


    void Start()
    {
       if (modules > 5) //sets maximum value on variables
            modules = 5;
       if (quizzes > 6)
            quizzes = 6;
       if (reading > 5)
            reading = 5;
       if(assignments > 6)
            assignments = 6;
       if (timesTaught > 5)
            timesTaught = 5;
        
        modulesScore = modules * 3; //calculates percentages
        quizzesScore = quizzes * 5;
        readingScore = reading * 3;
        assignmentsScore = assignments * 5;
        timesTaughtScore = timesTaught * 2;

        classDifficulty = (modulesScore + quizzesScore + readingScore + assignmentsScore + timesTaughtScore)/10; //determines class difficulty score

        Debug.Log(className + " Class Difficulty = " +  classDifficulty); //displays class name and difficulty score in console
    }
}
