class Banque_ligne : Banque
{

  public Banque_ligne(string nomB, string adresseB) : base(nomB,adresseB)
  {
  }

  public override string ToString(){
    var chaine = "**************** Votre banque en ligne : "+ base.Nom + " ****************";
    chaine += base.ToString();
    return chaine;
  }

  
}