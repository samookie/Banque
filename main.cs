using System;

public class Program {
  public static void Main (string[] args) {
    Banque_physique poste = new Banque_physique("la Poste","la rue de la poste");
    Banque_ligne boursorama = new Banque_ligne("boursorama","la rue de la boursorama");
    
    Console.WriteLine(boursorama.GetType() == typeof(Banque_ligne));
    
  }
}