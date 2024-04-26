using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    [SerializeField] private Sprite bgImage;

    public Sprite[] puzzles;

    public List<Sprite> gamePuzzles = new List<Sprite>();

    public List<Button> btns = new List<Button>();

    private bool firstGuess, secondGuess;
    private int countGuesses;
    private int countCorrect;
    private int gameGuesses;

    private int firstGuessIndex, secondGuessIndex;

    private string firstGuessName, secondGuessName;
    private char firstGuessChar, secondGuessChar; 
     
    void Start()
    {
        GetButtons();
        AddListeners();
        AddGamePuzzles();
        gameGuesses = 8;
    }
    
    void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag ("PuzzleButton");

        for (int i=0; i < objects.Length; i++)
        {
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = bgImage;
        }
    }
    void AddGamePuzzles()
    {
        int looper = btns.Count;
        for (int i = 0; i < looper; i++)
        {
            gamePuzzles.Add(puzzles[i]);

        }
    }
    void AddListeners()
    {
        foreach(Button btn in btns)
        {
            btn.onClick.AddListener(() => PickAPuzzle());

        }
    }
    public void PickAPuzzle()
    {
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        if (!firstGuess)
        {
            firstGuess = true;
            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            firstGuessName = gamePuzzles[firstGuessIndex].name;
            firstGuessChar = firstGuessName[0];
            btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];

        }
        else if (!secondGuess)
        {
            secondGuess = true;
            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            secondGuessName = gamePuzzles[secondGuessIndex].name;
            secondGuessChar = secondGuessName[0];
            btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];

            StartCoroutine(CheckMatch());
        }
    }
    IEnumerator CheckMatch()
    {
        yield return new WaitForSeconds (1f) ;

        if (firstGuessChar == secondGuessChar)
        {
            btns[firstGuessIndex].interactable = false;
            btns[secondGuessIndex].interactable = false;

            btns[firstGuessIndex].image.color =new Color (0,0,0,0);
            btns[secondGuessIndex].image.color = new Color(0, 0, 0, 0);

            CheckIfTheGameIsFinished();
        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            btns[firstGuessIndex].image.sprite = bgImage;
            btns[secondGuessIndex].image.sprite = bgImage;
        }
        yield return new WaitForSeconds(0.5f);

        firstGuess = secondGuess = false;
    }
    void CheckIfTheGameIsFinished()
    {
        countCorrect++;

        if (countCorrect == gameGuesses)
        {
            Debug.Log("Game Finished");
        }
    }

}
