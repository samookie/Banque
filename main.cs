using System;

public class Program {
  public static void Main (string[] args) {
    Banque_physique poste = new Banque_physique("la Poste","la rue de la poste");
    Banque_ligne boursorama = new Banque_ligne("boursorama","la rue de la boursorama");

    Utilisateur shenda = new Utilisateur("shenda",2000);
    Utilisateur thomas = new Utilisateur("thomas",100);

    Gestionnaire_Banque gestionBanque =  new Gestionnaire_Banque();

    gestionBanque.addUtilisateur(shenda, poste);
    gestionBanque.addUtilisateur(thomas, boursorama);

    gestionBanque.addOB("crédit", 200, shenda);
    gestionBanque.addOB("débit", 100, shenda);
    Console.WriteLine(shenda.ToString());
    gestionBanque.addOB("crédit", 200, thomas);
    gestionBanque.addOB("débit", 100, thomas);
    Console.WriteLine(thomas.ToString());
    //Console.WriteLine(boursorama.GetType() == typeof(Banque_ligne));
    
  }
}