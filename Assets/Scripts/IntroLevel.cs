using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroLevel : MonoBehaviour {

	public void StraightLevelClick()
    {
        SceneManager.LoadScene("straightPathsLevel");
    }

    public void RotatedLevelClick()
    {
        SceneManager.LoadScene("rotatedPathsLevel");
    }

    public void HelpMenuClick()
    {
        SceneManager.LoadScene("helpMenu");
    }

    public void MainMenuClick()
    {
        SceneManager.LoadScene("introLevel");
    }

    public void RebindMenuClicked()
    {
        SceneManager.LoadScene("Rebind");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
