using System.Collections.Generic;
using System;

public abstract class Banque {
  private string nom;
  private string adresse;
  private List<Utilisateur> utilisateurs = new List<Utilisateur>();
  public Banque(string nomB, string adresseB)
  {
    nom = nomB;
    adresse = adresseB;
    
  }

  public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

  public string Adresse
  {
      get { return nom; }
      set { nom = value; }
  }

  public void AddUtil(Utilisateur util){
    utilisateurs.Add(util);
  }

  public override string ToString(){
    var chaine = "---------- Profil de votre banque ----------";

    if (nom != null){
      chaine += "Nom : " + nom + " /n";
    }
    if (adresse != null){
      chaine += "Adresse : " + adresse + " /n";
    }

    foreach (var util in utilisateurs){
      chaine += util.ToString();
    }
    return chaine;
  }

  public string ListUtil(){
    string chaine ="";
    foreach(var util in utilisateurs){
      chaine += "Nom : "+ util.Prenom + "/n";
    }
    return chaine;
  }
}