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

public Image[] images;
private Tween tween;

public LoadImage[] lI;


      IEnumerator Start()
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

void Update(){
    if(Input.GetMouseButtonDown(0)){
       
      
       StartCoroutine(CardsPositionBack());
    }
  }
       
    IEnumerator CardsPositionBack(){
     for(int i = 0; i < 4; i++){
      tween = cardsBack[i].transform.DORotate(new Vector3(0,90,0), 0.9f); 
      tween = images[i].transform.DORotate(new Vector3(0,90,0), 0.9f); 
     }
      yield return new WaitForSeconds(1f);
      for(int i = 0; i < 4; i++){
       tween = cards[i].transform.DORotate(new Vector3(0,0,0), 0.1f); 
      }
  }         
}

/*
-- Поочередный режим
public GameObject[] cardsBack;
public GameObject[] cards;

public Image[] images;
private Tween tween;

public LoadImage[] lI;


      IEnumerator Start()
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




-- Дотвин. Повороты одновременно //доработанная загрузка

public GameObject[] cardsBack;
public GameObject[] cards;

public Image[] images;
private Tween tween;

public LoadImage[] lI;


      IEnumerator Start()
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

void Update(){
    if(Input.GetMouseButtonDown(0)){
       
      
       StartCoroutine(CardsPositionBack());
    }
  }
       
    IEnumerator CardsPositionBack(){ // поворот в изначальную позицию
     for(int i = 0; i < 4; i++){
      tween = cardsBack[i].transform.DORotate(new Vector3(0,90,0), 0.9f); 
      tween = images[i].transform.DORotate(new Vector3(0,90,0), 0.9f); 
     }
      yield return new WaitForSeconds(1f);
      for(int i = 0; i < 4; i++){
       tween = cards[i].transform.DORotate(new Vector3(0,0,0), 0.1f); 
      }
  } 



-- Дотвин. Повороты одновременно //доработать загрузку
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
     for(int i = 0; i < 4; i++){
      tween = cardsBack[i].transform.DORotate(new Vector3(0,90,0), 0.9f); 
      tween = lI.img[i].transform.DORotate(new Vector3(0,90,0), 0.9f); 
     }
      yield return new WaitForSeconds(1f);
      for(int i = 0; i < 4; i++){
       tween = cards[i].transform.DORotate(new Vector3(0,0,0), 0.1f); 
      }
  }  


*/









