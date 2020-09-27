﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    public int score;
    public int highScore;

    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(){
        score++;

        updateHighScore();
    }

    public void updateHighScore(){
        if (score > highScore){
            highScore = score;
        }
    }

    public void ResetScore(){
        score =0;
    }
}
