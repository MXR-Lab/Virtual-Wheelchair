using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoBaseline()
    {
        SceneManager.LoadScene("Baseline");
    }
    public void GotoTritanopia()
    {
        SceneManager.LoadScene("Tritanopia");
    }
    public void GotoCataract()
    {
        SceneManager.LoadScene("Cataract 1");
    }
    public void GotoAchromatopsia()
    {
        SceneManager.LoadScene("Achromatopsia");
    }
    public void GotoAC()
    {
        SceneManager.LoadScene("AC+C");
    }
    public void GotoMenuScene()
    {
        SceneManager.LoadScene("menu");
    }
}
