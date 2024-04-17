using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ConstructingManager : MonoBehaviour
{


    public CardFielding MyCardFielder;

    // Start is called before the first frame update
    void Start()
    {
        MyCardFielder.FieldEvent += Build;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Build(object sender, EventArgs e)
    {
        Instantiate(MyCardFielder.cardInfo.CardObject,  MyCardFielder.FieldPosition , Quaternion.identity);
    }

}
