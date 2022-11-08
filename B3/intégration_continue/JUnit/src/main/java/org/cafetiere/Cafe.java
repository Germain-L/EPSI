package org.cafetiere;

public class Cafe {
 
	TypeCafe typeCafe  ; 
	double quantiteLiquideMl ; 
	
	Cafe() {
		typeCafe = TypeCafe.MOKA ; 
		quantiteLiquideMl = 100 ; 
	}
	
	Cafe(TypeCafe typeCafe, double quantiteLiquideMl) {
		this.typeCafe = typeCafe ; 
		this.quantiteLiquideMl = quantiteLiquideMl ; 
	}
	
}