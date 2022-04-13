class Banque_physique : Banque
{

  public Banque_physique(string nomB, string adresseB) : base(nomB,adresseB)
  {
    
  }

  public override string ToString(){
    var chaine = "**************** Votre banque physique : "+ base.Nom + " ****************";
    chaine += base.ToString();
    return chaine;
  }
  
}