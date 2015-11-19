using UnityEngine;
using System.Collections;
public class EscolhaDoPlayer : MonoBehaviour {
   public Texture[] Personagem;
   private int SelecaoAtual;
   void Start (){
      SelecaoAtual = 0;
   }
   void OnGUI (){
      //SELECAO DO PERSONAGEM

      if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 4, Screen.height / 2 - Screen.height / 2.2f, Screen.width / 2, Screen.height / 1.2f), "")) {
         DATA.PersonagemAInstanciar = SelecaoAtual;
         Application.LoadLevel ("JOGO"); // MUDAR O NOME DA CENA CONFORME O SEU JOGO
      }

      //IFS
      if (SelecaoAtual == 0) {
         GUI.DrawTexture(new Rect(Screen.width/2-Screen.width/4,Screen.height/2-Screen.height/2.2f,Screen.width/2,Screen.height/1.2f),Personagem[SelecaoAtual]);                                            
         //mudar selecao
         if(GUI.Button (new Rect(Screen.width/1.3f,Screen.height/2.2f,Screen.width/6.5f,Screen.height/5),"PROXIMO")){
            SelecaoAtual = SelecaoAtual +1;
         }
      }
      //
      if (SelecaoAtual > 0 && SelecaoAtual < (Personagem.Length - 1)) {
         GUI.DrawTexture(new Rect(Screen.width/2-Screen.width/4,Screen.height/2-Screen.height/2.2f,Screen.width/2,Screen.height/1.2f),Personagem[SelecaoAtual]);                 
         //mudar selecao
         if(GUI.Button (new Rect(Screen.width/1.3f,Screen.height/2.2f,Screen.width/6.5f,Screen.height/5),"PROXIMO")){
            SelecaoAtual = SelecaoAtual +1;
         }
         if(GUI.Button (new Rect(Screen.width/13,Screen.height/2.2f,Screen.width/6.5f,Screen.height/5),"ANTERIOR")){
            SelecaoAtual = SelecaoAtual -1;
         }
      }
      //
      if (SelecaoAtual >= (Personagem.Length - 1)) {
         GUI.DrawTexture(new Rect(Screen.width/2-Screen.width/4,Screen.height/2-Screen.height/2.2f,Screen.width/2,Screen.height/1.2f),Personagem[SelecaoAtual]);
         //mudar selecao
         if(GUI.Button (new Rect(Screen.width/13,Screen.height/2.2f,Screen.width/6.5f,Screen.height/5),"ANTERIOR")){
            SelecaoAtual = SelecaoAtual -1;
         }
      }
   }
}