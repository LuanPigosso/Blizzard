using UnityEngine;
using System.Collections;
public class EscolhaDoPlayer : MonoBehaviour {
   public Texture[] Personagem;
   public Texture[] Names;
   private int SelecaoAtual;
   public GameObject cam;
   public Texture SelectCharacter;
   public float x;
   public float y;
   void Start (){
      SelecaoAtual = 0;

   }
  
   void OnGUI (){
      if(cam.transform.position.y >=20){
         GUI.enabled = true;
         GUI.DrawTexture(new Rect(30,290,220,110), SelectCharacter);
         //SELECAO DO PERSONAGEM
         if (GUI.Button (new Rect (30,290,220,110), "")) {
            DATA.PersonagemAInstanciar = SelecaoAtual;
           // Application.LoadLevel("Mapa_Jogo"); // MUDAR O NOME DA CENA CONFORME O SEU JOGO
             
         }

         //IFS
         if (SelecaoAtual == 0) {
            GUI.DrawTexture(new Rect(333,20,400,400),Personagem[SelecaoAtual]);                                            
            //mudar selecao
            GUI.DrawTexture(new Rect(44,24,206,69), Names[0]);
            if(GUI.Button (new Rect(680,170,60,130),"")){
               SelecaoAtual = SelecaoAtual +1;
            }
         }
         //
         if (SelecaoAtual > 0 && SelecaoAtual < (Personagem.Length - 1)) {
            GUI.DrawTexture(new Rect(333,20,400,400),Personagem[SelecaoAtual]);                 
            //mudar selecao tamanho que vai aparecer o quadro da seleção
            if(GUI.Button (new Rect(680,170,60,130),"")){
               SelecaoAtual = SelecaoAtual +1;
            }
            //mudar selecao tamanho que vai aparecer o quadro da seleção
            if(GUI.Button (new Rect(270,170,60,130),"")){
               SelecaoAtual = SelecaoAtual -1;
            }
         }
         //
         if (SelecaoAtual >= (Personagem.Length - 1)) {
            //mudar selecao tamanho que vai aparecer o quadro da seleção
            GUI.DrawTexture(new Rect(333,20,400,400),Personagem[SelecaoAtual]);
            //mudar selecao
            GUI.DrawTexture(new Rect(44,24,206,69), Names[1]);
            if(GUI.Button (new Rect(270,170,60,130),"")){
               SelecaoAtual = SelecaoAtual -1;
            }
         }
      }else{
          GUI.enabled = false;
      }
   }
}