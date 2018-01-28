using UnityEngine;
using UnityEngine.UI;

public class GameFinish : MonoBehaviour {

    public Text m_textWin;
    public string m_textToDisplay = "You Win!";

    public GameObject m_menuYouWin;


    private void Awake()
    {
        m_textWin.text = "";
        m_pipes = FindObjectsOfType<Solutions>();
    }

    private void Update () {
        IsAllSolved();
	}


    private void IsAllSolved()
    {
        int countSolved = 0;

        foreach(Solutions pipe in m_pipes)
        {
            if (pipe.m_solved)
                countSolved++;
        }
        
        if (countSolved == m_pipes.Length)
            GameIsFinished();
    }

    private void GameIsFinished()
    {
        m_textWin.text = m_textToDisplay;
        m_menuYouWin.SetActive(true);
    }


    private Solutions[] m_pipes;
}
