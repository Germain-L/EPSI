package org.cafetiere;

public class Cafetiere {

	public Cafetiere() {
		
	}
	
	
	public void remplirTasse(Tasse tasse) {
		tasse.cafe = new Cafe(TypeCafe.MOKA, tasse.quantiteCafeMax) ; 
	}
	
	public void remplirTasse(Tasse tasse, TypeCafe type, double quantiteCafe) {
		tasse.cafe = new Cafe(type, quantiteCafe) ; 
	}
	
}
