using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierStock
{
    public class Produit
    {
        private decimal prixAchat, pourcentageMarge;
        private int stocks;
        private string reference, libelle;

        public Produit(string reference, string libelle, decimal prixAchat, decimal pourcentageMarge)
        {
            this.reference = reference;
            this.libelle = libelle;
            this.prixAchat = prixAchat;
            this.pourcentageMarge = pourcentageMarge;
            stocks = 0;
        }

        #region Accesseurs

        public string Reference => reference;
        public string Libelle => libelle;
        public int Stocks => stocks; // { get { return stocks; } }
        public decimal PrixVente => prixAchat + (prixAchat * pourcentageMarge);
        public decimal PrixAchat => prixAchat;

        #endregion

        #region Stocks

        /// <summary>
        /// Sort la quantité spécifiée des stocks pour le produit concerné. Prend en compte la rupture de stock.
        /// </summary>
        /// <param name="quantite">Quantité à retirer</param>
        /// <returns>Valeur réellement retirée inférieure (rupture) ou égale à la quantité</returns>
        public int Sortir(int quantite)
        {
            if (quantite > stocks)
            {
                int removed = 0;
                while (stocks > 0)
                {
                    stocks--;
                    removed++;
                }

                return removed;
            }


            stocks -= quantite;
            return quantite;
        }

        public void Rentrer(int quantite)
        {
            stocks += quantite;
        }

        public bool EstEnRupture => stocks <= 0;

        #endregion
    }
}