using System.Collections.Generic;
using System;

public class Banque {
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
}