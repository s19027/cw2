namespace Cw2
{
    public class Student
    {
        private string imie;
        private string nazwisko;
        private string kierunek;
        private string tryb;
        private int index;
        private string data;
        private string email;
        private string imie_matki;
        private string imie_ojca;
        
        public Student(string im,string naz,string kier,string tr,int ind,string dat,string mail,string imm,string imo)
        {
            imie = im;
            nazwisko = naz;
            kierunek = kier;
            tryb = tr;
            index = ind;
            data = dat;
            email = mail;
            imie_matki = imm;
            imie_ojca = imo;
        }

        public bool valid()
        {
            if (imie == null || nazwisko == null || kierunek == null || tryb == null || index == null || data == null ||
                email == null || imie_matki == null || imie_ojca == null)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return imie + " " + nazwisko + " " + kierunek + " " + tryb + " " + index + " " + data + " " + email + " " +
                   imie_matki + " " + imie_ojca;
        }
    }
}