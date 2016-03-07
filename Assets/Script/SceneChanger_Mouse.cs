using UnityEngine;
using System.Collections;

public class SceneChanger_Mouse : MonoBehaviour
{

    public string nextScene = "game_mouse";

    public void ChangeScene()
    {
        Application.LoadLevel(nextScene);
    }
}
