using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class ScoreManager : MonoBehaviour
{
    
    public TMP_InputField nameInputField;
    public TextMeshProUGUI scoreText;

    private string filePath;
    private string playerName;
    private int playerScore;

    private void Start()
    {
        // Establecer la ruta del archivo de puntuaciones.
        filePath = "C:/Users/anarb/OneDrive/Escritorio/Scores/Score.txt";
    }

    public void UpdatePlayerName(string newName)
    {
        playerName = newName;
    }

    public void UpdatePlayerScore(int newScore)
    {
        playerScore = newScore;
    }

    public void SaveScore()
    {
        // Crear una cadena con el nombre del jugador y su puntuación.
        string scoreEntry = playerName + ": " + playerScore.ToString();

        // Escribir la cadena en el archivo de puntuaciones.
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(scoreEntry);
        }

        // Limpiar el campo de entrada y la puntuación después de guardar.
        nameInputField.text = "";
        playerScore = 0;
        scoreText.text = "Score: " + playerScore.ToString();
    }
}
