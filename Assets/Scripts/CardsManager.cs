using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class CardsManager : MonoBehaviour
{
// public Animation[] anim;
public GameObject[] cardsBack;
public GameObject[] cards;

public LoadImage lI;
private Tween tween;




      IEnumerator Start()
    {
      for(int i = 0; i < cards.Length; i++){
        tween = cards[i].transform.DORotate(new Vector3(0,-90,0), 0.9f);
         lI.StartLoading(); 
         } 
        yield return new WaitForSeconds(1f);
        for(int i = 0; i < cards.Length; i++){
        cardsBack[i].SetActive(true);
        lI.img[i].enabled = true;
        }
    }

void Update(){
    if(Input.GetMouseButtonDown(0)){
       
      
       StartCoroutine(CardsPositionBack());
    }
  }
       
    IEnumerator CardsPositionBack(){
    
      tween = cardsBack[0].transform.DORotate(new Vector3(0,90,0), 0.9f); 
      tween = lI.img[0].transform.DORotate(new Vector3(0,90,0), 0.9f); 
      yield return new WaitForSeconds(1f);
       tween = cards[0].transform.DORotate(new Vector3(0,0,0), 0.1f); 
    
  }   

       
      
}









