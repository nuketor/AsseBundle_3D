using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class loadAsset : MonoBehaviour {

/*	// Use this for initialization
	string url = "http://filmbuzzer.com/AssetBundles/wheel";
	WWW www = new WWW(url);
	StartCoroutine(WaitForReq(www));
/
IEnumerator Start () {
	while (!Caching.ready)
		yield return null;
	// Start a download of the given URL
	WWW www = WWW.LoadFromCacheOrDownload (url, 1);

	// Wait for download to complete
	yield return www;

	// Load and retrieve the AssetBundle
	AssetBundle bundle = www.assetBundle;

	// Load the object asynchronously
	AssetBundleRequest request = bundle.LoadAssetAsync ("myObject", typeof(GameObject));

	// Wait for completion
	yield return request;

	// Get the reference to the loaded object
	GameObject obj = request.asset as GameObject;

	// Unload the AssetBundles compressed contents to conserve memory
	bundle.Unload(false);

	// Frees the memory from the web stream
	www.Dispose();
}
	*/
	//IEnumerator WaitForReq(WWW www)
IEnumerator Start ()
{
		string url = "http://127.0.0.1:81/AssetBundles/zombunny";
	WWW www = new WWW(url);

	yield return www;
	AssetBundle bundle = www.assetBundle;
	if(www.error == null){
		GameObject wheel = (GameObject)bundle.LoadAsset("zombunny");
		Instantiate(wheel); // **Change its position and rotation 
	}
	else{
		Debug.Log(www.error);
	}
}

}