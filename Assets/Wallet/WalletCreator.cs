using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UMod;
using UMod.Scripting;



public class WalletCreator : MonoBehaviour {
    string _path, receivedData;
    public Text jsonConfirmationText;
    public GameObject[] walletNaming;
    public ScriptProxy proxy;
    void Start () {
		
	}



    public void FindJSON()
    {
        receivedData = proxy.Call("FindFile").ToString();
        //JSONValidation(jsonText);

    }


    void JSONValidation(string jsonText)
    {
       
        if (jsonText.Contains("address"))
        {
            jsonConfirmationText.text = "Valid Keystore File Loaded";
        }
        else
        {
            jsonConfirmationText.text = "Not a Valid Keystore File";

        }
    }

 
    public void AddWallet()
    {
        StartCoroutine(AcceptJSON());
    }
    public IEnumerator AcceptJSON()
    {
        Debug.Log(receivedData);
        Dictionary<string, string> values = JsonUtility.FromJson<Dictionary<string, string>>(receivedData);
        yield return  new WaitForSeconds(1);



        yield return null;
    }
}
