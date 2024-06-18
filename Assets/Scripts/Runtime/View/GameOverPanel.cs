using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    public void Activate()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);
    }
}
