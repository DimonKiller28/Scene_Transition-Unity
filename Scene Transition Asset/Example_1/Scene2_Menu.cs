using UnityEngine;

public class Scene2_Menu : MonoBehaviour
{
    public string nameScene = "Scene1";

    public void ButtonClick()
    {
        SceneTransition.SceneTransition.SwitchToScene(nameScene);
    }
}
