namespace Cw2
{
    public class Student
    {
        private string imie;
        private string nazwisko;
        private string kierunek;
        private string tryb;
        private string index;
        private string data;
        private string email;
        private string imie_matki;
        private string imie_ojca;
        
        public Student(string im,string naz,string kier,string tr,string ind,string dat,string mail,string imm,string imo)
        {
            imie = im.Replace(" ", "");
            nazwisko = naz.Replace(" ", "");;
            kierunek = kier.Replace(" ", "");;
            tryb = tr.Replace(" ", "");;
            index = ind.Replace(" ", "");;
            data = dat.Replace(" ", "");;
            email = mail.Replace(" ", "");;
            imie_matki = imm.Replace(" ", "");;
            imie_ojca = imo.Replace(" ", "");;
        }

        public bool validtofile()
        {
            if (imie == null || nazwisko == null || kierunek == null || tryb == null || index == null || data == null ||
                email == null || imie_matki == null || imie_ojca == null||imie == ""|| nazwisko == "" || kierunek == "" || tryb == "" || index == "" || data == "" ||
                email =="" || imie_matki == "" || imie_ojca == "")
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