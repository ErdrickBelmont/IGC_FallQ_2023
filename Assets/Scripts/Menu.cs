using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject[] innerMenus;

    private void Awake()
    {
        foreach (GameObject menu in innerMenus) {
            menu.SetActive(false);
        }
    }

    public void PlayGame()
    {
        StartCoroutine(IntroCutscene());
        //SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void ResumeGame()
    {
        GameManager.Instance.ResumeGame();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }

    private IEnumerator IntroCutscene(){
        if(CinematicBarsController.Instance != null){
             CinematicBarsController.Instance.ShowBars();
            }
        
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("SampleScene");
        //cinematicBarsAnimator.SetTrigger("SceneStart");
        //CinematicBarsController.Instance.OpenScene();


        

    }
}
