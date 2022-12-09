using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using DG.Tweening;

public class LoadImage : MonoBehaviour
{
   [SerializeField] private string url;

    public Image[] img;
    public bool isLoaded = false;
    

    public void StartLoading()
    {
         StartCoroutine(GetImage());
       
    }

  
    IEnumerator GetImage()
    {
        
        for(int i = 0; i <  img.Length; i++){
        UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture(url);
        
        yield return webRequest.SendWebRequest();

        if(webRequest.isDone == false){
            Debug.Log(webRequest.error);
        }
        else{
            Texture texture = ((DownloadHandlerTexture)webRequest.downloadHandler).texture;
           
            img[i].sprite = Sprite.Create((Texture2D)texture, new Rect (0,0,texture.width, texture.height), Vector2. zero);
            
           
           
           // yield return new WaitForSeconds(0.03f);
             // lI.img[i].enabled = true; перенести в CardsManager
            }
        }
        
    }

}


