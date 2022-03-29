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
  public Operation_bancaire(string type, string date){
    type_operation = type;
    date_operation = date;
  }
  public void Crediter(Utilisateur util, int somme)
  { //tu gagne de l'argent  
    
  }
  public void Retrait(Utilisateur util, int somme)
  { //tu pers l'argent
      
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

  // retrait / créditer / afficher information du compte
  // une  méthode qui va etre declench" au moment ou l'utilisateur voudra faire un retrait et que son solde est négatif .( Gestion erreurs personnalisé)
}