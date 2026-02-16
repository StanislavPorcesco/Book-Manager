using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneCarti
{
    public class Carte
    {
        private int idCarte;
        private int idVechi;
        private string titlu;
        private string autor;
        private string loculPublicarii;
        private int anulPublicarii;
        private string idCZU;
        private decimal pret;

        public Carte(int idCarte, int idVechi, string titlu, string autor, string loculPublicarii, int anulPublicarii, string idCZU, decimal pret)
        {
            this.idCarte = idCarte;
            this.idVechi = idVechi;
            this.titlu = titlu;
            this.autor = autor;
            this.loculPublicarii = loculPublicarii;
            this.anulPublicarii = anulPublicarii;
            this.idCZU = idCZU;
            this.pret = pret;
        }

        public int getIdCarte() {  return idCarte; }
        public int getIdVechi() { return idVechi; }
        public string getTitlu() {  return titlu; }
        public string getAutor() { return autor; }
        public string getLoculPublicarii() {  return loculPublicarii; }
        public int getAnulPPublicarii() { return anulPublicarii; }
        public string getIdCZU() {  return idCZU; }
        public decimal getPret() {  return pret; }

        public void setIdCarte(int valoare) {  this.idCarte = valoare;}
        public void setIdVechi(int valoare) { this.idVechi = valoare;}
        public void setTitlu(string valoare) {  this.titlu = valoare;}
        public void setAutor(string valoare) {  this.autor = valoare;}
        public void setLoculPublicarii(string valoare) {  this.loculPublicarii = valoare;}
        public void setIdCzu(string valoare) {  this.idCZU = valoare;}
        public void setPret(decimal valoare) {  this.pret = valoare;}
        public void setAnulPublicarii(int valoare) {  this.anulPublicarii = valoare;}

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
