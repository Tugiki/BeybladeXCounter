
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void OpenTournamentSelect()
    {
        SceneManager.LoadScene("TournamentSelect");
    }

    public void OpenNormalTournamentSetup()
    {
        SceneManager.LoadScene("NormalTournamentSetup");
    }

    public void OpenBeybladeTournamentSetup()
    {
        SceneManager.LoadScene("BeybladeTournamentSetup");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
