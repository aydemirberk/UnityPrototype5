using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] GameManager gameManager;
    int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    public void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + "was clicked.");
        gameManager.StartGame(difficulty);
    }

}
