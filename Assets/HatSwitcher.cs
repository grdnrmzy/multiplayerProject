using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatSwitcher : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] _hats;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _hats.Length; i++)
        {
            _hats[i].SetActive(false);
        }

        _hats[0].SetActive(true);
    }

}
