using UnityEngine;
using UnityEngine.SceneManagement;
public class chapters : MonoBehaviour
{
    public void back()
    { SceneManager.LoadScene("mainMenu"); }


    public void CH1()
    { SceneManager.LoadScene("CH1levels"); }

   // public void CH2()
    //{ SceneManager.LoadScene("CH2levels"); }
}
