using System;
using System.Collections.Generic;

public class Utilisateur{
  private string prenom;
  private int solde;
  public List<Operation_bancaire> operations = new List<Operation_bancaire>();

  public Utilisateur(string prenomU, int soldeU){
    prenom = prenomU;
    solde = soldeU;  
  }

  public string Prenom
  {
    get { return prenom; }
    set { prenom = value; }
  }

  public int Solde
  {
    get { return solde; }
    set { solde = value; }
  }
  public void AddOB(Operation_bancaire ob){
    operations.Add(ob);
  }
  public override string ToString(){
    var chaine = "************************ Profil ************************/n";

    if (prenom != null){
      chaine += "Prenom : " + prenom + " /n";
    }
    if (solde != 0){
      chaine += "Solde : " + solde + " /n";
    }
    foreach(var op in operations){
      chaine += op.ToString();
    }

    return chaine;
  }

  public string Operations(){
    var chaine = "************************ Historique des opérations ************************/n";

    foreach(var op in operations){
      if(op.Type_operation == "crédit"){
        chaine += "crédit";
      }
      else{
        chaine += "débit";
      }
      
    }

    return chaine;
  }
  
}