using UnityEngine;
using UnityEngine.SceneManagement; 

public class RestartScene : MonoBehaviour
{
    public void RestartGame(){
        SceneManager.LoadScene("level1a");
    }
}