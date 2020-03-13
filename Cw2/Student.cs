namespace Cw2
{
    public class Student
    {
        public string imie;
        public string nazwisko;
        public string kierunek;
        public string tryb;
        public string index;
        public string data;
        public string email;
        public string imie_matki;
        public string imie_ojca;
        
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
    }
}