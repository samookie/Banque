using System;

public class Operation_bancaire{
    private string type_operation;
    private string date_operation;


  public string Type_operation
  {
    get { return type_operation; }
    set { type_operation = value; }
  }

  public string Date_operation
  {
    get { return date_operation; }
    set { date_operation = value; }
  }
  public Operation_bancaire(string type){
    string date = DateTime.Now.ToString("dd-MM-yyyy");
    type_operation = type;
    date_operation = date;
  }
  public void Crediter(Utilisateur util, int somme)
  { //tu gagne de l'argent
    util.Solde += somme;
    type_operation = "crédit";
  }
  public void Retrait(Utilisateur util, int somme)
  { //tu pers l'argent
    if(util.Solde - somme <= 0){
      throw(new SoldeZeroError("Vous ne pouvez pas faire de retrait. Car vous avez "+ util.Solde +" et que l'opération de retrait : "+ (util.Solde - somme) +" ne vous permet pas de retirer de l'argent."));
    }else{
      util.Solde -= somme;
      type_operation = "retrait";
    }
  }

  public override string ToString(){
    var chaine = "************************ Operation Bancaire ************************ /n";

    if (type_operation != null){
      chaine += "Type : " + type_operation + " /n";
    }
    if (date_operation != null ){
      chaine += "Date : " + date_operation + " /n";
    }

    return chaine;
  }

  public string InfoCompte(Utilisateur util){
    string chaine ="------------------ Information du compte ------------------";
    chaine += util.ToString();
    return chaine;
  }
  
  public string HistOperation(Utilisateur util){
    string chaine ="";
    chaine += util.Operations();
    return chaine;
  } 
}