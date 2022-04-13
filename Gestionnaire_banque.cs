using System;
/*namespace SampleApp {
   public delegate string MyDel(string str);
	
   public class EventProgram {
      event MyDel MyEvent;
		
      public EventProgram() {
         this.MyEvent += new MyDel(this.SoldeUser);
      }
      public string SoldeUser(Utilisateur util) {
         return "Solde : " + util.Solde;
      }
   }
}*/

public class Gestionnaire_Banque
{
  public void addUtilisateur( Utilisateur util, Banque banque){
    banque.AddUtil(util);
    Console.WriteLine("Solde : "+ util.Solde);
  }

  public void addOB(string type, int somme, Utilisateur util){
    string date = DateTime.Now.ToString("dd-MM-yyyy");
    var operation = new Operation_bancaire(type);
    if (type == "retrait")
    {  
      operation.Retrait(util,somme); // fait le retrait du compte avec la somme en paramètre
    }
    else if (type == "crédit"){
      operation.Crediter(util,somme); // crédite le compte de la somme en paramètre
    }
    util.AddOB(operation); // ajoute l'opération à la liste d'opération bancaire de l'utilisateur.
    Console.WriteLine("Solde : "+ util.Solde);
  }
  
  // faire un event sur toute les methodes qui permet d'afficher le solde

  public string OppList(Utilisateur util){
    string chaine ="";
    chaine += util.Operations();
    return chaine;
  }

  public string UtilList(Banque banque){
    string chaine ="";
    chaine += banque.ListUtil();
    return chaine;
  }
}