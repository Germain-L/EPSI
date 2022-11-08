package org.cafetiere;

public class Client {

	Tasse tasse ;
	Cafe commandeCafe; 
	String nom ; 
	double valeurFacture ;
	
	public Client() {
		this.nom = "Jean" ;
		this.tasse = new Tasse() ; 
	}
	
	public Client(String nom, Cafe commandeCafe, boolean asTasse) {
		this.nom = nom ; 
		if(asTasse)
			tasse = new Tasse() ; 
		this.commandeCafe = commandeCafe ; 
	}
	
	public Client(String nom, Cafe commandeCafe, Tasse tasse) {
		this.nom = nom ; 
		this.tasse = tasse ; 
		this.commandeCafe = commandeCafe ; 
	}
}