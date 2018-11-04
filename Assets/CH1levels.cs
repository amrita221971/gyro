using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CH1levels : MonoBehaviour {
    public void back()
    { SceneManager.LoadScene("chapters"); }
    public void L1()
    { SceneManager.LoadScene("jlevel1"); }
    public void L2()
    { SceneManager.LoadScene("NL1"); }
}
