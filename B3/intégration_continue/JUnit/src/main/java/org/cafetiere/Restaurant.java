package org.cafetiere;

import java.util.ArrayList;
import java.util.HashMap;

public class Restaurant {

	Cafetiere cafetiere ;
	double profit ; 
	
	String nom ;
	ArrayList<Client> listeClients ;  
	HashMap<String,Employe> employes ;
	
	public Restaurant() {
		cafetiere = new Cafetiere() ; 
		listeClients = new ArrayList<Client>() ; 
		employes = new HashMap<String, Employe>() ;
		nom = "Le Restaurant" ; 
	}
	
	public Restaurant(String nom) {
		this() ; 
		this.nom = nom ; 
	}
	
	public boolean servir(Client client) {
		if(client.commandeCafe != null && client.commandeCafe.typeCafe != TypeCafe.BATARD) {
			double cout = 0; 
			if(client.tasse == null) {
				if(client.commandeCafe.quantiteLiquideMl <= 100) {
					cout += 2 ; 
					client.tasse = new Tasse() ;
				} else {
					cout += 3 ; 
					client.tasse = new Tasse(500) ;
				}
			}
			
			cout += client.commandeCafe.quantiteLiquideMl * client.commandeCafe.typeCafe.coutParMl ; 		
			client.tasse.addCafe(client.commandeCafe) ; 
			profit += cout ; 
			client.valeurFacture = cout;
			listeClients.add(client) ; 
			return true ; 
		}
		
		System.out.println("Expulse le client " + client.nom + " du restaurant ! ");
		return false ; 
	
	}
	
}