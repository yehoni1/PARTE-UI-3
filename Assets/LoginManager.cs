using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public string Contra = "boca";
    public InputField IngresaContra;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Contraseña()
    {
        if(IngresaContra.text == Contra)
        {
            Debug.Log("acceso garantizado");
        }
        else
        {
            Debug.Log("acceso denegado");
        }
    }
}
