using UnityEngine;

public class nextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject NextLevelUI;
    public void NextLevel(){
        NextLevelUI.SetActive(false);
    }
}
