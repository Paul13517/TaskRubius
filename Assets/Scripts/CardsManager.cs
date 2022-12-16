using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class CardsManager : MonoBehaviour
{

public GameObject[] cardsBack;

public GameObject[] cards;

public Image[] images;
private Tween tween;

public LoadImage[] lI;



public void WaitingAllAtOnce ()
    {
      CardsPositionBackFunction();
      Invoke("AllAtOnceStart",2f);   
    }

public void WaitingOneByOne ()
    {
      CardsPositionBackFunction();
      Invoke("OneByOneStart",2f);   
    }

public void AllAtOnceStart(){
  StartCoroutine(AllAtOnce());
}

public void OneByOneStart(){
  StartCoroutine(OneByOne());
}


public void CardsPositionBackFunction(){
  StartCoroutine(CardsPositionBack());
}





      IEnumerator AllAtOnce()
    {
      for(int i = 0; i < 4; i++){
        tween = cards[i].transform.DORotate(new Vector3(0,-90,0), 0.9f);
           lI[i].StartLoading();
         } 
         
        yield return new WaitForSeconds(1f);
        for(int i = 0; i < cards.Length; i++){
        cardsBack[i].SetActive(true);
        images[i].enabled = true;
        }
    }


      IEnumerator OneByOne()
    {
      for(int i = 0; i < 4; i++){     
        tween = cards[i].transform.DORotate(new Vector3(0,-90,0), 0.9f);
        lI[i].StartLoading();
        yield return new WaitForSeconds(0.1f);
         } 
         
        
        for(int i = 0; i < cards.Length; i++){
          yield return new WaitForSeconds(0.1f);
        cardsBack[i].SetActive(true);
        images[i].enabled = true;
        }
    }

       
    IEnumerator CardsPositionBack(){
     for(int i = 0; i < 4; i++){
      tween = cardsBack[i].transform.DORotate(new Vector3(0,90,0), 0.7f); 
      tween = images[i].transform.DORotate(new Vector3(0,90,0), 0.7f); 
     }
      yield return new WaitForSeconds(1f);
      for(int i = 0; i < 4; i++){
       tween = cardsBack[i].transform.DORotate(new Vector3(0,0,0), 0.1f); 
       tween = images[i].transform.DORotate(new Vector3(0,0,0), 0.1f);  
       tween = cards[i].transform.DORotate(new Vector3(0,0,0), 0.1f); 
       cardsBack[i].SetActive(false);
       images[i].enabled = false;
      }
  }         
}











